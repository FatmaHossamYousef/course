namespace Course_.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int small = 25;
            const int large = 35;
            Console.WriteLine("*****Estimate for carpet cleaning service****");
            Console.Write("number of small carpets : ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("number of large carpets : ");
            int l = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("price per small room: $25");
            Console.WriteLine("price per small room: $35");
            int coast = (s * small) + (l * large);
            Console.WriteLine($"coast : {coast:C}");
            double tax = coast * 0.06;
            Console.WriteLine($"tax : {tax:C}");
            Console.WriteLine("===============================");
            double total = coast + tax;
            Console.WriteLine($"total estimate: {total:C}");
            Console.WriteLine("this estimate is valid for 30 days");
        }
    }
}
