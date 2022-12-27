
namespace FlowLayoutPanel
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sampleFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbFlowDirection = new System.Windows.Forms.ComboBox();
			this.txbControlName = new System.Windows.Forms.TextBox();
			this.txbControlText = new System.Windows.Forms.TextBox();
			this.chbWrapContens = new System.Windows.Forms.CheckBox();
			this.chbAutoScroll = new System.Windows.Forms.CheckBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnAddTextBox = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// sampleFlowLayoutPanel
			// 
			this.sampleFlowLayoutPanel.Location = new System.Drawing.Point(21, 118);
			this.sampleFlowLayoutPanel.Name = "sampleFlowLayoutPanel";
			this.sampleFlowLayoutPanel.Size = new System.Drawing.Size(282, 101);
			this.sampleFlowLayoutPanel.TabIndex = 0;
			this.sampleFlowLayoutPanel.WrapContents = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Flow Direction:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 243);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Control Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(64, 284);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Control Text:";
			// 
			// cmbFlowDirection
			// 
			this.cmbFlowDirection.FormattingEnabled = true;
			this.cmbFlowDirection.Items.AddRange(new object[] {
            "LeftToRight",
            "TopDown",
            "RightToLeft",
            "BottonUp"});
			this.cmbFlowDirection.Location = new System.Drawing.Point(154, 27);
			this.cmbFlowDirection.Name = "cmbFlowDirection";
			this.cmbFlowDirection.Size = new System.Drawing.Size(121, 23);
			this.cmbFlowDirection.TabIndex = 20;
			this.cmbFlowDirection.SelectedIndexChanged += new System.EventHandler(this.cmbFlowDirection_SelectedIndexChanged);
			// 
			// txbControlName
			// 
			this.txbControlName.Location = new System.Drawing.Point(171, 240);
			this.txbControlName.Name = "txbControlName";
			this.txbControlName.Size = new System.Drawing.Size(100, 23);
			this.txbControlName.TabIndex = 5;
			// 
			// txbControlText
			// 
			this.txbControlText.Location = new System.Drawing.Point(171, 281);
			this.txbControlText.Name = "txbControlText";
			this.txbControlText.Size = new System.Drawing.Size(100, 23);
			this.txbControlText.TabIndex = 6;
			// 
			// chbWrapContens
			// 
			this.chbWrapContens.AutoSize = true;
			this.chbWrapContens.Location = new System.Drawing.Point(154, 59);
			this.chbWrapContens.Name = "chbWrapContens";
			this.chbWrapContens.Size = new System.Drawing.Size(105, 19);
			this.chbWrapContens.TabIndex = 7;
			this.chbWrapContens.Text = "Wrap Contents";
			this.chbWrapContens.UseVisualStyleBackColor = true;
			this.chbWrapContens.CheckedChanged += new System.EventHandler(this.chbWrapContens_CheckedChanged);
			// 
			// chbAutoScroll
			// 
			this.chbAutoScroll.AutoSize = true;
			this.chbAutoScroll.Location = new System.Drawing.Point(154, 84);
			this.chbAutoScroll.Name = "chbAutoScroll";
			this.chbAutoScroll.Size = new System.Drawing.Size(81, 19);
			this.chbAutoScroll.TabIndex = 8;
			this.chbAutoScroll.Text = "AutoScroll";
			this.chbAutoScroll.UseVisualStyleBackColor = true;
			this.chbAutoScroll.CheckedChanged += new System.EventHandler(this.chbAutoScroll_CheckedChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(171, 324);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(88, 23);
			this.btnAdd.TabIndex = 9;
			this.btnAdd.Text = "Add Button";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnAddTextBox
			// 
			this.btnAddTextBox.Location = new System.Drawing.Point(171, 365);
			this.btnAddTextBox.Name = "btnAddTextBox";
			this.btnAddTextBox.Size = new System.Drawing.Size(88, 23);
			this.btnAddTextBox.TabIndex = 10;
			this.btnAddTextBox.Text = "Add TextBox";
			this.btnAddTextBox.UseVisualStyleBackColor = true;
			this.btnAddTextBox.Click += new System.EventHandler(this.btnAddTextBox_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 412);
			this.Controls.Add(this.btnAddTextBox);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.chbAutoScroll);
			this.Controls.Add(this.chbWrapContens);
			this.Controls.Add(this.txbControlText);
			this.Controls.Add(this.txbControlName);
			this.Controls.Add(this.cmbFlowDirection);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.sampleFlowLayoutPanel);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FlowLayoutPanel";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel sampleFlowLayoutPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbFlowDirection;
		private System.Windows.Forms.TextBox txbControlName;
		private System.Windows.Forms.TextBox txbControlText;
		private System.Windows.Forms.CheckBox chbWrapContens;
		private System.Windows.Forms.CheckBox chbAutoScroll;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnAddTextBox;
	}
}

