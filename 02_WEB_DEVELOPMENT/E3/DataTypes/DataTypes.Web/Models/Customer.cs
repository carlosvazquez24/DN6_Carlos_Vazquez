namespace DataTypes.Web.Models
{
    public class Customer
    {
        public string nombreCliente { get; set; }
        public string apellidoCliente { get; set; }
        public DateTime fechaIngreso { get; set; }

        public string tipoMensualidad { get; set; }

        public Customer() {
            fechaIngreso= DateTime.Now;
        }


    }
}
