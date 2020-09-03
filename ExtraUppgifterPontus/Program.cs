using System;
using System.Collections.Generic;
using System.Linq;
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
                    var number = ( i * j ).ToString();
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
            #region Övning 3-5

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
        }
        #region Uppgift 3 metoder

        /*static double meterToYard(double a) // Metod för att kovertera meter till yard.
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
        }*/

        #endregion
    }
}
