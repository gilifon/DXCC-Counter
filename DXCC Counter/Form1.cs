using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXCC_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }
        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                ExploreFile(file);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            L_filename.Text = "";
            L_dxcc.Text = "0";
            L_zones.Text = "0";
            L_cont.Text = "0";
            L_prefix.Text = "0";
            L_qso.Text = "0";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                ExploreFile(file);
            }
        }

        private void ExploreFile(string file)
        {
            L_filename.Text = file;
            L_dxcc.Text = "";
            L_zones.Text = "";
            L_cont.Text = "";
            L_prefix.Text = "";
            L_qso.Text = "";
            LST_DXCC.Items.Clear();
            LST_Zones.Items.Clear();
            LST_Cont.Items.Clear();
            LST_Prefix.Items.Clear();
            try
            {

                string all = File.ReadAllText(file);
                all = all.Replace("<", "\n<");
                all = all.Replace("\r", "");
                //string[] text = File.ReadAllLines(file);
                string[] text = all.Split('\n');
                string countryPattern = "<COUNTRY:\\d+>";
                string zonePattern = "<CQZ:\\d+>";
                string contPattern = "<cont:\\d+>";
                string pfxPattern = "<pfx:\\d+>";
                List<string> entities = new List<string>();
                List<string> continents = new List<string>();
                List<int> zones = new List<int>();
                List<string> prefixes = new List<string>();

                

                int contactsCounter = 0;

                foreach (string s in text)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(s, countryPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                    {
                        contactsCounter++;
                        string matchDXCC = System.Text.RegularExpressions.Regex.Match(s, countryPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase).Value;
                        string dxcc = s.Replace(matchDXCC, "");
                        if (!entities.Contains(dxcc))
                        {
                            entities.Add(dxcc);
                        }
                    }
                    if (System.Text.RegularExpressions.Regex.IsMatch(s, zonePattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                    {
                        string match = System.Text.RegularExpressions.Regex.Match(s, zonePattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase).Value;
                        int z = int.Parse(s.Replace(match, ""));
                        if (!zones.Contains(z))
                        {
                            zones.Add(z);
                        }
                    }
                    if (System.Text.RegularExpressions.Regex.IsMatch(s, contPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                    {
                        string match = System.Text.RegularExpressions.Regex.Match(s, contPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase).Value;
                        string cont = s.Replace(match, "");
                        if (!continents.Contains(cont))
                        {
                            continents.Add(cont);
                        }
                    }
                    if (System.Text.RegularExpressions.Regex.IsMatch(s, pfxPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                    {
                        string match = System.Text.RegularExpressions.Regex.Match(s, pfxPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase).Value;
                        string pfx = s.Replace(match, "");
                        if (!prefixes.Contains(pfx))
                        {
                            prefixes.Add(pfx);
                        }
                    }

                }
                System.Console.WriteLine("Total DXCC: {0}", entities.Count.ToString());
                System.Console.WriteLine("Total ZONES: {0}", zones.Count.ToString());
                System.Console.WriteLine("Total CONTINENTS: {0}", continents.Count.ToString());
                System.Console.WriteLine("Total PREFIXES: {0}", prefixes.Count.ToString());
                L_dxcc.Text = entities.Count.ToString();
                L_zones.Text = zones.Count.ToString();
                L_cont.Text = continents.Count.ToString();
                L_prefix.Text = prefixes.Count.ToString();
                L_qso.Text = contactsCounter.ToString();
                entities.Sort();
                LST_DXCC.Items.AddRange(entities.ToArray());
                continents.Sort();
                LST_Cont.Items.AddRange(continents.ToArray());
                zones.Sort();
                LST_Zones.Items.AddRange(zones.Cast<object>().ToArray());
                prefixes.Sort();
                LST_Prefix.Items.AddRange(prefixes.Cast<object>().ToArray());
            }
            catch (IOException)
            {
            }
        }
    }
}
