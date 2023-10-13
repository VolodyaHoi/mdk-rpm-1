using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_9
{
    public class Class1
    {
        // добавил комментарии
        public int sumOfNumbers(int n) // Сформировать n целых чисел в диапазоне 2-14. Найти сумму чисел < 8. Результат 
                                       // вывести на экран.
        {
            int currentValue = 0; // сгенерированное значение
            int sum = 0; // сумма

            for (int i = 0; i < n; i++) // формирование n чисел
            {
                Random rnd = new Random(); // обьявление рандом
                currentValue = rnd.Next(2, 14); // создание случайного значения в диапазоне 2 - 14 
                if (currentValue < 8) // если сгенерированное значение меньше 8,сложить
                {
                    sum = sum + currentValue;
                }
            }
            return sum; // возвращение суммы
        }
    }
}
