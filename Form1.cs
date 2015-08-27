using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hibiki_Angel_Generator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			generate(inputTextBox.Text);
		}

		private void generate(string src)
		{
			if (string.IsNullOrWhiteSpace(src))
			{
				MessageBox.Show("文字を入れてください");
				return;
			}

			/*
			List<char> cList = new List<char>();
			int min = 127;
			int max = 0;

			foreach (char c in src)
			{
				min = Math.Min(min, c);
				max = Math.Max(max, c);
				if (!cList.Contains(c))
					cList.Add(c);
			}

			cList.Sort();
			*/

			string result = string.Empty;

			for (int i = 0; i < 10; i++)
				result += "響ちゃん";

			result += "マジ天使";

			foreach (char c in src)
			{
				for (int i = 0; i < c / 10; i++)
					result += "響ちゃん";
				result += "天使";
			}

			result = result.Substring(0, result.Length - 2);

			for (int i = 0; i < src.Length; i++)
				result += "結婚しよ";

			result += "かわいいかなさんどー天使";

			foreach (char c in src)
			{
				for (int i = 0; i < c % 10; i++)
					result += "響ちゃん";
				result += "天使";
			}

			result = result.Substring(0, result.Length - 2);

			for (int i = 0; i < src.Length; i++)
				result += "結婚しよ";

			for (int i = 0; i < src.Length; i++)
				result += "天使愛してる";

			output(result);
		}

		private void output(string s)
		{
			SaveFileDialog sfd = new SaveFileDialog();

			sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			sfd.FileName = "Noname";
			sfd.Filter = "響ちゃんマジ天使言語ファイル(*.hcmt)|*.hcmt|テキストファイル(*.txt)|*.txt";
			sfd.Title = "どこにファイルを保存する？";
			sfd.RestoreDirectory = true;

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				Stream stream = sfd.OpenFile();
				if (stream != null)
				{
					StreamWriter sw = new StreamWriter(stream);
					sw.Write(s);
					sw.Close();
				}
				stream.Close();

			}

			sfd.Dispose();
		}
	}
}
