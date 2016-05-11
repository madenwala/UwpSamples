using Windows.System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Contoso
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ListView_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            var list = sender as ListView;
            if (list?.Items != null && list.Items.Count >= 0)
            {
                if (list.SelectedIndex == 0 && e.Key == VirtualKey.Left)
                {
                    e.Handled = true;
                }
                else if (list.SelectedIndex + 1 == list.Items.Count && e.Key == VirtualKey.Right)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
