using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_13
{
    static class Rand
    {
        static Random rand = new Random();
        static string[] arr_f = { "Коэн ", "Леви ", "Мизрахи ", "Аврахам ", "Фридман ", "Кац ", "Йосеф ", "Таль ", "Ашкенази ", "Хазан " };
        static string[] arr_i = { "Аарон ", "Абрам ", "Мойша ", "Иов ", "Авраам ", "Давид ", "Дов ", "Вениамин ", "Гавриил ", "Елизар " };
        static string[] arr_o = { "Ааронович", "Рабинович", "Абрамович", "Авраамович", "Давидович", "Вениаминович", "Гавриилович", "Елизарович", "Исаевич", "Самуилович" };

        public static int Kol_pas()
        {
            return rand.Next(0, 50);
        }

        public static string Name_vod()
        {
            return string.Format("{0}{1}{2}", arr_f[rand.Next(0, 10)], arr_i[rand.Next(0, 10)], arr_o[rand.Next(0, 10)]);
        }

        public static bool Est_detsk_kresl()
        {
            return Convert.ToBoolean(rand.Next(0, 2));
        }

        public static int Kol_vag()
        {
            return rand.Next(1, 20);
        }

        public static int Speed()
        {
            return rand.Next(20, 200);
        }
    }
}
