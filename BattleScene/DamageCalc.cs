using _5PlayerBattleTest.PlayerClass;
using _5PlayerBattleTest.EnemyClass;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5PlayerBattleTest.BattleScene
{

    /*
     * Calculator when taking or dealing damage, including healing.
     * After calculation, value are sent to the given player/enemy
     * 
     * IMPORTANT: When healing, make sure to pass "isHeal" boolean. This will allow defence bypass. Healing should only be reduced if status effects are in place
    */
    internal class PlayerDamageCalc
    {
        
        //  If player damages self
        public PlayerDamageCalc(AllyPlayers playerTarget, int damage, Boolean isHeal)
        {
            if (isHeal)
            {
                playerTarget.setHealth(isHeal, playerTarget.getHealthMax() * (damage / 100));
                return;
            }
            else
            {

            }

            //Player damage to self
        }

        //  If player damages anotherplayer
        public PlayerDamageCalc(AllyPlayers playerTarget, AllyPlayers playerSource, int damage, Boolean isHeal)
        {
            //Player damage to self
        }

        //  If enemy damages player
        public PlayerDamageCalc(AllyPlayers playerTarget, EnemyPlayer enemySource, int damage)
        {
            //Enemy damage to player
        }

        //  IMPORTANT: Defence will give reach dimishing returns the higher it is. This is to prevent low damage gain.
        private double defenceRating(int playerDef, int playerLvl)
        {
            double temp = ((playerDef / 100) - 0.4);
            return temp;
        }




        public int damageGained(int damage, int temp)
        {
            return 1; //Placeholder
        }

    }
    internal class EnemyDamageCalc
    {

    }
}
