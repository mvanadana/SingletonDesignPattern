using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Room myRoom = Room.GetInstance();

            myRoom.Enter();

            Room anotherRoom = Room.GetInstance();
            
            Console.WriteLine("Are both instances the same? " + (myRoom == anotherRoom));
        }
    }
}


