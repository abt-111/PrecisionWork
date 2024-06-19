namespace PrecisionWork
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Building building1 = new Building(143, 34);

            Building building2 = new Building(34);

            Console.WriteLine($"Ce bâtiment à {building1.GetFloorCount()} étages,\n" +
                $"pour une taille de {building1.GetSize()} mètres.\n" +
                $"Ce qui donne une taille maximal de {building1.GetFloorMaxSize()} m par étages\n");

            Console.WriteLine($"Ce bâtiment à {building2.GetFloorCount()} étages,\n" +
                $"pour une taille de {building2.GetSize()} mètres.\n" +
                $"Ce qui donne une taille maximal de {building2.GetFloorMaxSize()} m par étages\n");
        }
    }
}