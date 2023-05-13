using System;

namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть слово з маленької літери: ");
            string word = Console.ReadLine();

            char sameChar = ' ';
            int index1 = -1;
            int index2 = -1;

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (word[i] == word[j])
                    {
                        sameChar = word[i];
                        index1 = i;
                        index2 = j;
                        break;
                    }
                }

                if (index1 != -1 && index2 != -1)
                {
                    break;
                }
            }

            if (index1 != -1 && index2 != -1)
            {
                Console.WriteLine("У слові є дві однакові літери '{0}' на позиції {1} та {2}.", sameChar, index1, index2);
            }
            else
            {
                Console.WriteLine("У слові немає двох однакових літер.");
            }

            Console.ReadKey();
        }
    }
}
