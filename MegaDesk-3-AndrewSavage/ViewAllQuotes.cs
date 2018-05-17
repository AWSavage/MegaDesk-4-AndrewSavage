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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            loadGrid();
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
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
