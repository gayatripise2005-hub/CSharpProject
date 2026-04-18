using System;
using System.Text;

class car
{
    //public int age;
    //public string name;

    //public static void Main(string[] args)
    //{
    //    Program P = new Program();
    //    P.age = 21;
    //    P.name = "gayatri";
    //    Console.WriteLine(P.age );
    //    Console.WriteLine(P.name );
    //}


    //public int carId;
    //public string carName;
    //public int  carSpeed;

    //public static void Main(string[] args)
    //{
    //    car e = new car();
    //    e.carId = 1;
    //    e.carName ="Thar";
    //    e.carSpeed =40;
    //    Console.WriteLine(e.carId);
    //    Console.WriteLine(e.carName);   
    //    Console.WriteLine(e.carSpeed);  


    //class A
    //{
    //    public string name;
    //    public int value;
    //}
    //class B : A
    //{
    //    public int id;
    //    public string name;
    //}
    //class program
    //{
    //    public static void Main(string[] args)
    //    {
    //        B git = new B();

    //        Console.WriteLine(git.name = "gayatri");
    //        Console.WriteLine(git.value = 2);
    //        Console.WriteLine(git.id = 1);
    //        Console.WriteLine(git.name = "maithili");
    //    }
  //  }

    sealed class Animal
    {
        public string animalSound;
        public string animalColor;
    }
    class Dog:Animal
    {
        public string dogColor;
        public string dogSound;
    }
    class program
    {
        public static void Main(string[] args)
        {
            Dog d=new Dog();
            d.dogColor = "black";
            d.dogSound = "barke";
            Console.WriteLine($"{d}dogColor  \n {d}dogSound");
        }
    }
}
    
      