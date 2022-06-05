using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG3
{
    enum MonsterType
    {
        None = 0,
        Slime = 1,
        Orc = 2,
        Skeleton = 3
    }

    class Monster : Creture
    {
        public Monster()
        {
            this.Hp = 1;
            this.Mp = 1;
            this.Att = 1;
            this.Exp = 1;
            this.Jop = "몬스터";
        }


    }

    class Slime : Monster
    {
        public Slime()
        {
            this.Hp = 20;
            this.Mp = 10;
            this.Att = 10;
            this.Exp = 5;
            this.Jop = "슬라임";
        }
    }

    class Orc : Monster
    {
        public Orc()
        {
            this.Hp = 30;
            this.Mp = 15;
            this.Att = 15;
            this.Exp = 10;
            this.Jop = "오크";
        }
    }

    class Skeleon : Monster
    {
        public Skeleon()
        {
            this.Hp = 40;
            this.Mp = 20;
            this.Att = 20;
            this.Exp = 15;
            this.Jop = "스켈레톤";
        }
    }
}
