
using ClassLibrary1;
using System.ComponentModel;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<Cliente> list = new List<Cliente>();
        list.Add(new Cliente(){ id = 1, age = 23, name = "juan" });
        list.Add(new Cliente(){ id = 2, age = 28, name = "pancho" });
        list.Add(new Cliente(){ id = 3, age = 29, name = "pedro" });


        var lista = list.Where(x => x.age >= 18 && x.age < 25).ToList();

        if(lista != null)
        {
            foreach (var elemento in list)
            {
                Console.WriteLine(elemento.id + " " + elemento.name + " " + elemento.age);
            }
        }

        Console.ReadKey();

        
    }
}