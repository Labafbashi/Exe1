using System.Collections.Generic;

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
        List<Personal> staff = new List<Personal>();
        String answer;
        
        do
        {
            ShowMenu();
            Console.Write("Please Select a number from menu: ");
            answer = Console.ReadLine();
            if (answer is "0" or "1" or "2")
            {
                switch (Convert.ToInt32(answer))
                {
                    case 0:
                    default:
                        //Exit application
                        System.Environment.Exit(1);
                        break;
                    case 1:
                        //Personal registration
                        (String, int) personInfo = getPersonInfo();
                        staff.Add(item: new Personal(personInfo.Item1, personInfo.Item2));
                        break;
                    case 2:
                        //Personal List
                        Console.Clear();
                        Console.WriteLine("Staff Name \t \t \t Salary");
                        Console.WriteLine("========== \t \t \t ======");
                        foreach (Personal item in staff)
                        {
                            Console.WriteLine($"{item.GetPersonal().Item1} \t \t \t {item.GetPersonal().Item2}");
                        }
                        Console.ReadKey();
                        break;
                }
            }
        } while (true);

    }

    private static (String, int) getPersonInfo()
    {
        String staffName;
        int staffSalery;
        Console.Write("Skriv namn: ");
        staffName = Console.ReadLine();
        Console.Write("Skrive lön: ");
        staffSalery = Convert.ToInt32(Console.ReadLine());
        return (staffName, staffSalery);
    }

    private static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("=====>> Restaurangregistrering <<===== \n\n\n");
        Console.WriteLine("\t Main Menu");
        Console.WriteLine("1. Registration");
        Console.WriteLine("2. Show List");
        Console.WriteLine("0. Exit");
        Console.WriteLine("\n ======================================== \n \n");
    }
}