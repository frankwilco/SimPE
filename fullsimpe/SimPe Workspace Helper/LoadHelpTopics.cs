using System;

namespace SimPe
{
	/// <summary>
	/// An Item in the Help Menu
	/// </summary>
	class HelpTopicMenuItem : TD.SandBar.MenuButtonItem
	{
		SimPe.Interfaces.IHelp topic;
		public HelpTopicMenuItem(SimPe.Interfaces.IHelp topic):base()
		{			
			this.topic = topic;
			this.Text = GetName();
			this.Image = topic.Icon;

			this.Activate += new EventHandler(HelpTopicMenuItem_Activate);			
		}	
	
		public string GetName()
		{
			string[] path = GetMenuPath();
			if (path.Length>0) return SimPe.Localization.GetString(path[path.Length-1]);
			return SimPe.Localization.GetString("Unknown");
		}

		public string[] GetMenuPath()
		{
			return topic.ToString().Split(new char[]{'\\'});
		}

		private void HelpTopicMenuItem_Activate(object sender, EventArgs e)
		{
			topic.ShowHelp(new SimPe.ShowHelpEventArgs());
		}
	}

	/// <summary>
	/// Used to add HelpTopics to a Menu
	/// </summary>
	public class LoadHelpTopics
	{
		TD.SandBar.MenuItemBase mbi;
		public LoadHelpTopics(TD.SandBar.MenuItemBase parentmenu)
		{
			mbi = parentmenu;
			AddItems(SimPe.FileTable.HelpTopicRegistry);
			SetupImages(parentmenu);
		}

		void SetupImages(TD.SandBar.MenuItemBase parent)
		{
			foreach (TD.SandBar.MenuItemBase m in parent.Items)
			{
				SetupImages(m);
				if (parent.Image==null && m.Image!=null)
					parent.Image = m.Image;
			}

			if (parent.Image == null)
				parent.Image = System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.agt_support.png"));
		}

		void AddItems(SimPe.Interfaces.IHelpRegistry reg)
		{
			foreach (SimPe.Interfaces.IHelp topic in reg.HelpTopics)
				AddItem(topic);
		}

		void AddItem(SimPe.Interfaces.IHelp topic)
		{
			HelpTopicMenuItem htmi = new HelpTopicMenuItem(topic);
			string[] path = htmi.GetMenuPath();

			TD.SandBar.MenuItemBase parent = mbi;
			for (int i=0; i<path.Length-1; i++)
			{
				string n = SimPe.Localization.GetString(path[i]);

				TD.SandBar.MenuButtonItem m = null;
				foreach (TD.SandBar.MenuButtonItem item in parent.Items)
				{
					if (item.Text.Trim().ToLower()==n.Trim().ToLower()) 
					{
						m = item;
						break;
					}
				}
				if (m==null) 
				{
					m = new TD.SandBar.MenuButtonItem(n);
					parent.Items.Add(m);
				}
				parent = m;
			}
			parent.Items.Add(htmi);
		}
	}
}
