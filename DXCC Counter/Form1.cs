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

        private List<QSO> qsos;
        private List<string> entities = new List<string>();
        private List<string> continents = new List<string>();
        private List<string> zones = new List<string>();
        private List<string> prefixes = new List<string>();
        private List<string> bands = new List<string>();
        private List<string> modes = new List<string>();
        ADIFParser parser;

        //Event Handlers
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                ParseAndSetUI(file);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                ParseAndSetUI(file);
            }
        }
        private void Btn_GenerateInsert_Click(object sender, EventArgs e)
        {
            if (parser == null)
                MessageBox.Show("You have to parse the file first");
            else
            {
                string insert = parser.GenerateInsert();
                MessageBox.Show(insert);
                Clipboard.SetText(insert);
            }
        }

        private void ParseAndSetUI(string filename)
        {
            L_filename.Text = filename;
            L_dxcc.Text = "";
            L_zones.Text = "";
            L_cont.Text = "";
            L_prefix.Text = "";
            L_qso.Text = "";
            L_Bands.Text = "";
            L_Mode.Text = "";

            LST_DXCC.Items.Clear();
            LST_Zones.Items.Clear();
            LST_Cont.Items.Clear();
            LST_Prefix.Items.Clear();
            LST_Bands.Items.Clear();
            LST_Mode.Items.Clear();

            entities.Clear();
            zones.Clear();
            continents.Clear();
            bands.Clear();
            prefixes.Clear();
            modes.Clear();

            NewExploreFile(filename);

            entities.AddRange(qsos.Where(p => p.country != null).Select(p => p.country + " (" + qsos.Where(t => t.country == p.country).Count().ToString() + ")").Distinct());
            zones.AddRange(qsos.Where(p => p.cqz != null).OrderBy(p => int.Parse(p.cqz)).Select(p => p.cqz + " (" + qsos.Where(t => t.cqz == p.cqz).Count().ToString() + ")").Distinct());
            continents.AddRange(qsos.Where(p => p.cont != null).Select(p => p.cont + " (" + qsos.Where(t => t.cont == p.cont).Count().ToString() + ")").Distinct());
            bands.AddRange(qsos.Where(p => p.band != null).OrderBy(p => int.Parse(p.band.ToLower().Replace("cm", "").Replace("m", ""))).Select(p => p.band + " (" + qsos.Where(t => t.band == p.band).Count().ToString() + ")").Distinct());
            prefixes.AddRange(qsos.Where(p => p.pfx != null).Select(p => p.pfx).Distinct());
            modes.AddRange(qsos.Where(p => p.mode != null).Select(p => p.mode + " (" + qsos.Where(t => t.mode == p.mode).Count().ToString() + ")").Distinct());

            L_dxcc.Text = entities.Count.ToString();
            L_zones.Text = zones.Count.ToString();
            L_cont.Text = continents.Count.ToString();
            L_prefix.Text = prefixes.Count.ToString();
            L_Bands.Text = bands.Count.ToString();
            L_Mode.Text = modes.Count.ToString();
            L_qso.Text = qsos.Count.ToString();

            entities.Sort();
            LST_DXCC.Items.AddRange(entities.ToArray());

            continents.Sort();
            LST_Cont.Items.AddRange(continents.ToArray());

            //zones.Sort();
            LST_Zones.Items.AddRange(zones.Cast<object>().ToArray());

            prefixes.Sort();
            LST_Prefix.Items.AddRange(prefixes.Cast<object>().ToArray());

            //bands.Sort();
            LST_Bands.Items.AddRange(bands.Cast<object>().ToArray());

            modes.Sort();
            LST_Mode.Items.AddRange(modes.Cast<object>().ToArray());

            QSO first = qsos.OrderBy(p => p.qso_date + p.time_on).FirstOrDefault();
            QSO last = qsos.OrderByDescending(p => p.qso_date + p.time_on).FirstOrDefault();
        }
        private void NewExploreFile(string file)
        {
            string all = File.ReadAllText(file);
            parser = new ADIFParser(all);
            parser.TableName = "4XFF_Log";
            parser.Parse();
            string insert = parser.GenerateInsert();
            Clipboard.SetText(insert);
            qsos = parser.QSO_List.ToList();
        }

        

        
    }
}
