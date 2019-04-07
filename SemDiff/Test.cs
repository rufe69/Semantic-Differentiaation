using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemDiff
{
    public class Test
    {
        public int[] Points = {
            3, //Четкий
            2, //Активный
            3, //Организованный
            3, //Глубокий
            1, //Красивый
            2, //Громкий
            3, //Последовательный
            3, //Сложный
            3, //Порядочный
            1, //Умный
            1, //Полезный
            2, //Энергичный
            1, //Мыслящий
            2, //Волевой
            1, //Серьезный
            2, //Живой
            2, //Сильный
            2, //Бодрый
            1, //Оптимитсичный
            2, //Уверенный
            1, //Интересный
            3, //Доступный
            3, //Современный
            1 }; //Хороший

        public int[] Values;

        public Test()
        {
            Values = new int[24];
            for (int i = 0; i < Values.Length; i++)
                Values[i] = 10;
        }
    }
}
