using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;


namespace KingBot
{
    class Program
    {
        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {

            var client = new DiscordClient();
            await client.Connect(PrivateKey.Token, TokenType.Bot);
            Console.ReadLine();
            await client.Disconnect();




        }

    }
}
