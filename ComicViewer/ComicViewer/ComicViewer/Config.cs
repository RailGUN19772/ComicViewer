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

            var stackLayout = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "エピソード表示の変更"
                    },
                    buttonConfig,
                },
            };

            Content = stackLayout;

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
