using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class Hotel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Room> Rooms { get; set; }
        public Hotel(string name, string location)
        {
            Name = name;
            Location = location;
            Rooms = new List<Room>();
        }
        public Hotel(string name, string location, List<Room> rooms)
        {
            Name = name;
            Location = location;
            Rooms = rooms;
        }
        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
        public Room FindRoom(string roomNumber)
        {
            return Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
        }
    }
    public class Room
    {
        public string RoomNumber { get; set; }
        public RoomClass RoomClass { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public Room(string roomNumber, RoomClass roomClass, decimal price)
        {
            RoomNumber = roomNumber;
            RoomClass = roomClass;
            Price = price;
            IsAvailable = true;
        }
    }
    public enum RoomClass
    {
        Economy,
        Standard,
        Luxury
    }
}
