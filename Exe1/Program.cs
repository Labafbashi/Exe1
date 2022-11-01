internal class Program
{
    private static void Main(string[] args)
    {
        List<string> staffName = new List<string>();
        List<int> salary = new List<int>();
        int i = -1;


        Console.WriteLine("=====>> Restaurangregistrering <<=====");
        Console.WriteLine("\n to finish the game enter end. \n\n\n");
        do
        {
            i++;
            Console.Write("Skriv namn: ");
            staffName.Add(Console.ReadLine());
            if (staffName[i].ToUpper() == "END") { break; }
            Console.Write("Skrive lön: ");
            salary.Add(Convert.ToInt32(Console.ReadLine()));
        } while (staffName[i].ToUpper() != "END");

        Console.WriteLine("\n\n");
        Console.WriteLine("Staff Name \t \t \t Salary");
        Console.WriteLine("========== \t \t \t ======");
        for (i = 0; i < salary.Count; i++)
        {
            Console.WriteLine($"{staffName[i]} \t \t \t {salary[i]}");

        }
    }
}