namespace APIDemo2.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public DateTime FechaFactura { get; set; }

        public int ClientID { get; set; }
        public Person? Client { get; set; }
        public List<Detail>? Details { get; set; }

        public bool Estado { get; set; }
    }
}
