using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastExmpl
{
	class Program
	{
		static void Main(string[] args)
		{
			var ThingA = new ThingA();
			var ThB = new ThingB();

			D(ThingA);
			D(ThB);

			Console.ReadLine();
		}

		static void D(IThing t)// интерфейс не является экземпляром. В любом случае компилятор обращается к реальному коду.
		{
			validate("no");
			Console.WriteLine(t.ToString());
		}

		static void validate(string n)
		{
			if(n.Equals("yes"))
				throw new Exception("I am not bad G");
		}
	}
}
