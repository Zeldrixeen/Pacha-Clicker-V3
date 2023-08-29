namespace PACV3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneControlBox3 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.Pacha = new System.Windows.Forms.PictureBox();
            this.Texto = new System.Windows.Forms.Label();
            this.LeftClick = new System.Windows.Forms.Label();
            this.siticoneTrackBar1 = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.CPS = new System.Windows.Forms.Label();
            this.LeftClicker = new System.Windows.Forms.Timer(this.components);
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.CheckBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.bindbutton = new System.Windows.Forms.Button();
            this.Bind = new System.Windows.Forms.Timer(this.components);
            this.Link = new System.Windows.Forms.LinkLabel();
            this.Solar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pacha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticonePanel1.Controls.Add(this.siticoneControlBox3);
            this.siticonePanel1.Controls.Add(this.siticoneControlBox1);
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(591, 46);
            this.siticonePanel1.TabIndex = 0;
            this.siticonePanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.siticonePanel1_MouseDown);
            this.siticonePanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.siticonePanel1_MouseMove);
            this.siticonePanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.siticonePanel1_MouseUp);
            // 
            // siticoneControlBox3
            // 
            this.siticoneControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox3.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox3.FillColor = System.Drawing.Color.DimGray;
            this.siticoneControlBox3.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox3.Location = new System.Drawing.Point(474, 0);
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.Size = new System.Drawing.Size(60, 46);
            this.siticoneControlBox3.TabIndex = 3;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.DimGray;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(531, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(60, 46);
            this.siticoneControlBox1.TabIndex = 1;
            // 
            // Pacha
            // 
            this.Pacha.Image = global::Anydesk.Properties.Resources.pasdr;
            this.Pacha.Location = new System.Drawing.Point(435, 90);
            this.Pacha.Name = "Pacha";
            this.Pacha.Size = new System.Drawing.Size(18, 53);
            this.Pacha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pacha.TabIndex = 2;
            this.Pacha.TabStop = false;
            // 
            // Texto
            // 
            this.Texto.AutoSize = true;
            this.Texto.BackColor = System.Drawing.Color.Transparent;
            this.Texto.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Texto.Location = new System.Drawing.Point(149, 90);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(280, 40);
            this.Texto.TabIndex = 1;
            this.Texto.Text = "PachaClicker v3";
            // 
            // LeftClick
            // 
            this.LeftClick.AutoSize = true;
            this.LeftClick.BackColor = System.Drawing.Color.Transparent;
            this.LeftClick.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftClick.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LeftClick.Location = new System.Drawing.Point(207, 165);
            this.LeftClick.Name = "LeftClick";
            this.LeftClick.Size = new System.Drawing.Size(169, 32);
            this.LeftClick.TabIndex = 2;
            this.LeftClick.Text = "Left Clicker:";
            // 
            // siticoneTrackBar1
            // 
            this.siticoneTrackBar1.FillColor = System.Drawing.Color.White;
            this.siticoneTrackBar1.Location = new System.Drawing.Point(168, 200);
            this.siticoneTrackBar1.Maximum = 21;
            this.siticoneTrackBar1.Minimum = 8;
            this.siticoneTrackBar1.Name = "siticoneTrackBar1";
            this.siticoneTrackBar1.Size = new System.Drawing.Size(238, 20);
            this.siticoneTrackBar1.TabIndex = 3;
            this.siticoneTrackBar1.ThumbColor = System.Drawing.Color.IndianRed;
            this.siticoneTrackBar1.Value = 10;
            this.siticoneTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.siticoneTrackBar1_Scroll);
            // 
            // CPS
            // 
            this.CPS.AutoSize = true;
            this.CPS.BackColor = System.Drawing.Color.Transparent;
            this.CPS.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPS.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.CPS.Location = new System.Drawing.Point(275, 223);
            this.CPS.Name = "CPS";
            this.CPS.Size = new System.Drawing.Size(50, 23);
            this.CPS.TabIndex = 4;
            this.CPS.Text = "CPS";
            this.CPS.Click += new System.EventHandler(this.CPS_Click);
            // 
            // LeftClicker
            // 
            this.LeftClicker.Enabled = true;
            this.LeftClicker.Tick += new System.EventHandler(this.LeftClicker_Tick);
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CheckBox.CheckedState.BorderRadius = 0;
            this.CheckBox.CheckedState.BorderThickness = 0;
            this.CheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CheckBox.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CheckBox.Location = new System.Drawing.Point(10, 262);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(120, 36);
            this.CheckBox.TabIndex = 5;
            this.CheckBox.Text = "Enable";
            this.CheckBox.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.CheckBox.UncheckedState.BorderRadius = 0;
            this.CheckBox.UncheckedState.BorderThickness = 0;
            this.CheckBox.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // bindbutton
            // 
            this.bindbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bindbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bindbutton.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindbutton.ForeColor = System.Drawing.Color.IndianRed;
            this.bindbutton.Location = new System.Drawing.Point(10, 304);
            this.bindbutton.Name = "bindbutton";
            this.bindbutton.Size = new System.Drawing.Size(62, 36);
            this.bindbutton.TabIndex = 6;
            this.bindbutton.Text = "Bind";
            this.bindbutton.UseVisualStyleBackColor = false;
            this.bindbutton.Click += new System.EventHandler(this.bindbutton_Click);
            this.bindbutton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bindbutton_KeyUp);
            // 
            // Bind
            // 
            this.Bind.Enabled = true;
            this.Bind.Interval = 200;
            this.Bind.Tick += new System.EventHandler(this.Bind_Tick);
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Link.Location = new System.Drawing.Point(428, 339);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(157, 14);
            this.Link.TabIndex = 7;
            this.Link.TabStop = true;
            this.Link.Text = "© Made by Mentiras / Zeldrixen";
            this.Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_LinkClicked);
            // 
            // Solar
            // 
            this.Solar.AutoSize = true;
            this.Solar.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solar.ForeColor = System.Drawing.Color.Silver;
            this.Solar.Location = new System.Drawing.Point(249, 130);
            this.Solar.Name = "Solar";
            this.Solar.Size = new System.Drawing.Size(84, 13);
            this.Solar.TabIndex = 8;
            this.Solar.Text = "Lunar Version";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Anydesk.Properties.Resources.pasdr;
            this.pictureBox1.Location = new System.Drawing.Point(125, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(587, 357);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pacha);
            this.Controls.Add(this.Solar);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.bindbutton);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.CPS);
            this.Controls.Add(this.siticoneTrackBar1);
            this.Controls.Add(this.LeftClick);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pacha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private System.Windows.Forms.PictureBox Pacha;
        private System.Windows.Forms.Label Texto;
        private System.Windows.Forms.Label LeftClick;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar siticoneTrackBar1;
        private System.Windows.Forms.Label CPS;
        private System.Windows.Forms.Timer LeftClicker;
        private System.Windows.Forms.Timer Random;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox CheckBox;
        private System.Windows.Forms.Button bindbutton;
        private System.Windows.Forms.Timer Bind;
        private System.Windows.Forms.LinkLabel Link;
        private System.Windows.Forms.Label Solar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

