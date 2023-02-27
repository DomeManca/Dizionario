using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, double> accounts = new Dictionary<string, double>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(textBox2.Text);
                accounts.Add(textBox1.Text, d);
                Aggiorna();
            }
            catch
            {
                MessageBox.Show("Inserire dati validi", "ERRORE");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string t = listView1.SelectedItems.ToString();
        }
        public void Aggiorna()
        {
            listView1.Items.Clear();
            
            foreach (KeyValuePair<string, double> p in accounts)
            {
                string[] row = { p.Key, p.Value.ToString() };
                var ListViewItem = new ListViewItem(row);
                listView1.Items.Add(ListViewItem); 
            }
            Dictionary<string, double>.ValueCollection ValueColl = accounts.Values;
            double n = 0;
            foreach (double d in ValueColl)
            {
                n =+ d;
            }
            label1.Text = n.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aggiorna();
        }
    }
}
