using System;
namespace Singleton
{
    public class Room
    {
        private static Room instance;
        private Room()
        {
            Console.WriteLine("Room instance created.");
        }
        public static Room GetInstance()
        {
                if (instance == null)
                {
                    instance = new Room();
                }
                return instance;
        }
        
        public void Enter()
        {
            Console.WriteLine("Someone entered the room.");
        }
    }
}
