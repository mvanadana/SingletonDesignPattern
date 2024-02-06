using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the room instance
            Room myRoom = Room.Instance;

            // Call a method on the room instance
            myRoom.Enter();

            // Try to create another instance (will get the existing one)
            Room anotherRoom = Room.Instance;

            // Check if both references point to the same instance
            Console.WriteLine("Are both instances the same? " + (myRoom == anotherRoom));
        }
    }
}


