using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _5PlayerBattleTest.PlayerClass
{
    internal class AllyPlayers
    {
        //Name - Currently place holder
        private String name;

        //Default stats - Only change these by lvl up!
        private int healthMax;
        private int energyMax;
        private int defence;
        private double crit;
        
        private int baseDam = 10;
        private int baseMagic = 10;


        //Actual Health/Energy - Cannot be higher than max value
        private int healthActual;
        private int energyActual;

        //Stats determined by gear - Only change these by gear equipped
        private int _healthMod;
        private int _energyMod;
        private int _defenceMod;
        private double _critMod;

        private int _baseDamMod = 0;
        private int _baseMagicMod = 0;

        //Ability List
        private List<String> abilityList = new List<String>(8);
        
        //Gear - UNUSED
        private List<String> equippedGear = new List<String>(4);

        //Player Status Effects
        Boolean isDowned;
        Boolean isExhausted;

        public AllyPlayers(String name, int healthMax, int energyMax, int defence, double crit, List<String> abilityList)
        {
            this.name = name;
            this.healthMax = this.healthActual = healthMax;
            this.energyMax = this.energyActual = energyMax;
            this.defence = defence;
            this.crit = crit;
            this.abilityList = abilityList;
        }

        //Reserved for save loading
        public AllyPlayers(String name, int healthMax, int energyMax, int defence, double crit, int baseDam, int baseMagic, List<String> abilityList, List<String> equippedGear)
        {
            this.name = name;
            this.healthMax = this.healthActual = healthMax;
            this.energyMax = this.energyActual = energyMax;
            this.defence = defence;
            this.crit = crit;
            this.abilityList = abilityList;

            //Damage
            this.baseDam = baseDam;
            this.baseMagic = baseMagic;

            //Gear
            this.equippedGear = equippedGear;
        }

        //Max Health/Energy setters/getters.
        public void setHealthMax(int max)
        {
            this.healthMax = max;
        }
        public int getHealthMax()
        {
            return this.healthMax;
        }

        public void setEnergyMax(int max)
        {
            this.energyMax = max;
        }
        public int getEnergyMax()
        {
            return this.energyMax;
        }

        //
        public int getHealth()
        {
            return healthActual;
        }
        public void setHealth(Boolean isHeal, int damage) 
        {
            switch (isHeal)
            {
                case true:
                    healthActual = healthActual + damage;
                    if (healthActual > healthMax)
                    {
                        healthActual = healthMax;
                    }
                    isDowned = false;
                    break;

                case false:
                    healthActual = healthActual - damage;
                    if (healthActual < 0)
                    {
                        healthActual = 0;
                        isDowned = true;
                    }
                    break;
            }
        }

        public int getEnergy()
        {
            return energyActual;
        }
        public void setEnergy(Boolean isGained, int amount)
        {
            switch (isGained)
            {
                case true:
                    energyActual = energyActual + amount;
                    if (energyActual > energyMax)
                    {
                        energyActual = energyMax;
                    }
                    break;

                case false:
                    energyActual = energyActual - amount;
                    if (energyActual < -15)
                    {
                        isExhausted = true;
                    }
                    break;
            }
        }

        //Defence: Reduces total damage taken. Will be calculated before being passed here.
        public int getDefence()
        {
            return defence;
        }
        public void setDefence(int value)
        {
            this.defence = value;
        }
        
        //Crit: Boosts damage to enemy.
        public double getCrit()
        {
            return crit;
        }
        public void setCrit(int value)
        {
            this.crit = value;
        }

        public String getCurrentAbilities()
        {
            return "";
        }

        public String getName()
        {
            return name;
        }
        public string displayStatsBattle()
        {
            return $"{name} - HP: {healthActual}/{healthMax} - AP: {energyActual}/{energyMax}";
        }
        public string displayStatsMenu()
        {
            return $"{name} - HP: {healthActual}/{healthMax} - AP: {energyActual}/{energyMax} - Att: {baseDam} - MD: {baseMagic} - Def: {defence} - Crit: {crit}";
        }

        public void displayEquippedAbilites()
        {
            foreach(String abilities in abilityList)
            {
                Console.WriteLine(abilities);
            }
        }
    }
}
