using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    internal interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
