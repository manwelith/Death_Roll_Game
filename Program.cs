using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathRoll_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome the DeathRoll. Here, someone who rolls 0 loses.");
            Console.WriteLine("Give me the first roll! (You can give number whatever you want)");

            Random rnd = new Random();

            //Player1

            int player1_roll = Convert.ToInt32(Console.ReadLine());
            bool kontrol = true;
            while (kontrol)
            {
               

                int player1_random = rnd.Next(player1_roll);

                Console.WriteLine("Player1 Roll: " + player1_random);

                if (player1_random == 0)
                {
                    Console.WriteLine("Player2 Won!");
                    break;
                }

                //Player2

                while (true)
                {
                    int player2_roll = Convert.ToInt32(Console.ReadLine());

                    if (player2_roll != player1_random)
                    {
                        Console.WriteLine("You must roll from the last number which Player1 gave you. Roll Again!");
                    }
                
                    else if (player2_roll == player1_random)
                    {
                        int player2_random = rnd.Next(player2_roll);
                    
                        Console.WriteLine("Player2 Roll: " + player2_random);

                        if (player2_random == 0)
                        {
                            Console.WriteLine("Player1 Won!");
                            kontrol = false;
                            break;
                        }
                        
                        else
                        {
                            while (true)
                            {
                                //Player1
                        
                                player1_roll = Convert.ToInt32(Console.ReadLine());

                                if (player1_roll != player2_random)
                                {
                                    Console.WriteLine("You must roll from the last number which Player2 gave you. Roll Again");
                                    
                                }
                                else
                                {
                                    if (player1_random == 0)
                                    {
                                        Console.WriteLine("Player2 Won!");

                                    }
                                    break;
                                }                               
                            }
                            break;
                        }

                    }
                
                }







             

            }
           
















            Console.ReadLine();
        }




















    }
}

