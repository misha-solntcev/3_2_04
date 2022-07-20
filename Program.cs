using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 4
Дана строка.Словом текста является последовательность цифр и букв латинского
алфавита; между соседними словами - не менее одного пробела, за последним словом -
точка. Найти и сохранить в строке те слова, в которых цифры и буквы латинского
алфавита чередуются. Все остальные слова удалить.*/

namespace _3_2_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "1a2b3c 4d5e6f7g abc123 8c9v.";
            char[] sep = { ' ', '.' };
            string[] myWord = myString.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            string newString = "";
            for (int i = 0; i < myWord.Length; i++)
            {                
                char[] myLetter = myWord[i].ToCharArray();
                bool flag = true;
                for (int j = 0; j < myLetter.Length - 1; j++)
                {
                    if (Char.IsLetter(myLetter[j]) != Char.IsDigit(myLetter[j + 1]))                    
                    {
                        flag = false;
                        break;
                    }                    
                }
                if (flag)             
                    newString += myWord[i] + " ";                
            }
            Console.WriteLine($"newString = {newString}");
            Console.ReadKey();
        }
    }
}
