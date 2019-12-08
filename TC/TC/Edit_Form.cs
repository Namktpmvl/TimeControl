using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC
{
    public partial class Edit_Form : Form
    {
        private int eventid;
        private LogicLayer Business;
        public Edit_Form(int id)
        {
            InitializeComponent();
            this.eventid = id;      
            this.Business = new LogicLayer();
            this.btnAdd.Click += btnAdd_Click;
            this.btnCancel.Click += btnCancel_Click;
            this.Load += Edit_Form_Load;
        }

        void Edit_Form_Load(object sender, EventArgs e)
        {
            var oldEvent = this.Business.GetEvent(this.eventid);
            this.txtTime.Text = oldEvent.Time;
            this.txtThingToDo.Text = oldEvent.Things_to_do;
            this.txtNote.Text = oldEvent.Note;
            //for (int i = 0; i < comboBox1.Items.Count; i++)    
            //if (comboBox1.Items[i].ToString() == Convert.ToString(oldEvent.Priority_Level))
            //{
            //this.comboBox1.SelectedItem = comboBox1.Items[this.eventid];
            //break;
            //}
            //this.comboBox1.SelectedItem = comboBox1.Items[i];
            var ev3nt = this.Business.GetEvent(this.eventid);
            this.comboBox1.DataSource = this.Business.GetLevels();
            this.comboBox1.DisplayMember = "Date";
            this.comboBox1.ValueMember = "Level";
            this.comboBox1.SelectedValue = ev3nt.Priority_Level;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var id = this.eventid;
            var date = this.dateTimePicker1.Value.Date;
            var time = this.txtTime.Text;
            var thtdo = this.txtThingToDo.Text;
            var note = this.txtNote.Text;
            var prioritylv = (string)this.comboBox1.SelectedValue;

            this.Business.UpdateEvent(id, date, time, thtdo, note, prioritylv);
            MessageBox.Show("Edit Event Successfully");
            this.Close();
        }
    }
}
