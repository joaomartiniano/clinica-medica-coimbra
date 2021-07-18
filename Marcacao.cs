using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinica_coimbra
{
    /// <summary>
    /// Marcação de uma consulta.
    /// </summary>
    public class Marcacao
    {
        public int Id { get; set; }
        public Paciente PacienteMarcacao { get; set; }
        public Medico MedicoMarcacao { get; set; }
        public DateTime DataHora { get; set; }

        public Marcacao()
        { }

        public Marcacao(Paciente paciente, Medico medico, DateTime dataHora)
        {
            PacienteMarcacao = paciente;
            MedicoMarcacao = medico;
            DataHora = dataHora;
        }
    }
}
