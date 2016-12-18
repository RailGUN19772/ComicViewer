using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ComicViewer
{
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            var button1 = new Button
            {
                Text = "Select the File",
                HeightRequest = 100,
            };
            var button2 = new Button
            {
                Text = "Config"
            };
            var button3 = new Button
            {
                Text = "About"
            };

            var content = new ContentPage
            {
                Title = "Main Menu",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                }
            };

            button1.Clicked += async (Sender, e) =>
            {

                if (Application.Current.Properties.ContainsKey("sLayout") == false)
                {
                    Application.Current.Properties["sLayout"] = "List";
                    await Navigation.PushAsync(new Ver());
                }
                else if (Application.Current.Properties.ContainsKey("sLayout") == true)
                {
                    var layoutView = Application.Current.Properties["sLayout"] as string;

                    if(layoutView == "List")
                    {
                        await Navigation.PushAsync(new SelectFile());
                    }
                    else if(layoutView == "Block")
                    {
                        await Navigation.PushAsync(new Config());
                    }
                }

            };

            button2.Clicked += async (Sender, e) =>
            {
                await Navigation.PushAsync(new Config());
            };

            button3.Clicked += async (Sender, e) =>
            {
                await Navigation.PushAsync(new Ver());
            };

            Title = "Main Menu";

            var content1 = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,

                Children =
                {
                    button1,
                }
            };

            var content2 = new StackLayout
            {
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                Spacing = 30,
                Children =
                {
                    button2,
                    button3,
                },
            };

            var ver = new StackLayout
            {
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End,
                Children =
                {
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.End,
                        VerticalTextAlignment = TextAlignment.End,
                        Text = "Ver 1.1"
                    },
                },
            };

            Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
                VerticalOptions = LayoutOptions.Center,
                Spacing = 50,
                Children =
                {
                    content1,
                    content2,
                    ver,
                },
            };       
        }
    }
}