using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace PokeForeverIHM.Class
{
	public class Pokemon
	{
		string name;
		string @abstract;
		short level;
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
				Dictionary<string,string> names = new Dictionary<string, string>();
				names.Add("Bulbizarre", "");
				names.Add("Herbizarre", "");
				names.Add("Florizarre", "Le parfum de sa fleur se fait plus pénétrant les lendemains de pluie. Cela appâte les autres Pokémon.");
				names.Add("Salameche", "");
				names.Add("Reptincel", "");
				names.Add("Dracaufeu", "");
				names.Add("Carapuce", "");
				names.Add("Carabaffe", "");
				names.Add("Tortank", "");
				names.Add("Chenipan", "");
				names.Add("Chrysacier", "");
				names.Add("Papilusion", "");
				names.Add("Aspicot", "");
				names.Add("Coconfort", "");
				names.Add("Dardargnan", "");
				names.Add("Roucool", "");
				names.Add("Roucoups", "");
				names.Add("Roucarnage", "");
				names.Add("Rattata", "");
				names.Add("Rattatac", "");
				names.Add("Piafabec", "");
				names.Add("Rapasdepic", "");
				names.Add("Abo", "");
				names.Add("Arbok", "");
				names.Add("Pikachu", "");
				names.Add("Raichu", "");
				names.Add("Sabelette", "");
				names.Add("Sablaireau", "");
				names.Add("NidoranF", "");
				names.Add("Nidorina", "");
				names.Add("Nidoqueen", "");
				names.Add("NidoranM", "");
				names.Add("Nidorino", "");
				names.Add("Nidoking", "");
				names.Add("Melofee", "");
				names.Add("Melodelfe", "");
				names.Add("Goupix", "");
				names.Add("Feunard", "");
				names.Add("Rondoudou", "");
				names.Add("Grodoudou", "");
				names.Add("Nosferapti", "");
				names.Add("Nosferalto", "");
				names.Add("Mystherbe", "");
				names.Add("Ortide", "");
				names.Add("Rafflesia", "");
				names.Add("Paras", "");
				names.Add("Parasect", "");
				names.Add("Mimitoss", "");
				names.Add("Aeromite", "");
				names.Add("Taupiqueur", "");
				names.Add("Triopikeur", "");
				names.Add("Miaouss", "");
				names.Add("Persian", "");
				names.Add("Psykokwak", "");
				names.Add("Akwakwak", "");
				names.Add("Ferosinge", "");
				names.Add("Colossinge", "");
				names.Add("Caninos", "");
				names.Add("Arcanin", "");
				names.Add("Ptitard", "");
				names.Add("Tetarte", "");
				names.Add("Tartard", "");
				names.Add("Abra", "");
				names.Add("Kadabra", "");
				names.Add("Alakazam", "");
				names.Add("Machoc", "");
				names.Add("Machopeur", "");
				names.Add("Mackogneur", "");
				names.Add("Chetiflor", "");
				names.Add("Boustiflor", "");
				names.Add("Empiflor", "");
				names.Add("Tentacool", "");
				names.Add("Tentacruel", "");
				names.Add("Racaillou", "");
				names.Add("Gravalanch", "");
				names.Add("Grolem", "");
				names.Add("Ponyta", "");
				names.Add("Galopa", "");
				names.Add("Ramoloss", "");
				names.Add("Flagadoss", "");
				names.Add("Magneti", "");
				names.Add("Magneton", "");
				names.Add("Canarticho", "");
				names.Add("Doduo", "");
				names.Add("Dodrio", "");
				names.Add("Otaria", "");
				names.Add("Lamantine", "");
				names.Add("Tadmorv", "");
				names.Add("Grotadmorv", "");
				names.Add("Kokiyas", "");
				names.Add("Crustabri", "");
				names.Add("Fantominus", "");
				names.Add("Spectrum", "");
				names.Add("Ectoplasma", "");
				names.Add("Onix", "");
				names.Add("Soporifik", "");
				names.Add("Hypnomade", "");
				names.Add("Krabby", "");
				names.Add("Krabboss", "");
				names.Add("Voltorbe", "");
				names.Add("Electrode", "");
				names.Add("Nœunœuf", "");
				names.Add("Noadkoko", "");
				names.Add("Osselait", "");
				names.Add("Ossatueur", "");
				names.Add("Kicklee", "");
				names.Add("Tygnon", "");
				names.Add("Excelangue", "");
				names.Add("Smogo", "");
				names.Add("Smogogo", "");
				names.Add("Rhinocorne", "");
				names.Add("Rhinoferos", "");
				names.Add("Leveinard", "");
				names.Add("Saquedeneu", "");
				names.Add("Kangourex", "");
				names.Add("Hypotrempe", "");
				names.Add("Hypocean", "");
				names.Add("Poissirene", "");
				names.Add("Poissoroy", "");
				names.Add("Stari", "");
				names.Add("Staross", "");
				names.Add("M.Mime", "");
				names.Add("Insecateur", "");
				names.Add("Lippoutou", "");
				names.Add("Elektek", "");
				names.Add("Magmar", "");
				names.Add("Scarabrute", "");
				names.Add("Tauros", "");
				names.Add("Magicarpe", "");
				names.Add("Leviator", "");
				names.Add("Lokhlass", "");
				names.Add("Metamorph", "");
				names.Add("Evoli", "");
				names.Add("Aquali", "");
				names.Add("Voltali", "");
				names.Add("Pyroli", "");
				names.Add("Porygon", "");
				names.Add("Amonita", "");
				names.Add("Amonistar", "");
				names.Add("Kabuto", "");
				names.Add("Kabutops", "");
				names.Add("Ptera", "");
				names.Add("Ronflex", "");
				names.Add("Artikodin", "");
				names.Add("Electhor", "");
				names.Add("Sulfura", "");
				names.Add("Minidraco", "");
				names.Add("Draco", "");
				names.Add("Dracolosse", "");
				names.Add("Mewtwo", "");
				names.Add("Mew", "");
				names.Add("Barbicha","Lorsque Barbicha se déchaîne, il déclenche des secousses sismiques dans un rayon de plus 5 km autour de lui. Ce Pokémon a le pouvoir de prédire les véritables tremblements de terre.");
				names.Add("Brouhabam", "Brouhabam communique avec les autres en émettant un sifflement qui provient des tubes de son corps. Ce Pokémon n'élève la voix que pendant les combats.");
				names.Add("Camerupt", "Le corps de Camérupt renferme un volcan. Du magma à 10 000 degrés coule dans ses veines. De temps à temps, les bosses sur le dos de ce Pokémon entrent en éruption et crachent le magma surchauffé");
				names.Add("Groret", "Groret utilise les perles noires sur son corps pour exercer ses formidables pouvoirs. Quand il est en action, il entame une étrange danse. Les perles noires de ce Pokémon ont une valeur inestimables.");
				names.Add("Milobellus", "Milobellus vit au fond des grands lacs. Lorsque le corps de ce Pokémon devient rose vif, il libère une pulsation d'énergie, capable d'apaiser les esprits agités.");
				names.Add("Morpheo", "Les variations de température ou d'humidité affectent sa structure cellulaire et son apparence.");
				names.Add("Pingoleon", "Les trois cornes de son bec sont le symbole de sa force. Celles du chef sont plus grosses que les autres.");
				names.Add("Tortipouss", "La coquille sur son dos est faite de terre. Plus il est en bonne santé, plus elle est humide.");
				#endregion

				foreach (KeyValuePair<string,string> pokemon in names)
				{
					Pokemons.Add(new Pokemon(pokemon.Key, (short)level.Next(1, 99), (Types)type.Next(1, 18), $"ms-appx:///Assets/Square44x44Logo.scale-200.png", pokemon.Value));
				}
				//for (int i = 0; i < names.Count; i++)
				//{
				//	Pokemons.Add(new Pokemon(names[i], (short)level.Next(1, 99), (Types)type.Next(1, 18), $"ms-appx:///Assets/Square44x44Logo.scale-200.png"));
				//}
				foreach (Pokemon pokemon in Pokemons)
				{
					createPokemonImageURi(pokemon);
				}
			}
			return Pokemons;
		}
	}
}
