using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace PokeForeverIHM.Class
{
	public class Pokemon
	{
		string name;
		string @abstract;
		short level = 1;
		Types type;
		ImageSource image, imageType;
		private static ObservableCollection<Pokemon> pokemons;

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

		public string Abstract
		{
			get
			{
				return @abstract;
			}

			set
			{
				@abstract = value;
			}
		}

		public object Level
		{
			get
			{
				return Convert.ToString(level);
			}

			set
			{
				level = (short)value;
			}
		}

		public Types Type
		{
			get
			{
				return type;
			}

			set
			{
				type = value;
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

		public string SetImageType
		{
			set
			{
				imageType = new BitmapImage(new Uri(value));
			}
		}
		public ImageSource GetImageType
		{
			get
			{
				return imageType;
			}
		}
		public static ObservableCollection<Pokemon> Pokemons
		{
			get
			{
				return pokemons;
			}

			set
			{
				pokemons = value;
			}
		}

		public Pokemon(string name, short level, Types type, string imageURI, string @abstract = "")
		{
			Name = name;
			Level = level;
			Type = type;
			Abstract = @abstract;
			SetImage = imageURI;
			SetImageType = checkType(type);
		}

		private string checkType(Types type)
		{
			string result = "";
			switch (type)
			{
				case Types.Bug:
					return result = "ms-appx:///Assets/Types/bug.png";
				case Types.Dark:
					return result = "ms-appx:///Assets/Types/dark.png";
				case Types.Dragon:
					return result = "ms-appx:///Assets/Types/dragon.png";
				case Types.Electric:
					return result = "ms-appx:///Assets/Types/electric.png";
				case Types.Fairy:
					return result = "ms-appx:///Assets/Types/fairy.png";
				case Types.Fight:
					return result = "ms-appx:///Assets/Types/fight.png";
				case Types.Fire:
					return result = "ms-appx:///Assets/Types/fire.png";
				case Types.Flying:
					return result = "ms-appx:///Assets/Types/flying.png";
				case Types.Ghost:
					return result = "ms-appx:///Assets/Types/ghost.png";
				case Types.Grass:
					return result = "ms-appx:///Assets/Types/grass.png";
				case Types.Ground:
					return result = "ms-appx:///Assets/Types/ground.png";
				case Types.Ice:
					return result = "ms-appx:///Assets/Types/ice.png";
				case Types.Normal:
					return result = "ms-appx:///Assets/Types/normal.png";
				case Types.Poison:
					return result = "ms-appx:///Assets/Types/poison.png";
				case Types.Psychic:
					return result = "ms-appx:///Assets/Types/psychic.png";
				case Types.Rock:
					return result = "ms-appx:///Assets/Types/rock.png";
				case Types.Steel:
					return result = "ms-appx:///Assets/Types/steel.png";
				case Types.Water:
					return result = "ms-appx:///Assets/Types/water.png";
				default:
					return result;
			}
		}



		public static ObservableCollection<Pokemon> GetPokemons()
		{
			if (Pokemons == null)
			{
				Pokemons = new ObservableCollection<Pokemon>();
				Pokemons.Add(new Pokemon("Brouhabam", 19, Types.Bug, "ms-appx:///Assets/250px-Brouhabam-RS.png", "Brouhabam communique avec les autres en émettant un sifflement qui provient des tubes de son corps. Ce Pokémon n'élève la voix que pendant les combats."));
				Pokemons.Add(new Pokemon("Barbicha", 42, Types.Dark, "ms-appx:///Assets/250px-Barbicha-RS.png", "Lorsque Barbicha se déchaîne, il déclenche des secousses sismiques dans un rayon de plus 5 km autour de lui. Ce Pokémon a le pouvoir de prédire les véritables tremblements de terre."));
				Pokemons.Add(new Pokemon("Camérupt", 68, Types.Dragon, "ms-appx:///Assets/250px-Camérupt-RS.png", "Le corps de Camérupt renferme un volcan. Du magma à 10 000 degrés coule dans ses veines. De temps à temps, les bosses sur le dos de ce Pokémon entrent en éruption et crachent le magma surchauffé"));
				Pokemons.Add(new Pokemon("Groret", 98, Types.Normal, "ms-appx:///Assets/250px-Groret-RS.png", "Groret utilise les perles noires sur son corps pour exercer ses formidables pouvoirs. Quand il est en action, il entame une étrange danse. Les perles noires de ce Pokémon ont une valeur inestimables."));
				Pokemons.Add(new Pokemon("Milobellus", 71, Types.Grass, "ms-appx:///Assets/250px-Milobellus-RS.png", "Milobellus vit au fond des grands lacs. Lorsque le corps de ce Pokémon devient rose vif, il libère une pulsation d'énergie, capable d'apaiser les esprits agités."));
				Pokemons.Add(new Pokemon("Morphéo", 56, Types.Ghost, "ms-appx:///Assets/250px-Morphéo-RS.png", "Les variations de température ou d'humidité affectent sa structure cellulaire et son apparence."));
				Pokemons.Add(new Pokemon("Pingoléon", 36, Types.Ice, "ms-appx:///Assets/250px-Pingoléon-DP.png", "Les trois cornes de son bec sont le symbole de sa force. Celles du chef sont plus grosses que les autres."));
				Pokemons.Add(new Pokemon("Tortipouss", 25, Types.Grass, "ms-appx:///Assets/250px-Tortipouss-Pt.png", "La coquille sur son dos est faite de terre. Plus il est en bonne santé, plus elle est humide."));
				Pokemons.Add(new Pokemon("Florizarre", 73, Types.Grass, "ms-appx:///Assets/773px-Florizarre-RFVF.png", "Le parfum de sa fleur se fait plus pénétrant les lendemains de pluie. Cela appâte les autres Pokémon.")); 
			}
			return Pokemons;
		}
	}
}
