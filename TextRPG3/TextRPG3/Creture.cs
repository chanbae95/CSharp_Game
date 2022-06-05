using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG3
{
    class Creture
    {
        enum CretureType
        {
            None = 0,
            Player = 1,
            Monster = 2,
            NPC = 3
        }

        public int Hp;
        public int Mp;
        public int Att;
        public int Exp;
        public string Jop;

        public Creture()
        {
            Hp = 0;
            Mp = 0;
            Att = 0;
            Exp = 0;
            Jop = null;
        }

        public void Fight(int OtherAtt)
        {
           this.Hp -= OtherAtt;
        }


    }
}
