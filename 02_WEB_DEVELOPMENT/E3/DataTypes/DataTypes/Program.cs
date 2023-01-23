using DataTypes.Web.Models;
using static DataTypes.Web.Models.Customer;

public class Program
{
    private static void Main(string[] args)
    {

        //Llenado de la lista
        
        List<Customer> lista = new List<Customer>();
        lista.Add(new Customer { nombreCliente = "Carlos", apellidoCliente = "Vázquez", tipoMensualidad = "estudiante" });
        lista.Add(new Customer { nombreCliente = "Daniel", apellidoCliente = "Hernández", tipoMensualidad = "normal" });
        lista.Add(new Customer { nombreCliente = "Sandra", apellidoCliente = "Rodriguez", tipoMensualidad = "normal" });
        lista.Add(new Customer { nombreCliente = "Angela", apellidoCliente = "Sanchez", tipoMensualidad = "normal" });
        lista.Add(new Customer { nombreCliente = "Laura", apellidoCliente = "Luna", tipoMensualidad = "normal" });
        lista.Add(new Customer { nombreCliente = "Luis", apellidoCliente = "Ramos", tipoMensualidad = "normal" });
        lista.Add(new Customer { nombreCliente = "Carlos", apellidoCliente = "Perez", tipoMensualidad = "normal" });
        lista.Add(new Customer { nombreCliente = "Arturo", apellidoCliente = "Castillo", tipoMensualidad = "normal" });
        lista.Add(new Customer { nombreCliente = "Roberto", apellidoCliente = "Cruz", tipoMensualidad = "estudiante" });
        lista.Add(new Customer { nombreCliente = "Eliam", apellidoCliente = "Torres", tipoMensualidad = "estudiante" });

        Console.WriteLine("Impresión con bucle foreach");

        foreach (var item in lista)
        {
            Console.WriteLine(item.nombreCliente + "  " + item.apellidoCliente + "  "  + item.tipoMensualidad + "  " + item.fechaIngreso.ToString().Substring(0,10));
        }

        
        Console.WriteLine( "\n" + "Impresión con bucle for");


        for (int i = 0; i < lista.Count ; i++)
        {
            Console.WriteLine(lista.ElementAt(i).nombreCliente + "  " + lista.ElementAt(i).apellidoCliente + "  " + lista.ElementAt(i).tipoMensualidad + "  " + lista.ElementAt(i).fechaIngreso.ToString().Substring(0, 10));

        }

        Console.WriteLine("\n" + "Impresión con bucle while");

        byte contador = 0;
        while( contador < lista.Count == true){
            Console.WriteLine(lista.ElementAt(contador).nombreCliente + "  " + lista.ElementAt(contador).apellidoCliente + "  " + lista.ElementAt(contador).tipoMensualidad + "  " + lista.ElementAt(contador).fechaIngreso.ToString().Substring(0, 10));
            contador++;        
        }

        Console.WriteLine("\n" +  "Impresión con bucle do While");

        contador = 0;
        do
        {
            Console.WriteLine(lista.ElementAt(contador).nombreCliente + "  " + lista.ElementAt(contador).apellidoCliente + "  " + lista.ElementAt(contador).tipoMensualidad + "  " + lista.ElementAt(contador).fechaIngreso.ToString().Substring(0, 10));
            contador++;        
        } while (contador < lista.Count);

        Console.ReadKey();


        /*
        Console.WriteLine("Hello, World!");
        string text = "This is a string";
        int age = 35;
        DateTime now = DateTime.Now;
        double amount = 0;

        //String concatenation
        string string2 = text + "second string" + age + now + amount;
        string string3 = string.Format("The age is {0}, the time is {1} and the amount is {2}", age, now, amount);
        string string4 = $"The age is {age}, the time is {now} and the amount is {amount}";

        char simpleChar = 'A';
        char[] arrayChar = string4.ToCharArray();

        amount = (double)10 / (double)3;

        //Set a specific date
        DateTime specificDate = new DateTime(2000, 1, 1);

        //Get the difference between the dates
        TimeSpan interval = now - specificDate;

        //Represent it in miliseconds
        Console.WriteLine(interval.TotalMilliseconds);

        string test = "15";
        age = int.Parse(test);

        string booleanText = "true";
        bool isTrue = bool.Parse(booleanText);

        */

    }
}