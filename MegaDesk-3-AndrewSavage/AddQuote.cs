﻿using System;
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

            var surfaces = new List<Desk.Surface>();
            surfaces = Enum.GetValues(typeof(Desk.Surface))
                                .Cast<Desk.Surface>()
                                .ToList();

            comboBoxSurface.DataSource = surfaces;

            var delievery = new List<DeskQuote.ShippingSpeed>();
            delievery = Enum.GetValues(typeof(DeskQuote.ShippingSpeed))
                                .Cast<DeskQuote.ShippingSpeed>()
                                .ToList();

            comboBoxShipping.DataSource = delievery;


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
            DeskQuote quote = new DeskQuote();
            quote.Name = textUserName.Text;
            quote.Width = (int)UpDownDeskWidth.Value;
            quote.Depth = (int)UpDownDeskDepth.Value;
            quote.Drawers = (int)UpDownDrawers.Value;
            quote.SurfaceMaterial = (Desk.Surface)comboBoxSurface.SelectedValue;
            quote.Shipping = (DeskQuote.ShippingSpeed)comboBoxShipping.SelectedValue;
            quote.Date = DateTime.Now;
            

           string csvFile = "quotes.txt";
           
            using (StreamWriter writer = new StreamWriter(csvFile, true))
            {
                writer.WriteLine(
                    $"{quote.Date}," +
                    $"{quote.Name}," +
                    $"{quote.getTotal()}," +
                    $"{quote.Depth}," +
                    $"{quote.Width}," +
                    $"{quote.Drawers}," +
                    $"{quote.SurfaceMaterial}," +
                    $"{quote.Shipping}");
            }
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
