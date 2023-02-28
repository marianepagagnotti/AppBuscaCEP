using System;
using System.Collections.Generic;
using System.Text;

namespace AppBuscaCEP.Model
{
    public class Cep
    {
        public int id { get; set; }
        public int id_cidade { get; set; }
        public string desc_bairro { get; set; }
        public string desc_logradouro { get; set; }
        public int CEP { get; set; }
    }
}
