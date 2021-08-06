using Hook;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace ShowYourKey
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///

    public partial class MainWindow : Window
    {
        Hashtable ksBoxTable = new Hashtable();

        public MainWindow()
        {
            InitializeComponent();

            ksBoxTable.Add(Keys.A, A);
            ksBoxTable.Add(Keys.W, W);
            ksBoxTable.Add(Keys.S, S);
            ksBoxTable.Add(Keys.D, D);
            ksBoxTable.Add(Keys.Z, Z);
            ksBoxTable.Add(Keys.Space, Space);
            ksBoxTable.Add(Keys.F, F);
            ksBoxTable.Add(Keys.J, J);
            ksBoxTable.Add(Keys.K, K);

            KeyboardHook.HookStart();
            MouseHook.HookStart();

            KeyboardHook.KeyDown += (int vkCode) =>
            {
                if (ksBoxTable.ContainsKey((Keys)vkCode))
                {
                    var key = (KeyStatusBox)ksBoxTable[(Keys)vkCode];
                    key.Light();
                }
                return true;
            };

            KeyboardHook.KeyUp += (int vkCode) =>
            {
                if (ksBoxTable.ContainsKey((Keys)vkCode))
                {
                    var key = (KeyStatusBox)ksBoxTable[(Keys)vkCode];
                    key.UnLight();
                }
                return true;
            };

            MouseHook.MouseDown += (MouseEventType type, int x, int y) =>
                {
                    switch (type)
                    {
                        case MouseEventType.LEFT:
                            ML.Light();
                            break;
                        case MouseEventType.RIGHT:
                            MR.Light();
                            break;
                    }
                    return true;
                };

            MouseHook.MouseUp += (MouseEventType type, int x, int y) =>
            {
                switch (type)
                {
                    case MouseEventType.LEFT:
                        ML.UnLight();
                        break;
                    case MouseEventType.RIGHT:
                        MR.UnLight();
                        break;
                }
                return true;
            };
        }


        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
            else if(e.ChangedButton == MouseButton.Right)
            {
                Close();
            }
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
            KeyboardHook.HookEnd();
            MouseHook.HookEnd();
        }
    }
}
