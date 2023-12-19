// See https://aka.ms/new-console-template for more information

using GIK299_Labb4;

internal class Program
{
    
    static string hairColor;
    static string hairType;
    static string hairLength;
    static Hair hair;
    static Gender gender;
    static List<Person> addedPersons = new List<Person>();
    
    public static void Main(string[] args)
    {
         
        bool exitOption = true;
        bool case1loop = true;
        Thinker thinker = new Thinker();
        

        while (exitOption)
        {
            Console.WriteLine(
                "----------------------------------" +
                "\n Choose an option from list below" +
                "\n (1) Add person" +
                "\n (2) Display added persons" +
                "\n (3) Exit" +
                "\n----------------------------------"
        
            );

            try
            {
                int mainMenu = int.Parse(Console.ReadLine());
                if (mainMenu < 0 || mainMenu > 3)
                {

                    throw new ArgumentOutOfRangeException();
                }
                
                switch (mainMenu)
                {

                    case 1:
                        string birthday;
                        int intGender;
                        int intHairLength;
                        int intHairColor;
                        while (true)
                        {
                            try
                            {
                                Console.Clear();
                                thinker.Think(3, 300);
                                Console.WriteLine("What is your date of birth?\n(YYYY-MM-DD)");
                                birthday = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(birthday))
                                {
                                    throw new ArgumentException("Name cannot be empty.");
                                }
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                throw;
                            }

                            Console.Clear();
                            //-------------- Gender ----------------------
                            Console.WriteLine("Please choose your gender from list below:" +
                                              "\n(1) Man" +
                                              "\n(2) Woman" +
                                              "\n(3) Other" +
                                              "\n(4) I do not want to specify");
                            try
                            {
                                intGender = int.Parse(Console.ReadLine());

                                if (intGender < 0 || intGender > 4)
                                {

                                    throw new ArgumentOutOfRangeException();
                                }
                            }
                            //catch (ArgumentOutOfRangeException argumentOutOfRangeException)
                            //{
                            //    Console.WriteLine("Please choose number from list!");
                            //}
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                throw;
                            }

                            MakeGender(intGender);


                            Console.Clear();
                            Console.WriteLine("Next we need information about your hair.");
                            Thread.Sleep(500);
                            //------------------ Hair ------------------
                            Console.Clear();
                            Console.WriteLine("What length is your hair?" +
                                              "\n(1) Long hair" +
                                              "\n(2) Short hair" +
                                              "\n(3) Medium hair" +
                                              "\n(4) Other");
                            try
                            {
                                intHairLength = int.Parse(Console.ReadLine());
                                if (intHairLength == 0)
                                {

                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                throw;
                            }

                            Console.Clear();
                            Console.WriteLine("What color is your hair?" +
                                              "\n(1) Black" +
                                              "\n(2) Blonde" +
                                              "\n(3) Brown" +
                                              "\n(4) Other");
                            try
                            {
                                intHairColor = int.Parse(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                                throw;
                            }


                            Console.Clear();
                            Console.WriteLine("What type is your hair?" +
                                              "\n(1) Curly" +
                                              "\n(2) Straight" +
                                              "\n(3) Other");
                            int intHairType = int.Parse(Console.ReadLine());
                            //try-catch
                            MakeHair(intHairLength, intHairColor, intHairType);

                            //---------- Eyecolor -----------------
                            Console.Clear();
                            Console.WriteLine("Lastly we need your eyecolor." +
                                              "\nWrite below:");
                            string eyecolor = Console.ReadLine();
                            //try-catch

                            AddPerson(birthday, eyecolor, gender, hair);
                            case1loop = false;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        thinker.Think(3, 300);
                        ListPersons();
                        Console.WriteLine("Press any key to show menu.");
                        Console.ReadKey();

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Exit process started");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Thread.Sleep(500);
                        Console.WriteLine("Press any key to exit" +
                                          "\n-----------------------");
                        Console.ReadKey();
                        exitOption = false;
                        break;
                    // default:
                    // thinker.Think(3, 300);
                    // Console.WriteLine("Please choose from list!");
                    // break;
                }
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("Please choose a number from list!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Please choose a number from list!"); 
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong,\nPlease choose a number from list!");
                
            }
        }
    }

    static Gender MakeGender(int intGender)
    {
        if (intGender == 1)
        {
            gender = Gender.Man;
        }

        if (intGender == 2)
        {
            gender = Gender.Woman;
        }
        if (intGender == 3)
        {
            gender = Gender.Other;
        }
        if (intGender == 4)
        {
            gender = Gender.NotAvailible;
        }

        return gender;
    }
    

    static Hair MakeHair(int intHairtype, int intHairColor, int intHairLength)
    {
     // intHairColor:    (1). Blonde     (2). Brown          (3). Black          (4). Other
     // intHairLength:   (1). Long hair  (2). Short hair     (3). Medium hair    (4). Other
     // intHairType:     (1). Curly      (2). Straight       (3). Other
    //---------- Hair Length --------------------------- 
     if (intHairLength == 1)
     {
         hairLength = "Long Hair";
     }
     if (intHairLength == 2)
     {
         hairLength = "Short Hair";
     } 
     if (intHairLength == 3)
     {
         hairLength = "Medium Hair";
     }
     if (intHairLength == 4)
     {
         hairLength = "Not specified";
     }
     else
     {
         hairLength = "Not specified";
     }
      //---------- Hair Color ---------------------------  
     if (intHairColor == 1)
     {
         hairColor = "Blonde";
     }

     if (intHairColor == 2)
     {
         hairColor = "Brown";
     }

     if (intHairColor == 3)
     {
         hairColor = "Black";
     }

     if (intHairColor == 4)
     {
         hairColor = "Not specified";
     }
     else
     {
         hairColor = "Not specified";
     }
     //---------- Hair Type --------------------------- 
     if (intHairtype == 1)
     {
         hairType = "Curly";
     }
     if (intHairtype == 2)
     {
         hairType = "Straight";
     }
     if (intHairtype == 3)
     {
         hairType = "Not specified";
     }
     else
     {
         hairType = "Not specified";
     }

     hair = new Hair { HairColor = hairColor, HairType = hairType, HairLength = hairLength };
     return hair;
    }
    
    

    static void AddPerson(string birthday, string eyecolor, Gender gender, Hair hair)
    {
        Person person = new Person(birthday, eyecolor, gender, hair);
        addedPersons.Add(person);
    }

    static void ListPersons()
    {
        foreach (var person in addedPersons)
        {
            Console.WriteLine(person.ToString());
            
        }
    }
}
