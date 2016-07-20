using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeForeverIHM.Class;
using PokeForeverIHM.UsersControls;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace PokeForeverIHM.ViewModel
{
	class PlayerViewModel
	{
		private GamePage myGamePageView;
		private Player player = Player.Instance;
		private const double deltaDisplacement = 20D;
		private bool isLeftFoot = false;
		private VirtualKey lastArrowKeyTriggered;
		TranslateTransform MenuPanelTranslate = new TranslateTransform();
		public PlayerViewModel(GamePage myGamePageView)
		{
			this.myGamePageView = myGamePageView;
			this.myGamePageView.myUCImgCharacter.DataContext = player;
			this.myGamePageView.myUCImgCharacter.Source = player.ImageStopDown;
			this.myGamePageView.myUCButtonMoveBottom.Holding += DirectionalCross_Holding;
			this.myGamePageView.myUCButtonMoveLeft.Holding += DirectionalCross_Holding;
			this.myGamePageView.myUCButtonMoveRight.Holding += DirectionalCross_Holding;
			this.myGamePageView.myUCButtonMoveTop.Holding += DirectionalCross_Holding;
			this.myGamePageView.myUCButtonMoveBottom.PointerPressed += DirectionalCross_PointerPressed;
			this.myGamePageView.myUCButtonMoveLeft.PointerPressed += DirectionalCross_PointerPressed;
			this.myGamePageView.myUCButtonMoveRight.PointerPressed += DirectionalCross_PointerPressed;
			this.myGamePageView.myUCButtonMoveTop.PointerPressed += DirectionalCross_PointerPressed;
			Window.Current.Content.KeyDown += Arrow_KeyDown;
			Window.Current.Content.KeyUp += Arrow_KeyUp;
			SQLiteTest();
		}

		private void SQLiteTest()
		{
			MySQLite.SQLiteManager<Player> managerPlayer = new MySQLite.SQLiteManager<Player>();
			managerPlayer.Insert(Player.Instance);
			var result = managerPlayer.Get<Player>(1);
		}

		#region KeyboardMoves
		private void ChangeAssets(object sender)
		{
			// Used to close the menu panel
			myGamePageView.myUCMenuPanel.Visibility = Visibility.Collapsed;
			// Cast the sender to a DirectionalCross to retrieve its name
			DirectionalCross btn = (DirectionalCross)sender;
			switch (btn.Name)
			{
				case "ButtonMoveTop":
					MoveUp();
					break;
				case "ButtonMoveBottom":
					MoveDown();
					break;
				case "ButtonMoveLeft":
					MoveLeft();
					break;
				case "ButtonMoveRight":
					MoveRight();
					break;
			}
		}

		private void Arrow_KeyUp(object sender, KeyRoutedEventArgs e)
		{
			switch (lastArrowKeyTriggered)
			{
				case VirtualKey.Up:
					myGamePageView.myUCImgCharacter.Source = player.ImageStopUp;
					break;
				case VirtualKey.Down:
					myGamePageView.myUCImgCharacter.Source = player.ImageStopDown;
					break;
				case VirtualKey.Left:
					myGamePageView.myUCImgCharacter.Source = player.ImageStopLeft;
					break;
				case VirtualKey.Right:
					myGamePageView.myUCImgCharacter.Source = player.ImageStopRight;
					break;
			}
		}

		private void Arrow_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
		{
			Task.Delay(10).Wait();
			switch (e.Key)
			{
				case VirtualKey.GamepadLeftThumbstickUp:
				case VirtualKey.Up:
					MoveUp();
					lastArrowKeyTriggered = VirtualKey.Up;
					break;
				case VirtualKey.GamepadLeftThumbstickDown:
				case VirtualKey.Down:
					MoveDown();
					lastArrowKeyTriggered = VirtualKey.Down;
					break;
				case VirtualKey.GamepadLeftThumbstickLeft:
				case VirtualKey.Left:
					MoveLeft();
					lastArrowKeyTriggered = VirtualKey.Left;
					break;
				case VirtualKey.GamepadLeftThumbstickRight:
				case VirtualKey.Right:
					MoveRight();
					lastArrowKeyTriggered = VirtualKey.Right;
					break;
			}
		}


		private void MoveUp()
		{
			if (isLeftFoot)
			{
				myGamePageView.myUCImgCharacter.Source = player.ImageMoveUpRightFoot;
				isLeftFoot = false;
			}
			else
			{
				myGamePageView.myUCImgCharacter.Source = player.ImageMoveUpLeftFoot;
				isLeftFoot = true;
			}
			if (myGamePageView.myUCGridMap.Margin.Top < -1500)
			{
				if (myGamePageView.myUCImgCharacter.Margin.Top == 0)
				{
					myGamePageView.myUCGridMap.Margin = new Thickness(myGamePageView.myUCGridMap.Margin.Left, myGamePageView.myUCGridMap.Margin.Top + deltaDisplacement, myGamePageView.myUCGridMap.Margin.Right, myGamePageView.myUCGridMap.Margin.Bottom - deltaDisplacement);
				}
				else
				{
					myGamePageView.myUCImgCharacter.Margin = new Thickness(myGamePageView.myUCImgCharacter.Margin.Left, myGamePageView.myUCImgCharacter.Margin.Top - deltaDisplacement, myGamePageView.myUCImgCharacter.Margin.Right, myGamePageView.myUCImgCharacter.Margin.Bottom + deltaDisplacement);
				}
			}
			else
			{
				if (myGamePageView.myUCImgCharacter.Margin.Top > -(Window.Current.Bounds.Height / 2) + myGamePageView.myUCImgCharacter.Height + 24)
				{
					myGamePageView.myUCImgCharacter.Margin = new Thickness(myGamePageView.myUCImgCharacter.Margin.Left, myGamePageView.myUCImgCharacter.Margin.Top - deltaDisplacement, myGamePageView.myUCImgCharacter.Margin.Right, myGamePageView.myUCImgCharacter.Margin.Bottom + deltaDisplacement);
				}
			}
		}

		private void MoveDown()
		{
			if (isLeftFoot)
			{
				myGamePageView.myUCImgCharacter.Source = player.ImageMoveDownRightFoot;
				isLeftFoot = false;
			}
			else
			{
				myGamePageView.myUCImgCharacter.Source = player.ImageMoveDownLeftFoot;
				isLeftFoot = true;
			}
			if (myGamePageView.myUCGridMap.Margin.Bottom < -1580D)
			{
				if (myGamePageView.myUCImgCharacter.Margin.Bottom == 0)
				{
					myGamePageView.myUCGridMap.Margin = new Thickness(myGamePageView.myUCGridMap.Margin.Left, myGamePageView.myUCGridMap.Margin.Top - deltaDisplacement, myGamePageView.myUCGridMap.Margin.Right, myGamePageView.myUCGridMap.Margin.Bottom + deltaDisplacement);
				}
				else
				{
					myGamePageView.myUCImgCharacter.Margin = new Thickness(myGamePageView.myUCImgCharacter.Margin.Left, myGamePageView.myUCImgCharacter.Margin.Top + deltaDisplacement, myGamePageView.myUCImgCharacter.Margin.Right, myGamePageView.myUCImgCharacter.Margin.Bottom - deltaDisplacement);
				}
			}
			else
			{
				if (myGamePageView.myUCImgCharacter.Margin.Bottom > -(Window.Current.Bounds.Height / 2) + myGamePageView.myUCImgCharacter.Height + 24)
				{
					myGamePageView.myUCImgCharacter.Margin = new Thickness(myGamePageView.myUCImgCharacter.Margin.Left, myGamePageView.myUCImgCharacter.Margin.Top + deltaDisplacement, myGamePageView.myUCImgCharacter.Margin.Right, myGamePageView.myUCImgCharacter.Margin.Bottom - deltaDisplacement);
				}
			}
		}

		private void MoveLeft()
		{
			if (isLeftFoot)
			{
				myGamePageView.myUCImgCharacter.Source = player.ImageMoveLeftRightFoot;
				isLeftFoot = false;
			}
			else
			{
				myGamePageView.myUCImgCharacter.Source = player.ImageMoveLeftLeftFoot;
				isLeftFoot = true;
			}
			if (myGamePageView.myUCGridMap.Margin.Left < -2880D)
			{
				if (myGamePageView.myUCImgCharacter.Margin.Left == 0)
				{
					myGamePageView.myUCGridMap.Margin = new Thickness(myGamePageView.myUCGridMap.Margin.Left + deltaDisplacement, myGamePageView.myUCGridMap.Margin.Top, myGamePageView.myUCGridMap.Margin.Right - deltaDisplacement, myGamePageView.myUCGridMap.Margin.Bottom);
				}

				else
				{
					myGamePageView.myUCImgCharacter.Margin = new Thickness(myGamePageView.myUCImgCharacter.Margin.Left - deltaDisplacement, myGamePageView.myUCImgCharacter.Margin.Top, myGamePageView.myUCImgCharacter.Margin.Right + deltaDisplacement, myGamePageView.myUCImgCharacter.Margin.Bottom);
				}
			}
			else
			{
				if (myGamePageView.myUCImgCharacter.Margin.Left > -(Window.Current.Bounds.Width / 2) + (myGamePageView.myUCImgCharacter.Width / 2))
				{
					myGamePageView.myUCImgCharacter.Margin = new Thickness(myGamePageView.myUCImgCharacter.Margin.Left - deltaDisplacement, myGamePageView.myUCImgCharacter.Margin.Top, myGamePageView.myUCImgCharacter.Margin.Right + deltaDisplacement, myGamePageView.myUCImgCharacter.Margin.Bottom);
				}
			}
		}

		private void MoveRight()
		{
			if (isLeftFoot)
			{
				myGamePageView.myUCImgCharacter.Source = player.ImageMoveRightRightFoot;
				isLeftFoot = false;
			}
			else
			{
				myGamePageView.myUCImgCharacter.Source = player.ImageMoveRightLeftFoot;
				isLeftFoot = true;
			}
			if (myGamePageView.myUCGridMap.Margin.Right < -2880D)
			{
				if (myGamePageView.myUCImgCharacter.Margin.Right == 0)
				{
					myGamePageView.myUCGridMap.Margin = new Thickness(myGamePageView.myUCGridMap.Margin.Left - deltaDisplacement, myGamePageView.myUCGridMap.Margin.Top, myGamePageView.myUCGridMap.Margin.Right + deltaDisplacement, myGamePageView.myUCGridMap.Margin.Bottom);
				}
				else
				{
					myGamePageView.myUCImgCharacter.Margin = new Thickness(myGamePageView.myUCImgCharacter.Margin.Left + deltaDisplacement, myGamePageView.myUCImgCharacter.Margin.Top, myGamePageView.myUCImgCharacter.Margin.Right - deltaDisplacement, myGamePageView.myUCImgCharacter.Margin.Bottom);
				}
			}
			else
			{
				if (myGamePageView.myUCImgCharacter.Margin.Right > -(Window.Current.Bounds.Width / 2) + (myGamePageView.myUCImgCharacter.Width / 2))
				{
					myGamePageView.myUCImgCharacter.Margin = new Thickness(myGamePageView.myUCImgCharacter.Margin.Left + deltaDisplacement, myGamePageView.myUCImgCharacter.Margin.Top, myGamePageView.myUCImgCharacter.Margin.Right - deltaDisplacement, myGamePageView.myUCImgCharacter.Margin.Bottom);
				}
			}
		}
		#endregion


		#region FingerMoves
		private void DirectionalCross_Holding(object sender, Windows.UI.Xaml.Input.HoldingRoutedEventArgs e)
		{
			ChangeAssets(sender);
		}
		#endregion

		#region MouseMoves
		private void DirectionalCross_PointerPressed(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
		{
			ChangeAssets(sender);
		}
		#endregion
	}
}
