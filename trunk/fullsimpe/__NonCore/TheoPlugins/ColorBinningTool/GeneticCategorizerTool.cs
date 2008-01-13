using System;
using System.Drawing;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Plugin;
using System.Threading;
using SimPe.Plugin.UI;

namespace SimPe.Plugin
{
	/// <summary>
	/// Summary description for GeneticCategorizerTool.
	/// </summary>
	public class GeneticCategorizerTool :  AbstractTool, IToolPlugin, ITool
	{

		#region IToolPlugin Members

		public override string ToString()
		{
			return "Color Binning Tool";
		}

		#endregion

		public override bool Visible
		{
			get { return true; }
		}

		#region ITool Members

		public bool IsEnabled(IPackedFileDescriptor pfd, IPackageFile package)
		{
			return true;
		}

		public IToolResult ShowDialog(ref IPackedFileDescriptor pfd, ref IPackageFile package)
		{
			EnsureFileTable();

			MainForm form = new MainForm();
			//form.WindowsRegistry = Helper.WindowsRegistry;
			form.Show();

			return new ToolResult(false, false);
		}


		#endregion

		public override System.Drawing.Image Icon
		{
			get
			{
				Image icon = Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.ColorBinningTool.png"));
				return icon;
			}
		}

		public static void EnsureFileTable()
		{
			if (!FileTable.FileIndex.Loaded)
			{
				ThreadStart ts = new ThreadStart(LoadFileTable);
				Thread t = new Thread(ts);
				t.Start();
			}

		}


		static void LoadFileTable()
		{
			WaitingScreen.Wait();
			WaitingScreen.UpdateMessage("Loading File Table...");
			FileTable.FileIndex.Load();
			WaitingScreen.Stop();
		}

	}


}
