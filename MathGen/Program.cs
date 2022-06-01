using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ZaverecnaPrace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Generátor příkladů";   // Console app name

            Console.SetWindowSize(160, 40);
            Random rnd = new Random();
            
            /*  EMPTY VALUES */

            int powMax = 0;
            int min = 0;
            int max = 0;
            int divider = 2;
            int pow = 2;
            int correctCounter = 0;
            int mistake = 0;
            /*  SELECT OPERATION  */

            Console.Write("Zvolte prosím typ matematické operace u počítaných příkladů\n1) Součet // 2) Rozdíl // 3) Násobení // 4) Dělení // 5) Druhá Mocnina\n> ");
            byte operations = Convert.ToByte(Console.ReadLine());
            if (operations >= 6)
            {
                int mistakeIf = 1;
                mistake = mistakeIf;
                goto End;                              
            }

            // math operations may be selected by typing 1 to 5 in console after being asked, other number value will be accepted but after setup phase (to Ln 121) app will be terminated with warning message; "Ln 31"

            /*  NUMBER RANGE    */ 

            Console.WriteLine();            // Spacing

            if (operations == 5)
            {
                Console.WriteLine("Zvolte maximální rozsah mocniny a mocninu na kolikátou, které se budou generovat v příkladech.");

                Console.Write("Maximum mocniny\n");
                Console.Write("> ");
                int powMaxIf = Convert.ToInt32(Console.ReadLine());

                Console.Write("Mocnina na kolikátou\n");
                Console.Write("> ");
                int powIf = Convert.ToInt32(Console.ReadLine());

                powMax = powMaxIf;
                pow = powIf;
            }
            else
            {
                Console.WriteLine("Zvolte rozsah nejmenšího a největšího čísla, které bude generováno v příkladech.");

                if (operations == 4)
                {
                    Console.WriteLine("(Doporučení: nejměnší číslo v příkladu dejte větší než číslo v děliteli.)");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("!! Výsledné číslo zaokrouhlete ke nejbližšímu menšímu celému číslu. !!\n");
                    Console.ResetColor();
                }

                Console.Write("Nejmenší možné číslo\n");
                Console.Write("> ");
                int minIf = Convert.ToInt32(Console.ReadLine());

                Console.Write("Největší možné číslo\n");
                Console.Write("> ");
                int tempMax = Convert.ToInt32(Console.ReadLine());

                int maxIf = tempMax + 1;

                min = minIf;
                max = maxIf;

                if (operations == 4)
                {
                    Console.Write("Největší možný dělitel\n");
                    Console.Write("> ");
                    int dividerIf = Convert.ToInt32(Console.ReadLine());
                    
                    divider = dividerIf;
                }
            }

            // user enters numbers that will be used during making equasions
            // there are few special parameters to ensure nothing will go wrong
            // examples: option 5 has its own method of collecting numbers than others and option 4 has additional question - via Ln 87-95

            /*  PROBLEM COUNTER  */

            Console.Write("\nKolik příkladů chcete vypočítat?\n");
            Console.Write("> ");
            int problemCounter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (problemCounter == 1)
            {
                for (int wait = 0; wait == 3; wait++)
                {
                    Thread.Sleep(200);
                    Console.Write(".");
                }
                problemCounter++;
                Console.WriteLine("1 příklad je málo, zkus alespoň 2.\n");
            }

            // user enters how many math problem wants to solve
            // if user enter that they want to solve only one math problem, program automatically updates and informs user that they will be solving atleast two math problems

            /* IT'S COUNTING TIME!! */
            switch (operations)
            {
                case 1: /*   ADDITION   */
                    for (int i = 0; i < problemCounter; i++)
                    {
                        int num1 = rnd.Next(min, max);
                        int num2 = rnd.Next(min, max);
                        int answer = num1 + num2;
                        Console.Write("{0} + {1} = ", num1, num2);
                        int usrAns = Convert.ToInt32(Console.ReadLine());
                        if (usrAns == answer)
                        {
                            correctCounter++;
                        }
                        else
                        {
                            Console.WriteLine("Správná odpověď byla: {0}", answer);
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:/*   SUBTRACTION    */
                    for (int i = 0; i < problemCounter; i++)
                    {
                        int num1 = rnd.Next(min, max);
                        int num2 = rnd.Next(min, max);
                        int answer = num1 - num2;
                        Console.Write("{0} - {1} = ", num1, num2);
                        int usrAns = Convert.ToInt32(Console.ReadLine());
                        if (usrAns == answer)
                        {
                            correctCounter++;
                        }
                        else
                        {
                            Console.WriteLine("Správná odpověď byla: {0}", answer);
                        }
                        Console.WriteLine();
                    }
                    break;


                case 3:/*   MULTIPLYING    */
                    for (int i = 0; i < problemCounter; i++)
                    {
                        int num1 = rnd.Next(min, max);
                        int num2 = rnd.Next(min, max);
                        int answer = num1 * num2;
                        Console.Write("{0} × {1} = ", num1, num2);
                        int usrAns = Convert.ToInt32(Console.ReadLine());
                        if (usrAns == answer)
                        {
                            correctCounter++;
                        }
                        else
                        {
                            Console.WriteLine("Správná odpověď byla: {0}", answer);
                        }
                        Console.WriteLine();
                    }
                    break;

                case 4:/*   DIVIDING    */
                    
                    if (divider != 0) // nerovna se 0
                        {

                            for (int i = 0; i < problemCounter; i++)
                            {
                                int num1 = rnd.Next(min, max);
                                int div = rnd.Next(1, divider);
                                int answer = num1 / div;
                                Console.Write("{0} ÷ {1} = ", num1, div);
                                Console.WriteLine(answer);                             
                                int usrAns = Convert.ToInt32
                                (Console.ReadLine());
                                if (usrAns == answer)
                                    {
                                        correctCounter++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Správná odpověď byla: {0}", answer);
                                    }
                                    Console.WriteLine();
                            }
                    }
                    else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("NULOU DĚLIT NELZE!");
                        }
                    break;

                case 5:/*   POWER    */
                    for (int i = 0; i < problemCounter; i++)
                    {
                        min++;
                        int powNum = rnd.Next(min, powMax);
                        double answer = Math.Pow(powNum, pow);
                        Console.Write("{0} ^{1} = ", powNum, pow);
                        double usrAns = Convert.ToInt32(Console.ReadLine());
                        if (usrAns == answer)
                        {
                            correctCounter++;
                        }
                        else
                        {
                            Console.WriteLine("Správná odpověď byla: {0}", answer);
                        }
                        Console.WriteLine();
                    }
                    break;

                default:
                    {
                    }
                    break;
            }

            // user counts math problems that random generators make and will instantly solve to make sure that user didn't make single mistake
            // if user makes mistake program will say right answer and goes on; if not, then program will goes on
            // there are five possible math problems - addition, subtracktion, multiplication, division and power

            // at division, if user has set divider as 0, program will say "cannot divide by zero"


            /*  SUCCESS RATE CALCULATION AND SAVING ALL DATA TO .TXT FILE  */

            Console.Write("\nMáš {0} správné odpovědi.\n", correctCounter);

            int V = problemCounter;         //celkový počet příkladů
            int W = correctCounter;         //počet správných příkladů
            string selectedOperations = "Vybrané procvičování: ";

            double successRate = (W * 100) / V;

            using (StreamWriter sw = new StreamWriter("data_save.txt", true))
            {
                
                sw.WriteLine(DateTime.Today.ToLongDateString() + " || " + DateTime.Now.ToLongTimeString());
                sw.WriteLine("=-=-=-=-=-=-=-");
                if (operations == 1)
                {
                    sw.WriteLine(selectedOperations + "Sčítání");
                }
                else if (operations == 2)
                {
                    sw.WriteLine(selectedOperations + "Odčítání");
                }
                else if (operations == 3)
                {
                    sw.WriteLine(selectedOperations + "Násobení");
                }
                else if (operations == 4)
                {
                    sw.WriteLine(selectedOperations + "Dělení");

                    if (min == 0)
                    {
                        sw.WriteLine("Akce byla zrušena z důvodu dělení nulou!!");
                    }
                }
                else if (operations == 5)
                {
                    sw.WriteLine(selectedOperations + "Mocniny");
                }
                sw.WriteLine("=-=-=-=-=-=-=-");
                sw.WriteLine("Počet zadaných příkladů: " + V);
                sw.WriteLine("Počet správných příkladů: " + W);
                sw.WriteLine("Úspěšnost: " + successRate + "%");
                sw.WriteLine("\n");

            // file is being saved in "\Zaverecna_Prace_Drstak\ZaverecnaPrace\bin\Debug\zápis_výsledků.txt"
            // the program prints in a specific order: the date and time of finishing of the math problems, what operation user had, the number of entered and correctly calculated math problems and the user's success in % always rounded down to the nearest whole number

            }
                        
            if (successRate == 0)
            {
                Console.WriteLine("Bohužel jsi nezvládl ani jeden příklad správně. Neboj, zkus to znovu a třeba ti to půjde líp. ");
            }
            else if (successRate <= 20)
            {
                Console.WriteLine("Snaha se cení a opakování je matka moudrosti, zkus to ještě jednou a vylepši si skore.");
            }
            else if (successRate <= 40)
            {
                Console.WriteLine("Nemáš ani půlku správně, ale nevadí. Zkus si to ještě jednou.");
            }
            else if (successRate <= 60)
            {
                Console.WriteLine("Z většiny to máš správně. Jen tak dál.");
            }
            else if (successRate <= 80)
            {
                Console.WriteLine("Výborné, jsi blízko k dokonalosti.");
            }
            else if (successRate <= 99)
            {
                Console.WriteLine("Skvělé, dokonalost máš na dosah.");
            }
            else
            {
                if (problemCounter <= 4)
                {
                    Console.WriteLine("Gratuluji, sice máš 100% úspěšnost, ale myslím že " + V + " příklady moc není. Nechceš to zkusit ještě jednou s více příklady?");
                }
                else if (problemCounter >= 10)
                {
                    Console.WriteLine("Gratuluji, máš 100% úspěšnost a zvládl(a) jsi všech " + V + " příkladů. 🎉🎉");
                }
                else
                {
                    Console.WriteLine("Gratuluji, zvládl(a) jsi drobné procvičování o " + V + " příkladech s 100% úspěšností.");
                }
            }

            // program motivates user(or atleast it tries) to solving more math problems (Ln 302-340)
                     

            Console.WriteLine("Počet zadaných příkladů: " + V);
            Console.WriteLine("Počet správných příkladů: " + W);
            Console.WriteLine("Úspěšnost: " + successRate + "%");
            Console.WriteLine("");

            // console typeout of results atfer motivation

            End:
            if (mistake == 1)
            {
                Console.WriteLine("Nelze použít při výběru matematických operací hodnotu 6 nebo vyšší.");
            }

            Console.ReadLine();

            // SPŠS Betlémská, 1.I, Jakub Dršťák, VS2012 & VS2022
            // MathGen - v1.0 (22w21a) || OpenSource
        }
    }
}
