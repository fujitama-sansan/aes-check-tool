using System;
using System.Windows.Forms;

namespace AESCheckTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _decryptButton_Click(object sender, EventArgs e)
        {
            var key = _aesKeyBox.Text;
            var value = _cookieValueBox.Text;
            try
            {
                var json = AESDecrypter.DecryptAuthenticationInfo(value, key);
                _jsonPane.Text = json;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.AESKey = _aesKeyBox.Text;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _aesKeyBox.Text = Properties.Settings.Default.AESKey;
        }

        private void _aesKeyBox_Enter(object sender, EventArgs e)
        {
            _aesKeyBox.SelectAll();
        }

        private void _cookieValueBox_Enter(object sender, EventArgs e)
        {
            _cookieValueBox.SelectAll();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_aesKeyBox.Text))
            {
                _cookieValueBox.Focus();
            }
        }
    }
}
