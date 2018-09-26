/*
Завдання 7.
Написати програму, яка кодує або декодує повідомлення, яке вказується в командному рядку. 
Сама дія (кодувати чи декодувати) вказується першим параметром, а потім йде фраза, яка підлягає відповідній операції. 
Метод шифрування може бути довільним, наприклад, метод XOR(операція ^ у С#) з вказуванням ключа, 
інкрементування на одиницю тощо. 
 */

using System;
using System.Text;


namespace _07_decoding_text
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine($"Recieve {args.Length} arguments");
            int cnt = 0;
            foreach (var arg in args)
            {
                Console.WriteLine($"[{++cnt}]: '{arg}'");
            }

            if (cnt >= 2)
            {
                StringBuilder text = new StringBuilder(args[1]);
                Console.WriteLine($"Before:\t{text}");

                if (char.TryParse(args[0], out char smb))
                {
                    if (smb == 'c')
                        for (int i = 0; i < text.Length; i++)
                        {
                            text[i] = Convert.ToChar(text[i] + 1);
                        }
                    else
                        if (smb == 'd')
                        for (int i = 0; i < text.Length; i++)
                        {
                            text[i] = Convert.ToChar(text[i] - 1);
                        }
                    else
                        Console.WriteLine($"Key '{smb}' is wrong. Enter 'c' for coding or 'd' for decoding\n");
                }
                else
                    Console.WriteLine($"Wrong command for coding or decoding\n");
                Console.WriteLine($"After:\t{text}");
            }
            else
                Console.WriteLine($"Wrong arguments. Enter 'c' for coding or 'd' for decoding and some text.\n");
            Console.ReadKey();
        }
    }
}
