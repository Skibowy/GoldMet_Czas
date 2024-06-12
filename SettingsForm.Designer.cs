namespace GoldMet_Czas
{
	partial class SettingsForm
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
			this.btnZatwierdzUstawienia = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSciezkaDoTxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSciezkaDoXls = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtIleKoszyDziennie = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnZatwierdzUstawienia
			// 
			this.btnZatwierdzUstawienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnZatwierdzUstawienia.Location = new System.Drawing.Point(18, 296);
			this.btnZatwierdzUstawienia.Name = "btnZatwierdzUstawienia";
			this.btnZatwierdzUstawienia.Size = new System.Drawing.Size(248, 59);
			this.btnZatwierdzUstawienia.TabIndex = 0;
			this.btnZatwierdzUstawienia.Text = "Zatwierdź";
			this.btnZatwierdzUstawienia.UseVisualStyleBackColor = true;
			this.btnZatwierdzUstawienia.Click += new System.EventHandler(this.btnZatwierdzUstawienia_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(254, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ścieżka do pliku .txt";
			// 
			// txtSciezkaDoTxt
			// 
			this.txtSciezkaDoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtSciezkaDoTxt.Location = new System.Drawing.Point(18, 43);
			this.txtSciezkaDoTxt.Name = "txtSciezkaDoTxt";
			this.txtSciezkaDoTxt.Size = new System.Drawing.Size(248, 38);
			this.txtSciezkaDoTxt.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(12, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(258, 31);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ścieżka do pliku .xls";
			// 
			// txtSciezkaDoXls
			// 
			this.txtSciezkaDoXls.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtSciezkaDoXls.Location = new System.Drawing.Point(18, 136);
			this.txtSciezkaDoXls.Name = "txtSciezkaDoXls";
			this.txtSciezkaDoXls.Size = new System.Drawing.Size(248, 38);
			this.txtSciezkaDoXls.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(12, 197);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(229, 31);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ile koszy dziennie";
			// 
			// txtIleKoszyDziennie
			// 
			this.txtIleKoszyDziennie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtIleKoszyDziennie.Location = new System.Drawing.Point(18, 231);
			this.txtIleKoszyDziennie.Name = "txtIleKoszyDziennie";
			this.txtIleKoszyDziennie.Size = new System.Drawing.Size(248, 38);
			this.txtIleKoszyDziennie.TabIndex = 6;
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(286, 368);
			this.Controls.Add(this.txtIleKoszyDziennie);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSciezkaDoXls);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSciezkaDoTxt);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnZatwierdzUstawienia);
			this.Name = "SettingsForm";
			this.Text = "SettingsForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnZatwierdzUstawienia;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSciezkaDoTxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSciezkaDoXls;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtIleKoszyDziennie;
	}
}