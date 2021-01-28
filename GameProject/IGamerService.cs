using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Upload(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
