using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using PCLStorage;

using Xamarin.Forms;

namespace ComicViewer
{
    public class SelectFile : ContentPage
    {
        public SelectFile()
        {
            var button1 = new Button
            {
                Text = "Episode 1"
            };
            var button2 = new Button
            {
                Text = "Episode 2"
            };
            var button3 = new Button
            {
                Text = "Episode3"
            };


            button1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1",new[] //Episode1は画像のフォルダ参照先を指定
                {
                    "Screenshot.png",
                    "Screenshot.png"
                }));
            };

            button2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "Screenshot.png",
                    "Screenshot.png",
                    "Screenshot.png",
                    "Screenshot.png"
                }));
            };
            button3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "Screenshot.png",
                    "Screenshot.png",
                    "Screenshot.png",
                    "Screenshot.png",
                    "Screenshot.png",
                    "Screenshot.png"
                }));
            };
            
            Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
                Children = {
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "",
                    },
                    button1,

                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "",
                    },
                    button2,

                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "",
                    },
                    button3,
                   
                }
            };
        }
    }
}