using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;

namespace MQTTClient
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();

        }
   


        private void Form1_Load(object sender, EventArgs e)
        {
            tokenEditor1.EditTextBox.KeyPress += EditTextBox_KeyPress;
            tokenEditor1.Tokens.Add(new DevComponents.DotNetBar.Controls.EditToken( "1"));
            tokenEditor1.Tokens.Add(new DevComponents.DotNetBar.Controls.EditToken( "2"));
            tokenEditor1.Tokens.Add(new DevComponents.DotNetBar.Controls.EditToken( "3"));
            tokenEditor1.Tokens.Add(new DevComponents.DotNetBar.Controls.EditToken( "4"));
            tokenEditor1.Tokens.Add(new DevComponents.DotNetBar.Controls.EditToken( "5"));
            tokenEditor1.Tokens.Add(new DevComponents.DotNetBar.Controls.EditToken( "6"));
            tokenEditor1.Tokens.Add(new DevComponents.DotNetBar.Controls.EditToken( "7"));
        
            tokenEditor1.SelectedTokens.Add(tokenEditor1.Tokens[0]);
            tokenEditor1.SelectedTokens.Add(tokenEditor1.Tokens[1]);
            tokenEditor1.SelectedTokens.Add(tokenEditor1.Tokens[2]);
            tokenEditor1.SelectedTokens.Add(tokenEditor1.Tokens[3]);
            tokenEditor1.SelectedTokens.Add(tokenEditor1.Tokens[4]);
            tokenEditor1.SelectedTokens.Add(tokenEditor1.Tokens[5]);
            tokenEditor1.SelectedTokens.Add(tokenEditor1.Tokens[6]);
        }

        private void EditTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TokenEditor1_RemovingToken_1(object sender, DevComponents.DotNetBar.Controls.RemovingTokenEventArgs ea)
        {
            richTextBoxEx1.Clear();
            richTextBoxEx1.AppendText(ea.Token.Value);
            tokenEditor1.Tokens.Remove(ea.Token);
        }

    }
}
