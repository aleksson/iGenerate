namespace PasswordGen
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
            this.checkBox_chars = new System.Windows.Forms.CheckBox();
            this.checkBox_num = new System.Windows.Forms.CheckBox();
            this.checkBox_sym = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_newPassword = new System.Windows.Forms.Label();
            this.label_newPassLength = new System.Windows.Forms.Label();
            this.trackBar_passLength = new System.Windows.Forms.TrackBar();
            this.linkLabel_copy = new System.Windows.Forms.LinkLabel();
            this.linkLabel_generateNew = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_passLength)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_chars
            // 
            this.checkBox_chars.AutoSize = true;
            this.checkBox_chars.Checked = true;
            this.checkBox_chars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_chars.Location = new System.Drawing.Point(39, 321);
            this.checkBox_chars.Name = "checkBox_chars";
            this.checkBox_chars.Size = new System.Drawing.Size(67, 21);
            this.checkBox_chars.TabIndex = 0;
            this.checkBox_chars.Text = "Chars";
            this.checkBox_chars.UseVisualStyleBackColor = true;
            this.checkBox_chars.CheckedChanged += new System.EventHandler(this.checkBox_chars_CheckedChanged);
            // 
            // checkBox_num
            // 
            this.checkBox_num.AutoSize = true;
            this.checkBox_num.Checked = true;
            this.checkBox_num.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_num.Location = new System.Drawing.Point(39, 348);
            this.checkBox_num.Name = "checkBox_num";
            this.checkBox_num.Size = new System.Drawing.Size(87, 21);
            this.checkBox_num.TabIndex = 0;
            this.checkBox_num.Text = "Numbers";
            this.checkBox_num.UseVisualStyleBackColor = true;
            this.checkBox_num.CheckedChanged += new System.EventHandler(this.checkBox_num_CheckedChanged);
            // 
            // checkBox_sym
            // 
            this.checkBox_sym.AutoSize = true;
            this.checkBox_sym.Location = new System.Drawing.Point(39, 375);
            this.checkBox_sym.Name = "checkBox_sym";
            this.checkBox_sym.Size = new System.Drawing.Size(83, 21);
            this.checkBox_sym.TabIndex = 0;
            this.checkBox_sym.Text = "Symbols";
            this.checkBox_sym.UseVisualStyleBackColor = true;
            this.checkBox_sym.CheckedChanged += new System.EventHandler(this.checkBox_sym_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(-45, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 126);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label_newPassword
            // 
            this.label_newPassword.AutoSize = true;
            this.label_newPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newPassword.ForeColor = System.Drawing.Color.White;
            this.label_newPassword.Location = new System.Drawing.Point(24, 124);
            this.label_newPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_newPassword.Name = "label_newPassword";
            this.label_newPassword.Size = new System.Drawing.Size(0, 25);
            this.label_newPassword.TabIndex = 7;
            // 
            // label_newPassLength
            // 
            this.label_newPassLength.AutoSize = true;
            this.label_newPassLength.Location = new System.Drawing.Point(33, 228);
            this.label_newPassLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_newPassLength.Name = "label_newPassLength";
            this.label_newPassLength.Size = new System.Drawing.Size(82, 17);
            this.label_newPassLength.TabIndex = 9;
            this.label_newPassLength.Text = "Length ( 8 )";
            // 
            // trackBar_passLength
            // 
            this.trackBar_passLength.Location = new System.Drawing.Point(35, 257);
            this.trackBar_passLength.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_passLength.Maximum = 28;
            this.trackBar_passLength.Minimum = 4;
            this.trackBar_passLength.Name = "trackBar_passLength";
            this.trackBar_passLength.Size = new System.Drawing.Size(333, 56);
            this.trackBar_passLength.SmallChange = 2;
            this.trackBar_passLength.TabIndex = 8;
            this.trackBar_passLength.TickFrequency = 4;
            this.trackBar_passLength.Value = 8;
            this.trackBar_passLength.Scroll += new System.EventHandler(this.trackBar_passLength_Scroll);
            // 
            // linkLabel_copy
            // 
            this.linkLabel_copy.AutoSize = true;
            this.linkLabel_copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel_copy.LinkColor = System.Drawing.Color.White;
            this.linkLabel_copy.Location = new System.Drawing.Point(344, 174);
            this.linkLabel_copy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_copy.Name = "linkLabel_copy";
            this.linkLabel_copy.Size = new System.Drawing.Size(40, 17);
            this.linkLabel_copy.TabIndex = 10;
            this.linkLabel_copy.TabStop = true;
            this.linkLabel_copy.Text = "Copy";
            this.linkLabel_copy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_copy_LinkClicked);
            // 
            // linkLabel_generateNew
            // 
            this.linkLabel_generateNew.AutoSize = true;
            this.linkLabel_generateNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel_generateNew.LinkColor = System.Drawing.Color.White;
            this.linkLabel_generateNew.Location = new System.Drawing.Point(270, 174);
            this.linkLabel_generateNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_generateNew.Name = "linkLabel_generateNew";
            this.linkLabel_generateNew.Size = new System.Drawing.Size(58, 17);
            this.linkLabel_generateNew.TabIndex = 11;
            this.linkLabel_generateNew.TabStop = true;
            this.linkLabel_generateNew.Text = "Refresh";
            this.linkLabel_generateNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_generateNew_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(39, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "- a simple password generator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel_copy);
            this.Controls.Add(this.linkLabel_generateNew);
            this.Controls.Add(this.label_newPassLength);
            this.Controls.Add(this.trackBar_passLength);
            this.Controls.Add(this.label_newPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox_sym);
            this.Controls.Add(this.checkBox_num);
            this.Controls.Add(this.checkBox_chars);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "iGenerate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_passLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_chars;
        private System.Windows.Forms.CheckBox checkBox_num;
        private System.Windows.Forms.CheckBox checkBox_sym;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_newPassword;
        private System.Windows.Forms.Label label_newPassLength;
        private System.Windows.Forms.TrackBar trackBar_passLength;
        private System.Windows.Forms.LinkLabel linkLabel_copy;
        private System.Windows.Forms.LinkLabel linkLabel_generateNew;
        private System.Windows.Forms.Label label1;
    }
}

