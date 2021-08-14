using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChipperUI
{
    public partial class Form1 : Form
    {
        public bool enc = true; // true=E flase=D
        private bool FromFile = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            LoadKeys();
        }

        public void LoadKeys()
        {
            ComboKey.Items.Clear();
            string[] KeyFiles = Directory.GetFiles(External.MainPath, "*.key.bin");
            for (int i = 0; i < KeyFiles.Length; i++)
            {
                ComboKey.Items.Add(Path.GetFileName(KeyFiles[i]));
            }
        }

        private void Encrypt(object sender, EventArgs e)
        {
            var Input = Algorythm.DataIn.ToArray();
            var KeyLoc = Path.Combine(External.MainPath, ComboKey.Text);
            var ByteEnc = Algorythm.EncryptData(Input, External.LoadBin(KeyLoc));
            TextBoxOut.Text = Algorythm.EncodeString(ByteEnc);
        }

        private void LoadFile(object sender, EventArgs e)
        {
            FromFile = true;
            OpenDialog.ShowDialog();
            string loc = OpenDialog.FileName;

            if (loc != null && loc != "")
            {
                var data = External.LoadBin(loc);
                Algorythm.DataIn = data.ToList();
                TextBoxIn.Text = Algorythm.EncodeString(data);

                if (OpenDialog.SafeFileName.Length > 9 && OpenDialog.SafeFileName[0..^8] == ".enc.bin")
                    enc = false;
                else
                    enc = true;
            }

            OpenDialog.FileName = "";
        }

        private void SaveFile(object sender, EventArgs e)
        {
            var Output = Algorythm.DataOut.ToArray();
            SaveDialog.ShowDialog();
            if (enc)
                SaveDialog.DefaultExt = ".enc.bin";
            else
                SaveDialog.DefaultExt = "";
            string loc = SaveDialog.FileName;

            if (loc != null && loc != "")
                External.SaveBin(loc, Output);

            SaveDialog.FileName = "";
        }

        private void StripKeyNew_Click(object sender, EventArgs e)
        {
            new FormKeyGen().Show();
            LoadKeys();
        }

        private void TextBoxIn_TextChanged(object sender, EventArgs e)
        {
            if (!FromFile)
                Algorythm.DataIn = Algorythm.EncodeBytes(TextBoxIn.Text).ToList();
        }

        private void ChangeEncoding(object sender, EventArgs e)
        {
            Algorythm.EncMode = ComboEncoding.Text;
        }

        private void CheckKey(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(External.MainPath, ComboKey.Text)) 
                && ComboKey.Text.Length > 8 
                && ComboKey.Text[^8..] == ".key.bin")
                btnEnc.Enabled = true;
            else
                btnEnc.Enabled = false;
        }

        private void StripKeyExt_Click(object sender, EventArgs e)
        {
            FromFile = true;
            OpenDialogKey.ShowDialog();
            string Loc = OpenDialogKey.FileName;

            if (!File.Exists(Loc))
                return;

            string FullPath = Path.Combine( External.MainPath, OpenDialogKey.SafeFileName);
            File.Copy(Loc, FullPath);
            LoadKeys();
        }

        private void StripKeyMan_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", External.MainPath);
        }
    }
}
