using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			//f1();

			f2();

			Console.ReadLine();
		}

		static void f2()
		{
			BaseDog base_dog;

			Dog d = new Dog() { age = 4, name = "bobik"};

			base_dog = d;

			foo(base_dog);
		}

		static void foo(BaseDog d)
		{
			Console.WriteLine(d.name);
		}

		static void f1()
		{
			List<Cat> cats = new List<Cat>();
			cats.Add(new Cat { Id = 1, Name = "Barsik", Age = 5 });
			cats.Add(new Cat { Id = 2, Name = "Mashka", Age = 15 });
			cats.Add(new Cat { Id = 3, Name = "Murka", Age = 3 });
			cats.Add(new Cat { Id = 4, Name = "Rijiy", Age = 5 });

			showEmployees(cats);

			var i = cats.FirstOrDefault(x => x.Id == 3);

			RmTaskModel service = new RmTaskModel().SetEntity(i);

			var edit_i = service.Clone();

			edit_i.Name = "789678 5789678";
			edit_i.Age = 100;

			service.Accept(edit_i);

			showEmployees(cats);
		}


		static void showEmployees(IEnumerable<Cat> items)
		{
			ConsoleTable table = new ConsoleTable(73);

			table.PrintLine();
			table.PrintRow("Id", "Name", "Age");
			table.PrintLine();

			foreach (var item in items)
			{
				table.PrintRow(item.Id.ToString(), item.Name, item.Age.ToString());
				table.PrintLine();
			}
		}
	}

	public class RmTaskModel
	{
		Cat _obj;

		public RmTaskModel(Cat t)
		{
			_obj = t;
		}

		public RmTaskModel()
		{

		}

		public RmTaskModel SetEntity(Cat t)
		{
			_obj = t;
			return this;
		}

		public Cat Clone()
		{
			return JsonCloner.Clone<Cat>(_obj);
		}

		public void Accept(Cat t)
		{
			if (t.Id != _obj.Id) throw new ArgumentException("Id does not fit to observable instance.");

			_obj.Age = t.Age;
			_obj.Name = t.Name;
		}
	}
}
