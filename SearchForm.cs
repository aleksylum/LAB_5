using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5
{
	public partial class SearchForm : Form
	{
		private MainForm parentForm;
		public BindingList<Animal> ResList { get; set; }
		public SearchForm(MainForm pForm)
		{
			InitializeComponent();
			parentForm = pForm;

			ResList = new BindingList<Animal>();
			dataGridView.DataSource = ResList;

			for (int i=0;i< dataGridView.ColumnCount-1;++i)
			{
				cbFields.Items.Add(dataGridView.Columns[i].HeaderText);
			}
			cbFields.SelectedIndex = 0;
		}

		public void Search()
		{
			ResList.Clear();
			
			int curCol = cbFields.SelectedIndex;
			string query = tbSearch.Text.Trim();
			string res;
			if (parentForm.Db.animalList != null) {
				foreach (var a in parentForm.Db.animalList)
				{
					switch (curCol)
					{
						//case "AName":
						case 0:
							res = a.AName;
							break;
						//case "ALatName":
						case 1:
							res = a.ALatName;
							break;
						//case "AClass":
						case 2:
							res = a.AClass;
							break;
						default:
							res = "";
							break;
					}
					if (res!=null && res.ToLower().Equals(query.ToLower()))
					{
						ResList.Add(a);
					}
				}
			}
		}

		private void bSearch_Click(object sender, EventArgs e)
		{
			Search();
		}
	}
}
