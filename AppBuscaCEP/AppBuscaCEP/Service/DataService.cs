using System;
using AppBuscaCEP.Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;

namespace AppBuscaCEP.Service
{
    public class DataService
    {
        public static async Task<Endereco> GetEnderecoByCep(string cep)
        {
            Endereco end;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/endereco/by-cep?cep=" + cep);
                    if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    
                    end = JsonConvert.DeserializeObject<Endereco>(json);
                }
                    else 
                    throw new Exception(response.RequestMessage.Content.ToString());
            
            }
            
            return end;
        }

        /**
         * Obtem a lista de bairros de uma cidade.
         */
        public static async Task<List<Bairro>> GetBairrosByIdCidade(int id_cidade)
        {
            List<Bairro> arr_bairros = new List<Bairro>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/bairro/by-cidade?cidade=" + id_cidade);
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    arr_bairros = JsonConvert.DeserializeObject<List<Bairro>>(json);
                }
                else
                    throw new Exception(response.RequestMessage.Content.ToString());
            }

            return arr_bairros;
        }
        
        /**
         * Obtem a lista de logradouros (ruas) de um bairro.
         */
        public static async Task<List<Logradouro>> GetLogradouroByBairroAndCidade(int id_cidade, string desc_bairro)
        {
            List<Logradouro> arr_log = new List<Logradouro>();
            
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/logradouro/by-bairro?id_cidade="+id_cidade+"&bairro=" + desc_bairro);
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    arr_log = JsonConvert.DeserializeObject<List<Logradouro>>(json);
                }
                else
                    throw new Exception(response.RequestMessage.Content.ToString());

            }

            return arr_log;
        }

        public static async Task<Cep> GetCepByLogradouro(string desc_logradouro)

        {
            Cep cep;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://cep.metoda.com.br/cep/by-logadouro?logradouro=" + desc_logradouro);
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    cep = JsonConvert.DeserializeObject<Cep>(json);
                }
                else
                    throw new Exception(response.RequestMessage.Content.ToString());

            }

            return cep;

        }

    }
}
