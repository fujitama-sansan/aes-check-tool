namespace AESCheckTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            this._aesKeyBox = new System.Windows.Forms.TextBox();
            this._cookieValueBox = new System.Windows.Forms.TextBox();
            this._jsonPane = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._decryptButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 18);
            label1.TabIndex = 3;
            label1.Text = "AES Key";
            // 
            // _aesKeyBox
            // 
            this._aesKeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._aesKeyBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._aesKeyBox.Location = new System.Drawing.Point(196, 21);
            this._aesKeyBox.Name = "_aesKeyBox";
            this._aesKeyBox.Size = new System.Drawing.Size(578, 25);
            this._aesKeyBox.TabIndex = 0;
            this._aesKeyBox.Enter += new System.EventHandler(this._aesKeyBox_Enter);
            // 
            // _cookieValueBox
            // 
            this._cookieValueBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cookieValueBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._cookieValueBox.Location = new System.Drawing.Point(196, 65);
            this._cookieValueBox.Name = "_cookieValueBox";
            this._cookieValueBox.Size = new System.Drawing.Size(578, 25);
            this._cookieValueBox.TabIndex = 1;
            this._cookieValueBox.Enter += new System.EventHandler(this._cookieValueBox_Enter);
            // 
            // _jsonPane
            // 
            this._jsonPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._jsonPane.Location = new System.Drawing.Point(25, 169);
            this._jsonPane.Multiline = true;
            this._jsonPane.Name = "_jsonPane";
            this._jsonPane.ReadOnly = true;
            this._jsonPane.Size = new System.Drawing.Size(749, 269);
            this._jsonPane.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cookie value";
            // 
            // _decryptButton
            // 
            this._decryptButton.Location = new System.Drawing.Point(118, 109);
            this._decryptButton.Name = "_decryptButton";
            this._decryptButton.Size = new System.Drawing.Size(150, 42);
            this._decryptButton.TabIndex = 5;
            this._decryptButton.Text = "Decrypt";
            this._decryptButton.UseVisualStyleBackColor = true;
            this._decryptButton.Click += new System.EventHandler(this._decryptButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._decryptButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(this._jsonPane);
            this.Controls.Add(this._cookieValueBox);
            this.Controls.Add(this._aesKeyBox);
            this.Name = "Form1";
            this.Text = "AES Decrypter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _aesKeyBox;
        private System.Windows.Forms.TextBox _cookieValueBox;
        private System.Windows.Forms.TextBox _jsonPane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _decryptButton;
    }
}

