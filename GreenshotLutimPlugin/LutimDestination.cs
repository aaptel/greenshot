using GreenshotPlugin.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Greenshot.Plugin;

namespace GreenshotLutimPlugin {
	class LutimDestination : AbstractDestination {
		private LutimPlugin _plugin;

		public LutimDestination(LutimPlugin lutimPlugin) {
			this._plugin = lutimPlugin;
		}

		public override string Designation => "Lutim";

		public override string Description => Language.GetString("lutim", LangKey.upload_menu_item);

		public override ExportInformation ExportCapture(bool manuallyInitiated, ISurface surface, ICaptureDetails captureDetails) {
			ExportInformation exportInformation = new ExportInformation(Designation, Description);
			string uploadUrl;
			string error;

			//exportInformation.ExportMade = true;
			//exportInformation.Uri = "https://pic.zbeul.ist/yyyyy/xxxxxx";

			exportInformation.ExportMade = _plugin.Upload(surface, out uploadUrl, out error);
			if (exportInformation.ExportMade) {
				exportInformation.Uri = uploadUrl;
			}
			else {
				exportInformation.ErrorMessage = error;
			}
			ProcessExport(exportInformation, surface);
			return exportInformation;
		}
	}
}
