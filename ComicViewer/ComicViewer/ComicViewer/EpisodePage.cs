using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ComicViewer
{
    public class EpisodePage : ContentPage
    {
        public EpisodePage(string episodeName,string[] files)
        {
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
                        
            StackLayout stackLayout = new StackLayout
            {
                Spacing = 0,
                Orientation = StackOrientation.Vertical,
            };

            foreach (var s in files)
                stackLayout.Children.Add(new Image
                {
                    Source = ImageSource.FromResource($"ComicViewer.EpisodeImage.{episodeName}.{s}")
                });

            ScrollView scrollView = new ScrollView
            {
                BackgroundColor = Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = stackLayout,
            };


            Content = scrollView;
        }
    }
}