using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ComicViewer
{
    public class SelectFileListView : ContentPage
    {
        public SelectFileListView()
        {
            var prologue = new Image
            {
                //プロローグ
                HeightRequest = 60,
                Source = ImageSource.FromResource("ComicViewer.Image.SelectFileListView.ListView.png"),
            };
            var prologueGR = new TapGestureRecognizer();
            prologue.GestureRecognizers.Add(prologueGR);

            var welcomeKST = new Image
            {
                //KSTへようこそ！
                HeightRequest = 60,
                Source = ImageSource.FromResource("ComicViewer.Image.SelectFileListView.ListView.png"),
            };
            var welcomeKSTGR = new TapGestureRecognizer();
            welcomeKST.GestureRecognizers.Add(welcomeKSTGR);

            var jouhou = new Image
            {
                //情報工学科
                HeightRequest = 60,
                Source = ImageSource.FromResource("ComicViewer.Image.SelectFileListView.ListView.png"),
            };
            var jouhouGR = new TapGestureRecognizer();
            jouhou.GestureRecognizers.Add(jouhouGR);

            var electronics = new Image
            {
                //総合電機科
                HeightRequest = 60,
                Source = ImageSource.FromResource("ComicViewer.Image.SelectFileListView.ListView.png"),
            };
            var electronicsGR = new TapGestureRecognizer();
            electronics.GestureRecognizers.Add(electronicsGR);

            var mechatronics = new Image
            {
                //電子機械科
                HeightRequest = 60,
                Source = ImageSource.FromResource("ComicViewer.Image.SelectFileListView.ListView.png"),
            };
            var mechatronicsGR = new TapGestureRecognizer();
            mechatronics.GestureRecognizers.Add(mechatronicsGR);

            var kensetsu = new Image
            {
                //建設工学科
                HeightRequest = 60,
                Source = ImageSource.FromResource("ComicViewer.Image.SelectFileListView.ListView.png"),
            };
            var kensetsuGR = new TapGestureRecognizer();
            kensetsu.GestureRecognizers.Add(kensetsuGR);

            var design = new Image
            {
                //デザイン科
                HeightRequest = 60,
                Source = ImageSource.FromResource("ComicViewer.Image.SelectFileListView.ListView.png"),
            };
            var designGR = new TapGestureRecognizer();
            design.GestureRecognizers.Add(designGR);

            var science = new Image
            {
                //科学科
                HeightRequest = 60,
                Source = ImageSource.FromResource("ComicViewer.Image.SelectFileListView.ListView.png"),
            };
            var scienceGR = new TapGestureRecognizer();
            science.GestureRecognizers.Add(scienceGR);

            BackgroundImage = "KST.JPG";
            //Android:AndroidResourceとしてResources/drawableに追加
            //iOS:Resourcesにリンクとして追加
            //UWP:プロジェクト直下にリンクとして追加

            Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.End,
                Spacing = 20,
                Children =
                {
                    prologue,
                    welcomeKST,
                    jouhou,
                    electronics,
                    mechatronics,
                    kensetsu,
                    design,
                    science,
                }
            };

            prologueGR.Tapped += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "Screenshot.png",
                    "Screenshot.png"
                }));
            };

            welcomeKSTGR.Tapped += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "Screenshot.png",
                    "Screenshot.png",
                    "Screenshot.png",
                    "Screenshot.png"
                }));
            };
            jouhouGR.Tapped += async (sender, e) =>
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
            electronicsGR.Tapped += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "Screenshot.png",
                    "Screenshot.png",
                    "Screenshot.png",
                    "Screenshot.png"
                }));
            };
            mechatronicsGR.Tapped += async (sender, e) =>
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
            kensetsuGR.Tapped += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "Screenshot.png",
                    "Screenshot.png",
                    "Screenshot.png",
                    "Screenshot.png"
                }));
            };
            designGR.Tapped += async (sender, e) =>
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
            scienceGR.Tapped += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "Screenshot.png",
                    "Screenshot.png",
                    "Screenshot.png",
                    "Screenshot.png"
                }));
            };
        }
    }
}