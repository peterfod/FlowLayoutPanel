using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//forrás: https://www.youtube.com/watch?v=NxfYFAw0JDs

namespace FlowLayoutPanel
{
	public partial class Form1 : Form
	{
		private static int sorszam = 1;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cmbFlowDirection.SelectedIndex = 0;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Button newButton = new Button();
			newButton.Name = txbControlName.Text;
			newButton.Text = txbControlText.Text;
			sampleFlowLayoutPanel.Controls.Add(newButton);
		}

		private void cmbFlowDirection_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cmbFlowDirection.Text)
			{
				case "LeftToRight":
					sampleFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
					break;
				case "TopDown":
					sampleFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
					break;
				case "RightToLeft":
					sampleFlowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
					break;
				case "BottonUp":
					sampleFlowLayoutPanel.FlowDirection = FlowDirection.BottomUp;
					break;
			}
		}

		private void chbWrapContens_CheckedChanged(object sender, EventArgs e)
		{
			if (chbWrapContens.Checked)
				sampleFlowLayoutPanel.WrapContents = true;
			else
				sampleFlowLayoutPanel.WrapContents = false;
		}

		private void chbAutoScroll_CheckedChanged(object sender, EventArgs e)
		{
			if (chbAutoScroll.Checked)
				sampleFlowLayoutPanel.AutoScroll = true;
			else
				sampleFlowLayoutPanel.AutoScroll = false;
		}

		private void btnAddTextBox_Click(object sender, EventArgs e)
		{
			TextBox newTextBox = new TextBox();
			newTextBox.Name = "txb" + sorszam.ToString();
			newTextBox.Text = sorszam.ToString();
			sampleFlowLayoutPanel.Controls.Add(newTextBox);
			sorszam++;
		}
	}
}
