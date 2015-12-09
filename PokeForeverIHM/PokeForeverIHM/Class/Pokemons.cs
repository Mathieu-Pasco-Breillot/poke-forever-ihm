using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PokeForeverIHM.Class
{
	public class Pokemons :ICollection<Pokemon>
	{
		private ObservableCollection<Pokemon> pokemons;

		public int Count
		{
			get
			{
				return ((ICollection<Pokemon>)pokemons).Count;
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return ((ICollection<Pokemon>)pokemons).IsReadOnly;
			}
		}

		public void Add(Pokemon item)
		{
			((ICollection<Pokemon>)pokemons).Add(item);
		}

		public void Clear()
		{
			((ICollection<Pokemon>)pokemons).Clear();
		}

		public bool Contains(Pokemon item)
		{
			return ((ICollection<Pokemon>)pokemons).Contains(item);
		}

		public void CopyTo(Pokemon[] array, int arrayIndex)
		{
			((ICollection<Pokemon>)pokemons).CopyTo(array, arrayIndex);
		}

		public IEnumerator<Pokemon> GetEnumerator()
		{
			return ((ICollection<Pokemon>)pokemons).GetEnumerator();
		}

		public bool Remove(Pokemon item)
		{
			return ((ICollection<Pokemon>)pokemons).Remove(item);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((ICollection<Pokemon>)pokemons).GetEnumerator();
		}
	}
}
