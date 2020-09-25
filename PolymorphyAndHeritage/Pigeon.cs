using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphyAndHeritage
{
	 class Pigeon : Animal
	{
		public Pigeon(string _name) : base(_name)
		{			

		}

		public override void Eat()
		{
			base.Eat();
		}


		public void Fly()
		{
			Console.WriteLine("I can fly.");
		}

		//implémentation de l'abstract method Test de Animal
		public override void Test()
		{
			Console.WriteLine("oui oui");
		}
	}
}
