namespace Altkom._3_5._07._2024.SOLID.L
{
    abstract class Vehicle
    {
        public string Name { get; set; }
        public abstract void Move();
    }

    class Airplane : Vehicle
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }

        public override void Move()
        {
            Fly();
        }
    }

    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("I am driving!");
        }

        public override void Move()
        {
            Drive();
        }
    }

    /*abstract class Vehicle
    {
        public string Name { get; set; }
        public abstract void Fly();
    }

    class Airplane : Vehicle
    {
        public override void Fly()
        {
            Console.WriteLine("I am flying!");
        }
    }

    class Car : Vehicle
    {
        public override void Fly()
        {
        }
    }*/
}
