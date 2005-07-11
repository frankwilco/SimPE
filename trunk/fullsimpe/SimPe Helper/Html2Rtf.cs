/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU General Public License as published by  *
 *   the Free Software Foundation; either version 2 of the License, or     *
 *   (at your option) any later version.                                   *
 *                                                                         *
 *   This program is distributed in the hope that it will be useful,       *
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
 *   GNU General Public License for more details.                          *
 *                                                                         *
 *   You should have received a copy of the GNU General Public License     *
 *   along with this program; if not, write to the                         *
 *   Free Software Foundation, Inc.,                                       *
 *   59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.             *
 ***************************************************************************/
using System;
using System.Text.RegularExpressions;

namespace Ambertation
{
	/// <summary>
	/// This class can convert html Content into the rtf Format
	/// </summary>
	public class Html2Rtf
	{
		/// <summary>
		/// Return the rtf Version of a String
		/// </summary>
		/// <param name="html"></param>
		/// <returns></returns>
		public static string Convert(string html) 
		{
			html = html.Replace("\n", " ");
			while (html.IndexOf("  ")!=-1) html=html.Replace("  ", " ");
			html = html.Replace("\\", "/").Replace("{", "(").Replace("}", ")");

			html = html.Replace("<br />", @"\pard\par"+"\n");
			html = Regex.Replace(html, "<p[^>]*>", @"\pard\f0\fs16 ");			
			html = html.Replace("</p>", @"\par\pard\par"+"\n");
			html = html.Replace("<h2>", @"\viewkind4\uc1\pard\b\f0\fs16 ");
			html = html.Replace("</h2>", @"\b0\par");
			html = Regex.Replace(html, "<a (.*?)href=\"([^\"]*)\"[^>]*>(.*?)<\\/a>", "$3 ($2)");			
			html = Regex.Replace(html, "<div[^>]*>", "");
			html = html.Replace("</div>", "");			
			html = Regex.Replace(html, @"<\?xml(.*?)<body>", "");
			html = Regex.Replace(html, @"</body>.*", "");
			html = Regex.Replace(html, "<img [ ]*src=\"([^\"]*)\"[^>]*>", "");
			html = html.Replace("<ul>", @"{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\'B7}}\fi-284\li426 ");
			html = html.Replace("<ul>", @"\pard{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\'B7}}\fi-284\li426");
			html = html.Replace("</ul>", @"\pard\par"+"\n");
			html = html.Replace("<li>", @"{\pntext\f1\'B7\tab}");
			html = html.Replace("</li>", @"\par ");
			html = html.Replace("../", @"http://sims.ambertation.de/");
			html = html.Replace("./", @"http://sims.ambertation.de/");
			while (html.IndexOf(" \\")!=-1) html=html.Replace(" \\", "\\");
			html = Regex.Replace(html, "<span [ ]*class=\"([^\"]*)serif([^\"]*)\"[^>]*>(.*?)<\\/span>", @"\cf1 $3\cf0 ");
			html = Regex.Replace(html, "<span [ ]*class=\"([^\"]*)\"[^>]*>(.*?)<\\/span>", @"$2");
			html = html.Replace("<b>", @"\b ").Replace("<strong>", @"\b ");
			html = html.Replace("</b>", @"\b0 ").Replace("</strong>", @"\b0 ");
			html = html.Replace("<u>", @"\ul ");
			html = html.Replace("</u>", @"\ulnone ");
			html = html.Replace("<i>", @"\i ").Replace("<em>", @"\i ");
			html = html.Replace("</i>", @"\i0 ").Replace("</em>", @"\i0 ");
			

			html = html.Replace("&nbsp;", " ").Replace("&auml;", "ä").Replace("&ouml;", "ö").Replace("&uuml;", "ü").Replace("&Auml;", "Ä").Replace("&Ouml;", "Ö").Replace("&Uuml;", "Ü").Replace("&szlig;", "ß").Replace("&quot;", "\"").Replace("&amp;", "&");
			html = html.Replace("&lt;", "<").Replace("&gt;", ">");
			

			string rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1031{\fonttbl{\f0\fswiss\fprq2\fcharset0 Verdana;}{\f1\fnil\fcharset2 Symbol;}}";
			rtf += @"{\colortbl ;\red215\green120\blue0;}";
			rtf += html;
			rtf += @"}";

			return rtf;
		}
	}
}
