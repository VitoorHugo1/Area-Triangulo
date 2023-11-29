namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Base : ");
            double baseDoTriangulo = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double alturaDoTriangulo = double.Parse(Console.ReadLine());

            double area = (baseDoTriangulo * alturaDoTriangulo) / 2;
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Base : {baseDoTriangulo}");
            Console.WriteLine($"Altura : {alturaDoTriangulo}");
            Console.WriteLine($"Area : {area} cm²");

        }
    }
}