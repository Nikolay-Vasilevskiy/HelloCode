// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число:");

            string str = Console.ReadLine();
            int n = 0;
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str.Substring(i, 1) != (str.Substring(str.Length - 1 - i, 1)))
                {
                    Console.WriteLine("Число {0} не является палиндромом", str);
                    break;
                }
                else
                    n = 1;
            }
            if (n == 1) Console.WriteLine("Число {0} является палиндромом", str);

