using System;

namespace HomeWork7
{
    internal class MyArray : IOutput2, ICalc, ICalc2
    {
        public int[] Arr { get; set; }
        public MyArray(int[] arr)
        {
            Arr = arr;
        }
        public int Less(int value)
        {
            int count = 0;

            foreach (var item in Arr)
            {
                if (item < value)
                {
                    count++;
                }

            }

            return count;
        }

        public int Greater(int value)
        {
            int count = 0;

            foreach (var item in Arr)
            {
                if (item > value)
                {
                    count++;
                }

            }

            return count;
        }
        public void ShowEven()
        {
            foreach (var item in Arr)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + ",");
                }

            }
        }

        public void ShowOdd()
        {
            foreach (var item in Arr)
            {
                if (item % 2 != 0)
                {
                    Console.Write(item + ",");
                }

            }
        }

        public int CountDistinct()
        {

            int count = 0;
            bool isUnique = true;

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] == Arr[j])
                    {
                        isUnique = false;
                        break;
                    }

                }
                if (isUnique)
                {
                    count++;

                }

            }

            return count;
        }

        public int EqualToValue(int value)
        {
            int count = 0;

            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == value)
                {
                    count++;
                }

            }

            return count;
        }
    }
}
