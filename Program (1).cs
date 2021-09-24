using System;

namespace tp1
{
    internal class Program
    {
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }

        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var ask);
            return ask;
        }
        
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

        public static void Main(string[] args)
        {
            Console.WriteLine("Which Exercise ?");
            int exercise = Convert.ToInt32(Console.ReadLine());
            
            while (exercise < 1 || exercise > 5)
            {
                Console.WriteLine("Between 1 and 5 !");
                exercise = Convert.ToInt32(Console.ReadLine());
            }
            switch (exercise)
            {
                case 1 : 
                    int i;
                    int t;
                    int result;
                    int rrrr = AskUserForParameter();
                    Console.WriteLine("Multiplication table :" + rrrr);
                    for (t = 1; t <= 10; t++)
                    {
                        result = t * rrrr;
                        Console.WriteLine(t + "*" + rrrr + "=" + result);
                    }
                    break;
                 case 2:
                     int n = AskUserForParameter();
                     while (n > 25)
                     {
                         n = AskUserForParameter();
                     }
                     //1
                     for(i = 1; i <= n; i++)
                     {
                         if (i == 1 || i == 0)
                             continue;
                         int isPrime = 1;
                         for(int j = 2; j <= i / 2; ++j)
                         {
                             if (i % j == 0)
                             {
                                 isPrime = 0;
                                 break;
                             }
                         }
                         if (isPrime == 1)
                             Console.WriteLine(i);
                     }
                     
                     //2
                     int n1 = 0;
                     int n2 = 1;
                     int n3 = 0;
                     
                     Console.WriteLine(n1 + " " + n2 + " ");
                     for (int a = 2; a <= n; a++)
                     {
                         n3 = n1 + n2;
                         Console.Write(n3+" ");
                         n1 = n2;
                         n2 = n3;
                     }
                     
                     //3
                     int fact = 1;
                     for (int b = 1; b <= n; b++)
                     {
                         fact = b * fact;
                         
                     }
                     Console.WriteLine(fact); 
                     break;
                 case 3 :
                     for (int c = -3; c <= 3; c++)
                     {
                         try
                         {
                             int pow = PowerFunction(c);
                             Console.WriteLine(10/pow);
                         }
                         catch (Exception e)
                         {
                             Console.WriteLine(e.Message);
                         }
                     }
                     break;
                 case 4 :
                     Console.WriteLine("Width ?");
                     int width = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("heigth ?");
                     int height = Convert.ToInt32(Console.ReadLine());
                     while (width < 1 || width > 1000 )
                     {
                         Console.WriteLine("Width ?");
                         width = Convert.ToInt32(Console.ReadLine());
                     }
                     while (height < 1 || height > 1000)
                     {
                         Console.WriteLine("heigth ?");
                         height = Convert.ToInt32(Console.ReadLine());
                     }

                     string li = "";
                     li = li + "0";
                     for (int e = 1; e <= width - 2; e++)
                     {
                         li = li + "_";
                     }
                     li = li + "0";
                     Console.WriteLine(li);
                     string l = "|";
                     for (int f = 1; f <= height - 2 ; f++)
                     {
                         for (int g = 1; g <= width - 2; g++)
                         {
                             l = l + " ";
                         }
                         l = l +"|";
                         Console.WriteLine(l);
                         l = "|";
                     }

                     if (height > 1)
                     {
                         string lf = "";
                         lf = lf + "0";
                         for (int h = 1; h <= width - 2; h++)
                         {
                             lf = lf + "_";
                         }
                         lf = lf + "0";
                         Console.WriteLine(lf);
                     }
                     break;
                case 5:
                    Console.WriteLine("Not implemented yet...");
                    break;
            }
            
        }
    }

}
