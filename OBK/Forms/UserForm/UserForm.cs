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

namespace OBK.Forms
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            Load load = new Load(this);
            Load += load.GetHandler("user");
        }
    }
}
