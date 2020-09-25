using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphyAndHeritage
{
	class Cat : Animal
	{
		public Cat(string _name): base(_name) { }

		public void Barking()
		{

		}

		public override void Eat()
		{
			base.Eat();
			Console.WriteLine("I'm a cat");
		}

		//implémentation de l'abstract method Test de Animal
		public override void Test()
		{
			Console.WriteLine("oui oui");
		}
	}
}
