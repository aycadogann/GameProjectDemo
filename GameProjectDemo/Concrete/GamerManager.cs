using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
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
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("{0} isimli oyuncu eklendi!", gamer.Name);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("{0} isimli oyuncu bilgileri silindi!", gamer.Name);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("{0} isimli oyuncu bilgileri güncellendi!", gamer.Name);
        }
    }
}
