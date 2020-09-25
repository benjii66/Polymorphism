using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphyAndHeritage
{
	public abstract class Animal
	{
		string Name;

		public Animal(string _name)
		{
			Name = _name;
		}

		public abstract void Test();
	

		public virtual void Eat()
		{
			Console.WriteLine("I can eat");
		}

		public virtual void Breath()
		{
			Console.WriteLine("I can breath");
		}
	}
}
