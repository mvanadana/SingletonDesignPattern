using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Room myRoom = Room.getInstance();

            myRoom.Enter();

            Room anotherRoom = Room.getInstance();
            
            Console.WriteLine("Are both instances the same? " + (myRoom == anotherRoom));
        }
    }
}


