﻿using OBK.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBK.Forms.StaffForm
{
    public partial class SoldoutDeleteForm : Form
    {
        public SoldoutDeleteForm()
        {
            InitializeComponent();
            StaffLoad load = new StaffLoad(this);
            Load += load.GetHandler("SoldoutDelete");
        }
    }
}
