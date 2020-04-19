using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Produto
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do Produto
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Descrição do Produto
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Valor do Produto
        /// </summary>
        public decimal Valor { get; set; }
    }
}
