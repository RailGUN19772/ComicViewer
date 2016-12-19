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
            var selectFile = new Button
            {
                Text = "Select the File",
                HeightRequest = 100,
            };

            var config = new Button
            {
                Text = "Config"
            };

            var about = new Button
            {
                Text = "About"
            };

            var content1 = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    selectFile,
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
                    config,
                    about,
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
                        Text = "Ver 1.2"
                    },
                },
            };
            BackgroundImage = "KST.JPG";
            //Android:AndroidResourceとしてResources/drawableに追加
            //iOS:Resourcesにリンクとして追加
            //UWP:プロジェクト直下にリンクとして追加

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
                    //BackGroundImage,
                },
            };

            selectFile.Clicked += async (Sender, e) =>
            {

                if (Application.Current.Properties.ContainsKey("sLayout") == false)
                {
                    Application.Current.Properties["sLayout"] = "List";
                    await Navigation.PushAsync(new SelectFileListView());
                }

                else if (Application.Current.Properties.ContainsKey("sLayout") == true)
                {
                    var layoutView = Application.Current.Properties["sLayout"] as string;

                    if(layoutView == "List")
                    {
                        await Navigation.PushAsync(new SelectFileListView());
                    }
                    else if(layoutView == "Block")
                    {
                        await Navigation.PushAsync(new SelectFileBlockView());
                    }
                }

            };

            config.Clicked += async (Sender, e) =>
            {
                await Navigation.PushAsync(new Config());
            };

            about.Clicked += async (Sender, e) =>
            {
                await Navigation.PushAsync(new Ver());
            };      
        }
    }
}