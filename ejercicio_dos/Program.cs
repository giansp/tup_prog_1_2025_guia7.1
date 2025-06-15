namespace Budines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int envol = 12, caja = 12;
            double masa, budin = 55;
            Console.WriteLine("Ingrese la masa del budín en gramos:");
            masa = Convert.ToDouble(Console.ReadLine());

            double budin_hecho, envol_usado, cajas_usadas;
            budin_hecho=Convert.ToInt32(masa / budin);
            envol_usado= Convert.ToInt32(budin_hecho / envol);
            cajas_usadas = Convert.ToInt32(envol_usado / caja);

            Console.WriteLine("Cantidad de budines hechos: " + budin_hecho);
            Console.WriteLine("Cantidad de envoltorios usados: " + envol_usado);
            Console.WriteLine("Cantidad de cajas usadas: " + cajas_usadas);
        }
    }
}
