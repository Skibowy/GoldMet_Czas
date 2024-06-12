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

namespace GoldMet_Czas
{
	public partial class SettingsForm : Form
	{
		public decimal ileKoszyDziennie = 0;
		public string excelFilePath = "C:/Users/dawis/Desktop/a.xls";
		public string txtFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "elementy.txt");

		public SettingsForm()
		{
			InitializeComponent();
		}

		private void btnZatwierdzUstawienia_Click(object sender, EventArgs e)
		{

		}
	}
}
