using System;
using System.Collections.Generic;
using System.Text;

namespace demo173
{
    public class Pattern
    {
        public void NoPattern1()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i % 2 == 0)
                        Console.Write("0");
                    else
                        Console.Write("1");

                }
                Console.WriteLine();
            }
        }

        public void NoPattern2()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    int result = j % 2;
                    Console.Write(result);
                }
                Console.WriteLine();
            }
        }


        public void NoPattern3()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    int result = (i == 1 || i == 5 || j == 1 || j == 5) ? 1 : 0;
                    Console.Write(result);
                }
                Console.WriteLine();
            }
        } 


        public void NoPattern4()
        {
            for(int i=1;i<=5; i++)
            {
                for( int j=1;j<=5; j++)
                {
                    int res = (i==3&&j==3)? 0:1;
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }

        
        public void NoPattern5()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    int res =(( i + j )% 2==0)?1:0;
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }


        public void NoPattern6()
        {
            for (int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    int res= (i==3||j==3)? 0:1;
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }
        public void NoPattern7()
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    int res =( i == j || i + j == 6) ? 1:0;
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }


        public void NoPattern8()
        {
            for( int i=1;i<=5; i++)
            {
                for(int j=1;j<=5;j++)
                {
                    int res= (i==1||i==5 || j==1||j==5) &&(i+j!=6 && i!=j)? 1:0;
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }


        public void NoPattern9()
        {
            for(int i=1;i<=5;i++)
            {
                for (int j=1;j<=5; j++)
                {
                    int res = i;
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }


        public void NoPattern10()
        {
            for ( int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    int res = j;
                    Console.Write(res);
                }
                Console.WriteLine();
            }
        }


        public void NoPattern11()
        {
            for(int i=1;i<=5;i++)
            {
                int n = i;
                for(int j=1;j<=5;j++)
                {
                    Console.Write(n);
                    n++;
                }
                Console.WriteLine();
            }
        }


        public void NoPattern12()
        {
            int n = 1;
            for (int i = 1; i <= 5; i++)
                
            {
                for( int j = 1;j<=5;j++)
                {
                   
                    Console.Write(n);
                    n++;
                }
                Console.WriteLine();
            }

        }


        public void NoPattern13()
        {
            for(int i=5;i>=1;i--)
            {
                for (int j=5;j>=i; j--)
                {
                    Console.Write(j); 
                }
                for(int k=1;k<i;k++)
                {
                    Console.Write(i); 
                }
                Console.WriteLine();
            }

        }


        public void NoPattern14()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(j);
                }
                for (int k=1;k<i; k++)
                {
                    Console.Write(5); 
                }
                Console.WriteLine();
            }

        }

        //------------------------------------------------

        public void NoPattern15()
        {
            for (int i = 1; i <= 5; i++)
            {
                int n = 1;
                for (int j = 5;j>=i;j--)
                {
                    Console.Write(n);
                    n++;
                }
                int m = i - 1;
                for (int k=1; k <i; k++)
                {
                    Console.Write(m);
                    m--;
                }
                Console.WriteLine();
            }

        }
//-------------------------------------------------------------

        
        public void NoPattern16()
        {
            for (int i=1;i<=5; i++)
            {
                int n = i;
                for (int j=1;j<=i;j++)
                {
                    Console.Write(n);
                    n--;
                }
                int m = 2;
                for (int k=5;k>i;k--)
                {
                    Console.Write(m);
                    m++;
                }
                Console.WriteLine();
            }
        }


        public void NoPattern19()
        {
            for (int i=1;i<=5;i++)
            {
                for (int j=1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }



        public void NoPattern20()
        {
            for (int i = 5; i >=1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }





        //---------------------------------------22---------------
        public void NoPattern22()
        {
            for(int i=5;i>=1;i--)
            {
                for(int j=5;j>=i;j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine() ;
            }
        }



        public void NoPattern23()
        {
          for (int i=1;i<=5;i++)
          {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j); 
                }
                Console.WriteLine();
          }
        }


        public void NoPattern24()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

        }

    }
}
