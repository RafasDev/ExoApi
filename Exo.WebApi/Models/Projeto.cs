using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo.WebApi.Models
{
    public class Projeto
    {
        public string Id { get; set; }
        public string NomeDoProjeto { get; set; }
        public string Area { get; set; }
        public string Status { get; set; }
    }
}