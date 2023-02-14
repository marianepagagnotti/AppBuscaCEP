using System;
using System.Collections.Generic;
using System.Text;

namespace AppBuscaCEP.Model
{
    public class Cidade
    {
        public int id { get; set; }
        public string desc_cidade { get; set; }
        public string uf { get; set; }
        public int codigo_ibge { get; set; }
        public int ddd { get; set; }
    }
}
