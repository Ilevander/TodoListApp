using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoListApp
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        private void ToDoList_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            zone.Columns.Add(txtTask.Text, txtDescription.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            zone.Rows.Add(txtName.Text,txtField.Text,txtTechLang.Text,txtTaskToDo.Text,txtDay.Text,txtTime.Text);
           
            txtName.Text = "";
            txtField.Text = "";
            txtTechLang.Text = "";
            txtTaskToDo.Text = "";
            txtDay.Text = "";
            txtTime.Text = "";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(zone.CurrentRow != null)
            {
                zone.CurrentRow.Cells["project_name"].Value = txtName.Text;
                zone.CurrentRow.Cells["field"].Value = txtField.Text;
                zone.CurrentRow.Cells["techLang"].Value = txtTechLang.Text;
                zone.CurrentRow.Cells["task"].Value = txtTaskToDo.Text;
                zone.CurrentRow.Cells["day"].Value = txtDay.Text;
                zone.CurrentRow.Cells["time"].Value = txtTime.Text;
            }
            txtName.Text = "";
            txtField.Text = "";
            txtTechLang.Text = "";
            txtTaskToDo.Text = "";
            txtDay.Text = "";
            txtTime.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(zone.CurrentRow != null)
            {
                zone.Rows.RemoveAt(zone.CurrentRow.Index);
            }
        }

        private void zone_SelectionChanged(object sender, EventArgs e)
        {
            if(zone.CurrentRow != null)
            {
                txtName.Text= zone.CurrentRow.Cells["project_name"].Value.ToString();
                txtField.Text = zone.CurrentRow.Cells["field"].Value.ToString();
                txtTechLang.Text = zone.CurrentRow.Cells["techLang"].Value.ToString();
                txtTaskToDo.Text = zone.CurrentRow.Cells["task"].Value.ToString();
                txtDay.Text = zone.CurrentRow.Cells["day"].Value.ToString();
                txtTime.Text = zone.CurrentRow.Cells["time"].Value.ToString();
            }
        }

        private void zone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
