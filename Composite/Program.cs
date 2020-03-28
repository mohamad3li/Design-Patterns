using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Housing building = new Housing("6a Mahmoudia");
            Housing floor = new Housing("6a Mahmoudia - 3rd floor");
            int floorIndex = building.AddStructure(floor);

            Room livingRoom = new Room("Living");
            Room kitchen = new Room("Kitchen");
            Room bedroom = new Room("Bedroom");

            int livingIndex = floor.AddStructure(livingRoom);
            int kitchenIndex = floor.AddStructure(kitchen);
            int bedroomIndex = floor.AddStructure(bedroom);

            building.Enter();

            Housing currentFloor = (Housing)building.GetStructure(floorIndex);
            currentFloor.Enter();
            Room currentRoom = (Room)currentFloor.GetStructure(livingIndex);
            currentRoom.Enter();
            currentRoom.Exit();

             currentRoom = (Room)currentFloor.GetStructure(kitchenIndex);
            currentRoom.Enter();
            currentRoom.Exit();

            currentRoom = (Room)currentFloor.GetStructure(bedroomIndex);
            currentRoom.Enter();
            currentRoom.Exit();

            currentFloor.Exit();
            building.Exit();

            Console.ReadKey();

        }
    }
}
