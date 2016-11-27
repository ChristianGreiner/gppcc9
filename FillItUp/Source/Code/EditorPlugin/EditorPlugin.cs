using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Duality.Editor;

namespace FillItUp.Editor
{
	/// <summary>
	/// Defines a Duality editor plugin.
	/// </summary>
    public class FillItUpEditorPlugin : EditorPlugin
	{
		public override string Id
		{
			get { return "FillItUpEditorPlugin"; }
		}
	}
}
