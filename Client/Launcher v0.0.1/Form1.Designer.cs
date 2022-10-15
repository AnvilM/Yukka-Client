namespace Launcher_v0._0._1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.underNick = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(240, 118);
            this.textBox1.MaxLength = 16;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Никнейм";
            this.textBox1.Size = new System.Drawing.Size(338, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // background
            // 
            this.background.Location = new System.Drawing.Point(-3, -5);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(806, 459);
            this.background.TabIndex = 1;
            this.background.TabStop = false;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // underNick
            // 
            this.underNick.BackColor = System.Drawing.Color.White;
            this.underNick.Location = new System.Drawing.Point(220, 144);
            this.underNick.Name = "underNick";
            this.underNick.Size = new System.Drawing.Size(378, 1);
            this.underNick.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(235, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 1);
            this.panel1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(255, 195);
            this.textBox2.MaxLength = 256;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '•';
            this.textBox2.PlaceholderText = "Пароль";
            this.textBox2.Size = new System.Drawing.Size(308, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(207)))), ((int)(((byte)(109)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(316, 289);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Играть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registration
            // 
            this.Registration.ActiveLinkColor = System.Drawing.Color.White;
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Registration.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Registration.LinkColor = System.Drawing.Color.Gray;
            this.Registration.Location = new System.Drawing.Point(346, 358);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(113, 25);
            this.Registration.TabIndex = 6;
            this.Registration.TabStop = true;
            this.Registration.Text = "Регистрация";
            this.Registration.VisitedLinkColor = System.Drawing.Color.Gray;
            this.Registration.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Registration_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.underNick);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "YUKKA";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private PictureBox background;
        private Panel underNick;
        private Panel panel1;
        private TextBox textBox2;
        private Button button1;
        private LinkLabel Registration;
    }
}