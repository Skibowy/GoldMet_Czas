using ExcelDataReader;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GoldMet_Czas
{
	public partial class GoldMet : Form
	{
		decimal ilosc = 0;
		decimal wieszaki = 0;
		decimal ileNaWieszaku = 0;
		decimal ileKoszy = 0;
		string excelFilePath = "C:/Users/dawis/Desktop/a.xls";
		string txtFilePath = "C:/Users/dawis/Desktop/elementy.txt";
		List<Element> elements = new List<Element>();
		List<ElementZExcela> elementyZExcela = new List<ElementZExcela>();
		Dictionary<string, string> iloscDlaIdentyfikatora = new Dictionary<string, string>();
		public GoldMet()
		{
			InitializeComponent();
			txtIlosc.Text = ilosc.ToString();
			txtWieszaki.Text = wieszaki.ToString();
			txtIleNaWieszaku.Text = ileNaWieszaku.ToString();

			if (File.Exists(excelFilePath))
			{
				DataTable dt = LoadExcelData(excelFilePath);
				for (int i = 0; i < dt.Rows.Count - 1; i++)
				{
					DataRow row = dt.Rows[i];
					if (row.ItemArray.All(field => field == null || string.IsNullOrWhiteSpace(field.ToString())))
					{
						continue;
					}
					ElementZExcela elementZExcela = new ElementZExcela
					{
						Id = int.Parse(row[0].ToString()),
						Name = row[1].ToString(),
						Ilosc = int.Parse(row[5].ToString())
					};
					elementyZExcela.Add(elementZExcela);
					clbListaTowarow.Items.Add(row[0].ToString() + " " + row[1].ToString()/* + "  Sztuk: " + row[5].ToString()*/, true);
					iloscDlaIdentyfikatora.Add(row[0].ToString(), row[5].ToString());
				}
			}
			else
			{
				MessageBox.Show("Plik '.xls' nie istnieje");
			}

			if (File.Exists(txtFilePath))
			{
				elements = LoadElementsFromFile(txtFilePath);
			}
			else
			{
				Console.WriteLine("Plik '.txt' nie istnieje.");
			}

			this.cbElement.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbElement.DataSource = elements;
			this.cbElement.SelectedIndex = 0;
			this.cbElement.DisplayMember = "Name";
			this.cbElement.ValueMember = "Name";
			this.cbElement.SelectedIndexChanged += new System.EventHandler(this.cbElement_SelectedIndexChanged);
		}

		private void btnOblicz_Click(object sender, EventArgs e)
		{
			ilosc = decimal.Parse(txtIlosc.Text);
			wieszaki = decimal.Parse(txtWieszaki.Text);
			ileNaWieszaku = decimal.Parse(txtIleNaWieszaku.Text);
			if (wieszaki * ileNaWieszaku == 0)
			{
				ileKoszy = 0;
				txtKosze.Text = "0";
			}
			else
			{
				ileKoszy = (decimal)(ilosc / (wieszaki * ileNaWieszaku));
			}
			ileKoszy = Math.Ceiling(ileKoszy);

			foreach (var item in clbListaTowarow.CheckedItems)
			{
				string identyfikator = item.ToString().Substring(0, 6);
				int ilosc = int.Parse(iloscDlaIdentyfikatora[identyfikator]);
				string nazwaElementu = item.ToString().Substring(7);

				Element znaleziony = elements.FirstOrDefault(x => x.Name == nazwaElementu);
				wieszaki = znaleziony.IleWieszakow;
				ileNaWieszaku = znaleziony.IleNaWieszaku;

				if (wieszaki * ileNaWieszaku != 0)
				{
					ileKoszy += (decimal)(ilosc / (wieszaki * ileNaWieszaku));
				}
			}

			ileKoszy = Math.Ceiling(ileKoszy);
			txtKosze.Text = ileKoszy.ToString();

			dtpCzasUkonczenia.Value = CalculateCompletionDate((int)ileKoszy);
		}

		private void btnZaznaczWszystkie_Click(object sender, EventArgs e)
		{
			bool allChecked = true;

			for (int i = 0; i < clbListaTowarow.Items.Count; i++)
			{
				if (!clbListaTowarow.GetItemChecked(i))
				{
					allChecked = false;
					break;
				}
			}

			for (int i = 0; i < clbListaTowarow.Items.Count; i++)
			{
				clbListaTowarow.SetItemChecked(i, !allChecked);
			}
		}

		private void cbElement_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbElement.SelectedItem != null)
			{
				Element selectedElement = cbElement.SelectedItem as Element;
				if (selectedElement != null)
				{
					wieszaki = (decimal)selectedElement.IleWieszakow;
					txtWieszaki.Text = wieszaki.ToString();
					ileNaWieszaku = (decimal)selectedElement.IleNaWieszaku;
					txtIleNaWieszaku.Text = ileNaWieszaku.ToString();
				}
			}
		}

		private DateTime CalculateCompletionDate(int ileKoszy)
		{
			int totalDays = (int)Math.Ceiling(ileKoszy / 10.0);
			DateTime startDate = DateTime.Today;
			DateTime completionDate = startDate;

			while (totalDays > 0)
			{
				completionDate = completionDate.AddDays(1);
				if (completionDate.DayOfWeek != DayOfWeek.Saturday && completionDate.DayOfWeek != DayOfWeek.Sunday)
				{
					totalDays--;
				}
			}
			return completionDate;
		}

		private static DataTable LoadExcelData(string path)
		{
			System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

			using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
			{
				using (var reader = ExcelReaderFactory.CreateReader(stream))
				{
					var result = reader.AsDataSet(new ExcelDataSetConfiguration()
					{
						ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
						{
							UseHeaderRow = true
						}
					});
					DataTableCollection tables = result.Tables;
					DataTable dt = tables[0];
					return dt;
				}
			}
		}

		private class Element
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public int IleWieszakow { get; set; }
			public int IleNaWieszaku { get; set; }
		}

		private class ElementZExcela
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public int Ilosc { get; set; }
		}

		private static List<Element> LoadElementsFromFile(string path)
		{
			List<Element> elements = new List<Element>();

			foreach (var line in File.ReadLines(path))
			{
				string[] parts = line.Split(';');
				if (parts.Length == 4)
				{
					Element element = new Element
					{
						Name = parts[1],
						IleWieszakow = int.Parse(parts[2]),
						IleNaWieszaku = int.Parse(parts[3])
					};
					elements.Add(element);
				}
			}
			return elements;
		}
	}
}
