using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			A a1 = new A { Age = 42, Name = "Roman" };
			A a2 = new A { Age = 37, Name = "Nata" };

			B b1 = new B { Name = "Luda", Hobby = "Developing", A = a1 };
			B b2 = new B { Name = "Voldia", Hobby = "Building", A = null };

			Console.Write("b2:");
			write_object(b2);

			b1.CopyPropertiesTo(b2);
			b1.A.Age = 20000;

			Console.Write("b1:");
			write_object(b1);

			Console.Write("b2:");
			write_object(b2);

			Console.ReadLine();
		}


		static void write_object(object o)
		{
			var str = Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
			Console.WriteLine(str);
		}
	}

	

	class A
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}

	class B
	{
		public string Name { get; set; }
		public string Hobby { get; set; }
		public A A { get; set; }
	}
}
