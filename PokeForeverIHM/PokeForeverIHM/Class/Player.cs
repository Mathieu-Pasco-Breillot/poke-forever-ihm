using System;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace PokeForeverIHM.Class
{
	public class Player
	{
		private static Player instance;
		private string name;
		ImageSource imageStopDown, imageStopUp, imageStopLeft, imageStopRight, imageMoveDownLeftFoot, imageMoveDownRightFoot, imageMoveUpLeftFoot, imageMoveUpRightFoot, imageMoveLeftLeftFoot, imageMoveLeftRightFoot, imageMoveRightLeftFoot, imageMoveRightRightFoot;

		private Player()
		{
			SetImageStopDown = $"ms-appx:///Assets/Player/player_stop_bottom.png";
			SetImageStopUp = $"ms-appx:///Assets/Player/player_stop_top.png";
			SetImageStopLeft = $"ms-appx:///Assets/Player/player_stop_left.png";
			SetImageStopRight = $"ms-appx:///Assets/Player/player_stop_right.png";
			SetImageMoveDownLeftFoot = $"ms-appx:///Assets/Player/player_left_foot_bottom.png";
			SetImageMoveDownRightFoot = $"ms-appx:///Assets/Player/player_right_foot_bottom.png";
			SetImageMoveLeftLeftFoot = $"ms-appx:///Assets/Player/player_left_foot_left.png";
			SetImageMoveLeftRightFoot = $"ms-appx:///Assets/Player/player_right_foot_left.png";
			SetImageMoveRightLeftFoot = $"ms-appx:///Assets/Player/player_left_foot_right.png";
			SetImageMoveRightRightFoot = $"ms-appx:///Assets/Player/player_right_foot_right.png";
			SetImageMoveUpLeftFoot = $"ms-appx:///Assets/Player/player_left_foot_top.png";
			SetImageMoveUpRightFoot = $"ms-appx:///Assets/Player/player_right_foot_top.png";
		}

		public static Player Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Player();
				}
				return instance;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}

			set
			{
				name = value;
			}
		}

		public ImageSource ImageStopDown
		{
			get
			{
				return imageStopDown;
			}
		}
		private string SetImageStopDown
		{
			set
			{
				imageStopDown = new BitmapImage(new Uri(value));
			}
		}

		public ImageSource ImageStopUp
		{
			get
			{
				return imageStopUp;
			}
		}
		private string SetImageStopUp
		{
			set
			{
				this.imageStopUp = new BitmapImage(new Uri(value));
			}
		}

		public ImageSource ImageStopLeft
		{
			get
			{
				return imageStopLeft;
			}
		}
		private string SetImageStopLeft
		{
			set
			{
				this.imageStopLeft = new BitmapImage(new Uri(value));
			}
		}

		public ImageSource ImageStopRight
		{
			get
			{
				return imageStopRight;
			}
		}
		private string SetImageStopRight
		{

			set
			{
				this.imageStopRight = new BitmapImage(new Uri(value));
			}
		}

		public ImageSource ImageMoveDownLeftFoot
		{
			get
			{
				return imageMoveDownLeftFoot;
			}
		}
		private string SetImageMoveDownLeftFoot
		{
			set
			{
				this.imageMoveDownLeftFoot = new BitmapImage(new Uri(value));
			}
		}

		public ImageSource ImageMoveDownRightFoot
		{
			get
			{
				return imageMoveDownRightFoot;
			}
		}
		private string SetImageMoveDownRightFoot
		{
			set
			{
				this.imageMoveDownRightFoot = new BitmapImage(new Uri(value));
			}
		}

		public ImageSource ImageMoveUpLeftFoot
		{
			get
			{
				return imageMoveUpLeftFoot;
			}
		}
		private string SetImageMoveUpLeftFoot
		{
			set
			{
				this.imageMoveUpLeftFoot = new BitmapImage(new Uri(value));
			}
		}

		public ImageSource ImageMoveUpRightFoot
		{
			get
			{
				return imageMoveUpRightFoot;
			}
		}
		private string SetImageMoveUpRightFoot
		{
			set
			{
				this.imageMoveUpRightFoot = new BitmapImage(new Uri(value));
			}
		}

		public ImageSource ImageMoveLeftLeftFoot
		{
			get
			{
				return imageMoveLeftLeftFoot;
			}

		}
		private string SetImageMoveLeftLeftFoot
		{
			set
			{
				this.imageMoveLeftLeftFoot = new BitmapImage(new Uri(value));
			}
		}

		public ImageSource ImageMoveLeftRightFoot
		{
			get
			{
				return imageMoveLeftRightFoot;
			}
		}
		private string SetImageMoveLeftRightFoot
		{
			set
			{
				this.imageMoveLeftRightFoot = new BitmapImage(new Uri(value));
			}
		}

		public ImageSource ImageMoveRightLeftFoot
		{
			get
			{
				return imageMoveRightLeftFoot;
			}
		}
		private string SetImageMoveRightLeftFoot
		{
			set
			{
				this.imageMoveRightLeftFoot = new BitmapImage(new Uri(value));
			}
		}

		public ImageSource ImageMoveRightRightFoot
		{
			get
			{
				return imageMoveRightRightFoot;
			}
		}
		private string SetImageMoveRightRightFoot
		{
			set
			{
				this.imageMoveRightRightFoot = new BitmapImage(new Uri(value));
			}
		}
	}
}
