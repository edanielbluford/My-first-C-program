using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Part One: Greenting Statement
            //string messageOne = "Hello World!";
            string messageTwo = "I am Sparticus";

            ////Part: One: Set initial sparticus attributes
            //int ageOne = 35;
            //int ageTwo = 45;
            //int ageThree = 80;
            //double heightOne = 72.50;
            //double heightTwo = 91.45;
            //float weightOne = 210.0284606f;
            //float weightTwo = 331.12345678f;
            //bool isGodLikeOne = true;
            //bool isGodLikeTwo = false;
            //char genderMale = 'M';
            //char genderFemale = 'F';

            ////Part Three: Display Variable Values
            //Console.WriteLine(messageOne);
            //Console.WriteLine(messageTwo);

            //// Part four: Mathmatical Operator, bool and char examples 
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(isGodLikeOne);
            //Console.WriteLine(genderMale);  

            ////Part Five: Variable Reassignment
            //ageTwo = 70;
            //heightTwo = 35.12345f;
            //weightTwo = -429.1234573f;

            ////Part six: Math Operater examples
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);

            ////Part 7: Increment and Decrement operator Examples
            //ageTwo = ageTwo + 1;
            //Console.WriteLine(ageTwo);
            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);




            //int full = 7;
            //int cups_remaining = full - 2;
            //Console.Write("Cups Remaining: ");
            //Console.WriteLine(cups_remaining);

            //int friends = 4;
            //int billTotal = 52;
            //int seperateChecks = billTotal / friends;
            //Console.Write("Bill Total: ");
            //Console.WriteLine(billTotal);
            //Console.Write("Bill Split: ");
            //Console.WriteLine(seperateChecks);

            ////Part eight concatenation example
            //Console.WriteLine(messageOne + " " + messageTwo + ".");
            //Console.WriteLine("I am " + ageOne + " years old and it is " + isGodLikeOne + " that I am God Like.");
            //Console.WriteLine("I weigh around " + weightOne + " pounds, and I am around " + heightOne + " inches tall.");
            //Console.WriteLine("My father is {0} years old, and it is {1} that he is a god.", ageThree, isGodLikeOne);
            //Console.WriteLine("I am {0} years old and it is {1} that I am God Like.", ageOne, isGodLikeOne);
            //Console.WriteLine("I weigh around {0} pounds and I am around {1} inches tall.", weightOne, heightOne);
            ////Part nine string equality examples These return boolean values

            //Console.WriteLine(messageTwo.Equals(messageOne));

            //Console.WriteLine(messageTwo.Equals("I am a Planeswalker"));
            // Part ten string length examples
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;

            //Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is " + messOneLength);
            //Console.WriteLine("The length of messageTwo is " + messTwoLength);



            //Console.WriteLine("Enter a color, please.");
            //string response = Console.ReadLine();

            //if (response.ToLower().Equals("red"))
            //{
            //    Console.WriteLine("Roses can be red. Also, lillies.");
            //}



            ////Part 11 Conditionla examples
            //string cityOne = "Vesuveiuvs";
            //string cityTwo = "Nola";
            //string cityThree = "Nuceria";
            //int cityOneDistance, cityTwoDistance, cityThreeDistance;

            ////Solicit user input
            //Console.WriteLine("What is the distance to{0}?", cityOne);
            //cityOneDistance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to" + cityTwo + "?");
            //cityTwoDistance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to Nuceria?");
            //cityThreeDistance = int.Parse(Console.ReadLine());

            //if ((cityOneDistance <= 125) && ((cityOneDistance < cityTwoDistance) && (cityOneDistance < cityThreeDistance)))
            //{
            //    Console.WriteLine("We will march to {0}", cityOne);
            //}
            //if ((cityTwoDistance <= 125) && ((cityTwoDistance < cityOneDistance) && (cityTwoDistance < cityThreeDistance)))
            //{
            //    Console.WriteLine("We will march to " + cityTwo);
            //}
            //if ((cityThreeDistance <= 125) && ((cityThreeDistance < cityOneDistance) && (cityThreeDistance < cityTwoDistance)))
            //{
            //    Console.WriteLine("We will march to {0}", cityThree);
            //}


            //Console.WriteLine("What is your rank soldier?");
            //string rank = Console.ReadLine().ToLower();

            //Console.WriteLine("What is your age soldier?");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("What is your job soldier?");
            //string job = Console.ReadLine().ToLower();

            //if ((rank == "officer") || (age <= 26))
            //{
            //    Console.WriteLine("Get your gear, kiss your family goodbye put on your marching boots.");
            //}
            //else if ((job == "cook") && (age >= 26))
            //{
            //    Console.WriteLine("My army has to eat. Pack your pots and pans.");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, you are staying home.");
            //}


            //switch (job)
            //{
            //    case "infantry":
            //        Console.WriteLine("You will carry a sword.");
            //        break;

            //    case "archer":
            //        Console.WriteLine("You will carry a bow and arrow.");
            //        break;

            //    case "supply":
            //        Console.WriteLine("You will carry pots and pans.");
            //        break;

            //    case "specialist":
            //        Console.WriteLine("You will operate the catapult.");
            //        break;

            //    default:
            //        Console.WriteLine("You will ride horseback.");
            //        break;
            //}

            //Console.WriteLine("What is the total of your bill today?");
            //int totalBill = int.Parse(Console.ReadLine());

            //Console.WriteLine("How many ways would you like to split this?");
            //int numberOfPeople = int.Parse(Console.ReadLine());

            //if ((numberOfPeople <1))
            //{
            //    Console.WriteLine("Thank you for eating with us, your total today is {0}.", totalBill);
            //}
            //else if ((numberOfPeople >1))
            //{
            //    Console.WriteLine("Thank your share of today's bill is " + totalBill / numberOfPeople);
            //}
            //else
            //{


            //string[] foodItems = new string[5];


            // Part thirteen while loop example

            //string action = " "; //Do While Loop example
            //do
            //{
            //    Console.WriteLine("What is your rank soldier?");
            //    string rank = Console.ReadLine();

            //    Console.WriteLine("What is your age soldier?");
            //    int age = int.Parse(Console.ReadLine());

            //    Console.WriteLine("What is your job soldier?");
            //    string job = Console.ReadLine();



            //    if ((rank == "officer") || (age <= 26))
            //    {
            //        Console.WriteLine("Get your gear, kiss your family goodbye,put on your marching boots.");
            //    }
            //    else if ((job == "cook") || (age >= 26))
            //    {
            //        Console.WriteLine("My army has to eat. Pack your pots and pans");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, you are staying home.");
            //    }
            //    Console.WriteLine("Add another? Type exit to quit");
            //    action = Console.ReadLine().ToLower();
            //} while (action != "exit");

            string[] elements = messageTwo.Split(' ');
            Console.WriteLine(elements[0]); // prints "I"
            Console.WriteLine(elements[1]); // prints "am"
            Console.WriteLine(elements[2]); // prints "Spartacus"


            string action = " ";
            while (action != "exit") // while loop
            {
                Console.WriteLine("What is your rank soldier?");
                string rank = Console.ReadLine();

                Console.WriteLine("What is your age soldier?");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("What is your job soldier?");
                string job = Console.ReadLine();



                if ((rank == "officer") || (age <= 26))
                {
                    Console.WriteLine("Get your gear, kiss your family goodbye,put on your marching boots.");
                }
                else if ((job == "cook") || (age >= 26))
                {
                    Console.WriteLine("My army has to eat. Pack your pots and pans");
                }
                else
                {
                    Console.WriteLine("Sorry, you are staying home.");
                }
                Console.WriteLine("Add another? Type exit to quit");
                action = Console.ReadLine().ToLower();
            }

            int[] foodAmount = new int[] { 1000, 1000, 2000, 10000, 1500 };
            Console.WriteLine(foodAmount[0] + ", " + foodAmount[1] + ", " +
                foodAmount[2] + ", " + foodAmount[3] + ", " + foodAmount[4]);

            List<string> foodList = new List<string>();
            foodList.Add("Milk");
            foodList.Add("Fruit");
            foodList.Add("Meat");
            foodList.Add("Wine");
            foodList.Add("Bread");

            ////Part fourteen for-loop examples
            //for (int i = 0; i < foodAmount.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 0; i < foodAmount.Length; i++)
            {
                Console.WriteLine("Enter a value for " + foodList[i]);
                foodAmount[i] = int.Parse(Console.ReadLine());
            }
        }
        }
        }
    

