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
		ushort hp;
		ushort attack;
		ushort defense;
		ushort critic;
		ushort speed;
		string @abstract;
		ushort level;
		PokemonNature nature;
		PokemonType type;
		ImageSource image, imageType;
		private static ObservableCollection<Pokemon> instance;

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

		public ushort Attack
		{
			get
			{
				return attack;
			}

			set
			{
				attack = value;
			}
		}

		public ushort Hp
		{
			get
			{
				return hp;
			}

			set
			{
				hp = value;
			}
		}

		public ushort Defense
		{
			get
			{
				return defense;
			}

			set
			{
				defense = value;
			}
		}

		public ushort Speed
		{
			get
			{
				return speed;
			}

			set
			{
				speed = value;
			}
		}

		public ushort Critic
		{
			get
			{
				return critic;
			}

			set
			{
				critic = value;
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
				level = (ushort)value;
			}
		}

		public PokemonType Type
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

		public PokemonNature Nature
		{
			get
			{
				return nature;
			}

			set
			{
				nature = value;
			}
		}

		public static ObservableCollection<Pokemon> Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new ObservableCollection<Pokemon>();
					Random type = new Random();
					Random level = new Random();
					Random hp = new Random();
					Random attack = new Random();
					Random defense = new Random();
					Random critic = new Random();
					Random speed = new Random();
					Random nature = new Random();
					#region Create names
					Dictionary<string, string> names = new Dictionary<string, string>();
					names.Add("Bulbizarre", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Herbizarre", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Florizarre", "Le parfum de sa fleur se fait plus pénétrant les lendemains de pluie. Cela appâte les autres Pokémon.");
					names.Add("Salameche", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Reptincel", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Dracaufeu", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Carapuce", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Carabaffe", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Tortank", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Chenipan", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Chrysacier", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Papilusion", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Aspicot", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Coconfort", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Dardargnan", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Roucool", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Roucoups", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Roucarnage", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Rattata", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Rattatac", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Piafabec", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Rapasdepic", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Abo", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Arbok", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Pikachu", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Raichu", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Sabelette", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Sablaireau", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
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
					names.Add("Barbicha", "Lorsque Barbicha se déchaîne, il déclenche des secousses sismiques dans un rayon de plus 5 km autour de lui. Ce Pokémon a le pouvoir de prédire les véritables tremblements de terre.");
					names.Add("Brouhabam", "Brouhabam communique avec les autres en émettant un sifflement qui provient des tubes de son corps. Ce Pokémon n'élève la voix que pendant les combats.");
					names.Add("Camerupt", "Le corps de Camérupt renferme un volcan. Du magma à 10 000 degrés coule dans ses veines. De temps à temps, les bosses sur le dos de ce Pokémon entrent en éruption et crachent le magma surchauffé");
					names.Add("Groret", "Groret utilise les perles noires sur son corps pour exercer ses formidables pouvoirs. Quand il est en action, il entame une étrange danse. Les perles noires de ce Pokémon ont une valeur inestimables.");
					names.Add("Milobellus", "Milobellus vit au fond des grands lacs. Lorsque le corps de ce Pokémon devient rose vif, il libère une pulsation d'énergie, capable d'apaiser les esprits agités.");
					names.Add("Morpheo", "Les variations de température ou d'humidité affectent sa structure cellulaire et son apparence.");
					names.Add("Pingoleon", "Les trois cornes de son bec sont le symbole de sa force. Celles du chef sont plus grosses que les autres.");
					names.Add("Tortipouss", "La coquille sur son dos est faite de terre. Plus il est en bonne santé, plus elle est humide.");
					#endregion

					foreach (KeyValuePair<string, string> pokemon in names)
					{
						instance.Add(new Pokemon(pokemon.Key, (ushort)level.Next(1, 99), (ushort)hp.Next(25, 300), (ushort)attack.Next(10, 250), (ushort)defense.Next(10, 250), (ushort)critic.Next(1, 100), (ushort)speed.Next(10, 250), (PokemonType)type.Next(1, 18), (PokemonNature)nature.Next(1, 25), $"ms-appx:///Assets/Square44x44Logo.scale-200.png", pokemon.Value));
					}
					//for (int i = 0; i < names.Count; i++)
					//{
					//	Pokemons.Add(new Pokemon(names[i], (short)level.Next(1, 99), (Types)type.Next(1, 18), $"ms-appx:///Assets/Square44x44Logo.scale-200.png"));
					//}
					foreach (Pokemon pokemon in instance)
					{
						createPokemonImageURi(pokemon);
					}
				}
				return instance;
			}

			set
			{
				instance = value;
			}
		}

		public Pokemon(string name, ushort level, ushort hp, ushort attack, ushort defense, ushort critic, ushort speed, PokemonType type, PokemonNature nature, string imageURI, string @abstract = "")
		{
			Name = name;
			Level = level;
			Type = type;
			Abstract = @abstract;
			SetImage = imageURI;
			SetImageType = checkType(type);
		}

		private string checkType(PokemonType type)
		{
			string result = "";
			switch (type)
			{
				case PokemonType.Bug:
					return result = "ms-appx:///Assets/Types/bug.png";
				case PokemonType.Dark:
					return result = "ms-appx:///Assets/Types/dark.png";
				case PokemonType.Dragon:
					return result = "ms-appx:///Assets/Types/dragon.png";
				case PokemonType.Electric:
					return result = "ms-appx:///Assets/Types/electric.png";
				case PokemonType.Fairy:
					return result = "ms-appx:///Assets/Types/fairy.png";
				case PokemonType.Fight:
					return result = "ms-appx:///Assets/Types/fight.png";
				case PokemonType.Fire:
					return result = "ms-appx:///Assets/Types/fire.png";
				case PokemonType.Flying:
					return result = "ms-appx:///Assets/Types/flying.png";
				case PokemonType.Ghost:
					return result = "ms-appx:///Assets/Types/ghost.png";
				case PokemonType.Grass:
					return result = "ms-appx:///Assets/Types/grass.png";
				case PokemonType.Ground:
					return result = "ms-appx:///Assets/Types/ground.png";
				case PokemonType.Ice:
					return result = "ms-appx:///Assets/Types/ice.png";
				case PokemonType.Normal:
					return result = "ms-appx:///Assets/Types/normal.png";
				case PokemonType.Poison:
					return result = "ms-appx:///Assets/Types/poison.png";
				case PokemonType.Psychic:
					return result = "ms-appx:///Assets/Types/psychic.png";
				case PokemonType.Rock:
					return result = "ms-appx:///Assets/Types/rock.png";
				case PokemonType.Steel:
					return result = "ms-appx:///Assets/Types/steel.png";
				case PokemonType.Water:
					return result = "ms-appx:///Assets/Types/water.png";
				default:
					return result;
			}
		}

		private static void createPokemonImageURi(Pokemon pokemon)
		{
			pokemon.SetImage = $"ms-appx:///Assets/Pokemons/{pokemon.Name}.png";
		}
	}
}
