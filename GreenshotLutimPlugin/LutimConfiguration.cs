using Greenshot.IniFile;
using GreenshotLutimPlugin.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GreenshotLutimPlugin {

	/// <summary>
	/// Description of ImgurConfiguration.
	/// </summary>
	[IniSection("Lutim", Description = "Greenshot Lutim Plugin configuration")]
	public class LutimConfiguration : IniSection {
		[IniProperty("LutimHost", Description = "Url to Lutim host", DefaultValue = "https://lut.im/")]
		public string LutimHost { get; set; }

		public bool ShowConfigDialog() {
			SettingsForm settingsForm = new SettingsForm();
			DialogResult result = settingsForm.ShowDialog();
			return result == DialogResult.OK;
		}
	}
}
