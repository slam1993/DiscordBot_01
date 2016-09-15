using Discord;
using System;

namespace DiscordBot_01
{
    public class DiscordBot
    {
        private DiscordClient bot;
        private Random randomNumberGenerator;

        public DiscordBot()
        {
            bot = new DiscordClient();
            randomNumberGenerator = new Random();

            bot.ExecuteAndWait(async () =>
            {
                bot.MessageReceived += Bot_MessageReceived;

                await bot.Connect("simonlam123@aol.com", "jasonjofung");
            });
        }

        private void Bot_MessageReceived(object sender, MessageEventArgs e)
        {
            if (e.Message.IsAuthor) return;            

            switch (e.Message.Text.ToLower())
            {
                case "!help":
                    ListCommands(e);
                    break;
                case "!hi":
                    e.Channel.SendMessage("Hello there, " + e.User.Mention + ". How are you today?");
                    break;
                case "!rank":
                    e.Channel.SendMessage("SleepyBear's rank:  Wood 5 Division");
                    break;
                case "!rolldice":
                    e.Channel.SendMessage(randomNumberGenerator.Next(1, 7).ToString());
                    break;
                case "!whois":
                    e.Channel.SendMessage("I am SleepyBear's discord bot.");
                    break;
            }
        }

        private void ListCommands(MessageEventArgs e)
        {
            string commands = "!help, !hi, !rank, !rolldice, !whois";
            e.Channel.SendMessage(commands);
        }
    }
}
