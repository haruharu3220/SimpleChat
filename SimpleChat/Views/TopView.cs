using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleChat.Views
{
    public partial class TopView : Form
    {
        public TopView()
        {
            InitializeComponent();
        }


        private void SendButton_Click(object sender, EventArgs e)
        {
            //テスト１
            //テスト２
            this.ReceiveMessageTextBox.Text = this.SendMessageTextBox.Text;
        }
    }
}
