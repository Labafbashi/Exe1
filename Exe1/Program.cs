internal class Program
{
    private static void Main(string[] args)
    {
        List<string> staffName = new List<string>();
        List<int> salary = new List<int>();
        int i = -1;


        Console.WriteLine("=====>> Restaurangregistrering <<=====");
        Console.WriteLine("\n\n");
        do
        {
            i++;
            Console.Write("Skriv namn: ");
            staffName.Add(Console.ReadLine());
            if (staffName[i].ToUpper() == "END") { break; }
            Console.Write("Skrive lön: ");
            salary.Add(Convert.ToInt32(Console.ReadLine()));
        } while (staffName[i].ToUpper() != "END");

        for(i = 0; i < salary.Count; i++)
        {
            Console.WriteLine($"Staff Name : {staffName[i]} === \t === Salary : {salary[i]}");

        }
    }
}