using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorBattle.Client.Services
{
    public class BananaService : IBananaService
    {
        public event Action OnChange;
        public int Bananas { get; set; } = 1000;

        public void EatBananas(int amount)
        {
            Console.WriteLine("## BananaService EatBananas");
            Bananas -= amount;
            //BananasChanged();

            /*
             * 바뀌었다는걸 알려주기
             */
            OnChange.Invoke();
        }

        public void AddBananas(int amount)
        {
            Console.WriteLine("## BananaService AddBananas");
            Bananas += amount;
            //BananasChanged();

            /*
             * 바뀌었다는걸 알려주기
             */
            OnChange.Invoke();
        }
    }
}
