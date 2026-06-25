using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace _5PlayerBattleTest.PlayerClass
{
    internal class Abilities<T>
    {
        //This will define all abilites, universal and player specific
        public Abilities()
        {
            
        }
        //Universal Abilities
         
    }

    internal class InitalAbilites
    {
        List<String> abilityList = new List<String>(8);
        //Starting Player
        public List<String> Lily ()
        {
            abilityList.Add("CommandStrike");
            abilityList.Add("Charge");
            return abilityList;
        }
        //Starting Barb
        public List<String> Barb()
        {
            abilityList.Add("CriticalPoint");
            abilityList.Add("DualStrike");
            return abilityList;
        }
        //Starting Pal
        public List<String> Pal()
        {
            abilityList.Add("ShieldBash");
            abilityList.Add("MagicMissile");
            return abilityList;
        }
        //Starting Wiz
        public List<String> Wiz()
        {
            abilityList.Add("FireBall");
            abilityList.Add("MagicMissile");
            abilityList.Add("Barrier");
            abilityList.Add("GroupHeal");
            return abilityList;
        }
        //Starting Blood
        public List<String> Blood()
        {
            abilityList.Add("Heal1");
            abilityList.Add("GroupHeal_Blood");
            return abilityList;
        }

        public List<String> BasicEnemy()
        {
            abilityList.Add("Heal1");
            abilityList.Add("CritialPoint");
            abilityList.Add("FireBall");
            abilityList.Add("barrier");
            return abilityList;
        }
    }
}
