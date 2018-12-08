using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_13
{
    class TranspSredstv :IComparable<TranspSredstv>
    {
        //Автосвойство
        public int Kol_pas { get; set; }
        public string Name_vod { get; set; }
        public static string Obj { get; protected set; } = "Транспортное средство";

        //Конструктор по умолчанию
        public TranspSredstv()
        {
            Kol_pas = Rand.Kol_pas();
            Name_vod = Rand.Name_vod();
        }

        //Конструктор с вводом кол-ва пассажиров и именем водителя
        public TranspSredstv(int Kol_pas, string Name_vod)
        {
            this.Kol_pas = Kol_pas;
            this.Name_vod = Name_vod;
        }

        //Строка, соответствующая данному классу
        public override string ToString()
        {
            return string.Format("Тип: {0,-20}\tКол-во пассажиров: {1,-3}\tФИО водителя: {2,-30}",
                                Obj, Kol_pas, Name_vod);
        }

        //Печать строки в консоль
        public virtual void Show()
        {
            Console.Write(this.ToString());
        }

        //Для того, чтобы показать, что оно плохо работает
        public void Show1()
        {
            Console.Write("Тип: {0,-20}\tКол-во пассажиров: {1,-3}\tФамилия водителя: {2,-10}",
                                Obj, Kol_pas, Name_vod);
        }

        //Сортировка по кол-ву пассажиров
        public int CompareTo(TranspSredstv other)
        {
            return Kol_pas.CompareTo(other.Kol_pas);
        }
    }
}

