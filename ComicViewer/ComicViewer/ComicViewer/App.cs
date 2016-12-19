using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ComicViewer
{
    public class App : Application
    {                             
        public App()
        {
            // The root page of your application
            var mp = new NavigationPage(new MainMenu())     //MainMenuに画面推移
            {
                Title = "ナビゲーション スタック",
                // ナビゲーションバー TextColor
                BarTextColor = Color.White,
                // ナビゲーションバックグランドバーカラー
                BarBackgroundColor = Color.Black
            };

            // The root page of your application
            MainPage = mp;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}