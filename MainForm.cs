using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab_5
{
	public partial class MainForm : Form
	{
		public AnimalDB Db { get; set; }
		public MainForm()
		{
			InitializeComponent();
			Db = new AnimalDB();
			//источник данных для binding
			BindingSource bSource = new BindingSource(Db.animalList, null);//binding list
			bindingNavigator.AddNewItem.Enabled = false;
			bindingNavigator.AddNewItem.Visible = false;
			bindingNavigator.DeleteItem.Enabled = false;
			dataGridView.DataSource = bSource;
			bindingNavigator.BindingSource = bSource;
			//dataGridView.Columns[0].HeaderText = "Название:";
			//dataGridView.Columns[1].HeaderText = "Латинское название:";
			//dataGridView.Columns[2].HeaderText = "Класс:";
			//dataGridView.Columns[3].HeaderText = "Средний вес (гр.):";
		}

		private void loadFileItem_Click(object sender, EventArgs e)
		{
			if (System.IO.File.Exists(Environment.CurrentDirectory + "/animal.xml"))
			{
				XmlSerializer xmlSer = new XmlSerializer(typeof(BindingList<Animal>));
				using (var stream = new FileStream(Environment.CurrentDirectory + "/animal.xml", FileMode.Open))
				{
					Db.animalList = ((BindingList<Animal>)xmlSer.Deserialize(stream));
					BindingSource bSource = new BindingSource(Db.animalList, null);//binding list
					dataGridView.DataSource = bSource;
					bindingNavigator.BindingSource = bSource;
				}
			}
		}

		private void saveFileItem_Click(object sender, EventArgs e)
		{
			XmlSerializer xmlSer = new XmlSerializer(typeof(BindingList<Animal>));
			using (var stream = new FileStream(Environment.CurrentDirectory + "/animal.xml", FileMode.Create))
			{
				xmlSer.Serialize(stream, Db.animalList);
			}
		}

		private void dataGridView_SelectionChanged(object sender, EventArgs e)
		{//передвинули выделение в таблице
		
			if (dataGridView.CurrentRow != null)
			{
				int curRow = dataGridView.CurrentRow.Index;

				propertyGrid.SelectedObject = Db.animalList[curRow];
				propertyGrid.Visible = true;

				//метод кот подгружает изображение из ресурса
				switch (Db.animalList[curRow].ALatName)
				{
					case "Lutra lutra":
						pictureBox1.Image = Properties.Resources.Otter;
						break;
					case "Microchiroptera":
						pictureBox1.Image = Properties.Resources.Bat;
						break;
					case "Ambystoma mexicanum":
						pictureBox1.Image = Properties.Resources.Axolotl;
						break;
					case "Bombus":
						pictureBox1.Image = Properties.Resources.Bumblebee;
						break;
					default:
						pictureBox1.Image = Properties.Resources.noImage;
						break;
				}
			}
			updateGraph();
			if (Db.animalList.Count > 1)
			{
				bindingNavigator.DeleteItem.Enabled = true;
			}
		}

		private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
				if (e.ColumnIndex == dataGridView.Columns["AWeight"].Index)
				{
					double d;
					
					//если строка еще не добавлена
					if (!Double.TryParse(e.FormattedValue.ToString(), out d) || d < 0)
					{
						e.Cancel = true;
						//не можем добавить некорректное значение 
					}
				updateGraph();
			}								
		}


		//строим график
		public void updateGraph() {
			chart.Series["Weight"].Points.Clear();
			foreach (Animal a in Db.animalList)
			{
				if (a.AName != null)
				{
					chart.Series["Weight"].Points.AddXY(a.AName, a.AWeight);
				}
			}
		}

		private void bSearch_Click(object sender, EventArgs e)
		{
			SearchForm s = new SearchForm(this);
			s.ShowDialog(this);
		}

		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{//доп. обработчик
			if (Db.animalList.Count<=1) {
				bindingNavigator.DeleteItem.Enabled = false;
			}
		}
	}
}
