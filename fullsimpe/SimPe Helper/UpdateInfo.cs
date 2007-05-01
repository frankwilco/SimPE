using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.Updates
{
    /// <summary>
    /// Thic class is sent by an updatable plugin, telling SimPE it's current state
    /// </summary>
    public class UpdateInfo
    {
        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="version">Current Version of the installed Plugugin</param>
        /// <param name="key">The key that uniquely identifies the plugin</param>
        /// <param name="displayname">The name of the Plugin as it should be presented to the User</param>
        public UpdateInfo(long version, string key, string displayname)
            :this(version, key, displayname, null)
        {
          
        }

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="version">Current Version of the installed Plugugin</param>
        /// <param name="key">The key that uniquely identifies the plugin</param>
        /// <param name="displayname">The name of the Plugin as it should be presented to the User</param>
        /// <param name="vurl">Where should SimPE look for update informations. If NULL, SimPE will check the SimPE site</param>
        public UpdateInfo(long version, string key, string displayname, string vurl)
        {
            v = version;
            va = v;
            this.key = key.Replace("<", "").Replace(">", "").Replace("/", "");
            this.hname = displayname;
            this.url = "";
            verurl = vurl;
            if (verurl == null) verurl = "http://sims.ambertation.de/pluginnfo.xml?&browser=simpe";
        }

        long v, va;
        string key, hname, url, verurl;

        /// <summary>
        /// The Version of the installed plugin
        /// </summary>
        public long CurrentVersion
        {
            get { return v; }
        }

        /// <summary>
        /// The Version of latest available plugin
        /// </summary>
        public long AvailableVersion
        {
            get { return va; }
        }

        /// <summary>
        /// True, if the system found an update
        /// </summary>
        public bool HasUpdate
        {
            get { return v < va; }
        }

        /// <summary>
        /// The unique ID of this plugin
        /// </summary>
        /// <remarks>Make sure you use something that is gauaranteed to be 
        /// unique. like a name starting with your nickname</remarks>
        public string Key
        {
            get { return key; }
        }

        /// <summary>
        /// The name of the Plugin as presented to the Users
        /// </summary>
        public string DisplayName
        {
            get { return hname; }
        }

        /// <summary>
        /// Returns the URL that point's to a site where users can download the update
        /// </summary>
        public string DownloadUrl
        {
            get { return url; }
        }

        /// <summary>
        /// Returns the URL that points to a resource defining the latest version for one or more plugins
        /// </summary>
        public string VersionCheckUrl
        {
            get { return verurl; }
        }

        internal void SetAvailVersion(long v, string url)
        {
            va = v;
            this.url = url;
        }
    }
}
