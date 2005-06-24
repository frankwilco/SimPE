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
		/// Install the Photostudio Templates
		/// </summary>
		/// <returns>true if success</returns>
		public static bool CheckUpdate()
		{
			WebClient Client = new WebClient ();
			try 
			{
				WaitingScreen.Wait();
				WaitingScreen.UpdateMessage("Check for new Updates");
				WebClient cli = new WebClient();
				byte[] data = cli.DownloadData("http://sims.ambertation.de/downloadnfo.txt");
				MemoryStream ms = new MemoryStream(data);
				StreamReader sr = new StreamReader(ms);
				string content = sr.ReadToEnd();

				//extract the Version String
				WaitingScreen.UpdateMessage("read latest Version");
				bool res = false;
				try 
				{
					int p1 = content.IndexOf("<!--version-->")+14;
					if (p1!=-1) 
					{
						int p2 = content.IndexOf("<!--version-->", p1);
						if (p2!=-1) 
						{
							string ver = content.Substring(p1, p2-p1);
							string[] vers = ver.Split(".".ToCharArray(), 4);

							int max = Convert.ToInt32(vers[0]);
							int min = Convert.ToInt32(vers[1]);
							int build = Convert.ToInt32(vers[2]);
							int priv = Convert.ToInt32(vers[3]);

							if (Helper.SimPeVersion.FileMajorPart<max) res = true;
							else if (Helper.SimPeVersion.FileMajorPart>max) res = false;
							else if (Helper.SimPeVersion.FileMinorPart<min) res = true;
							else if (Helper.SimPeVersion.FileMinorPart>min) res = false;
							else if (Helper.SimPeVersion.FileBuildPart<build) res = true;
							else if (Helper.SimPeVersion.FileBuildPart>build) res = false;
							else if (Helper.SimPeVersion.FilePrivatePart<priv) res = true;
						}
					}
				} 
				catch (Exception ex) 
				{
					WaitingScreen.Stop();
					Helper.ExceptionMessage("", ex);
				}

				WaitingScreen.Stop();
				
				return res;

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
