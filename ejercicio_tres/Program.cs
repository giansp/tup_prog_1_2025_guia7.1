namespace Patentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int patente, a1, a2, a3,valor;
            char b1, b2, b3;
            int numb1, numb2, numb3;
            Console.WriteLine("Ingrese el número de patente");
            patente = Convert.ToInt32(Console.ReadLine());

            a3 = patente % 10;
            a2 = (patente / 10) % 10;
            a1 = (patente / 100) % 10;

            valor  = patente / 1000;
            numb3 = valor % 26;
            b3=(char)('a' + numb3);

            valor = valor / 26;
            numb2 = valor % 26;
            b2 = (char)('a' + numb2);

            valor = valor / 26;
            numb1 = valor % 26;
            b1 = (char)('a' + numb1);

            Console.WriteLine($"La patente es: {b1}{b2}{b3}{a1}{a2}{a3}");

        }
    }
}
