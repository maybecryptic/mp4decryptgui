using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mp4decryptgui
{
	public partial class mp4decryptgui : Form
	{
		public string dir = AppContext.BaseDirectory;

		public mp4decryptgui()
		{
			InitializeComponent();
		}

		private void textBox1_Click(object sender, EventArgs e)
		{
			vk1.Text = Regex.Replace(Clipboard.GetText(), @"(-)", "").Trim();
		}

		private void textBox2_Click(object sender, EventArgs e)
		{
			vk2.Text = Clipboard.GetText().Trim();
		}

		private void ak1_Click(object sender, EventArgs e)
		{
			ak1.Text = Regex.Replace(Clipboard.GetText(), @"(-)", "").Trim();
		}

		private void ak2_Click(object sender, EventArgs e)
		{
			ak2.Text = Clipboard.GetText().Trim();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			txtLog.Text = "";

			if (vk1.Text.Length == 0 || vk2.Text.Length == 0)
			{
				log("×× video key required ××");
				return;
			}
			if (ak1.Text.Length == 0 || ak2.Text.Length == 0)
			{
				log("×× audio key required ××");
				return;
			}

			await Task.Run(() => Work());
		}

		private void Work()
		{
			var video = "";
			foreach (var file in Directory.GetFiles(dir))
				if (file.Contains("_video_"))
					video = file;

			if (video == "")
			{
				log("×× video not found ××");
				return;
			}

			var audio = "";
			foreach (var file in Directory.GetFiles(dir))
				if (file.Contains("_audio_"))
					audio = file;

			if (audio == "")
			{
				log("×× audio not found ××");
				return;
			}

			log("» decrypting video");

			// decrypt video
			Process decryptv = new Process
			{
				StartInfo =
				{
					UseShellExecute = false,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					CreateNoWindow = true,
					Arguments = "--key " + vk1.Text + ":" + vk2.Text + " \"" + video + "\" \"" + video.Replace(".mp4", "-d.mp4") + "\"",
					FileName = Path.GetFileName(dir + "mp4decrypt.exe"),
					WorkingDirectory = Path.GetDirectoryName(dir + "mp4decrypt.exe")
				}
			};

			decryptv.Start();
			log(decryptv.StandardOutput.ReadToEnd());
			decryptv.WaitForExit();

			log("» decrypting audio");

			// decrypt audio
			Process decrypta = new Process
			{
				StartInfo =
				{
					UseShellExecute = false,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					CreateNoWindow = true,
					Arguments = "--key " + ak1.Text + ":" + ak2.Text + " \"" + audio + "\" \"" + audio.Replace(".mp4", "-d.mp4") + "\"",
					FileName = Path.GetFileName(dir + "mp4decrypt.exe"),
					WorkingDirectory = Path.GetDirectoryName(dir + "mp4decrypt.exe")
				}
			};

			decrypta.Start();
			log(decrypta.StandardOutput.ReadToEnd());
			decrypta.WaitForExit();

			var sub = false;
			var ext = "";

			// subs are optional, but are always nice to include
			if (subs.Text.Length != 0 && File.Exists(subs.Text.Substring(subs.Text.LastIndexOf("/") + 1)))
			{
				ext = subs.Text.Substring(subs.Text.LastIndexOf(".") + 1);
				sub = true;

				log("» converting subtitles");
				
				// convert subs
				Process convert = new Process
				{
					StartInfo =
					{
						UseShellExecute = false,
						RedirectStandardOutput = true,
						RedirectStandardError = true,
						CreateNoWindow = true,
						Arguments = "/convert *." + ext + " srt",
						FileName = Path.GetFileName(dir + "SubtitleEdit.exe"),
						WorkingDirectory = Path.GetDirectoryName(dir + "SubtitleEdit.exe")
					}
				};

				convert.Start();
				log(convert.StandardOutput.ReadToEnd());
				convert.WaitForExit();
			}
			else
			{
				log("×× no subtitles found ××");
			}

			var parameters = "-o " + video.Replace(".mp4", ".mkv") + " --language 0:en \"" + video.Replace(".mp4", "-d.mp4") + "\" --language 0:en \"" + audio.Replace(".mp4", "-d.mp4") + "\" --language 0:en --default-track 0:no " + (sub ? "\"" + dir + subs.Text.Substring(subs.Text.LastIndexOf("/") + 1).Replace(ext, "srt") + "\"" : "");
			log("» muxing video with the following parameters");
			log(parameters + Environment.NewLine);

			// mux into an mkv
			Process mux = new Process
			{
				StartInfo =
				{
					UseShellExecute = false,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					CreateNoWindow = true,
					Arguments = parameters,
					FileName = Path.GetFileName(dir + "mkvmerge.exe"),
					WorkingDirectory = Path.GetDirectoryName(dir + "mkvmerge.exe")
				}
			};

			mux.Start();

			var muxlog = mux.StandardOutput.ReadToEnd();
			var del = true;

			// just in case there's issues we should save the files
			if (muxlog.Contains("Error") || muxlog.Contains("Warning"))
				del = false;
			
			txtLog.Text += mux.StandardOutput.ReadToEnd();
			mux.WaitForExit();


			if (del)
			{
				log("» deleting files..." + Environment.NewLine);

				File.Delete(video);
				File.Delete(audio);
				File.Delete(video.Replace(".mp4", "-d.mp4"));
				File.Delete(audio.Replace(".mp4", "-d.mp4"));
				if (sub)
				{
					File.Delete(dir + subs.Text.Substring(subs.Text.LastIndexOf("/") + 1));
					File.Delete(dir + subs.Text.Substring(subs.Text.LastIndexOf("/") + 1).Replace(ext, "srt"));
				}
			}
			

			log("» finished");
		}

		private void log(string txt)
		{
			this.Invoke((MethodInvoker)delegate
			{
				txtLog.AppendText(txt + Environment.NewLine);
			});
		}

		private void keys_Click(object sender, EventArgs e)
		{
			var paste = Clipboard.GetText();
			keys.Text = paste;

			var vkey = paste.Substring(paste.IndexOf("default_KID=\"") + 13);
			vkey = vkey.Remove(vkey.IndexOf("\""));
			vkey = Regex.Replace(vkey, @"(-)", "");
			vk1.Text = vkey;

			var akey = paste.Substring(paste.IndexOf("default_KID=\"") + 13);
			akey = akey.Substring(akey.IndexOf("default_KID=\"") + 13);
			akey = akey.Remove(akey.IndexOf("\""));
			akey = Regex.Replace(akey, @"(-)", "");
			ak1.Text = akey;
		}

		private void subs_Click(object sender, EventArgs e)
		{
			var paste = Clipboard.GetText();
			subs.Text = paste;

			var link = paste.Substring(paste.IndexOf("subtitleUrls"));
			link = link.Substring(link.IndexOf("http"));
			link = link.Remove(link.IndexOf("\""));

			subs.Text = link;

			var name = link.Substring(link.LastIndexOf("/") + 1);

			using (var client = new WebClient())
				client.DownloadFile(link, dir + name);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			vk1.Text = "";
			vk2.Text = "";
			ak1.Text = "";
			ak2.Text = "";
			keys.Text = "";
			subs.Text = "";
		}
	}
}
