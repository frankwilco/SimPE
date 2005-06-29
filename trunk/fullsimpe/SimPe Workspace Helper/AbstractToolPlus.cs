using System;

namespace SimPe.Interfaces
{
	/// <summary>
	/// Abstract Implementation for <see cref="SimPe.Interfaces.IToolExt"/> classes
	/// </summary>
	public abstract class AbstractToolPlus : AbstractTool, SimPe.Interfaces.IToolPlus
	{
		#region ITool Member

		public abstract SimPe.Interfaces.Plugin.IToolResult ShowDialog(ref SimPe.Interfaces.Files.IPackedFileDescriptor pfd, ref SimPe.Interfaces.Files.IPackageFile package);
		public abstract bool IsEnabled(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package);

		#endregion

		public static SimPe.Interfaces.Files.IPackedFileDescriptor ExtractFileDescriptor(SimPe.Events.ResourceEventArgs e) 
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor pfd = null;
			if (e.Count>0) 
			{
				if (e[0].HasFileDescriptor)
					pfd = e[0].Resource.FileDescriptor;
				
			}

			

			return pfd;
		}

		public static SimPe.Interfaces.Files.IPackageFile ExtractPackage(SimPe.Events.ResourceEventArgs e) 
		{
			SimPe.Interfaces.Files.IPackageFile pkg = null;
			if (e.Count>0) 
			{
				if (e[0].HasPackage)
					pkg = e[0].Resource.Package;
			}

			if (pkg==null && e.Loaded) pkg=e.LoadedPackage.Package;

			return pkg;
		}		

		#region IToolPlus Member

		public virtual void Execute(object sender, SimPe.Events.ResourceEventArgs e)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor pfd = ExtractFileDescriptor(e);
			SimPe.Interfaces.Files.IPackageFile pkg = ExtractPackage(e);

			if (!IsEnabled(pfd, pkg)) return;
			
			SimPe.Interfaces.Plugin.IToolResult ires = ShowDialog(ref pfd, ref pkg);

			if (e.Count>0) 
			{
				e[0].ChangedFile = ires.ChangedFile;
				e[0].ChangedPackage = ires.ChangedPackage;
			}
		}

		public virtual bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs e)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor pfd = ExtractFileDescriptor(e);
			SimPe.Interfaces.Files.IPackageFile pkg = ExtractPackage(e);		
			
			return IsEnabled(pfd, pkg);
		}

		#endregion
	}
}
