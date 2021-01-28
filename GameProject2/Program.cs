using System;

namespace GameProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidManager());
            Gamer gamer = new Gamer() {
                Id = 5,
                FirstName = "semih",
                LastName ="acar",
            };
            gamerManager.Add(gamer);
            
        }
    }
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
    class Gamer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public string BirthYear { get; set; }

    }
    class GamerManager : IGamerService
    {
        IUserValidService _userValidService;

        public GamerManager(IUserValidService userValidService)
        {
            _userValidService = userValidService;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidService.IsValid(gamer) == true)
            {
                Console.WriteLine("Kayıt Eklendi...");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi...");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi...");
        }
    }

    interface IUserValidService
    {
        bool IsValid(Gamer gamer);
    }

    class UserValidManager : IUserValidService
    {
        public bool IsValid(Gamer gamer)
        {
            if(gamer.Id == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
