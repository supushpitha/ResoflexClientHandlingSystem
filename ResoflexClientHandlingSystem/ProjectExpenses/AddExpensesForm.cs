﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem
{
    public partial class AddExpensesForm : MetroFramework.Forms.MetroForm
    {
        public AddExpensesForm()
        {
            InitializeComponent();
        }

        public AddExpensesForm(int proj_id, int event_id)
        {
            InitializeComponent();

            //eventID.Text = event_id.ToString();

            //fillExpensesTypeCmbBox();
        }

        private void CategorySetupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
