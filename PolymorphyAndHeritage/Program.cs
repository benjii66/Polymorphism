using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphyAndHeritage
{
	class Program
	{
		static void Main(string[] args)
		{
			Dog _d = new Dog("Toto");
			_d.Eat();

			Cat _c = new Cat("Garfield");
			_c.Eat();

			Animal _a = _d;

			Human _s = new Superman();
			List<Animal> _an = new List<Animal>();
			_an.Add(_d);
			_an.Add(_c);
			List<Human> _h = new List<Human>();
			_h.Add(_s);

			IFly _flyDog = _d;
			IFly _superMan = (Superman)_s;

			//pas de la même famille mais ils se ressemblent par le IFly
			List<IFly> _ifly = new List<IFly>();
			_ifly.Add(_flyDog);
			_ifly.Add(_superMan);

			Console.Read();
		}
	}
}
