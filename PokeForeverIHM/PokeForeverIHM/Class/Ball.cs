using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace PokeForeverIHM.Class
{
	public class Ball
	{
		private ushort lvlMin = 1, lvlMax = 99;
		private ushort powerCapture, quantity;
		private ImageSource image;
		private static ObservableCollection<Ball> balls;

		public ushort PowerCapture
		{
			get
			{
				return powerCapture;
			}

			set
			{
				powerCapture = value;
			}
		}

		public ushort Quantity
		{
			get
			{
				return quantity;
			}

			set
			{
				quantity = value;
			}
		}

		public ushort LvlMin
		{
			get
			{
				return lvlMin;
			}

			set
			{
				lvlMin = value;
			}
		}

		public ushort LvlMax
		{
			get
			{
				return lvlMax;
			}

			set
			{
				lvlMax = value;
			}
		}

		public string SetImage
		{
			set
			{
				image = new BitmapImage(new Uri(value));
			}
		}

		public ImageSource GetImage
		{
			get
			{
				return image;
			}
		}

		public static ObservableCollection<Ball> Balls
		{
			get
			{
				if (balls == null)
				{
					balls = new ObservableCollection<Ball>();
					balls.Add(new Ball(BallType.Pokeball));
					balls.Add(new Ball(BallType.SuperBall));
					balls.Add(new Ball(BallType.HyperBall));
					balls.Add(new Ball(BallType.MasterBall));
					balls.Add(new Ball(BallType.SafariBall));
				}
				return balls;
			}

			set
			{
				balls = value;
			}
		}

		public Ball(BallType type)
		{
			switch (type)
			{
				case BallType.Pokeball:
					PowerCapture = 1;
					LvlMax = 33;
					SetImage = "ms-appx:///Assets/Balls/pokeball.png";
					break;
				case BallType.SuperBall:
					PowerCapture = 2;
					LvlMax = 66;
					SetImage = "ms-appx:///Assets/Balls/superball.png";
					break;
				case BallType.HyperBall:
					PowerCapture = 3;
					SetImage = "ms-appx:///Assets/Balls/hyperball.png";
					break;
				case BallType.MasterBall:
					PowerCapture = 1000;
					SetImage = "ms-appx:///Assets/Balls/masterball.png";
					break;
				case BallType.SafariBall:
					PowerCapture = 1;
					SetImage = "ms-appx:///Assets/Balls/safariball.png";
					break;
			}
		}

	}
}
