﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }

        private void Note_Load(object sender, EventArgs e)
        {
            lblTitle.Text = NoteApp.CurrentTitle;
            txtNote.Text = NoteApp.CurrentNote;
        }
    }
}
