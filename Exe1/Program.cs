internal class Program
{
    private static void Main(string[] args)
    {
        string[] staffName = { "" };
        int[] salary = { 0 };
        int i = 0;


        Console.WriteLine("=====>> Restaurangregistrering <<=====");
        Console.WriteLine("\n\n");
        do
        {
            Console.Write("Skriv namn: ");
            staffName[i] = Console.ReadLine();
            //if (staffName[i].ToUpper() == "END") { break; }
            Console.Write("Skrive lön: ");
            salary[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        } while (staffName[i].ToUpper() != "END");

        for(i = 0; i < salary.Length; i++)
        {
            Console.WriteLine($"Staff Name : {staffName[i]} === \t === Salary : {salary[i]}");

        }
    }
}