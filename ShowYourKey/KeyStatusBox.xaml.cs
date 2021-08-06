using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShowYourKey
{
    /// <summary>
    /// KeyStatusBox.xaml 的交互逻辑
    /// </summary>
    public partial class KeyStatusBox : UserControl
    {
        public int Time = 150;
        public double DefaultAlpha = 0;

        public KeyStatusBox()
        {
            InitializeComponent();

            grid.Background = new SolidColorBrush(Colors.White);
            grid.Background.Opacity = DefaultAlpha;
        }

        public string Text
        {
            get
            {
                return (string)label.Content;
            }
            set
            {
                label.Content = value;
            }
        }

        public void Light()
        {
            var alphaAnimation = new DoubleAnimation
            {
                From = grid.Background.Opacity,
                To = 1,
                Duration = TimeSpan.FromMilliseconds(Time),
                EasingFunction = new SineEase()
                {
                    EasingMode = EasingMode.EaseOut,
                },
            };

            grid.Background.BeginAnimation(SolidColorBrush.OpacityProperty, alphaAnimation);
        }

        public void UnLight()
        {
            var alphaAnimation = new DoubleAnimation
            {
                From = grid.Background.Opacity,
                To = DefaultAlpha,
                Duration = TimeSpan.FromMilliseconds(Time),
                EasingFunction = new SineEase()
                {
                    EasingMode = EasingMode.EaseOut,
                },
            };

            grid.Background.BeginAnimation(SolidColorBrush.OpacityProperty, alphaAnimation);
        }
    }
}
