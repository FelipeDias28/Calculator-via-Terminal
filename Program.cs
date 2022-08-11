namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Limpa o terminal

            Console.WriteLine("Digite um número: ");
            float numberOne = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            float numberTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = numberOne + numberTwo;
            Console.WriteLine($"A soma dos números é {result}");
        }
    }
}