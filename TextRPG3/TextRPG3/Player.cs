using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG3
{
    enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3
    }

    class Player : Creture
    {
        public Player()
        {
            this.Hp = 10;
            this.Mp = 10;
            this.Att = 1;
            this.Exp = 0;
            this.Jop = "플레이어";
        }


    }

    class Knight : Player
    {
        public Knight()
        {
            this.Hp = 100;
            this.Mp = 10;
            this.Att = 10;
            this.Exp = 0;
            this.Jop = "기사";
        }
    }

    class Archer : Player
    {
        public Archer()
        {
            this.Hp = 80;
            this.Mp = 15;
            this.Att = 12;
            this.Exp = 0;
            this.Jop = "궁수";
        }
    }

    class Mage : Player
    {
        public Mage()
        {
            this.Hp = 70;
            this.Mp = 30;
            this.Att = 15;
            this.Exp = 0;
            this.Jop = "법사";
        }
    }
}
