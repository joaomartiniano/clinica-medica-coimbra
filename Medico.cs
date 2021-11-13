// Copyright(c) João Martiniano. All rights reserved.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinica_coimbra
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Especialidade EspecialidadeMedico { get; set; }

        public Medico()
        { }

        public Medico(int id, string nome, Especialidade especialidadeMedico)
        {
            Id = id;
            Nome = nome;
            EspecialidadeMedico = especialidadeMedico;
        }
    }
}
