using System;
using System.Collections;
using System.Collections.Generic;

namespace CodeFifteen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(RemoveIllegalCars("0111010"));
        }

        static int RemoveIllegalCars(string binary)
        {
            char illegal = '1';
            char legal = '0';
            char[] illegalCars = binary.ToCharArray();
            int counter = 0;
            for (int i = 0; i < illegalCars.Length; i++)
            {
                if (binary.Contains(illegal))
                {
                    if (i == 0)
                    {
                        if (illegal == illegalCars[i])
                        {
                            counter++;
                        }
                        else if (illegal != illegalCars[i])
                        {
                            continue;
                        }
                    }
                    else if (illegal == illegalCars[i - 1] && illegal == illegalCars[i])
                    {
                        counter++;
                    }
                    else if (illegalCars[i - 1] == legal && illegal == illegalCars[i] && i != illegalCars.Length - 1)
                    {
                        counter += 2;
                    }
                    else if (illegalCars[i - 1] == legal && illegal == illegalCars[i] && i != illegalCars.Length - 1)
                    {
                        counter += 2;
                    }
                    else if (illegal == illegalCars[i] && i == illegalCars.Length - 1)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
     
    }
}
