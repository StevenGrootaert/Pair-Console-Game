using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GameLibrary
{
    public class Player01
    {
        public string Player01Name { get; set; }
        public Player01() { }
        public Player01(string playerName)
        {
            Player01Name = playerName;
        }
        public List<String> PlayerPocket { get; set; }
        //add constructors for these? 
    }

    public class Room01
    {
        public string Room01Name { get; set; }
        // does the room need a list? or an enum with all the items in that room that can be added to the list? 
    }


}
