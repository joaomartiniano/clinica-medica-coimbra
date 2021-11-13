// Copyright(c) João Martiniano. All rights reserved.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinica_coimbra
{
    public enum TipoResultado
    {
        Nulo,
        OK,

        /// <summary>Erro genérico</summary>
        Erro,

        /// <summary>Erro de acesso à base de dados.</summary>
        ErroBaseDados,

        /// <summary>Erro de acesso ao servidor da base de dados: não é possível efetuar ligação ao servidor da base de dados.</summary>
        ErroBaseDadosLigacaoServidor,

        /// <summary>Erro ao eliminar um registo: existe um registo relacionado noutra tabela.</summary>
        ErroBaseDadosForeignKeyConstraint
    }

    /// <summary>
    /// Resultado de uma operação.
    /// </summary>
    public struct ResultadoOperacao
    {
        public TipoResultado Tipo;
        public string Detalhe;

        public ResultadoOperacao(TipoResultado tipo, string detalhe)
        {
            Tipo = tipo;
            Detalhe = detalhe;
        }

        /// <summary>
        /// Efetua a correspondência entre uma exceção MySQLConnector e o tipo de resultado desta estrutura.
        /// </summary>
        /// <param name="number">O código numérico de uma exceção da classe MySqlException.</param>
        /// <returns>Um valor da enumeração TipoResultado.</returns>
        public static TipoResultado MapearExcecaoMySQLConnector(int number)
        {
            switch (number)
            {
                case 1042: // Erro de ligação ao servidor de bases de dados
                    return TipoResultado.ErroBaseDadosLigacaoServidor;

                case 1451: // Erro ao eliminar um registo: existe um registo relacionado noutra tabela
                    return TipoResultado.ErroBaseDadosForeignKeyConstraint;

                default:
                    return TipoResultado.ErroBaseDados;
            }
        }
    }
}
