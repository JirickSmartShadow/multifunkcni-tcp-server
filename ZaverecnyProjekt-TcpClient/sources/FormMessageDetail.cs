using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjekt_TcpClient
{
    public partial class FormMessageDetail : Form
    {
        public Form Form { get; set; }

        public FormMessageDetail(Form form, string sender, string text, string date)
        {
            InitializeComponent();
            Form = form;
            lbUser.Text = sender;
            tbMessage.Text = text;
            lbDate.Text = date;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form.Location = Location;
            Form.Show();
            Close();
        }

        private void FormMessageDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form.Location = Location;
            Form.Show();
        }
    }
}
