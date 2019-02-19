﻿namespace WeatherBotv4App.Models
{
    public class Message
    {
        public string Text { get; set; }
        public string User { get; set; }

        public Message(string text, string user)
        {
            Text = text;
            User = user;
        }
    }
}
