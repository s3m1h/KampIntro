using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidService _userValidService;
        // gamermanager içerisinde bir doğrulama servisi kullanacagımı belirttim
        public GamerManager(IUserValidService userValidService)
        {
            _userValidService = userValidService;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidService.Validation(gamer) == true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız oldu");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Upload(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
