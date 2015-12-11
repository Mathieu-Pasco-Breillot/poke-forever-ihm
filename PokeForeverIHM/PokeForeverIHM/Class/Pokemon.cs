using System;
using System.Collections.Generic;
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

		private static void createPokemonImageURi(Pokemon pokemon)
		{
			pokemon.SetImage = $"ms-appx:///Assets/Pokemons/{pokemon.Name}.png";
		}

		public static ObservableCollection<Pokemon> GetPokemons()
		{
			if (Pokemons == null)
			{
				Pokemons = new ObservableCollection<Pokemon>();
				Random type = new Random();
				Random level = new Random();
				#region Create names
				List<string> names = new List<string>();
				names.Add("Bulbizarre");
				names.Add("Herbizarre");
				names.Add("Florizarre");
				names.Add("Salamèche");
				names.Add("Reptincel");
				names.Add("Dracaufeu");
				names.Add("Carapuce");
				names.Add("Carabaffe");
				names.Add("Tortank");
				names.Add("Chenipan");
				names.Add("Chrysacier");
				names.Add("Papilusion");
				names.Add("Aspicot");
				names.Add("Coconfort");
				names.Add("Dardargnan");
				names.Add("Roucool");
				names.Add("Roucoups");
				names.Add("Roucarnage");
				names.Add("Rattata");
				names.Add("Rattatac");
				names.Add("Piafabec");
				names.Add("Rapasdepic");
				names.Add("Abo");
				names.Add("Arbok");
				names.Add("Pikachu");
				names.Add("Raichu");
				names.Add("Sabelette");
				names.Add("Sablaireau");
				names.Add("Nidoran?");
				names.Add("Nidorina");
				names.Add("Nidoqueen");
				names.Add("Nidoran?");
				names.Add("Nidorino");
				names.Add("Nidoking");
				names.Add("Mélofée");
				names.Add("Mélodelfe");
				names.Add("Goupix");
				names.Add("Feunard");
				names.Add("Rondoudou");
				names.Add("Grodoudou");
				names.Add("Nosferapti");
				names.Add("Nosferalto");
				names.Add("Mystherbe");
				names.Add("Ortide");
				names.Add("Rafflesia");
				names.Add("Paras");
				names.Add("Parasect");
				names.Add("Mimitoss");
				names.Add("Aéromite");
				names.Add("Taupiqueur");
				names.Add("Triopikeur");
				names.Add("Miaouss");
				names.Add("Persian");
				names.Add("Psykokwak");
				names.Add("Akwakwak");
				names.Add("Férosinge");
				names.Add("Colossinge");
				names.Add("Caninos");
				names.Add("Arcanin");
				names.Add("Ptitard");
				names.Add("Têtarte");
				names.Add("Tartard");
				names.Add("Abra");
				names.Add("Kadabra");
				names.Add("Alakazam");
				names.Add("Machoc");
				names.Add("Machopeur");
				names.Add("Mackogneur");
				names.Add("Chétiflor");
				names.Add("Boustiflor");
				names.Add("Empiflor");
				names.Add("Tentacool");
				names.Add("Tentacruel");
				names.Add("Racaillou");
				names.Add("Gravalanch");
				names.Add("Grolem");
				names.Add("Ponyta");
				names.Add("Galopa");
				names.Add("Ramoloss");
				names.Add("Flagadoss");
				names.Add("Magnéti");
				names.Add("Magnéton");
				names.Add("Canarticho");
				names.Add("Doduo");
				names.Add("Dodrio");
				names.Add("Otaria");
				names.Add("Lamantine");
				names.Add("Tadmorv");
				names.Add("Grotadmorv");
				names.Add("Kokiyas");
				names.Add("Crustabri");
				names.Add("Fantominus");
				names.Add("Spectrum");
				names.Add("Ectoplasma");
				names.Add("Onix");
				names.Add("Soporifik");
				names.Add("Hypnomade");
				names.Add("Krabby");
				names.Add("Krabboss");
				names.Add("Voltorbe");
				names.Add("Électrode");
				names.Add("Nœunœuf");
				names.Add("Noadkoko");
				names.Add("Osselait");
				names.Add("Ossatueur");
				names.Add("Kicklee");
				names.Add("Tygnon");
				names.Add("Excelangue");
				names.Add("Smogo");
				names.Add("Smogogo");
				names.Add("Rhinocorne");
				names.Add("Rhinoféros");
				names.Add("Leveinard");
				names.Add("Saquedeneu");
				names.Add("Kangourex");
				names.Add("Hypotrempe");
				names.Add("Hypocéan");
				names.Add("Poissirène");
				names.Add("Poissoroy");
				names.Add("Stari");
				names.Add("Staross");
				names.Add("M. Mime");
				names.Add("Insécateur");
				names.Add("Lippoutou");
				names.Add("Elektek");
				names.Add("Magmar");
				names.Add("Scarabrute");
				names.Add("Tauros");
				names.Add("Magicarpe");
				names.Add("Léviator");
				names.Add("Lokhlass");
				names.Add("Métamorph");
				names.Add("Évoli");
				names.Add("Aquali");
				names.Add("Voltali");
				names.Add("Pyroli");
				names.Add("Porygon");
				names.Add("Amonita");
				names.Add("Amonistar");
				names.Add("Kabuto");
				names.Add("Kabutops");
				names.Add("Ptéra");
				names.Add("Ronflex");
				names.Add("Artikodin");
				names.Add("Électhor");
				names.Add("Sulfura");
				names.Add("Minidraco");
				names.Add("Draco");
				names.Add("Dracolosse");
				names.Add("Mewtwo");
				names.Add("Mew");
				#endregion

				for (int i = 0; i < names.Count; i++)
				{
					Pokemons.Add(new Pokemon(names[i], (short)level.Next(1, 99), (Types)type.Next(1, 18), $"ms-appx:///Assets/Square44x44Logo.scale-200.png"));
				}
				foreach (Pokemon pokemon in Pokemons)
				{
					createPokemonImageURi(pokemon);
				}

				//Pokemons.Add(new Pokemon("Brouhabam", 19, Types.Bug, "ms-appx:///Assets/250px-Brouhabam-RS.png", "Brouhabam communique avec les autres en émettant un sifflement qui provient des tubes de son corps. Ce Pokémon n'élève la voix que pendant les combats."));
				//Pokemons.Add(new Pokemon("Barbicha", 42, Types.Dark, "ms-appx:///Assets/250px-Barbicha-RS.png", "Lorsque Barbicha se déchaîne, il déclenche des secousses sismiques dans un rayon de plus 5 km autour de lui. Ce Pokémon a le pouvoir de prédire les véritables tremblements de terre."));
				//Pokemons.Add(new Pokemon("Camérupt", 68, Types.Dragon, "ms-appx:///Assets/250px-Camérupt-RS.png", "Le corps de Camérupt renferme un volcan. Du magma à 10 000 degrés coule dans ses veines. De temps à temps, les bosses sur le dos de ce Pokémon entrent en éruption et crachent le magma surchauffé"));
				//Pokemons.Add(new Pokemon("Groret", 98, Types.Normal, "ms-appx:///Assets/250px-Groret-RS.png", "Groret utilise les perles noires sur son corps pour exercer ses formidables pouvoirs. Quand il est en action, il entame une étrange danse. Les perles noires de ce Pokémon ont une valeur inestimables."));
				//Pokemons.Add(new Pokemon("Milobellus", 71, Types.Grass, "ms-appx:///Assets/250px-Milobellus-RS.png", "Milobellus vit au fond des grands lacs. Lorsque le corps de ce Pokémon devient rose vif, il libère une pulsation d'énergie, capable d'apaiser les esprits agités."));
				//Pokemons.Add(new Pokemon("Morphéo", 56, Types.Ghost, "ms-appx:///Assets/250px-Morphéo-RS.png", "Les variations de température ou d'humidité affectent sa structure cellulaire et son apparence."));
				//Pokemons.Add(new Pokemon("Pingoléon", 36, Types.Ice, "ms-appx:///Assets/250px-Pingoléon-DP.png", "Les trois cornes de son bec sont le symbole de sa force. Celles du chef sont plus grosses que les autres."));
				//Pokemons.Add(new Pokemon("Tortipouss", 25, Types.Grass, "ms-appx:///Assets/250px-Tortipouss-Pt.png", "La coquille sur son dos est faite de terre. Plus il est en bonne santé, plus elle est humide."));
				//Pokemons.Add(new Pokemon("Florizarre", 73, Types.Grass, "ms-appx:///Assets/773px-Florizarre-RFVF.png", "Le parfum de sa fleur se fait plus pénétrant les lendemains de pluie. Cela appâte les autres Pokémon."));
			}
			return Pokemons;
		}
	}
}
