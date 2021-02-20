using System;

namespace Oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson player1 = new Player() { FirstName = "Yusuf", LastName = "Çıra", DateOfBirth = new DateTime(2001, 05, 29)
                , NationalityId = "2432412", PlayerId = 1319 };

            PlayerManager playerManager = new PlayerManager();
            
            SellingManager sellingManager = new SellingManager();
            
            CampaignManager campaignManager = new CampaignManager();

            playerManager.Add(player1);
            sellingManager.SellTo(player1);
            campaignManager.Add(player1);

        }
    }
}
