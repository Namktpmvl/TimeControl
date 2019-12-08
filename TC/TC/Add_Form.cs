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
    public partial class Add_Form : Form
    {
        private LogicLayer Business;
        public Add_Form()
        {
            InitializeComponent();
            this.Business = new LogicLayer();
            this.btnAdd.Click += btnAdd_Click;
            this.btnCancel.Click += btnCancel_Click;
            this.Load += Add_Form_Load;
        }

        void Add_Form_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = this.Business.GetLevels();
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "Level"; ;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var date = this.dateTimePicker1.Value.Date;
            var time = this.txtTime.Text;
            var thingdo = this.txtThingToDo.Text;
            var note = this.txtNote.Text;
            var priolv = (string)this.comboBox1.SelectedValue;

            this.Business.AddEvents(date, time, thingdo, note, priolv);
            MessageBox.Show("Add event successfully ");
            this.Close();
        }
    }
}
