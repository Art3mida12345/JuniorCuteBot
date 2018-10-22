using System;

namespace JuniorCuteBot
{
    using Telegram.Bot;
    using Telegram.Bot.Args;

    class Program
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient(Constants.BotToken);

        static void Main(string[] args)
        {
            Bot.OnMessage += Bot_OnMessage;

            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();
        }

        private static void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                if (e.Message.Text == "Hello")
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, $"Hello from JuniorBot");
                else if (e.Message.Text == "Bye")
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, $"Bye from JuniorBot");
            }
        }
    }
}