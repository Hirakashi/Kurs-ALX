namespace ALXCalculator
{
    public class Calculator
    {
        public void Run()
        {
            Console.WriteLine("Calculator running...");
            Console.Write("1st number: ");
            var x = Double.Parse(Console.ReadLine());
            Console.Write("2nd number: ");
            var y = Double.Parse(Console.ReadLine());
            Console.Write("Choose operation ( + ; - ; * ; / ): ");
            var choice = char.Parse(Console.ReadLine());
            ChooseOperation(choice, x, y);
        }
        private void ChooseOperation(char choice, double x, double y)
        {

            switch (choice)
            {
                case '+':
                    Console.WriteLine($"{x} + {y} = {Add(x, y)}");
                    break;
                case '-':
                    Console.WriteLine($"{x} - {y} = {Substract(x, y)}"); Substract(x, y);
                    break;
                case '*':
                    Console.WriteLine($"{x} * {y} = {Multiply(x, y)}"); Multiply(x, y);
                    break;
                case '/':
                    Console.WriteLine($"{x} / {y} = {Divide(x, y)}"); Divide(x, y);
                    break;
                default:
                     Console.WriteLine("Invalid operation.");
                    break;
            }
           
        }
        private double Add(double x, double y)
        {
            return x + y;
        }
        private double Substract(double x, double y)
        {
            return x - y;
        }
        private double Multiply(double x, double y)
        {
            return x * y;
        }
        private double Divide(double x, double y)
        {
            return x / y;
        }
    }
}
