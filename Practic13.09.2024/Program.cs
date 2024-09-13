using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic13._09._2024
{
    internal class Program
    {
        /*
        Напишите метод, фильтрующий массив на основании
        переданных параметров. Метод принимает параметры:
        оригинальный_массив, массив_с_данными_для_фильтрации.
        Метод возвращает оригинальный массив без элементов, 
        которые есть в массиве для фильтрации.
        Например:
        1 2 6 -1 88 7 6 — оригинальный массив;
        6 88 7 — массив для фильтрации;
        1 2 -1 — результат работы метода.
         */
        public static int[] FilterArray(int[] originArray, int[] filterArray)
        {
            /*List<int> filteredList = new List<int>();
            foreach (int number in originArray)
            {
                bool isFiltered = false;
                foreach(int filterNumber in filterArray)
                {
                    if (number == filterNumber)
                    {
                        isFiltered = true;
                        break;
                    }
                }
                if (!isFiltered) {
                    filteredList.Add(number);
                }
            }
            return filteredList.ToArray();*/

            int[] resultArray = new int[originArray.Length];
            int resultIndex = 0;
            foreach (int num in originArray)
            {
                if (Array.IndexOf(filterArray, num) == -1)
                    resultArray[resultIndex++] = num;
            }
            Array.Resize(ref resultArray, resultIndex);
            return resultArray;
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine("Введите количество значений");
            int sizeOriginArray = int.Parse(Console.ReadLine());
            int[] originArray = new int[sizeOriginArray];
            Random rand = new Random();
            for (int i = 0; i < sizeOriginArray; i++)
            {
                originArray[i] = rand.Next(0,10);
                Console.WriteLine(originArray[i]);
            }
            Console.WriteLine("Введите количество значений");
            int sizeFilterArray = int.Parse(Console.ReadLine());
            int[] filterArray = new int[sizeFilterArray];
            
            for (int i = 0; i < sizeFilterArray; i++)
            {
                filterArray[i] = rand.Next(0, 10);
                Console.WriteLine(filterArray[i]);
            }*/

            /*try
            {
                int a = 7;
                int b = 0;
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                int[] arr = new int[5]{8,7,3,1,3 };

                Console.WriteLine(arr[2]);

                for (int i = 0; i <= arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                    if (i == 3) {
                        throw new Exception("индекс равен 3");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            /*try
            {
                // код, в котором может возникнуть исключение
            }
            catch
            {
                // обработка исключения
            }
            finally
            {
                // очистка ресурсов
            }*/

            /*
             Пользователь вводит с клавиатуры в строку набор
            0 и 1. Необходимо преобразовать строку в число 
            целого типа в десятичном представлении. Предусмотреть
            случай выхода за границы диапазона, определяемого
            типом int, неправильный ввод. Используйте механизм
            исключений.
             */
            /*Console.WriteLine("Введите числа 0 или 1");
            string input = Console.ReadLine();

            try
            {
                int number = Convert.ToInt32(input, 2);
                Console.WriteLine(number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введены не нули и еденицы");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Слишком больше число");
            }
            finally
            {
                Console.WriteLine("Конец программы");
            }*/
            /*
             Пользователь вводит с клавиатуры в строку набор
             символов от 0-9. Необходимо преобразовать строку в
             число целого типа. Предусмотреть случай выхода за 
             границы диапазона, определяемого типом int. Используйте
             механизм исключений.
             */
            /*Создайте класс «Кредитная карточка». Вамнеобходимо
            хранить информацию о номере карты, ФИО владельца,
            CVC, дата завершения работы карты и т.д. Предусмотреть
            механизмыдля инициализации полей класса.Если значение
            для инициализации неверное, генерируйте исключение.
            */
            Card card = new Card();
            try
            {
                card.CVC = 2222;
                card.DateActive = DateTime.Now;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.InnerException.M);
            }
            /*catch (Exception ex) {
               Console.WriteLine(ex.StackTrace);
                Console.WriteLine("неверно");
            }*/
        }
    }
}
