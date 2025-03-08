using System.ComponentModel;
using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace MyFirstCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.Beep(); // it beeps
            //Console.Write("No new line!"); // use write to avoid new line at end
            //Console.WriteLine("I proved you ha ha !");
            //Console.WriteLine("write cw and press tab for auto finish the print st");

            //int age = 39;

            //Console.WriteLine("Your age is "+age +" years");

            //constants: immutable values known at compile time and cannot be changed
            //for life of the program

            //const double pi = 3.14159;

            //type casting: converting value to different data type. 
            //C# accepts user input as string.

            /* double a = 34.87;
             int b = Convert.ToInt32(a);
             Console.WriteLine(b);
             Console.WriteLine(a.GetType());

             int c = 12;
             double d = Convert.ToDouble(c)+0.1; // to display the decimal value add a value with decimal
             Console.WriteLine(d);

             int e = 123;
             String f= Convert.ToString(e);
             Console.WriteLine(f);
             Console.WriteLine(f.GetType());

             String g = "$";
             char h = Convert.ToChar(g); 
             Console.WriteLine(h);
             Console.WriteLine(h.GetType());

             String i = "true";
             bool j = Convert.ToBoolean(i);
             Console.WriteLine(j);
             Console.WriteLine(j.GetType());*/

            /* Console.WriteLine("Enter your name: ");
             String name = Console.ReadLine();

             Console.WriteLine("Enter your age: ");
             int age = Convert.ToInt32(Console.ReadLine());


             Console.WriteLine("Hello, " +name +"!");
             Console.WriteLine("You are "+age+ " years old!");*/


            /* Random rand = new Random();

             int Val1= rand.Next(1,21);
             int Val2 = rand.Next(1, 21);
             int Val3 = rand.Next(1, 21);
             double num = rand.NextDouble(); //0.0 to 1.0

             Console.WriteLine(Val1);
             Console.WriteLine(Val2);
             Console.WriteLine(Val3);
             Console.WriteLine(num);*/

            //string methods

            /*String fullName = "Mano Jai";
             String phoneNumber = "123-456-7890";

             Console.WriteLine(fullName.ToUpper());
             Console.WriteLine(fullName.ToLower());
             Console.WriteLine(phoneNumber.Replace("-",""));//old,new
             Console.WriteLine(fullName.Insert(0,"Mrs."));//index,value

             String firstName = fullName.Substring(0,4); //index, length
             String lastName = fullName.Substring(5,3);

             //string property
             Console.WriteLine(fullName.Length);
             Console.WriteLine(firstName);
             Console.WriteLine(lastName);*/

            //Array and foreach

            /*  string[] cars = { "BMW", "Mustang", "corvette" };

              foreach (String car in cars)
              {
                  Console.WriteLine(car);
              }
              for(int i=0;i<cars.Length;i++) { Console.WriteLine(cars[i]); }

              String[] fruits = new String[4];
              fruits[0] = "apple";
              fruits[1] = "orange";
              fruits[2] = "kiwi";
              fruits[3] = "cherry";
              //cannot i++, i-- in foreach. less flexible

              foreach (String fruit in fruits)
              {
                  Console.WriteLine(fruit);
              }*/
            //methods : performs a section of code, when invoked. reuses

            /* Happy("Jai" , 42);//args
             Happy("Subhi",14);
             Happy("Madhav",8);*/


            //Console.WriteLine("Total number of 2 variety flowers: "+ Add_flowers(26,98));


            //method overloading:same name but diff params.
            //signature: name+param. methods should have unique signature
            //Console.WriteLine("Total number of 3 variety flowers: " + Add_flowers(43, 78, 12));

            //params keyword: method param that takes a var # of args, type must be 1d array

            //Console.WriteLine(Checkout(3.99, 7.8, 9.93));

            //Exception: try, catch and finally

            /* try
             {
                 Console.Write("Enter numerator: ");
                 int x = Convert.ToInt32(Console.ReadLine());
                 Console.Write("Enter denominator: ");
                 int y = Convert.ToInt32(Console.ReadLine());
                 int result = x / y;

                 Console.WriteLine("Result: " + result);

             }
             catch (FormatException ex)
             {
                 Console.WriteLine("Enter only numbers!");
             }
             catch (DivideByZeroException ex)
             {
                 Console.WriteLine("cannot be divided by zero!");
             }
             catch (Exception ex)
             {
                 Console.WriteLine("Error occurred!");
             }
             finally { Console.WriteLine("Bye, Take care!"); }*/

            //conditional operator
            //int big = (5 > 2) ? 5 : 2;
            //Console.WriteLine(big);

            //string interpolation: ${}. add spaces by {,10}right aligned {,-10}left aligned

            /* String firstName = "Manohari";
             String lastName = "Jayachandran";
             int age = 39;

             Console.WriteLine($"Hi, I am {firstName} {lastName}. I am {age,10} years old."); */

            //MultiDimensional array

            //String[] ford = { "Mustang", "F-150", "Explorer" };
            //String[] chevy = { "Corvette", "Camaro", "Silverado" };
            //String[] toyota = { "Corolla", "Camry", "Rav4" };

            //array of arrays

            /* String[,] cars = { {"Mustang", "F-150", "Explorer" },
                                 {"Corvette", "Camaro", "Silverado" },
                                 {"Corolla", "Camry", "Rav4"} };

             Console.WriteLine(cars[0,2]);
             cars[0, 2] = "Fusion";
             foreach(String car in cars)
             {
                 Console.WriteLine(car);
             }

             Console.WriteLine($"length of first: {cars.GetLength(0)}. length of 2nd dim: {cars.GetLength(1)}");
             //for grid form
             for(int i=0;i< cars.GetLength(0);i++) //row length dimension
             {
                 for(int j=0;j< cars.GetLength(1); j++) //col length
                 {
                     Console.Write(cars[i,j] + " ");
                 }
                 Console.WriteLine();
             }*/

            // Calling separate class without instantiating
            /*  Messages.Hello(); //static methods
              Messages.Dance();
              Messages.Bye();*/

            /* Human h1 = new Human("Mano", 39); //instantiating a class
             Human h2 = new Human("Jai",42);

             h1.Eat();
             h1.Sleep();


             h2.Eat();
             h2.Sleep();
             Console.WriteLine("Number of human objects are :" + Human.human_count);//static variable*/

            //Overloaded constructors
            /* Pizza p1 = new Pizza("Stuffed crust", "tomato","Mozzarella","Black Olives");
             p1.Delivery();
             Pizza p2 = new Pizza("Stuffed crust", "Garlic", "Mozzarella");
             p2.Delivery();*/

            //Inheritance
            /* Car c = new Car();
             Bicycle b = new Bicycle();
             Boat b2 = new Boat();

             Console.WriteLine(c.speed); 
             Console.WriteLine(c.wheels);
             c.go();*/

            //Abstract : indicates missing components or incomplete implementation
            //Vehicle v = new Vehicle(); //race but someone picks this vehicle... oh oh its incomplete 
            // so stop instantiating by preceding class with abstract


            //Array of objects
            //String[]
            /*Cararr[] garage = new Cararr[3];

            Cararr c1 = new Cararr("Mustang");
            Cararr c2 = new Cararr("Tesla");
            Cararr c3 = new Cararr("Acura");

            garage[0] = c1;
            garage[1] = c2;
            garage[2] = c3;

            foreach(Cararr cars in garage)
            {
                Console.WriteLine(cars.model);
            }

            //array of anonymous obj. no name for objects
            Cararr[] garage2 = { new Cararr("BMW"), new Cararr("Audi"), new Cararr("Benz") };

            foreach (Cararr cars in garage2)
            {
                Console.WriteLine(cars.model);
            }*/

            //object as args
            /* Car1 c = new Car1("Tesla","white");
             //method to change the color of the car
             ChangeColor(c,"red");
             Console.WriteLine(c.model);
             Console.WriteLine(c.color);

             Car1 c2 = Copy(c);
             Car1 c3 = Copy(c2);


             Console.WriteLine(c3.model);
             Console.WriteLine(c3.color);*/

            //method overriding: provides a new version of a method inherited from a parent class
            //inherited method must be abstract, virtual, or already overriddden
            //used with ToString(), Polymorphism

            /* Cat cat = new Cat();
             Dog dog = new Dog();

             cat.Speak();
             dog.Speak();*/

            //ToString() : converts an obj to string representation so that it is suitable for display

            /*Student s1 = new Student("Subhi", 15, "Math");
            Console.WriteLine(s1.ToString()); //MyFirstCsharp.Student
            //it can be overridden by a method in the class
            //Console.WriteLine(s1.ToString()); same as Console.WriteLine(s1); because it automatically calls ToString
            //method which we have overridden in the class
            Console.WriteLine(s1);*/

            //polymorphism: Obj can be identified by more than one type
            //A dog is also, canine, animal, organism

            /* Circle c = new Circle();
             Square s = new Square();
             Triangle t = new Triangle();

             //polymorphism as c,s,t inherits from shape, so we can create array of obj with all 3 for Shape class
             //Shape is the common class inherited by all three
             Shape[] shapes = {c, s, t};

             foreach( Shape sh in shapes)
             {
                 sh.Sides();
             }*/

            //Interface: A contract
            //It declares "what a class should have"
            //An inheriting class defines "how it should do it"
            //Benefit = security+multiple inheritance+"plug and play"

            /* Rabbit r = new Rabbit();
             Hawk h = new Hawk();
             Fish f= new Fish();

             r.Flee();
             h.Hunt();
             f.Flee();
             f.Hunt();*/

            //List: ds that represent a list of objects, can be accessed by index like array
            //but can dynamically increase/decrease in size using System.Collections.Generic
            //Array: no dynamic addition. throws error

            /* String[] food = new string[3];

             food[0] = "Dosa";
             food[1] = "Idli";
             food[2] = "Pongal";
            // food[3] = "Vadai";

             foreach(String item in food)
             {
                 Console.WriteLine(item);
             }

             List<String> fruits = new List<String>();

             fruits.Add("Apple");
             fruits.Add("Banana");
             fruits.Add("Kiwi");
             fruits.Add("Orange");
             //fruits.Add("Blueberry");

             //Console.WriteLine(fruits[0]);
             //fruits.Remove(fruits[3]);

             fruits.Insert(0, "Blueberry");
             Console.WriteLine(fruits.Count);
             Console.WriteLine(fruits.IndexOf("Banana"));
             Console.WriteLine(fruits.LastIndexOf("Blueberry"));
             Console.WriteLine(fruits.Contains("Kiwi"));
             fruits.Sort();
             fruits.Reverse();
             //fruits.Clear();

             foreach (String item in fruits)
             {
                 Console.WriteLine(item);
             }

             //convert list to array
             String[] fruitarr = fruits.ToArray();


             Console.WriteLine("******");
             foreach (String item in fruitarr)
             {
                 Console.WriteLine(item);
             }*/

            //List of objects

            /*List<Player> players = new List<Player>();

            Player p1 = new Player("Jai");
            Player p2 = new Player("Subhi");
            Player p3 = new Player("Madhav");

            players.Add(p1);
            players.Add(p2);
            players.Add(p3);

            //another way to add objects in the list. Anonymous objects
            players.Add(new Player("Mano"));
            players.Add(new Player("Dano"));
            players.Add(new Player("Cano"));
           

            foreach (Player p in players)
            {
               // Console.WriteLine(p.username);
                Console.WriteLine(p);
            }*/

            //getters and setters: add security to fields by encapsulation. they are 
            //accessors found in properties.
            //properties: Combine aspects of both fields and methods(share name with the field)
            //get accessor: used to return the property value 
            //set accessor: used to assign a new value
            //value keyword: defines the value being assigned by the set(param)

            /* Bank bank = new Bank(5000);
             Console.WriteLine(bank.Balance);

             //somebody tampers with the balance:

             bank.Balance = -10;
             Console.WriteLine(bank.Balance);*/

            //Auto Implemented properties: Shortcut when no additional logic is required in the property.
            //no need of field for a property, write get or set  inside the property.

            /* Carprop c = new Carprop("Tesla");
             Console.WriteLine(c.Model);
             c.Model = "Nissan";
             Console.WriteLine(c.Model);*/

            //enums:special class that contains a set of named integer constants
            //use enums when values are not going to change
            //explicit conversion to int if integer value is needed. name = integer

            /* Console.WriteLine(Planets.Pluto + " is a planet!");//returns name not the integer
             //same as the below
             Console.WriteLine(Planets.Pluto.ToString() + " is a planet!");
             Console.WriteLine(Planets.Earth + " is planet #" + (int)Planets.Earth);
             Console.WriteLine("Planet: "+PlanetRadius.Earth);
             Console.WriteLine("Radius: "+(int)PlanetRadius.Earth +" KM");
             Console.WriteLine("Volume: " + Volume(PlanetRadius.Earth) + " KM^3");*/

            //generic: not specific to a particular datatype.
            //add <T> to: classes, methods, fields, .. code reusability

            int[] intarr = { 1, 2, 3 };
            double[] doublearr = { 1.1, 2.2, 3.3 };
            String[] stringarr = { "one", "two", "three" };

            
            display(intarr); 
            display(doublearr); 
            display(stringarr);



            Console.ReadKey(); //to avoid unwanted text in the output window

        }

        public static void display<T>(T[] arr)
        {
            foreach(T item in arr )
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

        }

        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
        //obj as args
        public static void ChangeColor(Car1 c, String color)
        {
            c.color = color;
        }
        //return an obj

        public static Car1 Copy(Car1 c)
        {
            return new Car1(c.model, c.color);
        }

        //methods

        //to avoid repeating overloaded methos use param keyword
       /* static double Checkout(double a)
        {
            return a;
        }
        static double Checkout(double a, double b)
        {
            return a + b;
        }*/

        static double Checkout(params double[] prices)
        {
            double total = 0;

            foreach(double price in prices)
            {
                total += price;
            }
            return total;


        }
        static void Happy(String name, int age)//parameter
        {
            Console.WriteLine("Happy Birthday to You!");
            Console.WriteLine("Happy Birthday to You!");
            Console.WriteLine("Happy Birthday dear "+name);
            Console.WriteLine("You are "+age+" years old!");
            Console.WriteLine("Happy Birthday to You!");
            Console.WriteLine();
        }

        static int Add_flowers(int daisy,int roses)
        {
            return (daisy+roses);
        }

        static int Add_flowers(int daisy, int roses,int lily)
        {
            Console.WriteLine("3 args:");
            return (daisy + roses+lily);

        }
    }
    //blueprint to create objects
    //created a separate file for this class in this project
  /*  class Messages
    {
        void Hello()
        {
            Console.WriteLine("Hello");
        }
        void Dance()
        {
            Console.WriteLine("Dance with me!!");
        }
        void Bye()
        {
            Console.WriteLine("Thank you!");
        }

    }*/

    //object creation:

   /* class Human
    {
        public String name;
        public int age;
        public static int human_count=0;

        public Human(String name, int age)
        {
            this.name = name;
            this.age = age;
            human_count++;
        }
        public void Eat()
        {
            Console.WriteLine(name + " is eating!");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping!");
        }
    }*/

    //Overloaded constructors: unique signature: name+param. same name diff param

    class Pizza
    {
        String bread, sauce, cheese, topping;
        public Pizza(String bread, String sauce, String cheese, String topping )
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;

        }
        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }

        public void Delivery()
        {
            if (topping != null)
            {
                Console.WriteLine($"Here is your pizza with {sauce} sauce on {bread} and {cheese} cheese with {topping} ");
            }
            else
            {
                Console.WriteLine($"Here is your pizza with {sauce} sauce on {bread} and {cheese} cheese");

            }
        }
    }
//Inheriance and abstract classes
    abstract class Vehicle
    {
        public int speed = 0;
        public void go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }

    class Car: Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
       
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }

    //array of obj
    class Cararr
    {
        public String model;

        public Cararr(String model)
        {
            this.model = model;
        }
    }

    //obj as arg

    class Car1
    {
        public String model;
        public String color;

        public Car1(String model, String color) 
        {
            this.model=model;
            this.color = color;
        }
    }

    //Method Overriding:
    //virtual or abstract
    abstract class Animal 
    {
        public abstract void Speak();//class also should be abstract and should not have a body
        
    }

   /* class Animal
    {
        public virtual void Speak()
        {
            //Console.WriteLine("brrrrr...");
        }

    }*/
    class  Dog: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Woooooof...");
        }

    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meowwwwwwwww...");
        }

    }

    class Student
    {
        String name;
        int age;
        String subject;

        public Student(string name, int age, string subject)
        {
            this.name = name;
            this.age = age;
            this.subject = subject;
        }

        public override String ToString()
        {
            //return base.ToString();
            String sentence = $"I am {name}. I am {age} years old. I love {subject} subject";
            return sentence; 
        }
    }

    class Shape
    {
        public virtual void Sides()
        {
            Console.WriteLine("Shapes have n number of sides");
        }

    }
    class Circle: Shape
    {
        public override void Sides()
        {
            Console.WriteLine("Circle has 0 sides");
        }

    }

    class Square : Shape
    {
        public override void Sides()
        {
            Console.WriteLine("Square has 4 sides");
        }
    }
    class Triangle : Shape
    {
        public override void Sides()
        {
            Console.WriteLine("Triangle has 3 sides");
        }
    }

    interface IPrey
    {
        void Flee();
    }
    interface IPredator
    {
        void Hunt();
    }

    //if inherits from interface it has to implement all methods!
    class Rabbit: IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away!");
        }

    }

    class Hawk: IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The Hawk hunts the prey!");
        }

    }

    class Fish: IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The Fish swims away!");
        }
        public void Hunt()
        {
            Console.WriteLine("The Fish hunts the prey!");
        }


    }

    class Player
    {
        public String username;

        public Player(string username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return "Name of the player is "+username;
        }
        
    }

    class Bank
    {
        private float balance;
        public Bank(float balance)
        {
            Balance = balance;
        }

        //add a property. capitalise the field name

        public float Balance
        {
            get { return balance; }
            //add condition to avoid bad values
            //value keyword hold the value passed
            
            set {
                if(value<100)
                {
                    balance = 100;
                }
                else
                {
                    balance = value;
                }
                 }
        }
    }

    class Carprop
    {
        /*String model;

        public String Model
        {
            get { return model; }
            set { Model = model; }
        }*/

        //same as the above
        //use this when there is no additional logic!

        public String Model { get; set; }
        
        public Carprop(String model)
        {
            this.Model = model;
        }
    }

    enum Planets
    {
        //starts from 0 if not specified explicitly
        Mercury=1,
        Venus, 
        Earth,
        Mars, 
        Jupiter, 
        Saturn, 
        Uranus, 
        Neptune, 
        Pluto
    }
    enum PlanetRadius
    {
        //starts from 0 if not specified explicitly
        Mercury = 2439,
        Venus = 6051,
        Earth=6371,
        Mars=3389,
        Jupiter=69911,
        Saturn=58232,
        Uranus=25362,
        Neptune=24622,
        Pluto=1188
    }

}
