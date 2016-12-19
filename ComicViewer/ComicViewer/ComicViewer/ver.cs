using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ComicViewer
{
    public class Ver : ContentPage
    {
        public Ver()
        {
            //変更内容の段落は半角８個分
            string ver1_0 = "16/11/30 Ver1.0 Release\n16/12/12\n";
            string ver1_1 = "16/12/12 Ver1.1 更新内容\n"+
                            "        ソースコード及び内部処理の簡略化\n"+
                            "        Aboutの追加\n"+
                            "        ボタン配置の変更及びサイズの調整\n";
            string ver1_2 = "16/12/18 Ver1.2 更新内容\n"+
                            "        エピソードページの表示切替の実装\n"+
                            "        エピソードページのデザインの修正\n"+
                            "        メインページのデザインの修正、画像の追加\n";

            StackLayout stackLayout = new StackLayout
            {
                Spacing = 30,
                Children = {
                    new Label
                    { Text = "このアプリについて\n" + ver1_0 + ver1_1 + ver1_2 },
                    new Label
                    { Text = "動作確認端末及び環境\n"+
                             "SONY XPERIA Z5 Android6.0\n"+
                             "HUAWEI Media PAD 7 Lite Android4.0.3\n"+
                             "\nWindows10 AnniversaryUpdate"}
                }
            };

            Content = new ScrollView
            {
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
                BackgroundColor = Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = stackLayout,
            };
        }
    }
}