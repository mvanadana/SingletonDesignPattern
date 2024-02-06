using System;
namespace Singleton
{
    public class Room
    {
        private static Room instance;

        // Private constructor to prevent instantiation from outside the class
        private Room()
        {
            Console.WriteLine("Room instance created.");
        }

        public static Room getInstance()
        {
            get
            {
                // Create the instance if it doesn't exist
                if (instance == null)
                {
                    instance = new Room();
                }
                return instance;
            }
        }
        public void Enter()
        {
            Console.WriteLine("Someone entered the room.");
        }
    }
}
