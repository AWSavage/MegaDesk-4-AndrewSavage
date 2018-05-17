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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();

            var surfaces = new List<Desk.Surface>();
            surfaces = Enum.GetValues(typeof(Desk.Surface))
                                .Cast<Desk.Surface>()
                                .ToList();

            comboBox1.DataSource = surfaces;
            loadGrid();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
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

        private void loadGrid(string searchTerm)
        {
            dataGridView1.Rows.Clear();
            string[] deskQuotes = File.ReadAllLines(@"quotes.txt");

            foreach(string deskQuote in deskQuotes)
            {
                if (deskQuotes.Contains(searchTerm))
                {
                    string[] arrRow = deskQuote.Split(new char[] { ',' });
                    dataGridView1.Rows.Add(arrRow);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            loadGrid(combo.SelectedItem.ToString());
        }
    }
}
