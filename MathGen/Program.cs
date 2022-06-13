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
            string version = "v0.9.1";

            Console.Title = "MathGen " + version;

            Console.SetWindowSize(80, 22);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Random rnd = new Random();

            string Reset = "\x1B[0m";
            string Dim = "\x1b[2m";
            string Cursive = "\x1B[3m";
            string Underscore = "\x1b[4m";

            /*  EMPTY VALUES */

            int min = 0;
            int max = 0;
            int divisorMin = 0;
            int divisorMax = 0;
            int pow = 0;
            int correctCounter = 0;
            int rangeAnswer = 0;
            int problemCounter = 0;
            int divisorUniversal = 0;
            int problemNegative = 0;
            int invalidDiv = 0;
            int quit = 0;
            /*  SPACES + PREMADE CW's */     //if it ain't obvious, the number in the name of the string is how many spaces are there, duhh

            string enterChoice = "Enter Your Choice : ";
            string dash10 = "----------";
            string headerEquals = "==============================================================================="; // 79× = 
            string space14 = "            ";
            string space18 = "                 ";
            string space20 = "                    ";
            string space21 = "                     ";
            string space22 = "                      ";
            string space23 = "                       ";
            string space24 = "                        ";
            string space25 = "                         ";
            string space26 = "                          ";
            string space27 = "                           ";
            string space28 = "                            ";
            string space29 = "                             ";
            string space30 = "                              ";

        /*  SELECT TYPE OF MATH PROBLEM  */
        Menu:

            Thread.Sleep(80);
            Console.WriteLine(headerEquals);
            Thread.Sleep(80);
            Console.WriteLine("{0}MathGen {1} - Main Menu", space26, version);
            Thread.Sleep(80);
            Console.WriteLine(headerEquals);
            /* <3 */
            quit = 0;

            Console.WriteLine("{0}Please choose type of math problem\n", space22);
            Console.WriteLine("{0}[1]   Addition\n", space29);
            Console.WriteLine("{0}[2]   Subtraction\n", space29);
            Console.WriteLine("{0}[3]   Multiplication\n", space29);
            Console.WriteLine("{0}[4]   Division\n", space29);
            Console.WriteLine("{0}[5]   Power\n", space29);
            Console.WriteLine("\n{0}[9]   Quit\n", space29);     //could perharps add 8 as settings
            Console.WriteLine(headerEquals);
            Thread.Sleep(80);
            Console.Write(enterChoice);

            int operations = Convert.ToInt32(Console.ReadLine());
            if (operations >= 6 && operations <= 8)
            {
                Console.Clear();
                goto Menu;
            }
            else if (operations >= 10)
            {
                Console.Clear();
                goto Menu;
            }

            if (operations == 9)
            {
                Console.Clear();
                quit++;
                goto Quit;
            }
            Console.Clear();

        /* clearing console field for new set on information 
         * math problems may be selected by typing corresponding numbers in console after being asked (if ">" symbol is shown, application waits for users input), other number values will not accepted and will result in moving user to the :End 
         */

        /*  NUMBER RANGE  */

        Range:

            if (operations >= 1 || operations <= 5)
            {

                Thread.Sleep(80);
                Console.WriteLine(headerEquals);
                Thread.Sleep(80);
                Console.WriteLine("{0}MathGen {1} - Number Range", space25, version);
                Thread.Sleep(80);
                Console.WriteLine(headerEquals);


                Console.WriteLine("{0}Please choose number range or enter custom one\n", space18);
                Console.WriteLine("{0}[1]   1 - 10\n", space28);
                Console.WriteLine("{0}[2]   1 - 25\n", space28);
                Console.WriteLine("{0}[3]   1 - 50\n", space28);
                Console.WriteLine("{0}[4]   1 - 100\n", space28);
                Console.WriteLine("{0}[6]   Custom range\n", space28);
                Console.WriteLine("\n{0}[9]   Back to Main Menu\n", space28);
                Console.WriteLine(headerEquals);
                Thread.Sleep(80);
                Console.Write(enterChoice);
                int numbers = Convert.ToInt32(Console.ReadLine());


                switch (numbers)
                {
                    case 1:
                        min = 1;
                        max = 11;
                        break;

                    case 2:
                        min = 1;
                        max = 26;
                        break;

                    case 3:
                        min = 1;
                        max = 51;
                        break;

                    case 4:
                        min = 1;
                        max = 101;
                        break;

                    case 6:
                        Console.WriteLine(headerEquals + "\n");
                        Console.Write("Please, enter the smallest number\n");
                        Console.Write(enterChoice);
                        int tempMin = Convert.ToInt32(Console.ReadLine());
                        min = tempMin;

                        Console.WriteLine();
                        Console.Write("Please, enter the biggest number\n");
                        Console.Write(enterChoice);
                        int tempMax = Convert.ToInt32(Console.ReadLine());
                        max = tempMax + 1;

                    RangeAnswer1:

                        Console.Clear();
                        Thread.Sleep(80);
                        Console.WriteLine(headerEquals);
                        Thread.Sleep(80);
                        Console.WriteLine("{0}MathGen {1} - Confirmation", space24, version);
                        Thread.Sleep(80);
                        Console.WriteLine(headerEquals);



                        if (rangeAnswer == 0)
                        {
                            Console.WriteLine("{0} Are you sure you want range {1} - {2}? \n", space21, min, tempMax);
                        }
                        else
                        {
                            rangeAnswer = 0;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("{0} Are you sure you want range {1} - {2}? \n", space21, min, tempMax);

                        }

                        Console.WriteLine("{0}[1]   Yes, I want this range\n", space18);
                        Console.WriteLine("{0}[2]   No, I want to choose different range\n", space18);
                        Console.WriteLine(headerEquals);
                        Thread.Sleep(80);
                        Console.Write(enterChoice);
                        int answerSure = Convert.ToInt32(Console.ReadLine());

                        if (answerSure == 1)
                        {
                        }
                        else if (answerSure == 2)
                        {
                            Console.Clear();
                            min = 0;
                            max = 0;
                            goto Range;
                        }
                        else
                        {
                            Console.Clear();
                            rangeAnswer++;
                            goto RangeAnswer1;
                        }
                        break;

                    case 9:
                        Console.Clear();
                        goto Menu;

                    default:
                        Console.Clear();
                        goto Range;
                }
            }

        RangeDiv:

            if (operations == 4)
            {

                int attemptDisabled = 0;
                int disableCustomDiv = 0;
            PickDiv:
                if (invalidDiv == 2)
                {
                    invalidDiv = 0;
                    int disableCustomDivIf = 1;
                    disableCustomDiv = disableCustomDivIf;

                }

                Console.Clear();

                Thread.Sleep(80);
                Console.WriteLine(headerEquals);
                Thread.Sleep(80);
                Console.WriteLine("{0}MathGen {1} - Number Range", space24, version);
                Thread.Sleep(80);
                Console.WriteLine(headerEquals);

                if (attemptDisabled == 1)
                {
                    Console.WriteLine("{0}Custom Range is disabled, due to picking only from premade divisors.{1}", Cursive, Reset);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                }


                if (disableCustomDiv == 1)
                {
                    Console.Write("{0}Please choose largest divisor", space25);
                }
                else if (disableCustomDiv == 0)
                {
                    Console.Write("{0}Please choose largest divisor or enter a custom one", space14);
                }
                Console.WriteLine("\n\n{0}[1]   1 - 2\n", space30);
                Console.WriteLine("{0}[2]   1 - 5\n", space30);
                Console.WriteLine("{0}[3]   1 - 10\n", space30);
                Console.WriteLine("{0}[4]   1 - 20\n", space30);
                if (disableCustomDiv == 1)
                {
                    Console.WriteLine("{0}{1}[6]   Custom range{2}\n", space30, Dim, Reset);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (disableCustomDiv == 0)
                {
                    Console.WriteLine("{0}[6]   Custom range\n", space30);
                }
                Console.WriteLine("\n{0}[9]   Back to Main Menu\n", space30);
                Console.WriteLine(headerEquals);
                Thread.Sleep(80);
                Console.Write(enterChoice);
                byte numbersDiv = Convert.ToByte(Console.ReadLine());

                switch (numbersDiv)
                {
                    case 1:
                        divisorMin = 1;
                        divisorMax = 3;
                        break;

                    case 2:
                        divisorMin = 1;
                        divisorMax = 6;
                        break;

                    case 3:
                        divisorMin = 1;
                        divisorMax = 11;
                        break;

                    case 4:
                        divisorMin = 1;
                        divisorMax = 21;
                        break;

                    case 6:
                        if (disableCustomDiv == 1)
                        {
                            attemptDisabled = 1;
                            goto PickDiv;
                        }
                        else if (disableCustomDiv == 0)
                        {

                        EditDiv:
                            if (invalidDiv == 1)
                            {
                                invalidDiv = 0;

                                Console.Clear();

                                Thread.Sleep(80);
                                Console.WriteLine(headerEquals);
                                Thread.Sleep(80);
                                Console.WriteLine("{0}MathGen {1} - Edit Divisor", space24, version);
                                Thread.Sleep(80);
                            }
                            Console.WriteLine(headerEquals + "\n");
                            Console.Write(" Please, enter the smallest divisor\n");
                            Console.Write(enterChoice);
                            int divisorTempMin = Convert.ToInt32(Console.ReadLine());
                            divisorMin = divisorTempMin;

                            Console.WriteLine();
                            Console.Write(" Please, enter the largest divisor\n");
                            Console.Write(enterChoice);
                            int divisorTempMax = Convert.ToInt32(Console.ReadLine());
                            divisorMax = divisorTempMax + 1;

                            if (divisorMax == 1 || divisorMin == 0)
                            {
                                Console.Clear();

                                Thread.Sleep(80);
                                Console.WriteLine(headerEquals);
                                Thread.Sleep(80);
                                Console.WriteLine("{0}MathGen {1} - Invalid Divisor", space23, version);
                                Thread.Sleep(80);
                                Console.WriteLine(headerEquals);

                                if (divisorMax > divisorMin)
                                {
                                    divisorUniversal = divisorMin;
                                }
                                else if (divisorMax < divisorMin)
                                {
                                    divisorUniversal = divisorMax;
                                }

                                Console.WriteLine("\n You entered divisor as 0. Since you can't count with divisor as 0 or lower,\n would you like to:\n", divisorUniversal);
                                Console.WriteLine("\n{0}[1]   Edit divisors\n", space25);
                                Console.WriteLine("{0}[2]   Pick from premade ones\n", space25);
                                Console.WriteLine(headerEquals);
                                Thread.Sleep(80);
                                Console.Write(enterChoice);
                                invalidDiv = Convert.ToByte(Console.ReadLine());

                                if (invalidDiv == 1)
                                {
                                    goto EditDiv;
                                }
                                else if (invalidDiv == 2)
                                {
                                    goto PickDiv;
                                }
                            }
                        RangeAnswer2:

                            Console.Clear();
                            Thread.Sleep(80);
                            Console.WriteLine(headerEquals);
                            Thread.Sleep(80);
                            Console.WriteLine("{0}MathGen {1} - Confirmation", space24, version);
                            Thread.Sleep(80);
                            Console.WriteLine(headerEquals);

                            Console.WriteLine("{0} Are you sure you want range {1} - {2}? \n", space21, divisorMin, divisorTempMax);
                            Console.WriteLine("{0}[1]   Yes, I want this range\n", space18);
                            Console.WriteLine("{0}[2]   No, I want to choose different range\n", space18);
                            Console.WriteLine(headerEquals);
                            Thread.Sleep(80);
                            Console.Write(enterChoice);
                            int answerSure = Convert.ToInt32(Console.ReadLine());

                            if (answerSure == 1)
                            {
                            }
                            else if (answerSure == 2)
                            {
                                Console.Clear();
                                min = 0;
                                max = 0;
                                goto RangeDiv;
                            }
                            else
                            {
                                Console.Clear();
                                rangeAnswer++;
                                goto RangeAnswer2;
                            }

                        }
                        break;


                    case 9:
                        Console.Clear();
                        goto Menu;

                    default:
                        Console.Clear();
                        goto RangeDiv;
                }
            }

        RangePow:

            if (operations == 5)
            {
                Console.Clear();

                Thread.Sleep(80);
                Console.WriteLine(headerEquals);
                Thread.Sleep(80);
                Console.WriteLine("{0}MathGen {1} - Number Range", space25, version);
                Thread.Sleep(80);
                Console.WriteLine(headerEquals);


                Console.WriteLine("{0}Please choose number range or enter custom one\n", space18);
                Console.WriteLine("{0}[1]   ^2\n", space30);
                Console.WriteLine("{0}[2]   ^3\n", space30);
                Console.WriteLine("{0}[3]   ^5\n", space30);
                Console.WriteLine("{0}[4]   ^10\n", space30);
                Console.WriteLine("{0}[6]   Custom range\n", space30);
                Console.WriteLine("\n{0}[9]   Back to Main Menu\n", space30);
                Console.WriteLine(headerEquals);
                Thread.Sleep(80);
                Console.Write(enterChoice);
                byte numbersPow = Convert.ToByte(Console.ReadLine());

                switch (numbersPow)
                {
                    case 1:
                        pow = 2;
                        break;

                    case 2:
                        pow = 3;
                        break;

                    case 3:
                        pow = 5;
                        break;

                    case 4:
                        pow = 10;
                        break;

                    case 6:
                        Console.WriteLine();
                        Console.Write("Please, enter the power number\n");
                        Console.Write(enterChoice);
                        int tempPow = Convert.ToInt32(Console.ReadLine());
                        pow = tempPow + 1;

                    RangeAnswer3:

                        Console.Clear();
                        Thread.Sleep(80);
                        Console.WriteLine(headerEquals);
                        Thread.Sleep(80);
                        Console.WriteLine("{0}MathGen {1} - Confirmation", space24, version);
                        Thread.Sleep(80);
                        Console.WriteLine(headerEquals);

                        Console.WriteLine("{0} Are you sure you want power of {1}? \n", space22, tempPow);
                        Console.WriteLine("{0}[1]   Yes, I want power of {1}\n", space18, tempPow);
                        Console.WriteLine("{0}[2]   No, I want to choose different power\n", space18);
                        Console.WriteLine(headerEquals);
                        Thread.Sleep(80);
                        Console.Write(enterChoice + "^");
                        int answerSure = Convert.ToInt32(Console.ReadLine());

                        if (answerSure == 1)
                        {
                        }
                        else if (answerSure == 2)
                        {
                            Console.Clear();
                            min = 0;
                            max = 0;
                            goto RangePow;
                        }
                        else
                        {
                            Console.Clear();
                            rangeAnswer++;
                            goto RangeAnswer3;
                        }
                        break;

                    case 9:
                        Console.Clear();
                        goto Menu;

                    default:
                        Console.Clear();
                        goto RangePow;
                }
            }


        /*  PROBLEM COUNTER  */

        ProblemCounter:

            Console.Clear();

            Thread.Sleep(80);
            Console.WriteLine(headerEquals);
            Thread.Sleep(80);
            Console.WriteLine("{0}MathGen {1} - Execrise", space26, version);
            Thread.Sleep(80);
            Console.WriteLine(headerEquals);

            if (problemNegative == 1)
            {
                Console.WriteLine(" You can't set {0} problems. You need to enter number bigger than 0.", problemCounter);
                problemNegative = 0;
            }
            Console.WriteLine("{0}How many problems do you want to solve?\n", space20);
            Console.WriteLine("{0}[1]   3\n", space30);
            Console.WriteLine("{0}[2]   5\n", space30);
            Console.WriteLine("{0}[3]   10\n", space30);
            Console.WriteLine("{0}[4]   20\n", space30);
            Console.WriteLine("{0}[6]   Custom amount\n", space30);
            Console.WriteLine("\n{0}[9]   Back to Main Menu\n", space30);
            Console.WriteLine(headerEquals);
            Thread.Sleep(80);

            Console.Write(enterChoice);
            int problemChoose = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (problemChoose)
            {
                case 1:
                    problemCounter = 3;
                    break;

                case 2:
                    problemCounter = 5;
                    break;

                case 3:
                    problemCounter = 10;
                    break;

                case 4:
                    problemCounter = 20;
                    break;

                case 6:
                    Console.WriteLine(headerEquals + "\n");
                    Console.Write("Please, enter how many problems you want to solve\n");
                    Console.Write(enterChoice);
                    problemCounter = Convert.ToInt32(Console.ReadLine());


                ProblemAnswer1:

                    Console.Clear();
                    Thread.Sleep(80);
                    Console.WriteLine(headerEquals);
                    Thread.Sleep(80);
                    Console.WriteLine("{0}MathGen {1} - Confirmation", space25, version);
                    Thread.Sleep(80);
                    Console.WriteLine(headerEquals);

                    if (problemCounter == 1)
                    {
                        Console.WriteLine("{0} Are you sure you want to count {1} problem? \n", space21, problemCounter);

                    }
                    else if (problemCounter <= 0)
                    {
                        problemNegative = 1;
                        goto ProblemCounter;
                    }
                    else
                    {
                        Console.WriteLine("{0} Are you sure you want to count {1} problems? \n", space21, problemCounter);
                    }

                    if (problemCounter == 1)
                    {
                        Console.WriteLine("{0}[1]   Yes, I want to solve {1} problem\n", space20, problemCounter);

                    }
                    else
                    {
                        Console.WriteLine("{0}[1]   Yes, I want to solve {1} problems\n", space20, problemCounter);
                    }
                    
                    Console.WriteLine("{0}[2]   No, I want to change that number\n", space20);
                    Console.WriteLine(headerEquals);
                    Thread.Sleep(80);
                    Console.Write(enterChoice);
                    int answerSure = Convert.ToInt32(Console.ReadLine());

                    if (answerSure == 1)
                    {
                    }
                    else if (answerSure == 2)
                    {
                        Console.Clear();
                        min = 0;
                        max = 0;
                        goto ProblemCounter;
                    }
                    else
                    {
                        Console.Clear();
                        rangeAnswer++;
                        goto ProblemAnswer1;
                    }
                    break;

                case 9:
                    Console.Clear();
                    goto Menu;

                default:
                    Console.Clear();
                    goto ProblemCounter;
            }

            /* IT'S COUNTIN' TIME!!  (this doesn't have to do anything with It's morbin' time)*/

            Console.Clear();

            Thread.Sleep(80);
            Console.WriteLine(headerEquals);
            Thread.Sleep(80);
            Console.WriteLine("{0}MathGen {1} - Solving math problems", space20, version);
            Thread.Sleep(80);
            Console.WriteLine(headerEquals);
            Console.WriteLine(" Solve math problems just by typing answer after to equals symbol, like in\n math text book.");

            switch (operations)
            {
                case 1: /*   ADDITION   */
                    for (int i = 0; i < problemCounter; i++)
                    {
                        Console.WriteLine("\n {0}\n", dash10);
                        int num1 = rnd.Next(min, max);
                        int num2 = rnd.Next(min, max);
                        int answer = num1 + num2;
                        Console.Write(" {0} + {1} = ", num1, num2);
                        int usrAns = Convert.ToInt32(Console.ReadLine());
                        if (usrAns == answer)
                        {
                            correctCounter++;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" Correct!");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        else
                        {
                            Console.Write(" Correct answer was {0}{1}{2}{3}", Cursive, Underscore, answer, Reset);
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:/*   SUBTRACTION    */
                    for (int i = 0; i < problemCounter; i++)
                    {
                        Console.WriteLine("\n {0}\n", dash10);
                        int num1 = rnd.Next(min, max);
                        int num2 = rnd.Next(min, max);
                        int answer = num1 - num2;
                        Console.Write(" {0} - {1} = ", num1, num2);
                        int usrAns = Convert.ToInt32(Console.ReadLine());
                        if (usrAns == answer)
                        {
                            correctCounter++;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" Correct!");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        else
                        {
                            Console.Write(" Correct answer was {0}{1}{2}{3}", Cursive, Underscore, answer, Reset);
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.WriteLine();
                    }
                    break;


                case 3:/*   MULTIPLYING    */
                    for (int i = 0; i < problemCounter; i++)
                    {
                        Console.WriteLine("\n {0}\n", dash10);
                        int num1 = rnd.Next(min, max);
                        int num2 = rnd.Next(min, max);
                        int answer = num1 * num2;
                        Console.Write(" {0} × {1} = ", num1, num2);
                        int usrAns = Convert.ToInt32(Console.ReadLine());
                        if (usrAns == answer)
                        {
                            correctCounter++;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" Correct!");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        else
                        {
                            Console.Write(" Correct answer was {0}{1}{2}{3}", Cursive, Underscore, answer, Reset);
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.WriteLine();
                    }
                    break;

                case 4:/*   DIVIDING    */

                    if (divisorMin != 0 && divisorMax != 0)
                    {

                        for (int i = 0; i < problemCounter; i++)
                        {
                            Console.WriteLine("\n {0}\n", dash10);
                            double num1 = rnd.Next(min, max);
                            double div = rnd.Next(1, divisorMax);
                            double answer = num1 / div;
                            Console.Write(" {0} ÷ {1} = ", num1, div);
                            Console.WriteLine(answer);
                            answer = Math.Round(answer, 2, MidpointRounding.ToEven);
                            double usrAns = Convert.ToDouble(Console.ReadLine());
                            if (usrAns == answer)
                            {
                                correctCounter++;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(" Correct!");
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                            else
                            {
                                Console.Write(" Correct answer was {0}{1}{2}{3}", Cursive, Underscore, answer, Reset);
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.ForegroundColor = ConsoleColor.White;
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
                        Console.WriteLine("\n {0}\n", dash10);
                        min++;
                        int powNum = rnd.Next(min, max);
                        double answer = Math.Pow(powNum, pow);
                        Console.Write(" {0} ^{1} = ", powNum, pow);
                        double usrAns = Convert.ToInt32(Console.ReadLine());
                        if (usrAns == answer)
                        {
                            correctCounter++;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" Correct!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write(" Correct answer was {0}{1}{2}{3}", Cursive, Underscore, answer, Reset);
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
                    break;

                default:
                    {
                    }
                    break;
            }

            /*  SUCCESS RATE CALCULATION AND SAVING ALL DATA TO .TXT FILE  */

            int V = problemCounter;         //total number of math problems
            string selectedOperations = "Picked exercise: ";

            double successRate = (correctCounter * 100) / V;

            Console.Clear();
            Thread.Sleep(80);
            Console.WriteLine(headerEquals);
            Thread.Sleep(80);
            Console.WriteLine("{0}MathGen {1} - Results", space27, version);
            Thread.Sleep(80);
            Console.WriteLine(headerEquals);
            
            Console.WriteLine(" Your results are displayed right now under this text, as well they are going\n to be saved as .txt file (more info in README file)\n\n");
            Console.WriteLine(headerEquals);

            if (correctCounter == 1)
            {
                Console.WriteLine("\n You have {0} correct answer.\n", correctCounter);

            }
            else
            {
                Console.WriteLine("\n You have {0} correct answers.\n", correctCounter);
            }
            

            Console.WriteLine(" Math problems assigned: {0}", problemCounter);
            Console.WriteLine(" Correctly solved math problems: {0}", correctCounter);
            Console.WriteLine(" Success Rate: " + successRate + "%");
            Console.WriteLine("\n\n Press [Enter] to quit");

            // console typeout of results after motivation
            
            using (StreamWriter sw = new StreamWriter("results_export.txt", true))
            {

                sw.WriteLine(DateTime.Today.ToLongDateString() + " || " + DateTime.Now.ToLongTimeString());
                sw.WriteLine();
                sw.WriteLine("=-=-=-=-=-=-=-");
                if (operations == 1)
                {
                    sw.WriteLine(selectedOperations + "Additions");
                }
                else if (operations == 2)
                {
                    sw.WriteLine(selectedOperations + "Subtraction");
                }
                else if (operations == 3)
                {
                    sw.WriteLine(selectedOperations + "Multiplying");
                }
                else if (operations == 4)
                {
                    sw.WriteLine(selectedOperations + "Dividing");
                }
                else if (operations == 5)
                {
                    sw.WriteLine(selectedOperations + "Power of {0}", pow);
                }
                sw.WriteLine("=-=-=-=-=-=-=-");
                sw.WriteLine();
                if (correctCounter == 1)
                {
                    sw.WriteLine("\nYou have {0} correct answer.\n", correctCounter);

                }
                else
                {
                    sw.WriteLine("\nYou have {0} correct answers.\n", correctCounter);
                }


                sw.WriteLine("Math problems assigned: {0}\n", problemCounter);
                sw.WriteLine("Correctly counted math problems: {0}\n", correctCounter);
                sw.WriteLine("Success Rate: " + successRate + "%\n");

                // file is being saved in "\MathGen\MathGen\bin\Debug\data_save.txt"
                // the program prints out info about last session in a specific order: the date and time of finishing of the math problems, what operation user had, the number of entered and correctly calculated math problems and the user's success in % always rounded down to the nearest whole number

            }              

            Console.ReadLine();
        Quit:
            if (quit == 1)
            {
                Console.WriteLine(headerEquals);
                Thread.Sleep(75);
                Console.WriteLine("{0}MathGen {1} - Exit", space29, version);
                Thread.Sleep(75);
                Console.WriteLine(headerEquals);
                Thread.Sleep(75);
                Console.WriteLine("\n Press [Enter] to Quit...");
                Console.ReadLine();
            }

            // Programs Used: Visual Studio 2022 Professional | .NET FrameWork 6.0 / Turned in in .NET FrameWork 4.5
            // MathGen - v0.9.1 (22w23a) || OpenSource
            // https://beacons.ai/tsukichiwo; https://github.com/tsukichiwo/mathgen
        }
    }
}