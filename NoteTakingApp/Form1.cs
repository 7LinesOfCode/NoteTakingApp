using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class NoteTakeApp : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
            
        public NoteTakeApp()
        {
            InitializeComponent();
        }

        private void NoteTakeAppPole(object sender, EventArgs e)
        {
            notes.Columns.Add("Tittle");
            notes.Columns.Add("Note");

            previousNote.DataSource = notes;
        }

        private void previousNotes(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[previousNote.CurrentCell.RowIndex]["Tittle"] = TittleBox;
                notes.Rows[previousNote.CurrentCell.RowIndex]["Note"] = NoteBox;
            }
            else
            {
                notes.Rows.Add(TittleBox, NoteBox);

            }
            TittleBox.Text = "";
            NoteBox.Text = "";
            editing = false;

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            TittleBox.Text = notes.Rows[previousNote.CurrentCell.RowIndex].ItemArray[0].ToString();
            NoteBox.Text = notes.Rows[previousNote.CurrentCell.RowIndex].ItemArray[1].ToString();

            editing = true;
        }

        private void NewNoteBox_Click(object sender, EventArgs e)
        {
            TittleBox.Text = "";
            NoteBox.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previousNote.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) { Console.WriteLine("Not valid note"); }
        }

        private void NoteBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TittleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void previousNote_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TittleBox.Text = notes.Rows[previousNote.CurrentCell.RowIndex].ItemArray[0].ToString();
            NoteBox.Text = notes.Rows[previousNote.CurrentCell.RowIndex].ItemArray[1].ToString();

            editing = true;
        }
    }
}
