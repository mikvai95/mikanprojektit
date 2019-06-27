using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osallistujat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nimiBoxi.Text))
                return;
            ListViewItem nimi = new ListViewItem(nimiBoxi.Text);
            nimi.SubItems.Add(nimiBoxi.Text);
            listView1.Items.Add(nimi);
            nimiBoxi.Clear();
            nimiBoxi.Focus();
        }
    }
}
