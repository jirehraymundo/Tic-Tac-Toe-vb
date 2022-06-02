namespace Tic_Tac_Toe
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
            this.A = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.H = new System.Windows.Forms.Button();
            this.I = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(40, 33);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(74, 59);
            this.A.TabIndex = 0;
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.ButtonClick);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(40, 98);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(74, 56);
            this.B.TabIndex = 1;
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.ButtonClick);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(40, 160);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(74, 56);
            this.C.TabIndex = 2;
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.ButtonClick);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(120, 33);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(74, 59);
            this.D.TabIndex = 3;
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.ButtonClick);
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(120, 98);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(74, 55);
            this.E.TabIndex = 4;
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.ButtonClick);
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(120, 159);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(74, 57);
            this.F.TabIndex = 5;
            this.F.UseVisualStyleBackColor = true;
            this.F.Click += new System.EventHandler(this.ButtonClick);
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(200, 33);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(74, 59);
            this.G.TabIndex = 6;
            this.G.UseVisualStyleBackColor = true;
            this.G.Click += new System.EventHandler(this.ButtonClick);
            // 
            // H
            // 
            this.H.Location = new System.Drawing.Point(200, 98);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(74, 55);
            this.H.TabIndex = 7;
            this.H.UseVisualStyleBackColor = true;
            this.H.Click += new System.EventHandler(this.ButtonClick);
            // 
            // I
            // 
            this.I.Location = new System.Drawing.Point(200, 159);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(74, 57);
            this.I.TabIndex = 8;
            this.I.UseVisualStyleBackColor = true;
            this.I.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(104, 235);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(90, 33);
            this.Close.TabIndex = 9;
            this.Close.Text = "Exit";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(338, 297);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.I);
            this.Controls.Add(this.H);
            this.Controls.Add(this.G);
            this.Controls.Add(this.F);
            this.Controls.Add(this.E);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button A;
        private Button B;
        private Button C;
        private Button D;
        private Button E;
        private Button F;
        private Button G;
        private Button H;
        private Button I;
        private Button Close;
    }
}