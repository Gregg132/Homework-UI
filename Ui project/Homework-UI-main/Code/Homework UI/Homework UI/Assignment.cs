using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_UI
{
    public partial class Assignment : UserControl
    {
        public Homework hw;
        public Assignment(Homework H)
        {
            InitializeComponent();
            hw = H;
            TBXSubject.Text = hw.Subject1;
            TBXName.Text = hw.Name1;
            TBXDue.Text = hw.DueDate1.ToShortDateString();
            TBXDespcription.Text = hw.Despcription1;
        }

        private void Assignment_Load(object sender, EventArgs e)
        {
        }
    }
}
