using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class HotelService : IHotelService
    {
        private List<Hotel> hotels = new List<Hotel>() { 
            new Hotel("Guaka", "Paris", new List<Room>() { new Room("120", RoomClass.Economy, 120000), }),
            new Hotel("Romeo", "Paris"),
        };

        public IEnumerable<Hotel> SearchHotels(string location)
        {
            return hotels.Where(h => h.Location == location);
        }
    }
}
