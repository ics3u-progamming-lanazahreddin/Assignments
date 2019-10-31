namespace FallingObjectsLanaZE
{
    partial class frmFallingObjectsLanaZE
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.earthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gravityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // gravityToolStripMenuItem
            // 
            this.gravityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.earthToolStripMenuItem,
            this.moonToolStripMenuItem});
            this.gravityToolStripMenuItem.Name = "gravityToolStripMenuItem";
            this.gravityToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.gravityToolStripMenuItem.Text = "Gravity";
            // 
            // earthToolStripMenuItem
            // 
            this.earthToolStripMenuItem.Name = "earthToolStripMenuItem";
            this.earthToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.earthToolStripMenuItem.Text = "Earth";
            this.earthToolStripMenuItem.Click += new System.EventHandler(this.EarthToolStripMenuItem_Click);
            // 
            // moonToolStripMenuItem
            // 
            this.moonToolStripMenuItem.Name = "moonToolStripMenuItem";
            this.moonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.moonToolStripMenuItem.Text = "Moon";
            this.moonToolStripMenuItem.Click += new System.EventHandler(this.MoonToolStripMenuItem_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.DarkRed;
            this.lblQuestion.Location = new System.Drawing.Point(97, 56);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(846, 35);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Enter the time (in seconds) since the rock has been thrown from the Cliff:";
            this.lblQuestion.Click += new System.EventHandler(this.LblQuestion_Click);
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.Silver;
            this.txtTime.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(340, 109);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(378, 67);
            this.txtTime.TabIndex = 2;
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTime_KeyPress_1);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Maroon;
            this.lblAnswer.Location = new System.Drawing.Point(12, 379);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 35);
            this.lblAnswer.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Info;
            this.btnCalculate.Font = new System.Drawing.Font("Simplified Arabic Fixed", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Chocolate;
            this.btnCalculate.Location = new System.Drawing.Point(248, 205);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(539, 65);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate!";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // frmFallingObjectsLanaZE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFallingObjectsLanaZE";
            this.Text = "Falling Objects by Lana ZE";
            this.Load += new System.EventHandler(this.FrmFallingObjectsLanaZE_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gravityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem earthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moonToolStripMenuItem;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnCalculate;
    }
}

