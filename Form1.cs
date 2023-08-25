using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test0825
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Conn_Btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.comboBox1.Items[this.comboBox1.SelectedIndex].ToString()+" is Connected");
            Message_Box.Text = this.comboBox1.Items[this.comboBox1.SelectedIndex].ToString() + " is Connected";
        }


        private void Message_Box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_Led01_On(object sender, EventArgs e)
        {
            Console.WriteLine("Led01 On Clicked");
            Message_Box.Text= "Led01 On Success";
        }

        private void Btn_Led01_Off(object sender, EventArgs e)
        {
            Console.WriteLine("Led01 Off Clicked");
            Message_Box.Text = "Led01 Off Success";
        }

        private void Btn_Led02_On(object sender, EventArgs e)
        {
            Console.WriteLine("Led02 On Clicked");
            Message_Box.Text = "Led02 On Success";
        }

        private void Btn_Led02_Off(object sender, EventArgs e)
        {
            Console.WriteLine("Led02 Off Clicked");
            Message_Box.Text = "Led02 Off Success";
        }

        private void justLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
