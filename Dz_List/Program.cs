using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random random = new Random();
            int max=0;
            int premax = 0;
            int sum = 0;
            for(int i = 1; i < 11; i++)
            {
                numbers.Add(random.Next(20));
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > premax && numbers[i] < max)
                {
                    premax = numbers[i];
                }
            }
            for(int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine("Предмаксимальный элемент = {0}", premax);
            Console.WriteLine("Сумма = {0}", sum);
            Console.ReadLine();
        }
    }
}
