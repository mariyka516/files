using System;
using System.IO;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string writePath = @"C:\Users\User\Desktop\"Dz.txt";

            string text = "Проверка";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }

                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Вывод2");
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}