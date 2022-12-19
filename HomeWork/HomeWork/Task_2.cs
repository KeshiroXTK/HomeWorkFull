using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork.Utils.interface1.PrintInfo(3, "Щукин Александр");
            Console.ReadLine();

            //2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
            //      Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму
            //      вывести на экран; Используя tryParse;
            //      Так же добавил обработку исключительных ситуаций на то, что могут быть введены некорректные
            //      данные.При возникновении ошибки вывести сообщение.

            {
                int i = 0;
                int cum = 0;
                List<int> OddNumber = new List<int>();

                do
                {
                    bool flag = int.TryParse(Console.ReadLine(), out i);

                    if (Control(flag) == false) 
                    {
                        i = -1;
                        continue;
                    }

                    if (i % 2 != 0 && i > 0)
                    {
                        OddNumber.Add(i);
                        cum += i;
                    }
                } while (i != 0);

                Console.WriteLine("Нечетные положительные числа:");
                foreach (int item in OddNumber) // пришлось изучить списки, чтобы вывести нечетные положительные
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Сумма: " + cum);
                Console.ReadKey();
            }

            static bool Control(bool flag)
            {
                if (flag == false)
                {
                    Console.WriteLine("Ошибка при вводе данных. Повторите ввод.");
                    return false;
                }
                return true;
            }
        }
    }
}
