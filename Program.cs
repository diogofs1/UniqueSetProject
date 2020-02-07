using System;
using System.Collections.Generic;

namespace UniqueSetProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int setSize, item;
            List<int> uniqueSet = new List<int>();

            setSize = Convert.ToInt32(Console.ReadLine());


            if (!setSizeIsValid(setSize))
                return;

            for (int i = 0; i < setSize; i++)
            {
                item = Convert.ToInt32(Console.ReadLine());

                if (itemIsValid(item) && itemIsUnique(item, uniqueSet))
                {
                    uniqueSet.Add(item);
                }
            }

            uniqueSet.Sort();

            for (int i = 0; i < uniqueSet.Count; i++)
            {
                Console.WriteLine(uniqueSet[i]);
            }
        }

        static private bool setSizeIsValid(int setSize)
        {
            const int minSetSize = 1;
            const int maxSetSize = 1000;

            if (setSize < minSetSize || setSize > maxSetSize)
                return false;

            return true;
        }

        static private bool itemIsValid(int item)
        {
            const int minValueItem = -1000;
            const int maxValueItem = 1000;

            if (item < minValueItem || item > maxValueItem)
                return false;

            return true;
        }

        static private bool itemIsUnique(int item, List<int> uniqueSet)
        {
            if (uniqueSet.Contains(item))
                return false;

            return true;
        }
    }
}
