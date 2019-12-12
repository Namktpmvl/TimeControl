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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            this.btnCheck.Click += btnCheck_Click;
            this.btnExit.Click += btnExit_Click;
                    
        }

        void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnCheck_Click(object sender, EventArgs e)
        {
            var eventform = new Events_Form();
            eventform.ShowDialog();
        }
    }
}
