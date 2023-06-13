using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrate
{
    internal class GamerManager : IGamerService, ISaleService
    {
        UserValidationManager _userValidationManager;

        public GamerManager(UserValidationManager userValidationManager)
        {
            _userValidationManager = userValidationManager;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationManager.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu kaydedildi.");
            }
            else
            {
                Console.WriteLine("Oyuncu doğrulaması hatalı kaydetme işlemi başarısız.");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi.");
        }

        public void Sale(Gamer gamer)
        {
            Console.WriteLine("Oyun satışı tamamlandı.");
        }
    }
}
