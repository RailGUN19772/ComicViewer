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
            Content = new StackLayout
            {
                Spacing = 30,
                Children = {
                    new Label
                    { Text = "このアプリについて\n16/12/01 Ver1.0 Release\n16/12/12 Ver1.1 更新内容\n    ソースコード及び内部処理の簡略化\n    Aboutの追加\n    ボタン配置の変更及びサイズの調整" },
                    new Label
                    { Text = "動作確認端末及び環境\nSONY XPERIA Z5 Android6.0\nHUAWEI Media PAD 7 Lite Android4.0.3\n\nWindows10 AnniversaryUpdate"}
                }
            };
        }
    }
}
