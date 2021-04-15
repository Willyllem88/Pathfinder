using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of X cages: ");
            int Xcages = int.Parse(Console.ReadLine());
            Console.Write("Number of Y cages: ");
            int Ycages = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Options:");
            Console.WriteLine("   (0): void.");
            Console.WriteLine("   (1): wall.");
            Console.WriteLine("   (A): start point.");
            Console.WriteLine("   (B): final point.");
            Console.WriteLine();
            Console.WriteLine();

            string[] nums = new string[Xcages]; //Array

            bool Asetted = false;
            bool Bsetted = false;

            for (int count = 0; count < Xcages; count++)
            {

                Console.Write("Write the valor in the X axis: " + count + ". ");
                nums[count] = (Console.ReadLine());


                if (!(nums[count] == $"0" || nums[count] == $"1"))
                {
                    if ((nums[count] == $"A" || nums[count] == $"B") && (Asetted == false || Bsetted == false))
                    {
                        if (nums[count] == $"A") { Asetted = true; }
                        if (nums[count] == $"B") { Bsetted = true; }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Write: (0), (1), (A), (B),"); //Acabar de posar que usuari introdueixi input corregit
                    }
                }
                while (Asetted == true) //Corregir
                {
                    Console.WriteLine("Invalid input!");

                    if (Bsetted == false)
                    {
                        Console.Write("Press: (0), (1) or (B)");
                        nums[count] = (Console.ReadLine());
                        if (!(nums[count] == "A")) { Asetted = false; }
                    }
                    else
                    {
                        Console.Write("Press: (0) or (1)");
                        nums[count] = (Console.ReadLine());
                        if (!(nums[count] == "A")) { Asetted = false; }
                    }
                }
                while (Bsetted == true)
                {
                    if (Asetted == false)
                    {
                        Console.Write("Press: (0), (1) or (A)");
                        nums[count] = (Console.ReadLine());
                        if (!(nums[count] == "B")) { Bsetted = false; }
                    }
                    else
                    {
                        Console.Write("Press: (0) or (1)");
                        nums[count] = (Console.ReadLine());
                        if (!(nums[count] == "B")) { Bsetted = false; }
                    }
                }
            }

            for (int count = 0; count < Xcages; count++)
            {
                Console.Write(nums[count]);
                Console.Write(" ");
            }

            Console.ReadLine();
        }
    }
}
