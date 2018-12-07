using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_13
{
    class Train : TranspSredstv
    {
        public int Kol_vag { get; set; }
        public static new string Obj { get; private set; } = "Поезд";

        public Train() : base()
        {
            Kol_vag = Rand.Kol_vag();
        }

        public Train(int Kol_pas, string Name_vod, int Kol_vag) : base(Kol_pas, Name_vod)
        {
            this.Kol_vag = Kol_vag;
        }

        public override string ToString()
        {
            return string.Format("Тип: {0,-20}\tКол-во пассажиров: {1,-3}\tФИО водителя: {2,-30}\tКол-во вагонов: {3}",
                                Obj, Kol_pas, Name_vod, Kol_vag);
        }

        public override void Show()
        {
            Console.Write(this.ToString());
        }

        public void Show1()
        {
            Console.Write("Тип: {0,-20}\tКол-во пассажиров: {1,-3}\tФамилия водителя: {2,-10}\tКол-во вагонов: {3}",
                                Obj, Kol_pas, Name_vod, Kol_vag);
        }
    }
}
