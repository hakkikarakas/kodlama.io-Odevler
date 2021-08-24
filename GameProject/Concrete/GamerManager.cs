using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.Check(gamer))
            {
                Console.WriteLine("Correct" + gamer.UserName+ ":Added");
            }
            else
            {
                Console.WriteLine("Not added");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName+" Deleted");
        }

        public void Update(Gamer gamer)
        {
            if (_gamerCheckService.Check(gamer))
            {
                Console.WriteLine("Correct "+gamer.UserName + " Updated");
            }
            else
            {
                Console.WriteLine("Not updated");
            }
        }
    }
}
