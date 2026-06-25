using _5PlayerBattleTest.EnemyClass;
using _5PlayerBattleTest.PlayerClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _5PlayerBattleTest
{
    internal class PlayGame
    {
        public void InitializeGame()
        {
            List<AllyPlayers> allyPlayers = new List<AllyPlayers>(5);
            //Initialize values             name,       health, energy, def,    crit,   abilityList
            allyPlayers.Add(new AllyPlayers("Lily",     160,    250,    30,     35.5,   new InitalAbilites().Lily()));
            allyPlayers.Add(new AllyPlayers("Barb",     180,    250,    33,     80.5,   new InitalAbilites().Barb()));
            allyPlayers.Add(new AllyPlayers("Pal",      200,    250,    50,     60.5,   new InitalAbilites().Pal()));
            allyPlayers.Add(new AllyPlayers("Wiz",      140,    250,    26,     20.5,   new InitalAbilites().Wiz()));
            allyPlayers.Add(new AllyPlayers("Blood",    110,    250,    18,     40.5,   new InitalAbilites().Blood()));

            List<EnemyPlayer> enemyPlayers = new List<EnemyPlayer>(5);
            //Initialize values             name,       health, energy, def,    abilityList
            enemyPlayers.Add(new EnemyPlayer ("Test Enemy",   160,    250,    30,     new InitalAbilites().BasicEnemy()));

            //Following code will be put into seperate "battle" c# class
            int enemyCount = 3;
            String num;
            Boolean valid = false, endTurn = false;

            while (enemyCount > 0)
            {
                Boolean playersTurn = true;
                while (playersTurn)
                {
                    foreach (AllyPlayers player in allyPlayers)
                    {
                        Console.WriteLine("\n" + player.getName() + "'s turn!");
                        Console.WriteLine("0: Attack");
                        Console.WriteLine("1: Abilities");
                        Console.WriteLine("2: Duo");
                        Console.WriteLine("3: Items");
                        Console.WriteLine("4: Defend");

                        do
                        {
                            num = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(num))
                            {
                                Console.WriteLine("YOU SUCK!");
                                valid = false;
                            }
                            else
                            {
                                valid = true;

                                switch (num)
                                {
                                    case "0":
                                        break;
                                    case "1":
                                        Console.WriteLine(player.getName() + "'s Abilities");
                                        player.displayEquippedAbilites();
                                        break;
                                    case "2":
                                        Console.WriteLine(player.getName() + " performs duo with Lily");
                                        break;
                                    case "3":
                                        Console.WriteLine(player.getName() + " uses items");
                                        break;
                                    case "4":
                                        Console.WriteLine(player.getName() + " defends");
                                        endTurn = true;
                                        break;
                                }
                            }
                        } while (!valid && !endTurn);
                    }

                    //  Execute stored player input
                    //  This will pass List<> of player actions to a battle class that will execute the actions and return the results to be displayed to the user.
                    //  Damage will be calculated and applied to the players and enemies.
                    //  The battle class will also check for any enemy deaths and remove them from list.
                    playersTurn = endTurn = false;
                }
                
                foreach (EnemyPlayer enemy in enemyPlayers)
                {
                    //  !NEED TO WRITE AI LOGIC. FOR NOW THIS USES RANDOM ROLLS!
                    Random rand = new Random();
                    int roll = rand.Next(4);
                    Console.WriteLine($"{enemy.getName()} {roll}");

                    switch (roll)
                    {
                        case 0:
                            Console.WriteLine("Enemy attacks");
                            break;
                        case 1:
                            Console.WriteLine("Enemy uses an ability");
                            break;
                        case 2:
                            Console.WriteLine("Enemy does duo with enemy2");
                            break;
                        case 3:
                            Console.WriteLine("Enemy defends");
                            break;
                    }
                }
            }
        }

        public String displayCurrentEnemies(List<EnemyPlayer> enemies)
        {
            String enemyList = "";
            foreach (EnemyPlayer enemy in enemies)
            {
                enemyList += enemy.getName() + "\n";
            }
            return enemyList;
        }
    }
}
