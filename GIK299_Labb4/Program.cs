// See https://aka.ms/new-console-template for more information

using GIK299_Labb4;




    internal class Program
    {
        //Lista för tillaga personer
        static List<Person> addedPersons = new List<Person>();

        public static void Main(string[] args)
        {
            //bool-variabel för att kunna lämna meny
            bool exitOption = true;
            Thinker thinker = new Thinker();

            //Meny för att lägga till/visa personer som är tillaggda samt avsluta programmet
            while (exitOption)
            {
                Console.WriteLine(
                    "----------------------------------" +
                    "\n Choose an option from list below" +
                    "\n (1) Add person" +
                    "\n (2) Print stored person(s)" +
                    "\n (3) Exit" +
                    "\n----------------------------------"

                );


                string mainMenu = Console.ReadLine();

                //input valideras genom att switch bygger på en string som måste stämma överens med case,
                //annars hamnar man i default som ber en välja nummer
                switch (mainMenu)
                {

                    case "1":
                        Console.Clear();
                        thinker.Think(1, 300);
                        AddPerson();
                        break;
                    case "2":
                        Console.Clear();
                        thinker.Think(1, 300);
                        ListPersons();
                        Console.WriteLine("Stored information was successfully printed!");
                        Thread.Sleep(1500);
                        Console.WriteLine("Press any key to show menu.");
                        Console.ReadKey();

                        break;
                    case "3":
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
                    default:
                        Console.Clear();
                        Console.WriteLine("Please choose a number from list!");
                        break;
                }
            }
        }

        //Metod för att skapa och läggaa till personer
        static void AddPerson()
        {
            //variabler jag behöver nå senare
            string hairColor = "";
            string hairType = "";
            string hairLength = "";
            Gender gender = Gender.NotAvailible;
            int genderChoice = 4;
            int intHairLength = 4;
            int intHairColor = 4;
            int intHairType = 3;
            string eyeColor = "rainbow";
            string strEyeColor = "rainbow";
            bool doBirthday;
            bool doGender;
            bool doHairLength;
            bool doHairColor;
            bool doHairType;
            bool doEyeColor;
            DateTime birthday = DateTime.Now;
            DateTime maxAge = new DateTime(1900, 01, 01);
            Thinker thinker = new Thinker();
            ////do-while loop och try-catch för att ta emot och vailidera indata för födelsedatum
            do
            {
                try
                {
                    Console.WriteLine("What is your date of birth?\n(YYYY-MM-DD)");
                    birthday = DateTime.Parse(Console.ReadLine());
                    doBirthday = false;
                    Console.Clear();
                    if (birthday <= maxAge || birthday >= DateTime.Now)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Weird age! Either you are very old or to young!");
                    doBirthday = true;
                }
                catch
                {
                    Console.WriteLine("Please type date in YYYY-MM-DD format!");
                    doBirthday = true;
                }


            } while (doBirthday);

            thinker.Think(1, 300);
            //do-while loop och try-catch för att ta emot och vailidera indata för kön
            do
            {
                try
                {
                    Console.WriteLine("Please choose your gender from list below:" +
                                      "\n(1) Man" +
                                      "\n(2) Woman" +
                                      "\n(3) Other" +
                                      "\n(4) I do not want to specify");
                    string strGenderChoice = Console.ReadLine();

                    if (strGenderChoice == "1" || strGenderChoice == "2" || strGenderChoice == "3" ||
                        strGenderChoice == "4")
                    {
                        genderChoice = int.Parse(strGenderChoice);
                        doGender = false;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.Clear();
                    Console.WriteLine("Please choose number from list!");
                    doGender = true;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Please choose number from list!");
                    doGender = true;
                }


            } while (doGender);
            //Switch för att tilldela enum till gender

            switch (genderChoice)
            {
                case 1:
                    gender = Gender.Man;
                    break;
                case 2:
                    gender = Gender.Woman;
                    break;
                case 3:
                    gender = Gender.Other;
                    break;
                case 4:
                    gender = Gender.NotAvailible;
                    break;

            }

            Console.Clear();
            thinker.Think(1, 300);
            Console.WriteLine("Next we need information about your hair.");
            
            //do-while loop och try-catch för att ta emot och vailidera indata för hårlängd
            do
            {
                try
                {
                    //------------------ Hair ------------------
                    Console.WriteLine("What length is your hair?" +
                                      "\n(1) Long hair" +
                                      "\n(2) Short hair" +
                                      "\n(3) Medium hair" +
                                      "\n(4) Other");
                    string strHairLength = Console.ReadLine();

                    if (strHairLength == "1" || strHairLength == "2" || strHairLength == "3" ||
                        strHairLength == "4")
                    {
                        Console.Clear();
                        intHairLength = int.Parse(strHairLength);
                        doHairLength = false;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }

                }
                catch (ArgumentException)
                {
                    Console.Clear();
                    Console.WriteLine("Please choose number from list!");
                    doHairLength = true;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Please choose number from list!");
                    doHairLength = true;

                }

            } while (doHairLength);
            //Switch för tilldela string till hårlängd

            switch (intHairLength)
            {
                case 1:
                    hairLength = "Long Hair";
                    break;
                case 2:
                    hairLength = "Short Hair";
                    break;
                case 3:
                    hairLength = "Medium Hair";
                    break;
                case 4:
                    hairLength = "No information about hair length";
                    break;
            }

            Console.Clear();
            thinker.Think(1, 300);
            //do-while loop och try-catch för att ta emot och vailidera indata för hårfärg
            do
            {
                try
                {
                    Console.WriteLine("What color is your hair?" +
                                      "\n(1) Black" +
                                      "\n(2) Blonde" +
                                      "\n(3) Brown" +
                                      "\n(4) Other");

                    string strHairColor = Console.ReadLine();

                    if (strHairColor == "1" || strHairColor == "2" || strHairColor == "3" ||
                        strHairColor == "4")
                    {
                        Console.Clear();
                        intHairColor = int.Parse(strHairColor);
                        doHairColor = false;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }

                }
                catch (ArgumentException)
                {
                    Console.Clear();
                    Console.WriteLine("Please choose number from list!");
                    doHairColor = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please chose number from list!");
                    doHairColor = true;
                }


            } while (doHairColor);
            
            //Switch för tilldela string till hårfärg

            switch (intHairColor)
            {
                case 1:
                    hairColor = "Black hair";
                    break;
                case 2:
                    hairColor = "Blonde hair";
                    break;
                case 3:
                    hairColor = "Brown hair";
                    break;
                case 4:
                    hairColor = "No information about hair color";
                    break;

            }

            Console.Clear();
            thinker.Think(1, 300);
            //do-while loop och try-catch för att ta emot och vailidera indata för hårtyp
            do
            {
                try
                {
                    Console.WriteLine("What type is your hair?" +
                                      "\n(1) Curly" +
                                      "\n(2) Straight" +
                                      "\n(3) Other");
                    string strHairType = Console.ReadLine();

                    if (strHairType == "1" || strHairType == "2" || strHairType == "3")
                    {
                        Console.Clear();
                        intHairType = int.Parse(strHairType);
                        doHairType = false;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }

                }
                catch (ArgumentException)
                {
                    Console.Clear();
                    Console.WriteLine("Please choose number from list!");
                    doHairType = true;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Please chose number from list!");
                    doHairType = true;
                }

            } while (doHairType);
            
            //Switch för tilldela string till hårtyp
            switch (intHairType)
            {
                case 1:
                    hairType = "Curly hair";
                    break;
                case 2:
                    hairType = "Straight hair";
                    break;
                case 3:
                    hairType = "No information about hair type";
                    break;
            }

            //---------- Eye color -----------------
            Console.Clear();
            thinker.Think(1, 300);
            Console.WriteLine("Lastly we need your eyecolor." +
                              "\nWrite below:");
            //loop och validering av indata för ögonfärg
            do
            {
                try
                {
                    string inputEyeColor = Console.ReadLine();
                    strEyeColor = inputEyeColor.ToLower();
                    if (strEyeColor == "green" || strEyeColor == "blue" || strEyeColor == "brown" ||
                        strEyeColor == "grey" || strEyeColor == "mix")
                    {
                        doEyeColor = false;
                    }

                    else if (strEyeColor == "red")
                    {
                        Console.WriteLine("Demon??\n Try again!");
                        doEyeColor = true;
                    }
                    else if (strEyeColor == "")
                    {
                        throw new FormatException();
                    }
                    else
                    {
                        throw new FormatException();
                    }

                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Try again, examples for eye color:\n Green, Blue, Grey, Brown or Mix");
                    doEyeColor = true;

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Try again, examples for eye color:\n Green, Blue, Grey, Brown or Mix");
                    doEyeColor = true;
                }

            } while (doEyeColor);
            //Switch för att skriva ut ögonfärgen med stor första bokstav eftersom jag i tidigare steg
            //gör texten till små bokstäver för att kunna använda mina villkor i if-sats

            switch (strEyeColor)
            {
                case "green":
                    eyeColor = "Green";
                    break;
                case "blue":
                    eyeColor = "Blue";
                    break;
                case "brown":
                    eyeColor = "Brown";
                    break;
                case "grey":
                    eyeColor = "Grey";
                    break;
                case "mix":
                    eyeColor = "Mix";
                    break;
            }
            //Skapar "hair"
            Hair hair = new Hair { HairColor = hairColor, HairType = hairType, HairLength = hairLength };
            //skapar "person"
            Person person = new Person(birthday, eyeColor, gender, hair);
            //lägger till person
            addedPersons.Add(person);
            thinker.Think(1, 300);
            Console.WriteLine("Person successfully added!");
            Thread.Sleep(1500);
        }

        //Metod för att skriva ut alla personer i listan.
        static void ListPersons()
        {
            foreach (var person in addedPersons)
            {
                Console.WriteLine(person.ToString());

            }
        }
    }

