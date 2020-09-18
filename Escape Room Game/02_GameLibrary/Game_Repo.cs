using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GameLibrary
{
    public class Game_Repo
    {   // this will hold the itmes in the list
        private Player01 _playerPocket = new Player01();

        // ** CRUD **

        // ----- CREATE -----
        // create new item and add to list (how to add an exisiting item to list??)
        public void AddItemToPocket(string item)
        {
            _playerPocket.PlayerPocket.Add(item); // item is a parameter of Player01 so how do we add other items to Player01 List?? whatever we call item is added to list
        }

        // ----- READ -----
        public List<string> ListAllPocketItems()
        {
            return _playerPocket.PlayerPocket;
        }

    }
}
