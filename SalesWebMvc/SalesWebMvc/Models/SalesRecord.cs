using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        /// <summary>
        /// SalesRecord = Registro de Vendas que vai ter um vendedor especifico para essa venda.
        /// Lembrar que 1 vendedor pode ter mais de uma SalesRecord , ou seja, mais de uma venda.
        /// Amount = Quantidade de vendas.
        /// </summary>
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }


        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
