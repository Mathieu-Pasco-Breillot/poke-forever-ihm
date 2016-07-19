namespace PokeForeverIHM.Class
{
	public enum PokemonType
	{
		Steel,
		Fight,
		Dragon,
		Water,
		Electric,
		Fairy,
		Fire,
		Ice,
		Bug,
		Normal,
		Grass,
		Poison,
		Psychic,
		Rock,
		Ground,
		Ghost,
		Dark,
		Flying
	}
	public enum BallType
	{
		Pokeball,
		SuperBall,
		HyperBall,
		MasterBall,
		SafariBall
	}
	static class Types
	{
		public static PokemonType[] NormalWeak = new PokemonType[1] { PokemonType.Fight };
		public static PokemonType[] NormalStrong = new PokemonType[0];
		public static PokemonType[] NormalNoEffect = new PokemonType[1] { PokemonType.Ghost };
		//Grass
		public static PokemonType[] GrassWeak = new PokemonType[5] { PokemonType.Flying, PokemonType.Poison, PokemonType.Bug, PokemonType.Fire, PokemonType.Ice };
		public static PokemonType[] GrassStrong = new PokemonType[4] { PokemonType.Ground, PokemonType.Water, PokemonType.Grass, PokemonType.Electric };
		public static PokemonType[] GrassNoEffect = new PokemonType[0];
		//Electric
		public static PokemonType[] ElectricWeak = new PokemonType[1] { PokemonType.Ground };
		public static PokemonType[] ElectricStrong = new PokemonType[3] { PokemonType.Flying, PokemonType.Steel, PokemonType.Electric };
		public static PokemonType[] ElectricNoEffect = new PokemonType[0];
		//Water
		public static PokemonType[] WaterWeak = new PokemonType[2] { PokemonType.Grass, PokemonType.Electric };
		public static PokemonType[] WaterStrong = new PokemonType[4] { PokemonType.Steel, PokemonType.Fire, PokemonType.Water, PokemonType.Ice };
		public static PokemonType[] WaterNoEffect = new PokemonType[0];
		//Fire
		public static PokemonType[] FireWeak = new PokemonType[3] { PokemonType.Ground, PokemonType.Rock, PokemonType.Water };
		public static PokemonType[] FireStrong = new PokemonType[6] { PokemonType.Bug, PokemonType.Steel, PokemonType.Fire, PokemonType.Grass, PokemonType.Ice, PokemonType.Fairy };
		public static PokemonType[] FireNoEffect = new PokemonType[0];
		//Bug
		public static PokemonType[] BugWeak = new PokemonType[3] { PokemonType.Flying, PokemonType.Rock, PokemonType.Fire };
		public static PokemonType[] BugStrong = new PokemonType[3] { PokemonType.Fight, PokemonType.Ground, PokemonType.Grass };
		public static PokemonType[] BugNoEffect = new PokemonType[0];
		//Ghost
		public static PokemonType[] GhostWeak = new PokemonType[2] { PokemonType.Ghost, PokemonType.Dark };
		public static PokemonType[] GhostStrong = new PokemonType[2] { PokemonType.Poison, PokemonType.Bug };
		public static PokemonType[] GhostNoEffect = new PokemonType[2] { PokemonType.Normal, PokemonType.Fight };
		//Psychic
		public static PokemonType[] PsychicWeak = new PokemonType[3] { PokemonType.Bug, PokemonType.Ghost, PokemonType.Dark };
		public static PokemonType[] PsychicStrong = new PokemonType[2] { PokemonType.Fight, PokemonType.Psychic };
		public static PokemonType[] PsychicNoEffect = new PokemonType[0];
		//Steel
		public static PokemonType[] SteelWeak = new PokemonType[3] { PokemonType.Fight, PokemonType.Ground, PokemonType.Fire };
		public static PokemonType[] SteelStrong = new PokemonType[11] { PokemonType.Bug, PokemonType.Steel, PokemonType.Fire, PokemonType.Grass, PokemonType.Ice, PokemonType.Fairy, PokemonType.Normal, PokemonType.Flying, PokemonType.Rock, PokemonType.Psychic, PokemonType.Dragon };
		public static PokemonType[] SteelNoEffect = new PokemonType[1] { PokemonType.Poison };
		//Dark
		public static PokemonType[] DarkNoEffect = new PokemonType[1] { PokemonType.Psychic };
		public static PokemonType[] DarkWeak = new PokemonType[3] { PokemonType.Fight, PokemonType.Bug, PokemonType.Fairy };
		public static PokemonType[] DarkStrong = new PokemonType[2] { PokemonType.Ghost, PokemonType.Dark };
		//Flying
		public static PokemonType[] FlyingWeak = new PokemonType[3] { PokemonType.Rock, PokemonType.Electric, PokemonType.Ice };
		public static PokemonType[] FlyingStrong = new PokemonType[3] { PokemonType.Fight, PokemonType.Bug, PokemonType.Grass };
		public static PokemonType[] FlyingNoEffect = new PokemonType[1] { PokemonType.Ground };
		//Ice
		public static PokemonType[] IceWeak = new PokemonType[4] { PokemonType.Fight, PokemonType.Rock, PokemonType.Steel, PokemonType.Fire };
		public static PokemonType[] IceStrong = new PokemonType[1] { PokemonType.Ice };
		public static PokemonType[] IceNoEffect = new PokemonType[0];
		//Poison
		public static PokemonType[] PoisonWeak = new PokemonType[2] { PokemonType.Ground, PokemonType.Psychic };
		public static PokemonType[] PoisonStrong = new PokemonType[4] { PokemonType.Fight, PokemonType.Poison, PokemonType.Grass, PokemonType.Fairy };
		public static PokemonType[] PoisonNoEffect = new PokemonType[0];
		//Ground
		public static PokemonType[] GroundWeak = new PokemonType[3] { PokemonType.Water, PokemonType.Grass, PokemonType.Ice };
		public static PokemonType[] GroundStrong = new PokemonType[2] { PokemonType.Poison, PokemonType.Rock };
		public static PokemonType[] GroundNoEffect = new PokemonType[1] { PokemonType.Electric };
		//Rock
		public static PokemonType[] RockWeak = new PokemonType[5] { PokemonType.Fight, PokemonType.Ground, PokemonType.Steel, PokemonType.Water, PokemonType.Grass };
		public static PokemonType[] RockStrong = new PokemonType[4] { PokemonType.Normal, PokemonType.Flying, PokemonType.Poison, PokemonType.Fire };
		public static PokemonType[] RockNoEffect = new PokemonType[0];
		//Dragon
		public static PokemonType[] DragonWeak = new PokemonType[3] { PokemonType.Ice, PokemonType.Dragon, PokemonType.Fairy };
		public static PokemonType[] DragonStrong = new PokemonType[4] { PokemonType.Fire, PokemonType.Water, PokemonType.Grass, PokemonType.Electric };
		public static PokemonType[] DragonNoEffect = new PokemonType[0];
		//Fighting
		public static PokemonType[] FightWeak = new PokemonType[3] { PokemonType.Flying, PokemonType.Psychic, PokemonType.Fairy };
		public static PokemonType[] FightStrong = new PokemonType[3] { PokemonType.Rock, PokemonType.Bug, PokemonType.Dark };
		public static PokemonType[] FightNoEffect = new PokemonType[0];
		//Fairy
		public static PokemonType[] FairyWeak = new PokemonType[2] { PokemonType.Poison, PokemonType.Steel };
		public static PokemonType[] FairyStrong = new PokemonType[3] { PokemonType.Fight, PokemonType.Bug, PokemonType.Dark };
		public static PokemonType[] FairyNoEffect = new PokemonType[1] { PokemonType.Dragon };
	}
}
