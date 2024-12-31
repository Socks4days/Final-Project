namespace Final_Project
{
	partial class frmCreateAudit
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
			pnlCreateAudit = new Panel();
			btnCancel = new Button();
			label2 = new Label();
			label1 = new Label();
			nUDNoInStockActual = new NumericUpDown();
			lblNoExpectedInStock = new Label();
			btnCreatAudit = new Button();
			cBoxStock = new ComboBox();
			pnlCreateAudit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nUDNoInStockActual).BeginInit();
			SuspendLayout();
			// 
			// pnlCreateAudit
			// 
			pnlCreateAudit.Controls.Add(btnCancel);
			pnlCreateAudit.Controls.Add(label2);
			pnlCreateAudit.Controls.Add(label1);
			pnlCreateAudit.Controls.Add(nUDNoInStockActual);
			pnlCreateAudit.Controls.Add(lblNoExpectedInStock);
			pnlCreateAudit.Controls.Add(btnCreatAudit);
			pnlCreateAudit.Controls.Add(cBoxStock);
			pnlCreateAudit.Dock = DockStyle.Top;
			pnlCreateAudit.Location = new Point(0, 0);
			pnlCreateAudit.Name = "pnlCreateAudit";
			pnlCreateAudit.Size = new Size(984, 680);
			pnlCreateAudit.TabIndex = 0;
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.FromArgb(255, 138, 98);
			btnCancel.FlatAppearance.BorderSize = 0;
			btnCancel.FlatStyle = FlatStyle.Flat;
			btnCancel.Font = new Font("Segoe UI", 14F);
			btnCancel.Location = new Point(232, 505);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(220, 50);
			btnCancel.TabIndex = 7;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14F);
			label2.Location = new Point(376, 140);
			label2.Name = "label2";
			label2.Size = new Size(111, 25);
			label2.TabIndex = 6;
			label2.Text = "Select Stock";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14F);
			label1.Location = new Point(376, 317);
			label1.Name = "label1";
			label1.Size = new Size(204, 25);
			label1.TabIndex = 5;
			label1.Text = "Enter Number In Stock:";
			// 
			// nUDNoInStockActual
			// 
			nUDNoInStockActual.Font = new Font("Segoe UI", 14F);
			nUDNoInStockActual.Location = new Point(376, 345);
			nUDNoInStockActual.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
			nUDNoInStockActual.Name = "nUDNoInStockActual";
			nUDNoInStockActual.Size = new Size(220, 32);
			nUDNoInStockActual.TabIndex = 4;
			// 
			// lblNoExpectedInStock
			// 
			lblNoExpectedInStock.AutoSize = true;
			lblNoExpectedInStock.Font = new Font("Segoe UI", 14F);
			lblNoExpectedInStock.Location = new Point(376, 266);
			lblNoExpectedInStock.Name = "lblNoExpectedInStock";
			lblNoExpectedInStock.Size = new Size(236, 25);
			lblNoExpectedInStock.TabIndex = 2;
			lblNoExpectedInStock.Text = "Number Expected In Stock:";
			// 
			// btnCreatAudit
			// 
			btnCreatAudit.BackColor = Color.FromArgb(255, 138, 98);
			btnCreatAudit.FlatAppearance.BorderSize = 0;
			btnCreatAudit.FlatStyle = FlatStyle.Flat;
			btnCreatAudit.Font = new Font("Segoe UI", 14F);
			btnCreatAudit.Location = new Point(507, 505);
			btnCreatAudit.Name = "btnCreatAudit";
			btnCreatAudit.Size = new Size(220, 50);
			btnCreatAudit.TabIndex = 1;
			btnCreatAudit.Text = "Create Audit";
			btnCreatAudit.UseVisualStyleBackColor = false;
			// 
			// cBoxStock
			// 
			cBoxStock.Font = new Font("Segoe UI", 14F);
			cBoxStock.FormattingEnabled = true;
			cBoxStock.Location = new Point(376, 168);
			cBoxStock.Name = "cBoxStock";
			cBoxStock.Size = new Size(220, 33);
			cBoxStock.TabIndex = 0;
			cBoxStock.SelectionChangeCommitted += cBoxStock_SelectionChangeCommitted;
			// 
			// frmCreateAudit
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoScroll = true;
			AutoSize = true;
			BackColor = SystemColors.ScrollBar;
			ClientSize = new Size(984, 681);
			Controls.Add(pnlCreateAudit);
			Name = "frmCreateAudit";
			Text = "frmCreateAudit";
			pnlCreateAudit.ResumeLayout(false);
			pnlCreateAudit.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nUDNoInStockActual).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlCreateAudit;
		private NumericUpDown numericUpDown1;
		private Label lblNoExpectedInStock;
		private Button btnCreatAudit;
		private ComboBox cBoxStock;
		private NumericUpDown nUDNoInStockActual;
		private Label label1;
		private Label label2;
		private Button btnCancel;
	}
}