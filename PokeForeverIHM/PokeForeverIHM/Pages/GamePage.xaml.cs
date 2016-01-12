using PokeForeverIHM.UsersControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using PokeForeverIHM.Class;

namespace PokeForeverIHM
{
	public sealed partial class GamePage : Page
	{
		TranslateTransform MenuPanelTranslate = new TranslateTransform();
		Player player = Player.Instance;
		private bool isLeftFoot = false;

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
			// Used to close the menu panel
			menuPanel.Visibility = Visibility.Collapsed;
			
			// Cast the sender to a button to retrieve its name
			Button btn = (Button)sender;
			switch (btn.Name)
			{
				case "ButtonMoveTop":
					if (isLeftFoot)
					{
						player.SetImage = $"ms-appx:///Assets/Player/player_right_foot_top.png";
						isLeftFoot = false;
					}
					else
					{
						player.SetImage = $"ms-appx:///Assets/Player/player_left_foot_top.png";
						isLeftFoot = true;
					}
					break;
				case "ButtonMoveBottom":
					if (isLeftFoot)
					{
						player.SetImage = $"ms-appx:///Assets/Player/player_right_foot_bottom.png";
						isLeftFoot = false;
					}
					else
					{
						player.SetImage = $"ms-appx:///Assets/Player/player_left_foot_bottom.png";
						isLeftFoot = true;
					}
					break;
				case "ButtonMoveLeft":
					if (isLeftFoot)
					{
						player.SetImage = $"ms-appx:///Assets/Player/player_right_foot_left.png";
						isLeftFoot = false;
					}
					else
					{
						player.SetImage = $"ms-appx:///Assets/Player/player_left_foot_left.png";
						isLeftFoot = true;
					}
					break;
				case "ButtonMoveRight":
					if (isLeftFoot)
					{
						player.SetImage = $"ms-appx:///Assets/Player/player_right_foot_right.png";
						isLeftFoot = false;
					}
					else
					{
						player.SetImage = $"ms-appx:///Assets/Player/player_left_foot_right.png";
						isLeftFoot = true;
					}
					break;
			}

			
		}
	}
}
