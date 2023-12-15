using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternshipPetProject
{
    public partial class ServingIntel : Form
    {
        public ServingIntel()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void ServingIntel_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        //    private void btnClose_Click(object sender, EventArgs e)
        //    {
        //        this.Close();
        //    }
    }
}
