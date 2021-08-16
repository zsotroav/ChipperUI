using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChipperUI
{
    public partial class Form1 : Form
    {
        private readonly AlgorithmInstance _algorithm = new();
        public bool Enc = true; // true=E false=D
        private bool _fromFile;

        public string EncMode
        {
            get => ComboEncoding.Text;
            set => ComboEncoding.Text = value;
        }

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
            var keyFiles = Directory.GetFiles(External.MainPath, "*.key.bin");
            foreach (var t in keyFiles)
            {
                ComboKey.Items.Add(Path.GetFileName(t));
            }
        }

        private void Encrypt(object sender, EventArgs e)
        {
            var input = _algorithm.DataIn.ToArray();
            var keyLoc = Path.Combine(External.MainPath, ComboKey.Text);
            var byteEnc = _algorithm.EncryptData(input, External.LoadBin(keyLoc));
            TextBoxOut.Text = AlgorithmStatic.EncodeString(byteEnc, EncMode);
        }

        private void LoadFile(object sender, EventArgs e)
        {
            _fromFile = true;
            OpenDialog.ShowDialog();
            var loc = OpenDialog.FileName;

            if (!string.IsNullOrEmpty(loc))
            {
                var data = External.LoadBin(loc);
                _algorithm.DataIn = data.ToList();
                TextBoxIn.Text = AlgorithmStatic.EncodeString(data, EncMode);
                var fileName = OpenDialog.SafeFileName;

                if (fileName is { Length: > 9 } && fileName[..^8] == ".enc.bin")
                    Enc = false;
                else
                    Enc = true;
            }

            OpenDialog.FileName = "";
        }

        private void SaveFile(object sender, EventArgs e)
        {
            var output = _algorithm.DataOut.ToArray();
            SaveDialog.ShowDialog();
            SaveDialog.DefaultExt = Enc ? ".enc.bin" : "";
            var loc = SaveDialog.FileName;

            if (!string.IsNullOrEmpty(loc))
                External.SaveBin(loc, output);

            SaveDialog.FileName = "";
        }

        private void StripKeyNew_Click(object sender, EventArgs e)
        {
            new FormKeyGen().Show();
            LoadKeys();
        }

        private void TextBoxIn_TextChanged(object sender, EventArgs e)
        {
            if (!_fromFile)
                _algorithm.DataIn = AlgorithmStatic.EncodeBytes(TextBoxIn.Text, EncMode).ToList();
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
            _fromFile = true;
            OpenDialogKey.ShowDialog();
            var loc = OpenDialogKey.FileName;

            if (!File.Exists(loc))
                return;

            var fullPath = Path.Combine( External.MainPath, OpenDialogKey.SafeFileName);
            File.Copy(loc, fullPath);
            LoadKeys();
        }

        private void StripKeyMan_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", External.MainPath);
        }
    }
}
