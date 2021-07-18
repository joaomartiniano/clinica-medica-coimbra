using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinica_coimbra
{
    public class Especialidade
    {
        public int Id { get; set; }
        public string Designacao { get; set; }

        public Especialidade()
        { }

        public Especialidade(int id, string designacao)
        {
            Id = id;
            Designacao = designacao;
        }
    }
}
