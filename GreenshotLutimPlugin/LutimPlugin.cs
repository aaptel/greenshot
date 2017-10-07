using System.Collections.Generic;
using Greenshot.IniFile;
using Greenshot.Plugin;
using GreenshotPlugin.Controls;
using GreenshotPlugin.Core;
using System.IO;
using System.Net;
using System.Windows.Forms;
using log4net;

namespace GreenshotLutimPlugin {
	public class LutimPlugin : IGreenshotPlugin {
		private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(LutimPlugin));
		private static LutimConfiguration _config;
		public static PluginAttribute Attributes;

		public virtual void Configure() {
			_config.ShowConfigDialog();
		}

		public IEnumerable<IDestination> Destinations() {
			yield return new LutimDestination(this);
		}

		public void Dispose() {
			//throw new NotImplementedException();
		}

		public bool Initialize(IGreenshotHost host, PluginAttribute pluginAttribute) {
			_config = IniConfig.GetIniSection<LutimConfiguration>();
			Attributes = pluginAttribute;
			return true;
		}


		public IEnumerable<IProcessor> Processors() {
			//throw new NotImplementedException();
			yield break;
		}

		public bool Upload(ISurface img, out string uploadUrl, out string error) {
			MemoryStream ms = new MemoryStream();
			SurfaceOutputSettings outputSettings = new SurfaceOutputSettings(OutputFormat.png);
			ImageOutput.SaveToStream(img, ms, outputSettings);

			// Generate post objects
			Dictionary<string, object> postParameters = new Dictionary<string, object>();
			postParameters.Add("format", "json");
			postParameters.Add("delete-delay", "1"); // days
			postParameters.Add("first-view", "0");
			postParameters.Add("keep-exif", "0");
			postParameters.Add("crypt", "0");
			postParameters.Add("file", new HTTPFormUpload.FileParameter(ms.GetBuffer(), "pic.png", "image/png"));

			// Create request and receive response
			string postURL = _config.LutimHost;
			string userAgent = "greenshot-lutim-plugin";


			try {
				HttpWebResponse webResponse = HTTPFormUpload.MultipartFormDataPost(postURL, userAgent, postParameters);
				// Process response
				StreamReader responseReader = new StreamReader(webResponse.GetResponseStream());
				string fullResponse = responseReader.ReadToEnd();
				webResponse.Close();

				IDictionary<string, object> json = JSONHelper.JsonDecode(fullResponse);
				if ((bool)json["success"]) {
					IDictionary<string, object> msg = (IDictionary<string, object>)json["msg"];
					uploadUrl = postURL;
					if (uploadUrl[uploadUrl.Length - 1] != '/') {
						uploadUrl += "/";
					}
					uploadUrl += (string)msg["short"];
					System.Windows.Forms.Clipboard.SetText(uploadUrl);
					error = "";
					return true;
				}
				else {
					error = Language.GetString("lutim", LangKey.server_error) + ": " + (string)json["msg"];
				}
			}
			catch (System.Exception e) {
				error = Language.GetString("lutim", LangKey.server_error_unknown) + " (" + e.ToString() + ")";
				Log.Error(e);
				MessageBox.Show(error);
			}
			uploadUrl = "";
			return false;
		}

		public void Shutdown() {
			//throw new NotImplementedException();
		}
	}
}
