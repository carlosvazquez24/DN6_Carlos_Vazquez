internal class Program
{
    private static void Main(string[] args)
    {
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
        Console.ReadKey();
    }
}