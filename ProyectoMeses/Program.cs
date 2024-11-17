namespace ProyectoMeses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Introduce un número");
                string[] mes = new string[12];

                mes[0] = "Enero";
                mes[1] = "Febrero";
                mes[2] = "Marzo";
                mes[3] = "Abril";
                mes[4] = "Mayo";
                mes[5] = "Junio";
                mes[6] = "Julio";
                mes[7] = "Agosto";
                mes[8] = "Septiembre";
                mes[9] = "Octubre";
                mes[10] = "Noviemvre";
                mes[11] = "Diciembre";

                string input = Console.ReadLine();
                int.TryParse(input, out int result);

                if (result > 0 && result <= 12)
                {
                    Console.WriteLine(mes[result - 1]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Resultado incorrecto");
                }
                Console.WriteLine();


            } while (true);

        }
    }
}