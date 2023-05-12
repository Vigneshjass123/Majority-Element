using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majority_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input: nums = [2,2,1,1,1,2,2]
            //Output: 2

            int[] arr = { 2, 2, 1, 1, 1, 2, 2, };
            int temp = 0;
            int temp1 = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if (i == 2)
                {
                    temp++;

                    if (i == 1)
                    {
                        temp1++;


                    }
                            if (temp == temp1)
                            {
                                Console.WriteLine(" Majority element is = " + i);
                            }
                            else
                            {
                                Console.Write(" Majority Element is = " + i);
                            }
                             Console.ReadLine();
                        }

                    }
                }
            }
        }
    






    

    

