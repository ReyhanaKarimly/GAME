using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAMELibrary;

namespace GAME
{
 
    class Program
    {
       

      

        public void Fight(List<Soldier> l1, List<Soldier> l2,List<int>A1,List<int>A2)
        {
            double Army1 = 0;
            double Army2 = 0;



            for (int i = 0; i < l1.Count(); i++)
            {

                Army1 += (l1[i].GetPower()*A1[i]);
            }

            for (int i = 0; i < l2.Count(); i++)
            {
                Army2 += (l2[i].GetPower()*A2[i]);

            }


      
            double FightRes = Army1 - Army2;

            if (FightRes > 0)
            {
                foreach (var item in l1)
                {
                    item.SetRating(1);

                }
                foreach (var item in l2)
                {

                    item.SetRating(-1);
                }
            }
            else
            {
                foreach (var item in l1)
                {
                    item.SetRating(-1);

                }
                foreach (var item in l2)
                {

                    item.SetRating(1);
                }

            }


            Console.WriteLine("_____________________________");
            Console.WriteLine("Fight Results: ");

            if (FightRes == 0)
                Console.WriteLine( "Draw");
            else if (FightRes > 0)
                Console.WriteLine("Army1 wins!");
            else Console.WriteLine("Army2 wins!");
        }
        static void Main(string[] args)
        {
            
    


        Rider knight = new Knight(10, 5);

            Rider elephant = new Elephant(20, 3);

            Soldier archer = new Archer(5, 4);

            Soldier templar = new Templar(9, 5);

            List<string> L = new List<string>();
            List<Soldier> L2 = new List<Soldier>();
            L.Add("knight");
            L.Add("elephant");
            L.Add("archer");
            L.Add("templar");

            L2.Add(knight);
            L2.Add(elephant);
            L2.Add(archer);
            L2.Add(templar);
            Console.WriteLine("soldier type            power            rating");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0,-25}{1,-20}{2}",L[i],L2[i].GetPower(),L2[i].GetRating());

            }




            List<Soldier> Army1 = new List<Soldier>();
            List<Soldier> Army2 = new List<Soldier>();

            List<int> Ar1 = new List<int>();
            List<int> Ar2 = new List<int>();

           
          
      
          
            Console.WriteLine("Enter the number of soldier-types in Army1: ");
            int type1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter soldier-types of Army1 and their number, respectively: knight, templar, archer, elephant");
            for (int i = 0; i < type1; i++)
            {
                 string Fighter1 = Console.ReadLine();
                int SoldierNum1 = int.Parse(Console.ReadLine());
                
                  Ar1.Add(SoldierNum1);
                switch (Fighter1)
                {
                    case "knight": Army1.Add(knight); break;
                    case "archer": Army1.Add(archer); break;
                    case "templar": Army1.Add(templar); break;
                    case "elephant": Army1.Add(elephant); break;

                    default:
                        break;
                }

            }
            Console.WriteLine("Enter the number of soldier-types in Army2: ");
            int type2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter soldier-types of Army2 and their number, respectively: knight, templar, archer, elephant");
            
            for (int i = 0; i <type2; i++)
            {
                String Fighter2 = Console.ReadLine();
                int SoldierNum2 = int.Parse(Console.ReadLine());
                Ar2.Add(SoldierNum2);
                switch (Fighter2)
            {
                case "knight": Army2.Add(knight); break;
                case "archer": Army2.Add(archer); break;
                case "templar": Army2.Add(templar); break;
                case "elephant": Army2.Add(elephant); break;

                default:
                    break;
            }

            }





           
                Program p = new Program();
                p.Fight(Army1, Army2,Ar1,Ar2);
            
           

            Console.ReadKey();
        }

       
    }
}
