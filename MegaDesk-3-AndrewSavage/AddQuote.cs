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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            comboBoxSurface.DataSource = Enum.GetValues(typeof(Desk.Surface));
            comboBoxShipping.DataSource = Enum.GetValues(typeof(DeskQuote.ShippingSpeed));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("quote.txt");
            if(file.)
            {
                return;
            }
            else
            {
                    //create file
            }

            Desk desk = new Desk();
            DeskQuote quote = new DeskQuote();
            quote.Name = textUserName.Text;
            quote.Width = (int)UpDownDeskWidth.Value;
            quote.Depth = (int)UpDownDeskDepth.Value;
            quote.Drawers = (int)UpDownDrawers.Value;
            quote.SurfaceMaterial = (Desk.Surface)comboBoxSurface.SelectedValue;
            quote.Shipping = (DeskQuote.ShippingSpeed)comboBoxShipping.SelectedValue;
            quote.Date = DateTime.Now;

        }
    }
}
