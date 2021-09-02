using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoutingMessing
{
	/*
	 * Здесь я хочу отработать маршрутизацию действий над объектами.
	 * 
	 * В проекте коллектора задач.
	 * Презентер обращается к сервису, который содержит в себе коллекцию репозиториев.
	 * И идет вызов конкретных методов CRUD
	 * 
	 * Работа с таблицей разнотипных элементов. Но все имеют единый интерфейс. Уже репозиторий знает как работать со своим типом.
	 * Но нужно направить из общей таблицы и направить в конкретный репо.
	 * 
	 * 
	 * АПИ вида
	 * Save(IClass o)
	 * 
	 * 
	 */

	public partial class Form1 : Form
	{
		List<ClassA> classA = new List<ClassA>();
		List<ClassB> classB = new List<ClassB>();
		List<IClass> classes = new List<IClass>();

		Dictionary<type, IModule> modules = new Dictionary<type, IModule>();

		IClass currentSource { get; set; }

		public Form1()
		{
			InitializeComponent();

			buildData();
			displayAll();
		}

		private void displayAll()
		{
			lbA.DataSource = null;
			lbB.DataSource = null;
			lbMain.DataSource = null;

			lbA.DataSource = classA;
			lbA.DisplayMember = "full_name";

			lbB.DataSource = classB;
			lbB.DisplayMember = "full_name";

			lbMain.DataSource = classes;
			lbMain.DisplayMember = "full_name";

			Text = classes.Count().ToString();
		}

		private void moveToMain(IClass c)
		{
			classes.Add(c);
			displayAll();
		}

		private void returnFromMain(IClass c)
		{
			classes.Remove(c);
			displayAll();
		}

		private void buildData()
		{
			classA.Add(new ClassA { name = "Roman", t = type.a});
			classA.Add(new ClassA { name = "Nata", t = type.a});
			classA.Add(new ClassA { name = "Vita", t = type.a});

			classB.Add(new ClassB { name = "Tema", t = type.b });
			classB.Add(new ClassB { name = "Oxy", t = type.b });
			classB.Add(new ClassB { name = "Max", t = type.b });
			classB.Add(new ClassB { name = "Staas", t = type.b });
		}

		private void btnToMain_Click(object sender, EventArgs e)
		{
			moveToMain(currentSource);
		}

		private void btnFromMain_Click(object sender, EventArgs e)
		{
			returnFromMain(getCurrentFromListBox(lbMain));
		}

		private void lbA_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListBox lb = sender as ListBox;
			currentSource = getCurrentFromListBox(lb);
		}

		private void lbA_Enter(object sender, EventArgs e)
		{
			ListBox lb = sender as ListBox;
			currentSource = getCurrentFromListBox(lb);
		}

		IClass getCurrentFromListBox(ListBox lb)
		{
			return lb.SelectedItem as IClass;
		}

		private void btnShowClass_Click(object sender, EventArgs e)
		{
			MessageBox.Show(currentSource.full_name);
		}
	}
}
