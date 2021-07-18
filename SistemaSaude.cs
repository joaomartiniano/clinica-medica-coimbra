using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinica_coimbra
{
    public class SistemaSaude
    {
        public int Id { get; set; }
        public string Designacao { get; set; }

        public SistemaSaude()
        { }

        public SistemaSaude(int id, string designacao)
        {
            Id = id;
            Designacao = designacao;
        }
    }
}
