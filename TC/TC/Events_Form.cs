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
        private LogicLayer Business;
        public Events_Form()
        {
            InitializeComponent();
            this.Business = new LogicLayer();
            this.btnAdd.Click += btnAdd_Click;
            this.btnRemove.Click += btnRemove_Click;
            this.Load += Events_Form_Load;
            this.GridViewEvents.DoubleClick +=GridViewEvents_DoubleClick;
        }

        
        private void ShowAllEvents()
        {
            var events = this.Business.GetEvents();
            var eventView = new EventsView[events.Length];
            for (int i = 0; i < events.Length; i++)
                eventView[i] = new EventsView(events[i]);


            this.GridViewEvents.DataSource = eventView;
         
        }

        void Events_Form_Load(object sender, EventArgs e)
        {
            this.ShowAllEvents();
        }

        void GridViewEvents_DoubleClick(object sender, EventArgs e)
        {   
 	       if (this.GridViewEvents.SelectedRows.Count == 1)
            {
                var row = this.GridViewEvents.SelectedRows[0];
                var ev3ntView = (EventsView)row.DataBoundItem;

                (new Edit_Form(ev3ntView.id)).ShowDialog();
                this.ShowAllEvents();               
            }       
        }


        void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.GridViewEvents.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Wanna delete this ??", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var @event = (EventsView)this.GridViewEvents.SelectedRows[0].DataBoundItem;
                    this.Business.RemoveEvents(@event.id);
                    MessageBox.Show("Delete Class Successfully");
                    this.ShowAllEvents();
                }
            }
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var addform = new Add_Form();
            addform.ShowDialog();
            this.ShowAllEvents();
        }
    }
}
