using Q42.HueApi.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q42.HueApi.Interfaces;
using Q42.HueApi;

namespace HueConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      MainAsync(args).Wait();
    }
    static async Task MainAsync(string[] args)
    {
      IBridgeLocator locator = new SSDPBridgeLocator();

      var bridgeIPs = await locator.LocateBridgesAsync(TimeSpan.FromSeconds(60));
      foreach (var item in bridgeIPs)
      {
        Console.WriteLine(item.BridgeId);
      }

      //ILocalHueClient client = new LocalHueClient("192.168.178.56");
      ////var appKey = await client.RegisterAsync("srnux", "srnuxWin10");//already registered
      
      //client.Initialize("haKfNfJfRQqyRvdHO-2ub-u2Cp9jGKI7nExNquM1");// (appKey);
      //var command = new LightCommand();
      //command.On = true;
      //command.Alert = Alert.Multiple;
      //await client.SendCommandAsync(command,new List<string>{ "1" });

    }
  }
}
