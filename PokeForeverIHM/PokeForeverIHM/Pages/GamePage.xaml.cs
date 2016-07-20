using PokeForeverIHM.UsersControls;
using Windows.UI.Xaml.Media;
using PokeForeverIHM.Class;
using PokeForeverIHM.ViewModel;
using Microsoft.Azure.Engagement.Overlay;
using Windows.UI.Xaml.Controls;

namespace PokeForeverIHM
{
	/// <summary>
	/// The main view of the game, when the player is walking on the world
	/// </summary>
	public sealed partial class GamePage : EngagementPageOverlay
	{
		/// <summary>
		/// The GamePage view model
		/// </summary>
		private GamePageViewModel gamePageViewModel;
		/// <summary>
		/// The Player view model
		/// </summary>
		private PlayerViewModel playerViewModel;
		/// <summary>
		/// Menu Panel object
		/// </summary>
		public MenuPanel myUCMenuPanel { get; set; }
		/// <summary>
		/// The button to show or hide the menu panel
		/// </summary>
		public MenuButton myUCMenuButton { get; set; }
		/// <summary>
		/// Player asset
		/// </summary>
		public Image myUCImgCharacter { get; set; }
		/// <summary>
		/// The entire map
		/// </summary>
		public Grid myUCGridMap { get; set; }
		/// <summary>
		/// The top button of the directionnal cross
		/// </summary>
		public DirectionalCross myUCButtonMoveTop { get; set; }
		/// <summary>
		/// The left button of the directionnal cross
		/// </summary>
		public DirectionalCross myUCButtonMoveLeft { get; set; }
		/// <summary>
		/// The right button of the directionnal cross
		/// </summary>
		public DirectionalCross myUCButtonMoveRight { get; set; }
		/// <summary>
		/// The bottom button of the directionnal cross
		/// </summary>
		public DirectionalCross myUCButtonMoveBottom { get; set; }

		/// <summary>
		/// Constructor of the view which is passing itself to view models
		/// </summary>
		public GamePage()
		{
			InitializeComponent();
			this.myUCImgCharacter = this.XAMLImgCharacter;
			this.myUCMenuPanel = this.XAMLMenuPanel;
			this.myUCGridMap = this.XAMLGridMap;
			this.myUCButtonMoveTop = this.XAMLButtonMoveTop;
			this.myUCButtonMoveLeft = this.XAMLButtonMoveLeft;
			this.myUCButtonMoveRight = this.XAMLButtonMoveRight;
			this.myUCButtonMoveBottom = this.XAMLButtonMoveBottom;
			this.myUCMenuButton = this.XAMLMenuButton;
			this.gamePageViewModel = new GamePageViewModel(this);
			this.playerViewModel = new PlayerViewModel(this);
		}
	}
}
