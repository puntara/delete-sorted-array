using System;

namespace deleteDuplicate
{
    class Program
    {
        public static int deleteDuplicate(int[] arr)
        {
            int Array = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr[Array])
                {
                    Array++;
                    arr[Array] = arr[i];
                }
            }
            return Array +1;
        }
        static void Main(string[] args)
        {
            int[] numArray = { 1, 1, 1, 2, 2, 2, 3, 4, 5, 5, 5, 5, 5, 6 };

            int x = deleteDuplicate(numArray);
            for(int i = 0; i < x; i++)
            {
                Console.Write(numArray[i] + " ");
            }
         
        }
    }
}
