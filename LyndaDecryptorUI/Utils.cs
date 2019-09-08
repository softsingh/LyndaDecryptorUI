using System;
using System.Drawing;
using System.IO;

namespace LyndaDecryptorUI
{
    public static class Utils
    {
		//Maximum no of favourites
		public static int NUM_FAVOURITES = 5;

		public static bool running = false;
		public static IProgress<Msg> ProgressConsole;

        public static string ENCRYPTION_KEY = "~h#\x00b0" + new string(new char[] { '\'', '*', '\x00b2', '"', 'C', '\x00b4', '|', '\x00a7', '\\' }) + "3~.";
		public static string DEFAULT_INPUT_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\lynda.com\Lynda.com Desktop App\offline\ldc_dl_courses\";
		public static string DEFAULT_OUTPUT_FOLDER = @"C:\Temp\Lynda";
		public static string DEFAULT_DATABASE_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\lynda.com\Lynda.com Desktop App\";

		public static void WriteToConsole(string Text, Color color = default(Color))
		{
		    if (ProgressConsole != null)
		    {
				Msg msg = new Msg();
				msg.Text = Text;
				msg.TextColor = color;
				ProgressConsole.Report(msg);
		    }
		}
    }
}
