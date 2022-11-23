// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. ВАРИАНТ 2

int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine()); // считываем из консоли цифру и называем ее num

            Console.WriteLine("Чётные числа от 1 до " + num);
            while (i <= num)
            {
                if (i % 2 != 1)         // проверка на четность - если остаток от деления на 2 не равен 1 значит число нечетное
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)                      // видимо тут i ==1 но запись не понятна
            {
                Console.WriteLine("Нет чётных чисел!");
            }
            break;

        default;
            begin = false;
            break;
