namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1 = 12;
            int num2 = 13;
            Console.WriteLine(num1+num2);
            Console.WriteLine(num1-num2);
            Console.WriteLine(num2/num1);
            Console.WriteLine(num1%num2);

            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;
            if (a == 17 && b == 4)
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            Console.WriteLine("Enter the radius of your circle:");

            var userInput = Console.ReadLine();

            

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));

        }

        public static double AreaOfCircle(double radius)
        { 
          var area = Math.PI * Math.Pow (2, radius);
            return area; 
        
        }
        

    }
}
