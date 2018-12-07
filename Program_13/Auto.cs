using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_13
{
    class Auto : TranspSredstv
    {
        string detsk_kresl;
        public bool Est_detsk_kresl { get; private set; }
        public static new string Obj { get; private set; } = "Машина";

        //Конструктор по умолчанию
        public Auto() : base()
        {
            Est_detsk_kresl = Rand.Est_detsk_kresl();
            Detsk_kresl();
        }

        //Конструктор со всеми параметрами
        public Auto(int Kol_pas, string Name_vod, bool Est_detsk_kresl) : base(Kol_pas, Name_vod)
        {
            this.Est_detsk_kresl = Est_detsk_kresl;
            Detsk_kresl();
        }

        //Для заполнения поля, которое выводится в консоль
        private void Detsk_kresl()
        {
            if (Est_detsk_kresl) detsk_kresl = "Есть";
            else detsk_kresl = "Нет";
        }

        public override string ToString()
        {
            return string.Format("Тип: {0,-20}\tКол-во пассажиров: {1,-3}\tФИО водителя: {2,-30}\tДетское кресло: {3}",
                                Obj, Kol_pas, Name_vod, detsk_kresl);
        }

        //Вывод в консоль
        public override void Show()
        {
            Console.Write(this.ToString());
        }

        public void Show1()
        {
            Console.Write("Тип: {0,-20}\tКол-во пассажиров: {1,-3}\tФамилия водителя: {2,-10}\tДетское кресло: {3}",
                                            Obj, Kol_pas, Name_vod, detsk_kresl);
        }
    }
}
