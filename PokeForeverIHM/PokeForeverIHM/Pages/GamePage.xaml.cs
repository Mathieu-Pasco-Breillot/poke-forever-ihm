using PokeForeverIHM.UsersControls;
using Windows.UI.Xaml.Media;
using PokeForeverIHM.Class;
using PokeForeverIHM.ViewModel;
using Microsoft.Azure.Engagement.Overlay;
using Windows.UI.Xaml.Controls;

namespace PokeForeverIHM
{
	public sealed partial class GamePage : EngagementPageOverlay
	{
		private GamePageViewModel gamePageViewModel;
		private PlayerViewModel playerViewModel;
		public MenuPanel myUCMenuPanel { get; set; }
		public Image myUCImgCharacter { get; set; }

		public Grid myUCGridMap { get; set; }

		public DirectionalCross myUCButtonMoveTop { get; set; }
		public DirectionalCross myUCButtonMoveLeft { get; set; }
		public DirectionalCross myUCButtonMoveRight { get; set; }
		public DirectionalCross myUCButtonMoveBottom { get; set; }
		public MenuButton myUCMenuButton { get; set; }

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
