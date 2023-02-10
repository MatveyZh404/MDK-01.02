using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLength; //длина комнаты
        double roomWidth; //ширина комнаты
        public double RoomLength
        {
            get { return roomLength; }
            set { roomLength = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; } 
            set { roomWidth = value; }
        }
        /// <summary>
        /// Метод вычисляет периметр комнаты
        /// </summary>
        /// <returns>Возвращает значение периметра</returns>
        public double RoomPerimetr()
        {
            return 2 * (RoomLength - RoomWidth);
        }
        /// <summary>
        /// Метод вычислять площадь комнаты
        /// </summary>
        /// <returns>Возращает значение площади</returns>
        public double RoomArea()
        {
            return roomLength * roomWidth;
        }
        /// <summary>
        /// Метод вычисляет число квадратных метров
        /// на одного человека
        /// </summary>
        /// <param name="np"></param>
        /// <returns>Возащает число квадратных метров</returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }
        /// <summary>
        /// Информация о комнате
        /// </summary>
        /// <returns>Возвращает строку</returns>
        public virtual string Info()
        {
            return "Комната площадью " + RoomArea() + " кв.м";
        }
    }
    /// <summary>
    /// Класс "жилая комната"
    /// </summary>
    public class LivingRoom : Room
    {
        int numWin; //число окон
        public int NumWin
        { get { return numWin; } set { numWin = value; } }
        /// <summary>
        /// Метод возвращает информацию о комнате
        /// </summary>
        /// <returns>Возвращается строка с информацией</returns>
        public override string Info()
        {
            return "Жилая комната площадбю " + RoomArea() + "кв.м, с " + numWin + " окнами";
        }
    }
    /// <summary>
    /// Класс "офис"
    /// </summary>
    public class Office : Room
    {
        int numSockets; //число розеток
        public int NumSockets
        { get { return numSockets; } set { numSockets= value; } }
        /// <summary>
        /// Возвращает максимально возможное число рабочих мест
        /// </summary>
        /// <returns>Возвращает число мест</returns>
        public int NumWorkplaces()
        {
            int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
            return Math.Min(numSockets, num);
        }
        /// <summary>
        /// Метод возвращает информацию о офисе
        /// </summary>
        /// <returns>Возвращается строка с информацией</returns>
        public override string Info()
        {
            return "Офис на " + NumWorkplaces() + " рабочих мест";
        }
    }
}
