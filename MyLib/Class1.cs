using System;

namespace MYarrayLIb
{
    public static class Count
    {


        public static double AVG(this int[] num)
        {
            double avg = 0, count = 0;
            double result = 0;
            foreach (double i in num)
            {
                count++;
                avg += i;
            }
            result = avg / count;
            return result;

        }
        public static int SUM(this int[] num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            return sum;
        }
        public static int MAX(this int[] num)
        {
            int max = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (max < num[i])
                {
                    max = num[i];
                }

            }
            return max;
        }
        public static int MIN(this int[] num)
        {
            int min = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (min > num[i])
                {
                    min = num[i];

                }

            }
            return min;
        }
    }

}
