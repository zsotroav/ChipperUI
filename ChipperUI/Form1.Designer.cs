
namespace ChipperUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBoxIn = new System.Windows.Forms.TextBox();
            this.TextBoxOut = new System.Windows.Forms.TextBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.btnEnc = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ComboKey = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.StripLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.StripSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.StripKey = new System.Windows.Forms.ToolStripMenuItem();
            this.StripKeyExt = new System.Windows.Forms.ToolStripMenuItem();
            this.StripKeyNew = new System.Windows.Forms.ToolStripMenuItem();
            this.StripKeyMan = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMe = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.ComboEncoding = new System.Windows.Forms.ComboBox();
            this.OpenDialogKey = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxIn
            // 
            resources.ApplyResources(this.TextBoxIn, "TextBoxIn");
            this.TextBoxIn.Name = "TextBoxIn";
            this.TextBoxIn.TextChanged += new System.EventHandler(this.TextBoxIn_TextChanged);
            // 
            // TextBoxOut
            // 
            resources.ApplyResources(this.TextBoxOut, "TextBoxOut");
            this.TextBoxOut.Name = "TextBoxOut";
            this.TextBoxOut.ReadOnly = true;
            // 
            // BtnLoad
            // 
            resources.ApplyResources(this.BtnLoad, "BtnLoad");
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.LoadFile);
            // 
            // btnEnc
            // 
            resources.ApplyResources(this.btnEnc, "btnEnc");
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.Encrypt);
            // 
            // BtnSave
            // 
            resources.ApplyResources(this.BtnSave, "BtnSave");
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.SaveFile);
            // 
            // ComboKey
            // 
            this.ComboKey.FormattingEnabled = true;
            resources.ApplyResources(this.ComboKey, "ComboKey");
            this.ComboKey.Name = "ComboKey";
            this.ComboKey.SelectedIndexChanged += new System.EventHandler(this.CheckKey);
            this.ComboKey.TextUpdate += new System.EventHandler(this.CheckKey);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripFile,
            this.StripKey,
            this.StripMe});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // StripFile
            // 
            this.StripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripLoadFile,
            this.StripSaveFile});
            this.StripFile.Name = "StripFile";
            resources.ApplyResources(this.StripFile, "StripFile");
            // 
            // StripLoadFile
            // 
            this.StripLoadFile.Name = "StripLoadFile";
            resources.ApplyResources(this.StripLoadFile, "StripLoadFile");
            this.StripLoadFile.Click += new System.EventHandler(this.LoadFile);
            // 
            // StripSaveFile
            // 
            this.StripSaveFile.Name = "StripSaveFile";
            resources.ApplyResources(this.StripSaveFile, "StripSaveFile");
            this.StripSaveFile.Click += new System.EventHandler(this.SaveFile);
            // 
            // StripKey
            // 
            this.StripKey.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripKeyExt,
            this.StripKeyNew,
            this.StripKeyMan});
            this.StripKey.Name = "StripKey";
            resources.ApplyResources(this.StripKey, "StripKey");
            // 
            // StripKeyExt
            // 
            this.StripKeyExt.Name = "StripKeyExt";
            resources.ApplyResources(this.StripKeyExt, "StripKeyExt");
            this.StripKeyExt.Click += new System.EventHandler(this.StripKeyExt_Click);
            // 
            // StripKeyNew
            // 
            this.StripKeyNew.Name = "StripKeyNew";
            resources.ApplyResources(this.StripKeyNew, "StripKeyNew");
            this.StripKeyNew.Click += new System.EventHandler(this.StripKeyNew_Click);
            // 
            // StripKeyMan
            // 
            this.StripKeyMan.Name = "StripKeyMan";
            resources.ApplyResources(this.StripKeyMan, "StripKeyMan");
            this.StripKeyMan.Click += new System.EventHandler(this.StripKeyMan_Click);
            // 
            // StripMe
            // 
            this.StripMe.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.StripMe, "StripMe");
            this.StripMe.Name = "StripMe";
            // 
            // SaveDialog
            // 
            this.SaveDialog.SupportMultiDottedExtensions = true;
            // 
            // OpenDialog
            // 
            resources.ApplyResources(this.OpenDialog, "OpenDialog");
            // 
            // ComboEncoding
            // 
            this.ComboEncoding.FormattingEnabled = true;
            this.ComboEncoding.Items.AddRange(new object[] {
            resources.GetString("ComboEncoding.Items"),
            resources.GetString("ComboEncoding.Items1"),
            resources.GetString("ComboEncoding.Items2"),
            resources.GetString("ComboEncoding.Items3")});
            resources.ApplyResources(this.ComboEncoding, "ComboEncoding");
            this.ComboEncoding.Name = "ComboEncoding";
            // 
            // OpenDialogKey
            // 
            resources.ApplyResources(this.OpenDialogKey, "OpenDialogKey");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ComboEncoding);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ComboKey);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.TextBoxOut);
            this.Controls.Add(this.TextBoxIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxIn;
        private System.Windows.Forms.TextBox TextBoxOut;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox ComboKey;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripFile;
        private System.Windows.Forms.ToolStripMenuItem StripLoadFile;
        private System.Windows.Forms.ToolStripMenuItem StripSaveFile;
        private System.Windows.Forms.ToolStripMenuItem StripKey;
        private System.Windows.Forms.ToolStripMenuItem StripKeyExt;
        private System.Windows.Forms.ToolStripMenuItem StripKeyNew;
        private System.Windows.Forms.ToolStripMenuItem StripKeyMan;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        public System.Windows.Forms.ComboBox ComboEncoding;
        private System.Windows.Forms.OpenFileDialog OpenDialogKey;
        private System.Windows.Forms.ToolStripMenuItem StripMe;
    }
}

