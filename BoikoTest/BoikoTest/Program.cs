using System;
using System.Threading.Tasks;
using TestBoiko;
using TestBoiko.Models;

namespace BoikoTest
{
    class Program
    {
        static async Task Main()
        {
            while (true)
            {
                var command = InputHeandler.Handle();

                switch (command)
                {
                    case ActionType.Open:
                        var shop = await RestApiClient.Instance.Get("http://tester.consimple.pro");
                        PrintShop(shop);
                        break;

                    case ActionType.Exit:
                        return;
                };
            }
        }

        private static void PrintShop(Shop shop)
        {
            new PrinterShop().PrinInTable(shop);
        }
    }
}
