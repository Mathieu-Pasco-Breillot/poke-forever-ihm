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
					Random type = new Random(3);
					Random level = new Random(41);
					Random hp = new Random(37);
					Random atkDefSpeed = new Random(29);
					Random critic = new Random(61);
					Random nature = new Random(89);
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
					names.Add("NidoranF", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Nidorina", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Nidoqueen", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("NidoranM", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Nidorino", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Nidoking", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Melofee", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Melodelfe", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Goupix", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Feunard", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Rondoudou", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Grodoudou", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Nosferapti", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Nosferalto", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Mystherbe", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Ortide", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Rafflesia", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Paras", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Parasect", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Mimitoss", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Aeromite", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Taupiqueur", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Triopikeur", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Miaouss", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Persian", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Psykokwak", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Akwakwak", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Ferosinge", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Colossinge", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Caninos", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Arcanin", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Ptitard", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Tetarte", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Tartard", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Abra", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Kadabra", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Alakazam", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Machoc", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Machopeur", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Mackogneur", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Chetiflore", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Boustiflor", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Empiflor", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Tentacool", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Tentacruel", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Racaillou", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Gravalanch", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Grolem", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Ponyta", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Galopa", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Ramoloss", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Flagadoss", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Magneti", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Magneton", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Canarticho", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Doduo", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Dodrio", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Otaria", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Lamantine", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Tadmorv", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Grotadmorv", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Kokiyas", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Crustabri", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Fantominus", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Spectrum", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Ectoplasma", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Onix", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Soporifik", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Hypnomade", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Krabby", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Krabboss", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Voltorbe", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Electrode", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Nœunœuf", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Noadkoko", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Osselait", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Ossatueur", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Kicklee", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Tygnon", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Excelangue", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Smogo", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Smogogo", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Rhinocorne", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Rhinoferos", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Leveinard", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Saquedeneu", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Kangourex", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Hypotrempe", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Hypocean", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Poissirene", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Poissoroy", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Stari", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Staross", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("M.Mime", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Insecateur", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Lippoutou", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Elektek", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Magmar", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Scarabrute", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Tauros", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Magicarpe", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Leviator", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Lokhlass", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Metamorph", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Evoli", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Aquali", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Voltali", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Pyroli", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Porygon", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Amonita", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Amonistar", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Kabuto", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Kabutops", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Ptera", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Ronflex", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Artikodin", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Electhor", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Sulfura", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Minidraco", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Draco", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Dracolosse", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Mewtwo", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
					names.Add("Mew", "Lorem ipsum dolor sit amet consectetur. Adipiscing elit uit ultrices nomine patri.");
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
						instance.Add(
							new Pokemon(
								pokemon.Key,
								(ushort)level.Next(1, 99),
								(ushort)hp.Next(25, 300),
								(ushort)atkDefSpeed.Next(10, 250),
								(ushort)atkDefSpeed.Next(10, 250),
								(ushort)critic.Next(1, 100),
								(ushort)atkDefSpeed.Next(10, 250),
								(PokemonType)type.Next(1, 18),
								(PokemonNature)nature.Next(1, 25),
								$"ms-appx:///Assets/Square44x44Logo.scale-200.png",
								pokemon.Value)
						);
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
			Hp = hp;
			Attack = attack;
			Defense = defense;
			Critic = critic;
			Speed = speed;
			Type = type;
			Nature = nature;
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
