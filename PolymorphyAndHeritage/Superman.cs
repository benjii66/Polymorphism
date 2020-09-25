using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphyAndHeritage
{
	public class Superman : SuperHuman, IFly
	{
		int speed = 2;
		public int Speed { get => speed;}

		public void Fly()
		{
			Console.WriteLine("I Can fly because i'm superman");
		}
	}
}
