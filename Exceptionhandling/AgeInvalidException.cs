namespace Exceptionhandling
{
    public class AgeInvalidException : Exception
    {
        public AgeInvalidException()
        {

        }
        public AgeInvalidException(string massage) : base(massage)
        {

        }
    }

        public class Program
        {
            public static void Main(String[] args)
            {
                Console.WriteLine("Enter age :");
                int age = int.Parse(Console.ReadLine());
                try 
                {
                    if (age >= 18)
                    {
                        Console.WriteLine(" Valid ");
                    }
                    else
                    {

                        throw new AgeInvalidException("Invalid age " + age);
                        Console.WriteLine("Invalid age enter");

                        //Console.WriteLine("InValid "+age);
                    }
                }
                catch (AgeInvalidException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }


                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }

    }
    

