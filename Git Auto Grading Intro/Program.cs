namespace StudentProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Welcome to the calculator project, complete the methods

            // Call the methods here ex.
            int result = Add(2, 3);
            Console.WriteLine("The result of adding 2 and 3 is: " + result);

            int diff = Subtract(13, 7);
            Console.WriteLine("The result of subtracting 13 and 7 is: " + diff);
            int product = Multiply(2, 17);
            Console.WriteLine("The result of multiplying 2 and 17 is: " + product);
            decimal quotient = Divide(5, 2);
            Console.WriteLine("The result of dividing 5 and 2 is: " + quotient);
        }

        // Methods Here
        public static int Add(int a, int b)
        {
            // Code
            return a + b; 
        }
        public static int Subtract(int a, int b)
        {
            // Code
            return a - b; 
        }
        public static int Multiply(int a, int b)
        {
            // Code
            return a * b; 
        }
        public static decimal Divide(int a, int b)
        {
            // Code
            decimal newA = a;
            decimal newB = b;
            return newA / newB; 
        }
    }
}
