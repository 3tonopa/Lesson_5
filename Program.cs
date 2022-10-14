using System;
using System.Linq;
using System.Text;

namespace Lesson_5
{
    class Program //Д/З Урок 5. Стрелков Максим.
    {
        static void Main(string[] args)
        {
            LoginCheck();
            Console.WriteLine("Введите текст: ");
            string input = Console.ReadLine();
            Message.Count(input);
            Message.Delete(input);
            Message.MaxWord(input);
            Reverse();
        }

        static void LoginCheck() // Задача №1.
                                 //
                                 // Проверка логина на корректность
        {
            Console.WriteLine("Введите логин: ");

            string login = Console.ReadLine();
            // bool loginCheck = true;
            bool flag = false;
            if (login.Length >= 2 && login.Length <= 10 && Char.IsDigit((char)login[0]) == false && flag == false)
                Console.WriteLine("Вы ввели - {0}, логин корректен", login);
            else
                Console.WriteLine("Вы ввели - НЕкорректный логин!");



        }

        static void Reverse() // Задача №3. Метод, определяющий, является ли одна строка перестановкой другой.
        {
            string input = "Moscoow";
            string variant = "wocsoM";
            Console.WriteLine($"Заданная строка: [{input}]");
            Console.WriteLine($"Вариант для сравнения: [{variant}]");
            string output = new string(input.ToCharArray().Reverse().ToArray());
            Console.WriteLine($"Реверс строки: [{output}]");

            // сравнение с использованием статического метода
            int res = (String.Compare(output, variant));

            if (res != 0)

            {
                Console.WriteLine($"Строки НЕ совпадают");
            }
            if (res == 0)
            {
                Console.WriteLine($"Строки совпадают");
            }
        }


        class Message // Класс Message
                      //Задача № 2.

        {
            public static void Count(string input) //Вывести только те слова сообщения, которые содержат не более n букв.

            {
                Console.WriteLine("Введите кол-во символов в слове:");
                int length = int.Parse(Console.ReadLine());
                var array = input.Split(new char[] { ' ', ',', '.', '!', '?', '-' }).Where(x => x.Length == length).ToArray();
                Console.Write($"Слова состоящие из [{length}] букв:");

                foreach (var count in array)
                {
                    Console.Write(" " + $"[{count}]");
                }
                Console.WriteLine("");
            }
            public static void Delete(string input)  //Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            {
                string[] strletter = input.Split(' ', ',', '.', '!', '?', '-');
                Console.WriteLine("Введите букву. Слова заканчивающиеся на эту букву будут удалены.");
                string delete = Console.ReadLine();
                for (int i = 0; i < strletter.Length; i++)
                    if (strletter[i].EndsWith(delete))
                        Console.WriteLine($"Удалено - [{strletter[i]}]");
            }
            public static void MaxWord(string input) //Найти самое длинное слово сообщения, создать строку из самых длинных слов.

            {
                string max = String.Empty;
                string final = String.Empty;
                string[] stringSeparators = new string[] { " ", ",", ".", ":", "!", "?", ";" };
                string[] result; //массив для результатов обработки строки
                string[] check;  //массив для результатов отбора слов по длине слева направо
                result = input.Split(stringSeparators, StringSplitOptions.None);
                StringBuilder sr = new StringBuilder();//строка для промежуточных результатов
                Console.WriteLine($"Максимально длиные слова:");
                for (int i = 0; i < result.Length; i++) //обработка слева направо
                {
                    string word = result[i];
                    if (word != string.Empty && word.Length >= max.Length)
                    {
                        max = word;
                    }
                    //Console.WriteLine($"[ {max} ]"); //вывод всех длинных слов в процессе выборки 
                    if (result[i].Equals(max))
                    {
                        sr.Append(" " + max);
                    }
                }
                Console.WriteLine($"[ {max} ]"); //вывод последнего самого длинного слова
                string res = sr.ToString();

                check = res.Split(stringSeparators, StringSplitOptions.None);
                StringBuilder sn = new StringBuilder();//строка для результатов
                for (int i = check.Length -1; i > 0; i--)//обработка справа налево
                {
                    string word = check[i];
                    if (word != string.Empty && word.Length >= max.Length)
                    {
                        max = word;
                    }
                    if (check[i].Equals(max))
                    {
                        sn.Append(" " + max);
                    }
                    final = sn.ToString();
                }
                Console.WriteLine($"Строка из максимально длинных слов: [ {final} ]");
            }
        }
    }
}

        
            
        











    
