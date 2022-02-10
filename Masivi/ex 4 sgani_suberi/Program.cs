using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4_sgani_suberi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowLeft = nums.Length / 4;
            int rowRight = nums.Length / 4;
            int rowMiddle = nums.Length / 2;

            int[] numsLeft = new int[rowLeft];
            int[] numsRight = new int[rowRight];
            int[] numsMiddle = new int[rowMiddle];

            for (int i = 0; i < numsLeft.Length; i++)
            {
                numsLeft[i] = nums[i];
            }

            for (int i = 0; i < numsMiddle.Length; i++)
            {
                numsMiddle[i] = nums[i+rowLeft];
            }
            for (int i = 0; i < numsRight.Length; i++)
            {
                numsRight[i] = nums[i+rowLeft+rowMiddle];
            }

            Array.Reverse(numsLeft);
            Array.Reverse(numsRight);
            int[] finalNums = new int[rowMiddle];

                for (int i = 0; i <rowMiddle; i++)
                {
                  if (i<rowLeft)
                  {
                    finalNums[i]= numsLeft[i] + numsMiddle[i];
                  }
                  if (i>rowLeft && i<rowMiddle)
                  {
                    finalNums[i] = numsLeft[i] + numsMiddle[i-(rowRight/2-1)]; 
                   }
                }

            Console.WriteLine(string.Join(" ", finalNums));
        }
    }
}
