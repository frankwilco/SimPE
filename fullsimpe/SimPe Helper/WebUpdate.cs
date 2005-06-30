using System;
using System.Net;
using System.IO;
#if MAC
#else
using System.Runtime ;
using System.Runtime.InteropServices ;
#endif

namespace SimPe
{
	/// <summary>
	/// Update availability state
	/// </summary>
	public enum UpdateState:byte
	{
		Nothing = 0,
		NewRelease = 1,
		NewQARelease = 2,
		BothNew = 3
	}

	/// <summary>
	/// Use this class to Download upDate content
	/// </summary>
	public class WebUpdate
	{
		/// <summary>
		/// Doanload A File from the Internet
		/// </summary>
		/// <param name="URL"></param>
		/// <param name="Filename"></param>
		/// <param name="progress"></param>
		public static void DownloadFile(string URL, string Filename)
		{
			WebClient cli = new WebClient();
			Stream fDnld = null, fOut = null;

			WaitingScreen.Wait();
			int total = 0;
			try
			{
				fDnld = cli.OpenRead(URL);
				string sTotal = cli.ResponseHeaders["Content-Length"];
				int nTotal = (sTotal==null || sTotal.Length==0) ? 0 : Convert.ToInt32(sTotal);

				fOut = File.Create(Filename);
				byte[] buf = new byte[4096];
				int nBytesRead;
				while ((nBytesRead = fDnld.Read(buf, 0, buf.Length)) > 0)
				{
					total += nBytesRead;
					WaitingScreen.UpdateMessage(total.ToString()+" of "+nTotal.ToString());
					fOut.Write(buf, 0, nBytesRead);
				}
			}
			catch{ throw; }
			finally
			{
				WaitingScreen.Stop();
				if (fDnld!=null) fDnld.Close();
				if (fOut!=null) fOut.Close();				
			}
		}

		/// <summary>
		/// Install the Managed DX from the Sims CD
		/// </summary>
		/// <returns>true if success</returns>
		public static bool InstallMDX()
		{
			WebClient Client = new WebClient ();
			try 
			{
				WaitingScreen.Wait();
				string tempname = System.IO.Path.GetTempFileName()+".msi";
				DownloadFile("http://sims.ambertation.de/files/mdxredist.msi", tempname);

				WaitingScreen.Stop();
				try 
				{
					System.Diagnostics.Process p = System.Diagnostics.Process.Start(tempname);
					p.WaitForExit();

					return true;
				} 
				finally 
				{
					System.IO.File.Delete(tempname);
				}

			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("Unable to download the instalation File.", ex);
			}
			finally 
			{
				WaitingScreen.Stop();
			}

			return false;
		}

		/// <summary>
		/// Install the Photostudio Templates
		/// </summary>
		/// <returns>true if success</returns>
		public static bool InstallTemplates()
		{
			WebClient Client = new WebClient ();
			try 
			{
				WaitingScreen.Wait();
				string tempname = System.IO.Path.GetTempFileName()+".exe";
				DownloadFile("http://sims.ambertation.de/files/SimPE-Templates-Setup.exe", tempname);

				WaitingScreen.Stop();
				try 
				{
					System.Diagnostics.Process p = System.Diagnostics.Process.Start(tempname);
					p.WaitForExit();

					return true;
				} 
				finally 
				{
					System.IO.File.Delete(tempname);
				}

			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("Unable to download the instalation File.", ex);
			}
			finally 
			{
				WaitingScreen.Stop();
			}

			return false;
		}

		/// <summary>
		/// Returns the Version stored in a specific Tag
		/// </summary>
		/// <param name="tag"></param>
		/// <returns></returns>
		static long GetVersion(string content, string tag) 
		{
			int p1 = content.IndexOf("<!--"+tag+":")+tag.Length+5;
			if (p1!=-1) 
			{
				int p2 = content.IndexOf("-->", p1);
				if (p2!=-1) 
				{
					string ver = content.Substring(p1, p2-p1);
					long l = Convert.ToInt64(ver);

					return l;
				}
			}

			return 0;
		}

		/// <summary>
		/// Returns teh ChangeLog for the latest Release
		/// </summary>
		/// <returns></returns>
		public static string GetChangeLog()
		{
			if (!IsConnectedToInternet()) return "Unable to load the ChangeLog";

			WebClient Client = new WebClient ();
			bool run = WaitingScreen.Running;
			try 
			{
				
				if (!run) WaitingScreen.Wait();
				WaitingScreen.UpdateMessage("Loading ChangeLog");
				WebClient cli = new WebClient();
				byte[] data = cli.DownloadData("http://sims.ambertation.de/rssengine.php?&show=latestplain");
				MemoryStream ms = new MemoryStream(data);
				StreamReader sr = new StreamReader(ms);
				string content = sr.ReadToEnd();								
				
				return content;

			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("Unable to load the ChangeLog.", ex);
			}
			finally 
			{
				if (!run) WaitingScreen.Stop();
			}

			return "Unable to load the ChangeLog";
		}

		/// <summary>
		/// Install the Photostudio Templates
		/// </summary>
		/// <returns>true if success</returns>
		public static UpdateState CheckUpdate()
		{
			long version = 0;
			long qaversion = 0;

			return CheckUpdate(ref version, ref qaversion);
		}

		/// <summary>
		/// Install the Photostudio Templates
		/// </summary>
		/// <returns>true if success</returns>
		public static UpdateState CheckUpdate(ref long version, ref long qaversion)
		{
			if (!IsConnectedToInternet()) return UpdateState.Nothing;

			WebClient Client = new WebClient ();
			bool run = WaitingScreen.Running;
			try 
			{
				
				if (!run) WaitingScreen.Wait();
				WaitingScreen.UpdateMessage("Check for new Updates");
				WebClient cli = new WebClient();
				byte[] data = cli.DownloadData("http://sims.ambertation.de/downloadnfo.txt");
				MemoryStream ms = new MemoryStream(data);
				StreamReader sr = new StreamReader(ms);
				string content = sr.ReadToEnd();

				//extract the Version String
				WaitingScreen.UpdateMessage("read latest Version");
				UpdateState res = UpdateState.Nothing;
				try 
				{
					version = GetVersion(content, "lversion");
					qaversion = GetVersion(content, "qaversion");

					if (version>Helper.SimPeVersionLong) 
						res |= UpdateState.NewRelease;					

					if (Helper.QARelease) 
						if (qaversion>Helper.SimPeVersionLong) 
							res |= UpdateState.NewQARelease;					
				} 
				catch (Exception ex) 
				{
					if (!run) WaitingScreen.Stop();
					Helper.ExceptionMessage("", ex);
				}

				if (!run) WaitingScreen.Stop();
				
				return res;

			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("Unable to determin Version.", ex);
			}
			finally 
			{
				if (!run) WaitingScreen.Stop();
			}

			return UpdateState.Nothing;
		}

#if MAC
		/// <summary>
		/// Returns true if the System is Connected
		/// </summary>
		/// <returns></returns>
		public static bool IsConnectedToInternet( )
		{
			return false;
		}
#else
		[DllImport("wininet.dll")]
		private extern static bool InternetGetConnectedState( out int Description, int ReservedValue ) ;

		/// <summary>
		/// Returns true if the System is Connected
		/// </summary>
		/// <returns></returns>
		public static bool IsConnectedToInternet( )
		{

			int Desc ;
			return InternetGetConnectedState( out Desc, 0 ) ;
		}
#endif
	}
}
