using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Room myRoom = Room.Instance;
            myRoom.Enter();
            Room anotherRoom = Room.Instance;

            // Check if both references point to the same instance
            Console.WriteLine("Are both instances the same? " + (myRoom == anotherRoom));
        }
    }
}


