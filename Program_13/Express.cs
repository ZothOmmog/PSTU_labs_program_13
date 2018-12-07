using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_13
{
    class Express : TranspSredstv
    {
        public int Speed { get; set; }
        public static new string Obj { get; private set; } = "Экспресс";

        public Express() : base()
        {
            Speed = Rand.Speed();
        }

        public Express(int Kol_pas, string Name_vod, int Speed) : base(Kol_pas, Name_vod)
        {
            this.Speed = Speed;
        }

        public override string ToString()
        {
            return string.Format("Тип: {0,-20}\tКол-во пассажиров: {1,-3}\tФИО водителя: {2,-30}\tСкорость(км/ч): {3}",
                                Obj, Kol_pas, Name_vod, Speed);
        }

        public override void Show()
        {
            Console.Write(this.ToString());
        }

        public void Show1()
        {
            Console.Write("Тип: {0,-20}\tКол-во пассажиров: {1,-3}\tФамилия водителя: {2,-10}\tСкорость(км/ч): {3}",
                                            Obj, Kol_pas, Name_vod, Speed);
        }
    }
}
