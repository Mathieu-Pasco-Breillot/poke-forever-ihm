using PokeForeverIHM.Pages;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using PokeForeverIHM.Class;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace PokeForeverIHM.UsersControls
{
	public sealed partial class MenuPanel : UserControl
	{
		TranslateTransform MenuPanelTransform = new TranslateTransform();
		public MenuPanel()
		{
			InitializeComponent();
		}

		private void PokeButton_Tapped(object sender, TappedRoutedEventArgs e)
		{
			((Frame)Window.Current.Content).Navigate(typeof(Pokedex));
		}

		private void MapButton_Tapped(object sender, TappedRoutedEventArgs e)
		{
			((Frame)Window.Current.Content).Navigate(typeof(Map));
		}

		private void QuitButton_Tapped(object sender, TappedRoutedEventArgs e)
		{
			Application.Current.Exit();
		}

		private void BackButton_Tapped(object sender, TappedRoutedEventArgs e)
		{
			Frame maPage = ((Frame)Window.Current.Content);
			Page p = maPage.Content as Page;
			if (p.Name.Equals("gamePage"))
			{
				foreach (MenuPanel mp in HelperFunctions.FindVisualChildren<MenuPanel>(p))
				{
					mp.Visibility = Visibility.Collapsed;
				}
			}
			else
			{
				((Frame)Window.Current.Content).Navigate(typeof(GamePage));
			}
		}
	}
}
