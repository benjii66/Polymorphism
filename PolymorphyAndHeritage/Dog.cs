using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphyAndHeritage
{
	class Dog: Animal, IFly
	{
		public Dog(string _name) : base(_name) { }

	

		public void Barking()
		{

		}

		public sealed override void Eat()
		{
			base.Eat();
			Console.WriteLine("I can't eat, i'm dead");
		}

		int speed = 2;
		public int Speed { get => speed; }

		public void Fly()
		{
			Console.WriteLine("I Can fly and i'm a dog");
		}

		//implémentation de l'abstract method Test de Animal
		public override void Test()
		{
			Console.WriteLine("oui oui");
		}
	}
}
