internal class Program
{
    private static void Main(string[] args)
    {
        /* This is version 1 of application
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

        }*/
        // Restaurant registration version 2
        ShowMenu();
        SelectMenu();

    }

    private static void SelectMenu()
    {
        Console.Write("Please Select a number from menu: ");
        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 0:
                //Exit application
                break;
            case 1:
                //Personal registration
                break;
            case 2:
                //Personal List
                break;
        }
    }

    private static void ShowMenu()
    {
        Console.WriteLine("=====>> Restaurangregistrering <<===== \n\n\n");
        Console.WriteLine("\t Main Menu");
        Console.WriteLine("1. Registration");
        Console.WriteLine("2. Show List");
        Console.WriteLine("0. Exit");
        Console.WriteLine("\n ======================================== \n \n");
    }
}