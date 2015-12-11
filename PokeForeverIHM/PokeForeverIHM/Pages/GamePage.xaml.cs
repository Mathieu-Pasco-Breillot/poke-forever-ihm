using PokeForeverIHM.UsersControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace PokeForeverIHM
{
	public sealed partial class GamePage : Page
	{
		TranslateTransform MenuPanelTranslate = new TranslateTransform();

		public GamePage()
		{
			InitializeComponent();
		}

		private void MenuButton_Click(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
		{
			menuPanel.Visibility = Visibility.Visible;
		}

		private void Map_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
		{
			menuPanel.Visibility = Visibility.Collapsed;
		}

		private void DirectionalCross_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
		{
			menuPanel.Visibility = Visibility.Collapsed;
		}
	}
}
