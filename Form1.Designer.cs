
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Passwordtxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Usernametxt = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Issuetxt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = false;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Issuetxt);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.Passwordtxt);
            this.panel1.Controls.Add(this.Usernametxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(0, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 519);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(863, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 28);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 12;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = true;
            this.bunifuLabel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(92, 32);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(220, 31);
            this.bunifuLabel1.TabIndex = 11;
            this.bunifuLabel1.Text = "Gym Management ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(593, 439);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(116, 42);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Enter as Guest?\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(533, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.welcome_i;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(467, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 149);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Login";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 2;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.MidnightBlue;
            this.bunifuThinButton21.Location = new System.Drawing.Point(623, 335);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(151, 41);
            this.bunifuThinButton21.TabIndex = 6;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.AcceptsReturn = false;
            this.Passwordtxt.AcceptsTab = false;
            this.Passwordtxt.AnimationSpeed = 200;
            this.Passwordtxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Passwordtxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Passwordtxt.BackColor = System.Drawing.Color.Transparent;
            this.Passwordtxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Passwordtxt.BackgroundImage")));
            this.Passwordtxt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Passwordtxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Passwordtxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Passwordtxt.BorderColorIdle = System.Drawing.Color.Silver;
            this.Passwordtxt.BorderRadius = 1;
            this.Passwordtxt.BorderThickness = 1;
            this.Passwordtxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Passwordtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Passwordtxt.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.Passwordtxt.DefaultText = "";
            this.Passwordtxt.FillColor = System.Drawing.Color.White;
            this.Passwordtxt.HideSelection = true;
            this.Passwordtxt.IconLeft = null;
            this.Passwordtxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Passwordtxt.IconPadding = 10;
            this.Passwordtxt.IconRight = null;
            this.Passwordtxt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Passwordtxt.Lines = new string[0];
            this.Passwordtxt.Location = new System.Drawing.Point(537, 292);
            this.Passwordtxt.MaxLength = 32767;
            this.Passwordtxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.Passwordtxt.Modified = false;
            this.Passwordtxt.Multiline = false;
            this.Passwordtxt.Name = "Passwordtxt";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Passwordtxt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Passwordtxt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Passwordtxt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Passwordtxt.OnIdleState = stateProperties4;
            this.Passwordtxt.PasswordChar = '●';
            this.Passwordtxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Passwordtxt.PlaceholderText = "Password";
            this.Passwordtxt.ReadOnly = false;
            this.Passwordtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Passwordtxt.SelectedText = "";
            this.Passwordtxt.SelectionLength = 0;
            this.Passwordtxt.SelectionStart = 0;
            this.Passwordtxt.ShortcutsEnabled = true;
            this.Passwordtxt.Size = new System.Drawing.Size(237, 35);
            this.Passwordtxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.Passwordtxt.TabIndex = 5;
            this.Passwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Passwordtxt.TextMarginBottom = 0;
            this.Passwordtxt.TextMarginLeft = 5;
            this.Passwordtxt.TextMarginTop = 0;
            this.Passwordtxt.TextPlaceholder = "Password";
            this.Passwordtxt.UseSystemPasswordChar = true;
            this.Passwordtxt.WordWrap = true;
            // 
            // Usernametxt
            // 
            this.Usernametxt.AcceptsReturn = false;
            this.Usernametxt.AcceptsTab = false;
            this.Usernametxt.AnimationSpeed = 200;
            this.Usernametxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Usernametxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Usernametxt.BackColor = System.Drawing.Color.Transparent;
            this.Usernametxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Usernametxt.BackgroundImage")));
            this.Usernametxt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Usernametxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Usernametxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Usernametxt.BorderColorIdle = System.Drawing.Color.Silver;
            this.Usernametxt.BorderRadius = 1;
            this.Usernametxt.BorderThickness = 1;
            this.Usernametxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Usernametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Usernametxt.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.Usernametxt.DefaultText = "";
            this.Usernametxt.FillColor = System.Drawing.Color.White;
            this.Usernametxt.HideSelection = true;
            this.Usernametxt.IconLeft = null;
            this.Usernametxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Usernametxt.IconPadding = 10;
            this.Usernametxt.IconRight = null;
            this.Usernametxt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Usernametxt.Lines = new string[0];
            this.Usernametxt.Location = new System.Drawing.Point(537, 214);
            this.Usernametxt.MaxLength = 32767;
            this.Usernametxt.MinimumSize = new System.Drawing.Size(100, 35);
            this.Usernametxt.Modified = false;
            this.Usernametxt.Multiline = false;
            this.Usernametxt.Name = "Usernametxt";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Usernametxt.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Usernametxt.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Usernametxt.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Usernametxt.OnIdleState = stateProperties8;
            this.Usernametxt.PasswordChar = '\0';
            this.Usernametxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Usernametxt.PlaceholderText = "username";
            this.Usernametxt.ReadOnly = false;
            this.Usernametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Usernametxt.SelectedText = "";
            this.Usernametxt.SelectionLength = 0;
            this.Usernametxt.SelectionStart = 0;
            this.Usernametxt.ShortcutsEnabled = true;
            this.Usernametxt.Size = new System.Drawing.Size(237, 35);
            this.Usernametxt.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.Usernametxt.TabIndex = 3;
            this.Usernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Usernametxt.TextMarginBottom = 0;
            this.Usernametxt.TextMarginLeft = 5;
            this.Usernametxt.TextMarginTop = 0;
            this.Usernametxt.TextPlaceholder = "username";
            this.Usernametxt.UseSystemPasswordChar = false;
            this.Usernametxt.WordWrap = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(415, 513);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Issuetxt
            // 
            this.Issuetxt.AutoSize = true;
            this.Issuetxt.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issuetxt.ForeColor = System.Drawing.Color.Crimson;
            this.Issuetxt.Location = new System.Drawing.Point(533, 400);
            this.Issuetxt.Name = "Issuetxt";
            this.Issuetxt.Size = new System.Drawing.Size(287, 21);
            this.Issuetxt.TabIndex = 13;
            this.Issuetxt.Text = "Please fill in the Username text box";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 510);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Passwordtxt;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Usernametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel Issuetxt;
    }
}

