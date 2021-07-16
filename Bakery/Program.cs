using System;
using BakedGoods.Models;

namespace BakedGoods
{
  public class Program
  {
    public static void Main()
    {
      Greeting();
      int theBread = OrderSomeBread();
      int thePastry = OrderPastry();
      Receipt(theBread, thePastry);

    }


    public static void Greeting()
    {
      Console.WriteLine("Hello and Welcome to Pierre's Bakery!!!");
      Console.WriteLine("  _______");
      Console.WriteLine(" /       )");
      Console.WriteLine("/_____   |");
      Console.WriteLine("(  '   ) / ");
      Console.WriteLine(" |.  '| /");
      Console.WriteLine(" |____|/");
      Console.WriteLine("     ____                                    ?~~bL");
      Console.WriteLine("    z@~ b                                    |  `U,");
      Console.WriteLine("   ]@[  |                                   ]'   z@'");
      Console.WriteLine("  d@~' `|, .__     _----L___----, __, .  _t'      `@j");
      Console.WriteLine("  `@L_,      - ~-~-a,            C.  ~'UO          OO");
      Console.WriteLine("    q@~'   ]P       ]@[              `Y=,    `H+z_ `a@");
      Console.WriteLine("     `@L  _z@        d@                 Ya      `-@b,_a'");
      Console.WriteLine("      `-@d@a'        )@[                 `VL      `a@@'");
      Console.WriteLine("        aa~'       ],.a@'                 qqL  ), ./~");
      Console.WriteLine("          @@_  _z~  _d@[                 .V@  .L_d'");
      Console.WriteLine("          ~OOO  OOO                 __)@n @bza@-");
      Console.WriteLine("            `-@zzz@@@L        )@@z     ]@@=%-");
      Console.WriteLine("              *~~@@@@@bz_    _a@@@@z___a@K");
      Console.WriteLine("                   ~-@@@@@@@@@@@@@@@@@@~");
      Console.WriteLine("                    `~~~-@~~-@@~~~~~'");
      Console.WriteLine("                          (             )                           ");
      Console.WriteLine("                  )      (*)           (*)      (                   ");
      Console.WriteLine("                 (*)      |             |      (*)                  ");
      Console.WriteLine("                  |      |~|           |~|      |                   ");
      Console.WriteLine("                 |~|     | |           | |     |~|                  ");
      Console.WriteLine("                 | |     | |           | |     | |                  ");
      Console.WriteLine("                ,| |a@@@@| |@@@@@@@@@@@| |@@@@a| |.                 ");
      Console.WriteLine("           .,a@@@| |@@@@@| |@@@@@@@@@@@| |@@@@@| |@@@@a,.           ");
      Console.WriteLine("         ,a@@@@@@| |@@@@@@@@@@@@.@@@@@@@@@@@@@@| |@@@@@@@a,         ");
      Console.WriteLine("        a@@@@@@@@@@@@@@@@@@@@@' . `@@@@@@@@@@@@@@@@@@@@@@@@a        ");
      Console.WriteLine("        ;`@@@@@@@@@@@@@@@@@@'   .   `@@@@@@@@@@@@@@@@@@@@@';        ");
      Console.WriteLine("        ;@@@`@@@@@@@@@@@@@'     .     `@@@@@@@@@@@@@@@@'@@@;        ");
      Console.WriteLine("        ;@@@;,.aaaaaaaaaa       .       aaaaa,,aaaaaaa,;@@@;        ");
      Console.WriteLine("        ;;@;;;;@@@@@@@@;@      @.@      ;@@@;;;@@@@@@;;;;@@;        ");
      Console.WriteLine("        ;;;;;;;@@@@;@@;;@    @@ . @@    ;;@;;;;@@;@@@;;;;;;;        ");
      Console.WriteLine("        ;;;;;;;;@@;;;;;;;  @@   .   @@  ;;;;;;;;;;;@@;;;;@;;        ");
      Console.WriteLine("        ;;;;;;;;;;;;;;;;;@@     .     @@;;;;;;;;;;;;;;;;@@a;        ");
      Console.WriteLine("    ,%%%;;;;;;;;@;;;;;;;;       .       ;;;;;;;;;;;;;;;;@@;;%%%,    ");
      Console.WriteLine(" .%%%%%%;;;;;;;a@;;;;;;;;     ,%%%,     ;;;;;;;;;;;;;;;;;;;;%%%%%%, ");
      Console.WriteLine(".%%%%%%%;;;;;;;@@;;;;;;;;   ,%%%%%%%,   ;;;;;;;;;;;;;;;;;;;;%%%%%%%,");
      Console.WriteLine("%%%%%%%%`;;;;;;;;;;;;;;;;  %%%%%%%%%%%  ;;;;;;;;;;;;;;;;;;;'%%%%%%%%");
      Console.WriteLine("%%%%%%%%%%%%`;;;;;;;;;;;;,%%%%%%%%%%%%%,;;;;;;;;;;;;;;;'%%%%%%%%%%%%");
      Console.WriteLine("`%%%%%%%%%%%%%%%%%,,,,,,,%%%%%%%%%%%%%%%,,,,,,,%%%%%%%%%%%%%%%%%%%%'");
      Console.WriteLine("  `%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%'  ");
      Console.WriteLine("      `%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%'      ");
      Console.WriteLine("             $$$$$$$$$$$$$$`,,,,,,,,,'$$$$$$$$$$$$$$$$$             ");
      Console.WriteLine("                            `%%%%%%%'                               ");
      Console.WriteLine("                             `%%%%%'                                ");
      Console.WriteLine("                               %%%                                  ");
      Console.WriteLine("                              %%%%%                                 ");
      Console.WriteLine("                           .,%%%%%%%,.                              ");
      Console.WriteLine("                      ,%%%%%%%%%%%%%%%%%%%,                         ");
      Console.WriteLine("          ---------------------------------------------             ");
      Console.WriteLine("We have a few specials to offer today!");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Pastries are $2 each, or 3 for $5!!");
      Console.WriteLine("and bread is $5 a loaf, or BUY 2 GET 1 FREE!!!");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }

    public static int OrderSomeBread()
    {
      Bread breadOrder = new Bread();
      Console.WriteLine("Please enter the amount of bread you would like to purchase:");
      int loaves = int.Parse(Console.ReadLine());
      Console.WriteLine("Got it! " + loaves + " loaf/loaves added to order!");
      breadOrder.BreadCost(loaves);
      int breadTotal = breadOrder.PriceOfBread;
      return breadTotal;
    }
    public static int OrderPastry()
    {
      Pastry pastryOrder = new Pastry();
      Console.WriteLine("Please enter the amount of pastry you would like to purchase:");
      int pastries = int.Parse(Console.ReadLine());
      Console.WriteLine("Got it! " + pastries + " pastries added to order!");
      pastryOrder.PastryCost(pastries);
      int pastryTotal = pastryOrder.PriceOfPastry;
      return pastryTotal;
    }
    public static void Receipt(int breadTotal, int pastryTotal)
    {
      Console.WriteLine("Thanks for stopping by!");
      Console.WriteLine("Your order total will be: $" + breadTotal + pastryTotal);
      Console.WriteLine("We hope you enjoy these DELICIOUS TREATS!!!");
      Console.WriteLine("Have a SWEET day!!!");
      Console.WriteLine("           (          ");
      Console.WriteLine("           )          ");
      Console.WriteLine("      __..---..__     ");
      Console.WriteLine("  ,-='  /  |  /  `=-. ");
      Console.WriteLine(" :--..___________..--;");
      Console.WriteLine("  (,,_____________,./ ");
    }





  }
}