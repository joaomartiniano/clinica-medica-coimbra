// Copyright(c) João Martiniano. All rights reserved.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinica_coimbra
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Morada { get; set; }
        public string CodigoPostal { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nif { get; set; }
        public string Telefone { get; set; }
        public SistemaSaude SistemaSaudePaciente { get; set; }
        public string NumeroSistemaSaude { get; set; }

        public Paciente()
        { }

        public Paciente(string nome)
        {
            Nome = nome;
        }
    }
}
