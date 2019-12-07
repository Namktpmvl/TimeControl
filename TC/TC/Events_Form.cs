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
    public partial class Events_Form : Form
    {
        public Events_Form()
        {
            InitializeComponent();
            this.btnAdd.Click += btnAdd_Click;
            this.btnRemove.Click += btnRemove_Click;
            this.Load += Events_Form_Load;
        }

        private void ShowAllEvents()
        {
         
        }

        void Events_Form_Load(object sender, EventArgs e)
        {
            this.ShowAllEvents();
        }

        void btnRemove_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var addform = new Add_Form();
            addform.ShowDialog();
            this.ShowAllEvents();
        }
    }
}
