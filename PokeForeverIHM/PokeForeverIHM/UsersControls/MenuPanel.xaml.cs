using PokeForeverIHM.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace PokeForeverIHM.UsersControls
{
    public sealed partial class MenuPanel : UserControl
    {
        TranslateTransform MenuPanelTransform = new TranslateTransform();
        public MenuPanel()
        {
            this.InitializeComponent();
        }

        private void MapButton_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Orange);
            ((Frame)Window.Current.Content).Navigate(typeof(Map));
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame maPage = ((Frame)Window.Current.Content);
            Page p = maPage.Content as Page;
            if (p.Name.Equals("gamePage"))
            {
                foreach(MenuPanel mp in FindVisualChildren<MenuPanel>(p))
                {
                    mp.Visibility = Visibility.Collapsed;
                    if (mp.FocusState.Equals(1)){
                        mp.Focus(FocusState.Unfocused);
                    }
                    if (mp.FocusState.Equals(1))
                    {
                        mp.Focus(FocusState.Unfocused);
                    }
                }
            } else
            {
                ((Frame)Window.Current.Content).Navigate(typeof(GamePage));
            }
        }

        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
        private void StockButton_Click(object sender, RoutedEventArgs e)
        {
            //((Frame)Window.Current.Content).Navigate(typeof(Store));
        }

        private void PokeButton_Click(object sender, RoutedEventArgs e)
        {
            ((Frame)Window.Current.Content).Navigate(typeof(Pokedex));
        }

        private void ParamButton_Click(object sender, RoutedEventArgs e)
        {
            //((Frame)Window.Current.Content).Navigate(typeof(Parameters));
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //((Frame)Window.Current.Content).Navigate(typeof(Save));
        }
    }
}
