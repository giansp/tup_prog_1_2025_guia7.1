namespace MontoRepartir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nina1, nina2, nina3, nina4,sumaEdades;
            double monto,porc1,porc2,porc3,porc4,monto1, monto2, monto3, monto4;

            Console.WriteLine("Ingrese el monto a repartir:");
            monto=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la primera niña:");
            nina1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la segunda niña:");
            nina2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la tercera niña:");
            nina3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la cuarta niña:");
            nina4 = Convert.ToInt32(Console.ReadLine());

            sumaEdades = nina1 + nina2 + nina3 + nina4;

            porc1 = (1.0*nina1 / sumaEdades) * 100;
            porc2 = (1.0*nina2 / sumaEdades) * 100;
            porc3 = (1.0 * nina3 / sumaEdades) * 100;
            porc4 = (1.0 * nina4 / sumaEdades) * 100;

            monto1 = (porc1 / 100) * monto;
            monto2 = (porc2 / 100) * monto;
            monto3 = (porc3 / 100) * monto;
            monto4 = (porc4 / 100) * monto;

            Console.WriteLine($"La primera niña recibirá: {monto1:C} teniendo un porcentaje del monto del {porc1:F2}%");
            Console.WriteLine($"La segunda niña recibirá: {monto2:C} teniendo un porcentaje del monto del {porc2:F2}%");
            Console.WriteLine($"La tercera niña recibirá: {monto3:C} teniendo un porcentaje del monto del {porc3:F2}%");
            Console.WriteLine($"La cuarta niña recibirá: {monto4:C} teniendo un porcentaje del monto del {porc4:F2}%");
        }
    }
}
