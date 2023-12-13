// See https://aka.ms/new-console-template for more information
using GIK299_Labb4;

internal class Program
{
    List<Person> addedPersons = new List<Person>();
    public static void Main(string[] args)
    {
        


        DateTime birthday = new DateTime(2000, 01, 01);
        string eyecolor = "Green";
        Gender gender = Gender.Other;
        Hair hair = new Hair { HairColor = "Brown", HairType = "Curly", HairLength = "Long" };
        Person person = new Person(birthday, eyecolor, gender, hair);
//extra
        Thinker thinker = new Thinker();

        while (true)
        {
            Console.WriteLine(
                "----------------------------------" +
                "\n Choose an option from list below" +
                "\n (1) Add person" +
                "\n (2) Display added persons" +
                "\n (3) Exit" +
                "\n----------------------------------"
        
            );
            string mainMenu = Console.ReadLine();
            switch (mainMenu)
            {
                case "1":
                    Console.Clear();
                    thinker.Think(3, 100);
                    Console.WriteLine("val 1 gjort");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine(person.ToString());
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Press any key to exit" +
                                      "\n-----------------------");
                    return;
                default:
                    Console.WriteLine("Please choose from list!");
                    break;
            }
        }
    }



    public void ListPersons()
    {
        foreach (var person in addedPersons)
        {
            Console.WriteLine(person.ToString());
   
        }
    }
}
