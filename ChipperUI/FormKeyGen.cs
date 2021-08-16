using System;
using System.Windows.Forms;

namespace ChipperUI
{
    public partial class FormKeyGen : Form
    {
        public FormKeyGen()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (TextKeyPass.Text != TextKeyPass2.Text)
            {
                MessageBox.Show(@"The two passphrases do not match!", @"error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            AlgorithmStatic.GenKey(TextKeyPass.Text, TextKeyName.Text);
            MessageBox.Show($@"Key {TextKeyName.Text} was generated successfully.", @"Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            
            this.Close();
        }
    }
}
