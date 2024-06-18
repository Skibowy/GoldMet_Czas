namespace GoldMet_Czas
{
	partial class GoldMet
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoldMet));
			this.clbListaTowarow = new System.Windows.Forms.CheckedListBox();
			this.btnOblicz = new System.Windows.Forms.Button();
			this.lblIlosc = new System.Windows.Forms.Label();
			this.txtIlosc = new System.Windows.Forms.TextBox();
			this.lblWieszak = new System.Windows.Forms.Label();
			this.txtWieszaki = new System.Windows.Forms.TextBox();
			this.lblIleNaWieszaku = new System.Windows.Forms.Label();
			this.txtIleNaWieszaku = new System.Windows.Forms.TextBox();
			this.dtpCzasUkonczenia = new System.Windows.Forms.DateTimePicker();
			this.lblKosze = new System.Windows.Forms.Label();
			this.txtKosze = new System.Windows.Forms.TextBox();
			this.cbElement = new System.Windows.Forms.ComboBox();
			this.lblElement = new System.Windows.Forms.Label();
			this.btnZaznaczWszystkie = new System.Windows.Forms.Button();
			this.btnDodaj = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// clbListaTowarow
			// 
			this.clbListaTowarow.FormattingEnabled = true;
			this.clbListaTowarow.Location = new System.Drawing.Point(12, 12);
			this.clbListaTowarow.Name = "clbListaTowarow";
			this.clbListaTowarow.Size = new System.Drawing.Size(328, 529);
			this.clbListaTowarow.TabIndex = 0;
			// 
			// btnOblicz
			// 
			this.btnOblicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnOblicz.Location = new System.Drawing.Point(360, 485);
			this.btnOblicz.Name = "btnOblicz";
			this.btnOblicz.Size = new System.Drawing.Size(194, 56);
			this.btnOblicz.TabIndex = 1;
			this.btnOblicz.Text = "Oblicz";
			this.btnOblicz.UseVisualStyleBackColor = true;
			this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
			// 
			// lblIlosc
			// 
			this.lblIlosc.AutoSize = true;
			this.lblIlosc.BackColor = System.Drawing.Color.Transparent;
			this.lblIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblIlosc.ForeColor = System.Drawing.Color.Gold;
			this.lblIlosc.Location = new System.Drawing.Point(360, 199);
			this.lblIlosc.Name = "lblIlosc";
			this.lblIlosc.Size = new System.Drawing.Size(71, 31);
			this.lblIlosc.TabIndex = 2;
			this.lblIlosc.Text = "Ilość";
			// 
			// txtIlosc
			// 
			this.txtIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtIlosc.Location = new System.Drawing.Point(360, 233);
			this.txtIlosc.Name = "txtIlosc";
			this.txtIlosc.Size = new System.Drawing.Size(194, 38);
			this.txtIlosc.TabIndex = 3;
			// 
			// lblWieszak
			// 
			this.lblWieszak.AutoSize = true;
			this.lblWieszak.BackColor = System.Drawing.Color.Transparent;
			this.lblWieszak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblWieszak.ForeColor = System.Drawing.Color.Gold;
			this.lblWieszak.Location = new System.Drawing.Point(837, 212);
			this.lblWieszak.Name = "lblWieszak";
			this.lblWieszak.Size = new System.Drawing.Size(123, 31);
			this.lblWieszak.TabIndex = 4;
			this.lblWieszak.Text = "Wieszaki";
			// 
			// txtWieszaki
			// 
			this.txtWieszaki.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtWieszaki.Location = new System.Drawing.Point(843, 246);
			this.txtWieszaki.Name = "txtWieszaki";
			this.txtWieszaki.Size = new System.Drawing.Size(194, 38);
			this.txtWieszaki.TabIndex = 5;
			// 
			// lblIleNaWieszaku
			// 
			this.lblIleNaWieszaku.AutoSize = true;
			this.lblIleNaWieszaku.BackColor = System.Drawing.Color.Transparent;
			this.lblIleNaWieszaku.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblIleNaWieszaku.ForeColor = System.Drawing.Color.Gold;
			this.lblIleNaWieszaku.Location = new System.Drawing.Point(837, 287);
			this.lblIleNaWieszaku.Name = "lblIleNaWieszaku";
			this.lblIleNaWieszaku.Size = new System.Drawing.Size(200, 31);
			this.lblIleNaWieszaku.TabIndex = 6;
			this.lblIleNaWieszaku.Text = "Ile na wieszaku";
			// 
			// txtIleNaWieszaku
			// 
			this.txtIleNaWieszaku.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtIleNaWieszaku.Location = new System.Drawing.Point(843, 321);
			this.txtIleNaWieszaku.Name = "txtIleNaWieszaku";
			this.txtIleNaWieszaku.Size = new System.Drawing.Size(194, 38);
			this.txtIleNaWieszaku.TabIndex = 7;
			// 
			// dtpCzasUkonczenia
			// 
			this.dtpCzasUkonczenia.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
			this.dtpCzasUkonczenia.CalendarTitleForeColor = System.Drawing.SystemColors.Desktop;
			this.dtpCzasUkonczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dtpCzasUkonczenia.Location = new System.Drawing.Point(360, 558);
			this.dtpCzasUkonczenia.Name = "dtpCzasUkonczenia";
			this.dtpCzasUkonczenia.Size = new System.Drawing.Size(677, 50);
			this.dtpCzasUkonczenia.TabIndex = 8;
			// 
			// lblKosze
			// 
			this.lblKosze.AutoSize = true;
			this.lblKosze.BackColor = System.Drawing.Color.Transparent;
			this.lblKosze.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblKosze.ForeColor = System.Drawing.Color.Gold;
			this.lblKosze.Location = new System.Drawing.Point(837, 469);
			this.lblKosze.Name = "lblKosze";
			this.lblKosze.Size = new System.Drawing.Size(90, 31);
			this.lblKosze.TabIndex = 9;
			this.lblKosze.Text = "Kosze";
			// 
			// txtKosze
			// 
			this.txtKosze.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtKosze.Location = new System.Drawing.Point(843, 503);
			this.txtKosze.Name = "txtKosze";
			this.txtKosze.Size = new System.Drawing.Size(194, 38);
			this.txtKosze.TabIndex = 10;
			// 
			// cbElement
			// 
			this.cbElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cbElement.FormattingEnabled = true;
			this.cbElement.Location = new System.Drawing.Point(360, 137);
			this.cbElement.Name = "cbElement";
			this.cbElement.Size = new System.Drawing.Size(677, 39);
			this.cbElement.TabIndex = 11;
			// 
			// lblElement
			// 
			this.lblElement.AutoSize = true;
			this.lblElement.BackColor = System.Drawing.Color.Transparent;
			this.lblElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblElement.ForeColor = System.Drawing.Color.Gold;
			this.lblElement.Location = new System.Drawing.Point(354, 103);
			this.lblElement.Name = "lblElement";
			this.lblElement.Size = new System.Drawing.Size(113, 31);
			this.lblElement.TabIndex = 12;
			this.lblElement.Text = "Element";
			// 
			// btnZaznaczWszystkie
			// 
			this.btnZaznaczWszystkie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnZaznaczWszystkie.Location = new System.Drawing.Point(12, 558);
			this.btnZaznaczWszystkie.Name = "btnZaznaczWszystkie";
			this.btnZaznaczWszystkie.Size = new System.Drawing.Size(328, 51);
			this.btnZaznaczWszystkie.TabIndex = 13;
			this.btnZaznaczWszystkie.Text = "Zaznacz wszystkie";
			this.btnZaznaczWszystkie.UseVisualStyleBackColor = true;
			this.btnZaznaczWszystkie.Click += new System.EventHandler(this.btnZaznaczWszystkie_Click);
			// 
			// btnDodaj
			// 
			this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnDodaj.Location = new System.Drawing.Point(360, 303);
			this.btnDodaj.Name = "btnDodaj";
			this.btnDodaj.Size = new System.Drawing.Size(194, 56);
			this.btnDodaj.TabIndex = 14;
			this.btnDodaj.Text = "Dodaj";
			this.btnDodaj.UseVisualStyleBackColor = true;
			this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.Gold;
			this.label1.Location = new System.Drawing.Point(354, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 31);
			this.label1.TabIndex = 15;
			this.label1.Text = "Wpisz nazwę";
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtSearch.Location = new System.Drawing.Point(360, 46);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(677, 38);
			this.txtSearch.TabIndex = 16;
			// 
			// GoldMet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1060, 621);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDodaj);
			this.Controls.Add(this.btnZaznaczWszystkie);
			this.Controls.Add(this.lblElement);
			this.Controls.Add(this.cbElement);
			this.Controls.Add(this.txtKosze);
			this.Controls.Add(this.lblKosze);
			this.Controls.Add(this.dtpCzasUkonczenia);
			this.Controls.Add(this.txtIleNaWieszaku);
			this.Controls.Add(this.lblIleNaWieszaku);
			this.Controls.Add(this.txtWieszaki);
			this.Controls.Add(this.lblWieszak);
			this.Controls.Add(this.txtIlosc);
			this.Controls.Add(this.lblIlosc);
			this.Controls.Add(this.btnOblicz);
			this.Controls.Add(this.clbListaTowarow);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GoldMet";
			this.ShowIcon = false;
			this.Text = "GoldMet";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox clbListaTowarow;
		private System.Windows.Forms.Button btnOblicz;
		private System.Windows.Forms.Label lblIlosc;
		private System.Windows.Forms.TextBox txtIlosc;
		private System.Windows.Forms.Label lblWieszak;
		private System.Windows.Forms.TextBox txtWieszaki;
		private System.Windows.Forms.Label lblIleNaWieszaku;
		private System.Windows.Forms.TextBox txtIleNaWieszaku;
		private System.Windows.Forms.DateTimePicker dtpCzasUkonczenia;
		private System.Windows.Forms.Label lblKosze;
		private System.Windows.Forms.TextBox txtKosze;
		private System.Windows.Forms.ComboBox cbElement;
		private System.Windows.Forms.Label lblElement;
		private System.Windows.Forms.Button btnZaznaczWszystkie;
		private System.Windows.Forms.Button btnDodaj;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSearch;
	}
}

