using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic13._09._2024
{
    /*Создайте класс «Кредитная карточка». Вамнеобходимо
    хранить информацию о номере карты, ФИО владельца,
    CVC, дата завершения работы карты и т.д. Предусмотреть
    механизмыдля инициализации полей класса.Если значение
    для инициализации неверное, генерируйте исключение.
    */
    internal class Card
    {
        private int _cvc;
        public int CVC {  
            get { return _cvc; } 
            set {
                if (value >= 1000)
                    //throw new Exception();
                _cvc = value;
            } 
        }
        private DateTime _date;
        public DateTime DateActive { 
            get { return _date; }
            set { 
                if (value.Year < DateTime.Now.Year+2)
                {
                    try
                    {
                        char c = char.Parse(value.ToLongDateString());
                        
                    }
                    catch (FormatException ex)
                    {
                        throw new Exception();
                    }
                }
                _date = value;
            }
        }
    }
}
