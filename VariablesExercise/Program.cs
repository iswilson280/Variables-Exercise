namespace VariablesExercise
{
    public class Program
    {
        private static int hello;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string myString = "Hello World";
            int myInt = 42;
            char myChar = 'A';
            bool myBool = true;
            double myDouble = 3.14;
            decimal myDecimal = 3.14159M;



            Console.WriteLine("String: {0}", myString);
            Console.WriteLine("Integer: {0}", myInt);
            Console.WriteLine("Character: {0}", myChar);
            Console.WriteLine("Boolean: {0}", myBool);
            Console.WriteLine("Double: {0}", myDouble);
            Console.WriteLine("Decimal: {0}", myDecimal);
        }

    }
}
