using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChipperUI
{
    public partial class FormKeyGen : Form
    {
        public FormKeyGen()
        {
            InitializeComponent();
        }

        private void FormKeyGen_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (TextKeyPass.Text != TextKeyPass2.Text)
            {
                MessageBox.Show("The two Passphrases do not match!", "error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            Algorythm.GenKey(TextKeyPass.Text, TextKeyName.Text);
            MessageBox.Show($"Key {TextKeyName.Text} was generated successfully.", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            
            this.Close();
        }
    }
}
