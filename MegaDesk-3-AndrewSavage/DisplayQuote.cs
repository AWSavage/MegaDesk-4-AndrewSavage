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

namespace MegaDesk_3_AndrewSavage
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
            loadGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadGrid()
        {
            string[] deskQuotes = File.ReadAllLines(@"quotes.txt");

            foreach (string deskQuote in deskQuotes)
            {
                string[] arrRow = deskQuote.Split(new char[] { ',' });
                dataGridView1.Rows.Add(arrRow);
            }
        }
    }
}
