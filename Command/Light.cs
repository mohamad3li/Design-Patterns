using System;

namespace Command
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light On");
        }

        public void Off()
        {
            Console.WriteLine("Light Off");
        }

        public void Up()
        {
            Console.WriteLine("Light Up");
        }

        public void Down()
        {
            Console.WriteLine("Light Down");
        }
    }
}