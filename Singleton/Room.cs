using System;
namespace Singleton
{
    public class Room
    {
        // Private static instance variable
        private static Room instance;

        // Private constructor to prevent instantiation from outside the class
        private Room()
        {
            Console.WriteLine("Room instance created.");
        }

        // Public method to get the singleton instance
        public static Room Instance
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

        // Other methods and properties of the Room class can be added here
        public void Enter()
        {
            Console.WriteLine("Someone entered the room.");
        }
    }
}