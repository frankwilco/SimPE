using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;
using Ambertation.Collections;

namespace Ambertation.Windows.Forms.Graph
{
	/// <summary>
	/// This is an Item you can add to a <see cref="GraphPanel"/>.
	/// </summary>
	public class GraphItem : PropertyPanel
	{
		
		public GraphItem() : this(new Hashtable()) 
		{
		}

		public GraphItem(Hashtable properties) :base (properties)
		{				
		}		
	}
}
