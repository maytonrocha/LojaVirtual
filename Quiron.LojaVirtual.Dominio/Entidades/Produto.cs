﻿
namespace Quiron.LojaVirtual.Dominio.Entidades
{
   // [Table("")]
    public class Produto
    {
      //  [Key]
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string Categoria { get; set; }       
    }
}
