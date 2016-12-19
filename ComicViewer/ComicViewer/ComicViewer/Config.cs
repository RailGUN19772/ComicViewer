using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ComicViewer
{
    public partial class Config : ContentPage
    {
        public Config()
        {
            var buttonConfig = new Button
            {
                HeightRequest = 60,
                WidthRequest = 80,
                Text = "Change",
            };

            string vm = Application.Current.Properties["sLayout"] as string;

            var viewMode = new Label
            {
                Text = "現在の表示："+vm,
            };

            Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
                Children =
                {
                    new Label
                    {
                        Text = "エピソード表示の変更"
                    },
                    viewMode,
                    buttonConfig,
                },
            };

            buttonConfig.Clicked += (sender, e) =>
            {
                if (Application.Current.Properties.ContainsKey("sLayout") == true)
                {
                    var layoutView = Application.Current.Properties["sLayout"] as string;

                    if (layoutView == "List")
                    {
                        Application.Current.Properties.Clear();
                        Application.Current.Properties["sLayout"] = "Block";
                    }
                    else if (layoutView == "Block")
                    {
                        Application.Current.Properties.Clear();
                        Application.Current.Properties["sLayout"] = "List";
                    }
                }           
            };
        }
    }
}
