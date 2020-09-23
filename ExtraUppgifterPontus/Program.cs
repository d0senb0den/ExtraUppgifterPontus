using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExtraUppgifterPontus
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Uppgift 1
            /*Console.WriteLine("Vad är ditt namn?");
            string name = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Vilken stad bor du i?");
            string city = Console.ReadLine();
            Console.WriteLine("Är du en han eller hon?");
            string gender = Console.ReadLine();

            Console.WriteLine("\nDet var en gång en elev som hette " + name + ".");
            Console.WriteLine("En dag var " + gender + " ute på promenad i " + city + ", och träffade en katt.");
            Console.WriteLine("Katten frågade: - Vem är du?");
            Console.WriteLine("Eleven svarade: - Jag heter " + name + " och jag är " + age + " år gammal.");
            Console.WriteLine("Katten sa: - Du verkar trevlig, och ditt namn, " + name + ", låter sympatiskt.");
            Console.WriteLine("Katten fortsatte: - Jag är " + CalculateCatAge(age) + " år yngre än dig, men vi kan nog bli vänner.");
            Console.WriteLine("Eleven sa: Låt oss slå följe i " + city + ".");
            Console.WriteLine("Så var sagan slut!");

            Console.WriteLine("\nAvsluta med valfri tangent...");
            Console.ReadKey();
        }
        static int CalculateCatAge(int age)
        {
            return age - 8;
        }*/
            #endregion
            #region Uppgift 2

            /*Console.WriteLine("Skriv det första decimaltalet:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv det andra decimaltalet:");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv det tredje decimaltalet:");
            double thirdNumber = double.Parse(Console.ReadLine());

            double sum = firstNumber + secondNumber + thirdNumber;
            double average = sum / 3;

            Console.WriteLine("\nSumman av följande tal är: ");
            Console.WriteLine(firstNumber + " + " + secondNumber + " + " + thirdNumber + " = " + (firstNumber + secondNumber + thirdNumber));
            Console.WriteLine("Summan avrundat: " + Math.Round(firstNumber + secondNumber + thirdNumber));
            Console.WriteLine("\nMedelvärdet är: ");
            Console.WriteLine(average);

            Console.WriteLine("\nTryck på valfri tangent för att avsluta...");
            Console.ReadKey();*/

            #endregion
            #region Uppgift 3
            /*double number;
            Console.WriteLine("Skriv in en valfri siffra för att se hur den konverterar till olika enheter: ");
            string testNumber = Console.ReadLine();
            number = Convert.ToDouble(testNumber);

            Console.WriteLine($"{number} meter = {meterToYard(number)} yard.");
            Console.WriteLine($"{number} kilo = {kiloToPound(number)} pound.");
            Console.WriteLine($"{number} celsius = {celsiusToFahrenheit(number)} fahrenheit.");
            Console.WriteLine($"{number} kilowatt = {kiloWattToHorsePower(number)} hästkrafter.");

            Console.WriteLine("\nTryck på valfri tangent för att avsluta...");
            Console.ReadKey();*/
            #endregion
            #region Extra 1
            /*Console.WriteLine("Ange en siffra:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Numret " + number + " som du angav är jämnt.");
            }
            else
            {
                Console.WriteLine("Numret " + number + " som du angav är ojämnt.");
            }

            Console.ReadKey();*

            #endregion
            #region Extra 2
            /*Console.Title = "Berättelsen om katten";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Vad är ditt namn?");
            string name = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Hur gammal är du?");
            int age = int.Parse(Console.ReadLine());
            Console.Beep();
            Console.WriteLine("Vilken stad bor du i?");
            string city = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Är du en han eller hon?");
            string gender = Console.ReadLine();
            Console.Beep();

            Console.WriteLine("\nDet var en gång en elev som hette " + name + ".");
            Console.WriteLine("En dag var " + gender + " ute på promenad i " + city + ", och träffade en katt.");
            Console.WriteLine("Katten frågade: - Vem är du?");
            Console.WriteLine("Eleven svarade: - Jag heter " + name + " och jag är " + age + " år gammal.");
            Console.WriteLine("Katten sa: - Du verkar trevlig, och ditt namn, " + name + ", låter sympatiskt.");
            Console.WriteLine("Katten fortsatte: - Jag är " + CalculateCatAge(age) + " år yngre än dig, men vi kan nog bli vänner.");
            Console.WriteLine("Eleven sa: Låt oss slå följe i " + city + ".");
            Console.WriteLine("Så var sagan slut!");

            Console.WriteLine("\nAvsluta med valfri tangent...");
            Console.ReadKey();
        }
        static int CalculateCatAge(int age)
        {
            return age - 8;*/

            #endregion
            #region Extra 3
            /*var random = new Random();
            int randomNumber = random.Next(1, 101), count = 1, guess=0; // Skapar random tal mellan 1-100. startar gissningen på 1, skapar variabel för gissning.

            {

            }
            while (count < 4)
            {
                Console.WriteLine("\nGissa på ett tal mellan 1 - 100");
                try
                {
                    guess = int.Parse(Console.ReadLine());

                    if (guess == randomNumber)
                    {
                        Console.WriteLine("\nDet var rätt! Bra jobbat :)");
                        break;
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("\nTalet är större.");
                        Console.WriteLine($"Fel gissning, du har {3 - count} gissningar kvar.");
                        count++;
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("\nTalet är mindre.");
                        Console.WriteLine($"Fel gissning, du har {3 - count} gissningar kvar.");
                        count++;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Skriv endast siffror.");
                }

            }
            Console.WriteLine("\nTryck på valfri tangent för att avsluta..");
            Console.ReadKey();*/

            #endregion
            #region Extra 4

            //1
            /*Console.WriteLine("Skriv ditt namn:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
            Console.ReadKey();*/

            //2
            /*int firstNumber, secondNumber;
            Console.WriteLine("Ange det första numret:");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange det andra numret:");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Summan blir: " + (firstNumber + secondNumber));
            Console.ReadKey();*/

            //3
            /*double firstNumber, secondNumber, thirdNumber;
            Console.WriteLine("Ange det första decimaltalet:");
            firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Ange det andra decimaltalet:");
            secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Ange det tredje decimaltalet:");
            thirdNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Summan blir: " + (firstNumber + secondNumber + thirdNumber));
            Console.WriteLine("Medelvärdet blir: " + (firstNumber + secondNumber + thirdNumber) / 3);
            Console.ReadKey();*/

            //4
            /*double number;
            Console.WriteLine("Ange ett decimaltal:");
            number = double.Parse(Console.ReadLine());
            Console.WriteLine("Talet blir avrundat till: " + Math.Round(number));

            Console.ReadKey();*/
            #endregion
            #region Övning 3-1

            //1
            /*Console.WriteLine("Är MFF sveriges bästa lag? Svara med ja eller nej.");
            string answer = Console.ReadLine();
            if (answer == "ja")
            {
                Console.WriteLine("Helt rätt!");
            }
            else
            {
                Console.WriteLine("Väldigt fel!");
            }

            Console.ReadKey();*/

            //2 och 3
            /*Console.WriteLine("Vad är temperaturen i Svedala?");
            int temp1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vad är temperaturen i Jukkasjärvi?");
            int temp2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vad är temperaturen i Visby?");
            int temp3 = int.Parse(Console.ReadLine());

            if (temp1 < temp2 && temp1 < temp3)
            {
                Console.WriteLine("Svedala är kallast.");
            }
            else if (temp2 < temp1 && temp2 < temp3)
            {
                Console.WriteLine("Jukkasjärvi är kallast.");
            }
            else if (temp3 < temp1 && temp3 < temp2)
            {
                Console.WriteLine("Visby är kallast.");
            }

            Console.ReadKey();*/
            #endregion
            #region Övning 3-3
            //1
            /*int number = 0;

            while (number < 100)
            {
                
                number++;
                if (number % 2 == 0)
                {
                    Console.WriteLine("[" + number + "]");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }

            Console.ReadKey();*/

            //2

            /*for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("[" + i + "]");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            

            Console.ReadKey();*/
            #endregion
            #region Övning 3-4

            /*for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    var number = (i * j).ToString();
                    if (number.Length < 2)
                    {
                        Console.Write(number + "   ");
                    }
                    else
                    {
                        Console.Write(number + "  ");
                    }

                }
                Console.WriteLine();
            }
            Console.ReadKey();*/

            #endregion
            #region Övning 3-5 - Bish Bosh

            /*Console.WriteLine("Hur många loops vill du ha?");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in det första talet, bish:");
            int bish = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in det andra talet, bosh:");
            int bosh = int.Parse(Console.ReadLine());

            for (int i = 1; i < input; i++)
            {

                if (i % bish == 0 && i % bosh == 0)
                {
                    Console.Write(" Bish / Bosh ");
                    Console.WriteLine();
                }
                else if (i % bosh == 0)
                {
                    Console.Write(" Bosh ");
                }
                else if (i % bish == 0)
                {
                    Console.Write(" Bish ");
                }
                else
                {
                    Console.Write(" " + i + " ");
                }
                

            }


            Console.ReadKey();*/
            #endregion
            #region Extra 2-1 - Labyrint
            /*bool loop = true;
            int size = 3;
            do  // Kör denna kod.
            {
                Labyrinth(size); // Metod för labyrinten.

                Console.WriteLine($"\nStorlek: {size}x{size}");
                Console.WriteLine("\nAnvänd knapparna: X = förstora, Z = Förminska, Q = Avsluta");

                char player = 'O';
                int x = 4, y = 4;
                Write(player);

                var command = Console.ReadKey().Key;
                        
                switch (command)
                {
                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        y++;
                        break;
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        if (y > 4)
                        {
                            y--;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        if (x > 4)
                        {
                            x--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        x++;
                        break;
                }
                Write(player, x, y);


                ConsoleKeyInfo key = Console.ReadKey();
                if (key.KeyChar == 'x')
                {
                    size++;
                }
                if (key.KeyChar == 'z')
                {
                    size--;
                }
                Console.WriteLine();
                if (key.KeyChar == 'q')
                {
                    loop = false;
                }

            } while (loop); // Sålänge loop är sant.*/



            #endregion
            #region Övning 1 - Switch & metoder

            /*bool inMenu = true;
            float balance = 0;
            List<string> checkHistory = new List<string>();

            while (inMenu)
            {
                Console.Write(" \n" +
                              "_______Menu_______\n" +
                              " \n" +
                              "1.   Deposit\n" +
                              "2.   Withdraw\n" +
                              "3.   Check balance\n" +
                              "4.   Quit\n");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":

                        Console.Clear();
                        Console.WriteLine("\nType the amount you want to deposit:");

                        float deposit;
                        bool depositable = float.TryParse(Console.ReadLine(), out deposit);

                        if (depositable)
                        {
                            balance += deposit;
                            checkHistory.Add($"{DateTime.UtcNow} Deposit: +{deposit}");
                        }
                        else
                        {
                            Console.WriteLine("\nPlease try again..");
                        }
                        Console.Clear();
                        Console.WriteLine($"Deposited amount: {deposit}\n");
                        Console.WriteLine("\nPress any key to continue..");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Type the amount you want to withdraw:");

                        float withdraw;
                        bool withdrawable = float.TryParse(Console.ReadLine(), out withdraw);
                        if (withdrawable)
                        {
                            balance -= withdraw;
                            checkHistory.Add($"{DateTime.UtcNow} Withdraw: -{withdraw}");
                        }
                        else
                        {

                        }
                        Console.Clear();
                        Console.WriteLine($"Amount withdrawn: {withdraw}\n");
                        Console.WriteLine("\nPress any key to continue..");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Balance: " + balance + "\n");

                        foreach (var transaction in checkHistory)
                        {
                            Console.WriteLine(transaction);
                        }

                        Console.WriteLine("\nPress any key to continue..");
                        Console.ReadKey();
                        break;

                    case "4":
                        inMenu = false;
                        break;

                    default:
                        Console.WriteLine("Wrong input, try again using numbers 1-4.");
                        break;
                }
            }*/
            #endregion
            #region Övning 2 - Metoder

            /*Console.WriteLine($"Summan: {Addera (1, 2)}");
              Console.WriteLine($"Moms: {Momsen(100)}");
              Console.WriteLine($"Moms + belopp: {MomsBelopp(150)}");
              Console.ReadKey();*/

            #endregion
            #region Övning 4-1 - Veckodagar

            /*int day = (int)DateTime.Now.DayOfWeek;

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

                foreach (var number in numbers)
                {
                    switch (number)
                    {
                        case 1:
                        if (number == day)
                        {
                            Console.WriteLine("\nMåndag (IDAG) - Jobbig dag, början på veckan.");
                        }
                        else
                        {
                            Console.WriteLine("\nMåndag - Jobbig dag, början på veckan.");
                        }
                            break;
                        case 2:
                        if (number == day)
                        {
                            Console.WriteLine("\nTisdag (IDAG) - Bara 4 dagar till helg.");
                        }
                        else
                        {
                            Console.WriteLine("\nTisdag - Bara 4 dagar till helg.");
                        }
                            break;
                        case 3:
                        if (number == day)
                        {
                            Console.WriteLine("\nOnsdag (IDAG) - Lillördag");
                        }
                        else
                        {
                            Console.WriteLine("\nOnsdag - Lillördag");
                        }
                            break;
                        case 4:
                        if (number == day)
                        {
                            Console.WriteLine("\nTorsdag (IDAG) - Bara 2 dagar till helg");
                        }
                        else
                        {
                            Console.WriteLine("\nTorsdag - Bara 2 dagar till helg");
                        }
                            break;
                        case 5:
                        if (number == day)
                        {
                            Console.WriteLine("\nFredag (IDAG) - Fredagsmys!!");
                        }
                        else
                        {
                            Console.WriteLine("\nFredag - Fredagsmys!!");
                        }
                            break;
                        case 6:
                        if (number == day)
                        {
                            Console.WriteLine("\nLördag (IDAG) - Äntligen lördag!");
                        }
                        else
                        {
                            Console.WriteLine("\nLördag - Äntligen lördag!");
                        }
                            break;
                        case 7:
                        if (number == day)
                        {
                            Console.WriteLine("\nSöndag (IDAG) - Åh nej, är det redan söndag?");
                        }
                        else
                        {
                            Console.WriteLine("\nSöndag - Åh nej, är det redan söndag?");
                        }
                            break;
                    }
                }

            Console.ReadKey();*/
            #endregion
            #region Övning 4-2 - Tärning

            /*int dice1, dice2, dice3, score = 0;
            Random random = new Random();

            do
            {
                Console.WriteLine("Tryck på valfri tangent för att slå tärningarna.\n");
                Console.WriteLine("Tryck Q för avsluta.\n");
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.KeyChar == 'q')  // Avslutar
                {
                    break;
                }

                dice1 = random.Next(1, 7); // Metod för random nummer.
                dice2 = random.Next(1, 7);
                dice3 = random.Next(1, 7);
                Console.Clear();
                PrintDice(dice1);  // Metod för tärning.
                PrintDice(dice2);
                PrintDice(dice3);

                if (dice1 == dice2 && dice2 == dice3)
                {
                    score += 3;
                }
                else if (dice1 == dice2 || dice1 == dice3 || dice2 == dice3)
                {
                    score += 2;
                }
                else if ((dice1 + dice2 + dice3) < 9)
                {
                    score--;
                }

                Console.WriteLine($"\nScore: {score}\n");

            } while (true);*/

            #endregion
            #region Övning 5-1 - Berättelse 2

            /*TellStory();*/

            #endregion
            #region Övning 6-1 - Skogen
            /*
                        var forest = new List<SkogenAnimal>();

                        bool day = true;

                        forest.Add(new SkogenAnimal("Varg", true));
                        forest.Add(new SkogenAnimal("Fladdermus", true));
                        forest.Add(new SkogenAnimal("Delfin", false));
                        forest.Add(new SkogenAnimal("Örn", false));
                        forest.Add(new SkogenAnimal("Häst", false));

                        while (true)
                        {
                            Console.WriteLine("\nTryck Q för avsluta.\n");
                            Console.WriteLine("Tryck D för att visa djuren under dagtid.\n");
                            Console.WriteLine("Tryck N för att visa djuren under nattid.\n");

                            var input = Console.ReadKey(true);
                            if (input.KeyChar == 'q')  // Avslutar
                            {
                                break;
                            }
                            else if (input.KeyChar == 'd') //dagtid
                            {
                                day = true;

                            }
                            else if (input.KeyChar == 'n') //nattid
                            {
                                day = false;
                            }
                            Console.Clear();
                            foreach (var animal in forest)
                            {
                                if (day != animal.nocturnal)
                                {
                                    Console.WriteLine($"{animal.name}en jagar.");
                                }
                                else if (day == animal.nocturnal)
                                {
                                    Console.WriteLine($"{animal.name}en sover.");
                                }
                            }
                        }*/

            #endregion
            #region Övning 6-2 - Virusepidimin

            /*int time = 0;
            int infectedCount = 1;
            int infectedCountText = 1;
            int immuneCount = 0;

            var diskotek = new List<Person>();

            diskotek.Add(new Person(true, 0, false));

            for (int i = 0; i < 49; i++)
            {
                diskotek.Add(new Person(false, 0, false));
            }
            do
            {
                Console.ReadKey(true);
                int newInfected = 0;
                Console.WriteLine($"Time: {time}");
                Console.WriteLine($"Amount of infected: {infectedCountText}");
                Console.WriteLine($"Amount of immune: {immuneCount}");

                foreach (var person in diskotek)
                {
                    if (person.immune)
                    {
                        continue;
                    }
                    else if (!person.infected)
                    {
                        if (newInfected < infectedCount)
                        {
                            person.infected = true;
                            newInfected++;
                            infectedCountText++;
                        }
                    }
                    else if (person.infected)
                    {
                        person.infectedAt++;
                        if (person.infectedAt == 5)
                        {
                            person.infected = false;
                            person.immune = true;
                            immuneCount++;
                            infectedCountText--;
                            infectedCount--;
                        }
                    }
                    
                }
                int count = 0;
                //infectedCount = infectedCount * 2;
                foreach (var person in diskotek)
                {
                    if (person.infected)
                    {
                        count++;
                    }
                }

                infectedCount = count;
                time++;

            } while (true);*/

            #endregion
            #region Extraövning 1 - Skottår
            /*int year;

            while (true)
            {
                Console.Write("Vänligen mata in ett årtal: ");

                bool input = int.TryParse(Console.ReadLine(), out year);

                bool isLeapYear = IsLeapYear(year);
                
                if (year == 0)
                {
                    break;
                }

                if (isLeapYear == true)
                {
                    Console.WriteLine($"År {year} är ett skottår (det har 366 dagar.)\n");
                }
                else if (isLeapYear == false)
                {
                    Console.WriteLine($"År {year} är inte ett skottår (det har 365 dagar.)\n");
                }               
            }
*/

            #endregion
            #region Extraövning 2 - Merrymethods

            /*int count = 0;
            MethodBench methodBench = new MethodBench();
            bool shout = true;


            do
            {
                methodBench.FirstMethod();

                count++;

            } while (count < 3);
            Console.WriteLine("Skriv valfri text:");
            string text = Console.ReadLine();

            methodBench.SecondMethod("C# Now and Forever!");
            methodBench.SecondMethod(text);

            Console.WriteLine("Små eller stora bokstäver? 1 = stora , 2 = små.");
            var input = Console.ReadKey(true);

            switch (input.KeyChar)
            {
                case '1':
                    shout = true;
                    break;
                case '2':
                    shout = false;
                    break;
            }

            methodBench.ThirdMethod(text, shout);

            shout = methodBench.FourthMethod();

            methodBench.ThirdMethod(text, shout);

            methodBench.ThirdMethod(text, methodBench.FourthMethod());

            Console.ReadKey(true);*/

            #endregion
            #region Code Along - Constructor
            /*
            Car car = new Car("Volvo", 1997);

            Console.WriteLine($"En {car.model} som är {car.age} år {(car.age < 5?"ny":"gammal")}.");


            Console.ReadLine();
            */
            #endregion
            #region Övning 8-1 - Bibliotek

            /*List<Bok> böcker = SkapaBöcker();

            SkrivUtBöcker(böcker);

            bool iMeny = true;

            while (iMeny)
            {
                Console.Write(" \n" +
                              "_____Bibliotek_____\n" +
                              " \n" +
                              "1.   Fakta\n" +
                              "2.   Barn\n" +
                              "3.   Underhållning\n" +
                              "4.   Quit\n");

                var input = Console.ReadKey();

                Console.Clear();

                switch (input.KeyChar)
                {
                    case '1':
                        SkrivUtFaktaBöcker(böcker);
                        break;
                    case '2':
                        SkrivUtBarnBöcker(böcker);
                        break;
                    case '3':
                        SkrivUtUnderhållningsBöcker(böcker);
                        break;
                    case '4':
                        iMeny = false;
                        break;

                    default:
                        Console.WriteLine("Fel inmatning, försök igen med siffrorna 1-4.");
                        break;
                }
            }*/
            #endregion
            #region Övning 8-2 - Skogen 2

            List<Animal> animals = CreateAnimals();

            bool night = true;

            while (true)
            {
                Console.WriteLine("\nTryck Q för avsluta.\n");
                Console.WriteLine("Tryck D för att visa djuren under dagtid.\n");
                Console.WriteLine("Tryck N för att visa djuren under nattid.\n");

                var input = Console.ReadKey(true);
                if (input.KeyChar == 'q')  // Avslutar
                {
                    break;
                }
                else if (input.KeyChar == 'd') //dagtid
                {
                    night = false;

                }
                else if (input.KeyChar == 'n') //nattid
                {
                    night = true;
                }
                Console.Clear();
                foreach (var animal in animals)
                {
                    Console.WriteLine($"{animal.ToString(night)} {animal.name}en har en vikt på {animal.weight} kg och {animal.height} cm i höjd.");
                }
            }

                #endregion
        }

        #region Övning 8-2 - Skogen 2 - Metoder & class
        private static List<Animal> CreateAnimals()
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Wolf(8, 67, 74, "Varg", true));
            animals.Add(new Bat(true, 1, 11, "Fladdermus", true));
            animals.Add(new Dolphin(28, 130, 190, "Delfin", false));
            animals.Add(new Eagle(4, 6, 80, "Örn", false));
            animals.Add(new Horse(3, 720, 160, "Häst", false));

            return animals;
        }

        class Animal
        {
            public int weight;
            public int height;
            public string name;
            public bool nocturnal;
            public Animal(int weight, int height, string name, bool nocturnal)
            {
                this.weight = weight;
                this.height = height;
                this.name = name;
                this.nocturnal = nocturnal;
            }
            public virtual string ToString(bool night)
            {
                return $"{name}en har en vikt på {weight} kg och {height} cm i höjd.";
            }
        }

        class Wolf : Animal
        {
            public int numberInPack;
            public Wolf(int numberInPack , int weight, int height, string name, bool nocturnal) : base(weight, height, name, nocturnal)
            {
                this.numberInPack = numberInPack;
            }
            public override string ToString(bool night)
            {
                if (night == nocturnal)
                {
                    return $"{name}en går i sin pack på {numberInPack} vargar.";
                }
                else
                {
                    return $"{name}en sover i sin lya.";
                }
                
            }
        }

        class Bat : Animal
        {
            public bool vampire;
            public Bat(bool vampire, int weight, int height, string name, bool nocturnal) : base(weight, height, name, nocturnal)
            {
                this.vampire = vampire;
            }
            public override string ToString(bool night)
            {
                if (night == nocturnal)
                {
                    return $"{name}en {(vampire ? "kan förvandlas till Dracula!" : "är en vanlig fladdermus.")}";
                }
                else
                {
                    return $"{name}en sover i {(vampire ? "sin kista." : "grottan.")}";
                }
            }
        }

        class Dolphin : Animal
        {
            public int fishPerDay;
            public Dolphin(int fishPerDay, int weight, int height, string name, bool nocturnal) : base(weight, height, name, nocturnal)
            {
                this.fishPerDay = fishPerDay;
            }
            public override string ToString(bool night)
            {
                if (night == nocturnal)
                {
                    return $"{name}en simmar runt i vattnet, hittils har den ätit {fishPerDay} fiskar.";
                }
                else
                {
                    return $"{name}en sover lugnt i vattnet.";
                }
            }
        }

        class Eagle : Animal
        {
            public int spottedMice;
            public Eagle(int spottedMice, int weight, int height, string name, bool nocturnal) : base(weight, height, name, nocturnal)
            {
                this.spottedMice = spottedMice;
            }
            public override string ToString(bool night)
            {
                if (night == nocturnal)
                {
                    return $"{name}en fick syn på {spottedMice} möss.";
                }
                else
                {
                    return $"{name}en sover i sitt bo.";
                }
            }
        }

        class Horse : Animal
        {
            public int hayPerDay;

            public Horse(int hayPerDay, int weight, int height, string name, bool nocturnal) : base(weight, height, name, nocturnal)
            {
                this.hayPerDay = hayPerDay;
            }
            public override string ToString(bool night)
            {
                if (night == nocturnal)
                {
                    return $"{name}en har ätit {hayPerDay} höstackar.";
                }
                else
                {
                    return $"{name}en sover ståendes.";
                }
            }
        }
        #endregion
        #region Övning 8-1 - Bibliotek - Metoder & class
        class Bok
        {
            public string titel;
            public string författare;
            public int sidor;

            public Bok(string NamnPåTitel, string NamnPåFörfattare, int AntalSidor)
            {
                titel = NamnPåTitel;
                författare = NamnPåFörfattare;
                sidor = AntalSidor;
            }
        }

        class Faktabok : Bok
        {
            public string ämne;
            public int nivå;
            public Faktabok(string NamnPåTitel, string NamnPåFörfattare, int AntalSidor, string ÄmnePåBok, int Svårighetsgrad) : base(NamnPåTitel, NamnPåFörfattare, AntalSidor)
            {
                ämne = ÄmnePåBok;
                nivå = Svårighetsgrad;
            }

            public override string ToString()
            {
                return $"Ämne: {ämne}   Nivå: {nivå}";
            }
        }

        class Barnbok : Bok
        {
            public bool ålder;
            public bool bildbok;
            public Barnbok(string NamnPåTitel, string NamnPåFörfattare, int AntalSidor, bool BarnEllerUngdom, bool bilderbok) : base(NamnPåTitel, NamnPåFörfattare, AntalSidor)
            {
                ålder = BarnEllerUngdom;
                bildbok = bilderbok;
            }
            public override string ToString()
            {
                return $"ålder: {(ålder ? "Barn" : "Ungdom")}   bildbok: {(bildbok ? "Ja" : "Nej")}";
            }
        }

        class Underhållning : Bok
        {
            public string typ;
            public bool novell;
            public Underhållning(string NamnPåTitel, string NamnPåFörfattare, int AntalSidor, string TypAvBok, bool RomanEllerAntologi) : base(NamnPåTitel, NamnPåFörfattare, AntalSidor)
            {
                typ = TypAvBok;
                novell = RomanEllerAntologi;
            }
            public override string ToString()
            {
                return $"typ: {typ}   novell: {(novell ? "Roman" : "Antologi")}";
            }
        }

        private static List<Bok> SkapaBöcker()
        {
            List<Bok> böcker = new List<Bok>();

            böcker.Add(new Faktabok("Mamas sista kram", "Frans de Waal", 357, "Djur", 3));
            böcker.Add(new Faktabok("Svamparnas planet", "Jesper Nyström", 207, "Natur", 2));
            böcker.Add(new Barnbok("Campingmysteriet", "Martin Widmark", 88, true, true));
            böcker.Add(new Barnbok("Virus", "Lina Hammar", 189, false, false));
            böcker.Add(new Underhållning("Tillsammans", "Linus Svärd", 298, "Kärlek", true));
            böcker.Add(new Underhållning("Gitarrens vägar", "Kalle Nyfors", 189, "Musik", false));

            return böcker;
        }

        private static void SkrivUtBöcker(List<Bok> boklista)
        {
            foreach (var bok in boklista)
            {
                Console.WriteLine($"Titel: {bok.titel}   Författare: {bok.författare}   Sidor: {bok.sidor}   {bok.ToString()}");
            }
            
        }

        private static void SkrivUtFaktaBöcker(List<Bok> boklista)
        {
            foreach (var bok in boklista)
            {
                if (bok is Faktabok)
                {
                    Console.WriteLine($"Titel: {bok.titel}   Författare: {bok.författare}   Sidor: {bok.sidor}   {bok.ToString()}");
                }
                
            }

        }
        private static void SkrivUtBarnBöcker(List<Bok> boklista)
        {
            foreach (var bok in boklista)
            {
                if (bok is Barnbok)
                {
                    Console.WriteLine($"Titel: {bok.titel}   Författare: {bok.författare}   Sidor: {bok.sidor}   {bok.ToString()}");
                }

            }

        }
        private static void SkrivUtUnderhållningsBöcker(List<Bok> boklista)
        {
            foreach (var bok in boklista)
            {
                if (bok is Underhållning)
                {
                    Console.WriteLine($"Titel: {bok.titel}   Författare: {bok.författare}   Sidor: {bok.sidor}   {bok.ToString()}");
                }

            }

        }

        #endregion
        #region Code Along - Constructor - Class
        class Car
            {
                public string model;
                public int year;
                public int age;
                public Car(string modelName, int modelYear)
                {
                    model = modelName;
                    year = modelYear;
                    age = DateTime.Now.Year - modelYear;
                }

            }
        #endregion
        #region Extraövning 1 - Skottår - Metoder
        private static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }           
        }
        #endregion
        #region Övning 6-2 - Virusepidimin - Class
        class Person
        {
            public bool infected { get; set; }
            public int infectedAt { get; set; }
            public bool immune { get; set; }

            public Person(bool _infected, int _infectedTime, bool _immune)
            {
                infected = _infected;
                infectedAt = _infectedTime;
                immune = _immune;
            }
        }
        #endregion
        #region Övning 5-1 - Berättelse 2 - Metoder
        /*private static void TellStory()
        {
            Animal animal1 = CreateAnimal("kanin", "Tonny", 1988, 4, true);
            animal1.Story();
            Animal animal2 = CreateAnimal("åsna", "Bert", 1768, 4, false);
            animal2.Story();

            Console.ReadKey(true);
        }

        static Animal CreateAnimal(string _animalType, string _name, int _birthYear, int _legs, bool _isFast)
        {
            Animal animal = new Animal();
            animal.animalType = _animalType;
            animal.name = _name;
            animal.birthYear = _birthYear;
            animal.age = DateTime.Now.Year - _birthYear;
            animal.legs = _legs;
            animal.fast = _isFast;
            return animal;
        }*/
        #endregion
        #region Övning 4-2 - Tärning - Metoder
        private static void PrintDice(int value)
        {
            switch (value)
            {
                case 1:
                    Console.WriteLine(" _____ \n" +
                                      "|     |\n" +
                                      "|  O  |\n" +
                                      "|_____|\n");
                    break;
                case 2:
                    Console.WriteLine(" _____ \n" +
                                      "|O    |\n" +
                                      "|     |\n" +
                                      "|____O|\n");
                    break;
                case 3:
                    Console.WriteLine(" _____ \n" +
                                      "|O    |\n" +
                                      "|  O  |\n" +
                                      "|____O|\n");
                    break;
                case 4:
                    Console.WriteLine(" _____ \n" +
                                      "|O   O|\n" +
                                      "|     |\n" +
                                      "|O___O|\n");
                    break;
                case 5:
                    Console.WriteLine(" _____ \n" +
                                      "|O   O|\n" +
                                      "|  O  |\n" +
                                      "|O___O|\n");
                    break;

                case 6:
                    Console.WriteLine(" _____ \n" +
                                      "|O   O|\n" +
                                      "|O   O|\n" +
                                      "|O___O|\n");
                    break;
            }
        }
        #endregion
        #region Övning 2 - Metoder
        static double Addera(double a, double b)
        {
            return (a + b);
        }
        static double Momsen(double a)
        {
            return a * 0.25;
        }
        static double MomsBelopp(double a)
        {
            return Addera(a, Momsen(a));
        }
        #endregion
        #region Extra 2-1 Metoder

        private static void Write(char player, int x = 2, int y = 2)
        {
            try
            {
                if (x >= 2 && y >= 2)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(player);
                }
            }
            catch (Exception)
            {
            }
        }
        private static void Labyrinth(int size)
        {
            Console.Clear();
            size = 1 + (4 * size);   // Storlek på spelet.
            int line = 1;   // Variabel för line.
            int wall = 1;   // Variabel för wall.

            for (int y = 1; y <= size; y++) // Loop för att skapa en rad i y-led.
            {
                for (int x = 1; x <= size; x++) // Loop för att skapa en rad i x-led.
                {
                    if (line == y)  // Om line är samma som y.
                    {
                        if (size == x)  // Om size är samma som x.
                        {
                            Console.Write("X\n");  // Skriver ut X med radbyte.
                            line += 4;   // Hoppar 4 steg.
                        }
                        else
                        {
                            Console.Write("X");  // Annars skriver den ut X.
                        }
                    }
                    else
                    {
                        if (wall == x)  // Om väggen är samma som x.
                        {
                            if (size == x)   // Om Size är samma som x.
                            {
                                Console.Write("X\n");
                                wall = 1;  // Sätter om väggen till 1.
                            }
                            else
                            {
                                Console.Write("X");
                                wall += 4;    // Annars skriver den ut X vart fjärde steg.
                            }
                        }
                        else
                        {
                            Console.Write(" "); // Annars skriver den ut ett mellanrum.
                        }
                    }

                }

            }
        }
        #endregion
        #region Uppgift 3 metoder

        static double meterToYard(double a) // Metod för att kovertera meter till yard.
        {
            return Math.Round(a * 1.0936, 2); // Returnerar konverteringen, avrundat.
        }

        static double kiloToPound(double a) // Kilo till pound.
        {
            return Math.Round(a * 2.20462262, 2);
        }

        static double celsiusToFahrenheit(double a) // Celsius till fahrenheit.
        {
            return Math.Round((a * 1.8) + 32, 2);
        }

        static double kiloWattToHorsePower(double a) // Kilowatt till hästkrafter.
        {
            return Math.Round(a * 1.34102209, 2);
        }

        #endregion
    }
}
