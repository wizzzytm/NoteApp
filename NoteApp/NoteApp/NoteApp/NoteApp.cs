using System;
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
    public partial class NoteApp : Form
    {
        public static string CurrentTitle;
        public static string CurrentNote;
        public static DataTable Notes = new DataTable();
        public NoteApp()
        {
            InitializeComponent();
        }

        private void NoteApp_Load(object sender, EventArgs e)
        {
            Notes.Columns.Add("Title");
            Notes.Columns.Add("Note");
            dataGrid.DataSource = Notes;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            NewNote TempNote = new NewNote();
            TempNote.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                Notes.Rows[dataGrid.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex) { Console.WriteLine("Not a valid note!"); }
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Notes.Rows.Count != 0)
            {
                CurrentTitle = Notes.Rows[dataGrid.CurrentCell.RowIndex]["Title"].ToString();
                CurrentNote = Notes.Rows[dataGrid.CurrentCell.RowIndex]["Note"].ToString();
                Note Note = new Note();
                Note.Show();
            }
            else
            {
                dataGrid.CurrentCell = null;
            }
           
        }


    }
}
