using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoteApp
{
    public partial class NewNote : Form
    {
        public string nTitle;
        public string nNote;
        public NewNote()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            nTitle = txtTitle.Text;
            nNote = txtNote.Text;
            NoteApp.Notes.Rows.Add(nTitle, nNote);
            Close();
        }

        private void NewNote_Load(object sender, EventArgs e)
        {
            txtTitle.ScrollBars = ScrollBars.Horizontal;
            txtNote.ScrollBars = ScrollBars.Vertical;
        }
    }
}
