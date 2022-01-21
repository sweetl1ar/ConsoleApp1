using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //проверка строки на количество одинаковых букв
            /*string str =  "аргентина манит негра";
            char a = 'а';
            char e = 'е';
            int suma = 0;
            int sume = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == a)
                {
                    suma = suma + 1;
                }
                if (str[i] == e)
                {
                    sume = sume + 1;
                }
            }
            if (suma > sume)
            {
                Console.WriteLine($"Букв а в данной строке больше. Количество букв равно {suma}");
            }
            if (sume > suma)
            {
                Console.WriteLine($"Букв е в данной строке больше. Количество букв равно {sume}");
            }
            Console.ReadLine();*/

            //проверка строки на уникальные символы
            /*Console.Write("Введите слово: ");
            string text = Console.ReadLine();
            Dictionary<char, int> dictionarys = text.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            foreach (KeyValuePair<char, int> keyValuePair in dictionarys)
            {
                Console.WriteLine("{0}: {1}", keyValuePair.Key, keyValuePair.Value); 
            }
            Console.ReadLine();*/

            //проверка строки на палиндромность
            /*string str = "Аргентина манит негра";
            str = str.ToLower().Replace(" ", string.Empty);
            char[] str1 = str.ToCharArray();
            Array.Reverse(str1);
            string str2 = new string(str1);
            if(str2 == str)
            {
                Console.WriteLine("Строка является палиндромом.");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом.");
            }
            Console.ReadLine();*/

            //посчитать кол-во цифр
            /*string str = "2'5fZeA3y9oW";
            Console.WriteLine(str.Count(x => char.IsDigit(x)));
            Console.ReadLine();*/

            //посчитать сумму цифр в строке
            /*string str = "YQ02vO1gyYBM944";
            int sum = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if(char.IsNumber(str[i]))
                 {
                    sum = sum + Convert.ToInt32(str[i].ToString());
                 }
            }
            Console.WriteLine($"Сумма цифр данной строки равна: {sum}");
            Console.ReadLine();*/

            //Удаление всех цифр из строки
            /*string str = "5sfdf58rge6g6erg56548484";
            string s = "";
            for(int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    s = s + str[i];
                }
            }
            Console.WriteLine($"Строка без цифр: {s}");
            Console.ReadLine();*/

            //Определить количество различных символов
            /*Console.Write("Введите строку: ");
            string text = Console.ReadLine();
            Dictionary<char, int> dictionarys = text.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            foreach (KeyValuePair<char, int> keyValuePair in dictionarys)
            {
                Console.WriteLine("{0}: {1}", keyValuePair.Key, keyValuePair.Value);
            }
            Console.ReadLine();*/

            //удалить из строки средний символ
            /*Console.Write("Введите строку: ");
            string str = Convert.ToString(Console.ReadLine());
            Console.Write($"Введенная строка: {str}");
            Console.WriteLine($"\nКонечная строка: {Replace(str)}");
            Console.ReadLine();
            }*/

            /*public static string Replace(string text)
                {
                    if (string.Equals(text, "")) return "Введите текст!";
                    if (text.Length % 2 == 0) return text.Insert(text.Length / 2, "0");
                    else return text.Remove(text.Length / 2, 1);
                }*/
        }
    }
}


    //самая длинная подстрока из цифр + букв
    /*class MaximumSubstring
    {
        public static int GetMaximumSubstring(string s)
        {
            int count = 1;
            int x = 0;
            for (int i = 0; i < s.Length - 1; ++i)
            {
                char symbolOld = s[i];
                char symbolNext = s[i + 1];
                if (symbolOld.Equals(symbolNext))
                {
                    count++;
                    if (count > x) x = count;
                }
                else count = 1;
            }
            return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Длина максимальной подстроки цифр в строке 45645555645456 = " + GetMaximumSubstring("45645555645456"));
            Console.WriteLine("Длина максимальной подстроки символов в строке ggjf++++++5мавмва498*?:% = " + GetMaximumSubstring("ggjf++++++5мавмва498*?:%"));
            Console.ReadKey();
        }
    }*/

