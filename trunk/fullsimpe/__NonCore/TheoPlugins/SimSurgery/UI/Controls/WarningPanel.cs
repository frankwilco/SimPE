using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SimPe.Plugin.Helper;

namespace SimPe.Plugin.UI.Controls
{
	public partial class WarningPanel : UserControl
	{
		MessageBoxButtons buttons = MessageBoxButtons.OKCancel;

		public string Title
		{
			get { return this.lbTitle.Text; }
			set { this.lbTitle.Text = value; }
		}

		public string Description
		{
			get { return this.tbDescription.Text; }
			set { this.tbDescription.Text = value; }
		}

		public string Question
		{
			get { return this.lbQuestion.Text; }
			set { this.lbQuestion.Text = value; }
		}

		public MessageBoxButtons Buttons
		{
			get { return this.buttons; }
			set
			{
				if (value == MessageBoxButtons.OK)
				{
					this.btCancel.Visible = false;
				}
				else
					if (value == MessageBoxButtons.OKCancel)
					{
						this.btCancel.Visible = true;
					}

				this.buttons = value; 
			}
		}

		public string[] Lines
		{
			get { return this.tbDescription.Lines; }
			set { this.tbDescription.Lines = value; }
		}

		public WarningPanel()
		{
			
			InitializeComponent();
		}
	}
}
