using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int numRolls;
            int possibleRolls = 12;


            //get user input
            Console.Write("Enter the number of dice rolls: ");
            numRolls = Convert.ToInt32(Console.ReadLine());

            //program explenation 
            Console.WriteLine();
            Console.WriteLine("Results:");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls: " + numRolls);
            Console.WriteLine();


            //generate Random dice rolls and add too array
            int[] num = new int[numRolls];
            Random rnd = new Random();
 
            for (int j = 0; j < numRolls; j++)
            {

                int die1 = rnd.Next(1, 7);
                int die2 = rnd.Next(1, 7);
                int total = die1 + die2;
                num[j] = total;

            }

            //count the number of occurances in array for each possible roll
            float count = 0;
            for (int j = 2; j <= possibleRolls; j++)
            {
                for (int i = 0; i < numRolls; i++)
                {
                    if (j == num[i])
                        count = count + 1;
                }

                //calucate percentage each number occurs 
                float percent = Convert.ToInt32(Math.Floor((count / numRolls) * 100));
                count = 0;

                //output results 
                Console.Write(j + ": ");
                for (int k = 0; k < percent; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            

       
        }
    }
}
