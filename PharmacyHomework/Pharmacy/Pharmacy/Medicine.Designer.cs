namespace Pharmacy
{
	partial class Medicine
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDermantipi = new System.Windows.Forms.TextBox();
			this.txtDermanAdi = new System.Windows.Forms.TextBox();
			this.txtDermanqitmeti = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.update = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.Add = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 246);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1084, 294);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(35, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Derman Novu:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(35, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Dermanin Adi:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(35, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 19);
			this.label3.TabIndex = 3;
			this.label3.Text = "Qiymet:";
			// 
			// txtDermantipi
			// 
			this.txtDermantipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtDermantipi.Location = new System.Drawing.Point(149, 36);
			this.txtDermantipi.Name = "txtDermantipi";
			this.txtDermantipi.Size = new System.Drawing.Size(156, 26);
			this.txtDermantipi.TabIndex = 4;
			// 
			// txtDermanAdi
			// 
			this.txtDermanAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtDermanAdi.Location = new System.Drawing.Point(149, 94);
			this.txtDermanAdi.Name = "txtDermanAdi";
			this.txtDermanAdi.Size = new System.Drawing.Size(156, 26);
			this.txtDermanAdi.TabIndex = 5;
			// 
			// txtDermanqitmeti
			// 
			this.txtDermanqitmeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtDermanqitmeti.Location = new System.Drawing.Point(149, 149);
			this.txtDermanqitmeti.Name = "txtDermanqitmeti";
			this.txtDermanqitmeti.Size = new System.Drawing.Size(156, 26);
			this.txtDermanqitmeti.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Orange;
			this.panel1.Controls.Add(this.update);
			this.panel1.Controls.Add(this.delete);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.Add);
			this.panel1.Location = new System.Drawing.Point(361, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(403, 135);
			this.panel1.TabIndex = 7;
			// 
			// update
			// 
			this.update.Location = new System.Drawing.Point(12, 56);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(97, 44);
			this.update.TabIndex = 10;
			this.update.Text = "Update";
			this.update.UseVisualStyleBackColor = true;
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// delete
			// 
			this.delete.Location = new System.Drawing.Point(129, 3);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(105, 37);
			this.delete.TabIndex = 9;
			this.delete.Text = "Delete";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(270, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 8;
			// 
			// Add
			// 
			this.Add.BackColor = System.Drawing.Color.Silver;
			this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Add.ForeColor = System.Drawing.Color.White;
			this.Add.Location = new System.Drawing.Point(12, 3);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(97, 37);
			this.Add.TabIndex = 0;
			this.Add.Text = "Add Medicine";
			this.Add.UseVisualStyleBackColor = false;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// Medicine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(1084, 540);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtDermanqitmeti);
			this.Controls.Add(this.txtDermanAdi);
			this.Controls.Add(this.txtDermantipi);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Medicine";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Medicine List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Medicine_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDermantipi;
		private System.Windows.Forms.TextBox txtDermanAdi;
		private System.Windows.Forms.TextBox txtDermanqitmeti;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button delete;
		public System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button update;
	}
}