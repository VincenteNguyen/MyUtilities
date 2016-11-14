using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetReelsStrip();
        }
        

        public void GetReelsStrip()
        {
            var dictionary = textBox6.Text.ToDictionaryExt();
            var sb = new StringBuilder();
            for(int i = 1; i <= 5; i++)
            {
                Control ctn = this.Controls["textBox"+i];
                if (string.IsNullOrWhiteSpace(ctn.Text)) continue;
                var reelsStrip = ctn.Text.ToListExt();
                foreach (var item in reelsStrip)
                {
                    sb.Append(dictionary[item]);
                    sb.Append(",");
                }
                sb.Length--;
                sb.AppendLine();
                ctn.Text = string.Empty;
            }
            textBox7.Text = sb.ToString();
            Clipboard.SetText(textBox7.Text);
        }

    }

    public static class Extension
    {
        public static Dictionary<string, int> ToDictionaryExt(this string parameter)
        {
            return (from line in parameter.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                    let seperatorIndex = line.IndexOf("\t", StringComparison.Ordinal)
                    select new
                    {
                        Key = line.Substring(seperatorIndex + 1, line.Length - seperatorIndex - 1).Trim(),
                        Value = Convert.ToInt32(line.Substring(0, seperatorIndex)),
                    }).ToList().ToDictionary(x => x.Key, x => x.Value);
        }
        public static List<string> ToListExt(this string parameter)
        {
            return (from line in parameter.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                    select line).ToList();
        }
    }
}
