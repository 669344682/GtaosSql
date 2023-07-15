using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GtaosSql
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        private void Button_new_Click(object sender, EventArgs e)
        {
            //Window window = new();
            Window window = (Window)Application.OpenForms["Window"];
            window.AddNewConnection(textBox_name.Text, textBox_server.Text, textBox_port.Text, textBox_user.Text, textBox_password.Text);

            this.Close();
        }
    }
}
