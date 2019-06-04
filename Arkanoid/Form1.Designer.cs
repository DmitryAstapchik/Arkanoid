namespace Arkanoid
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelCount = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelPause = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(66, 22);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(120, 25);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "Отбиваний:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(66, 59);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(75, 25);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Очков:";
            // 
            // labelStart
            // 
            this.labelStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.Location = new System.Drawing.Point(88, 235);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(638, 31);
            this.labelStart.TabIndex = 2;
            this.labelStart.Text = "Нажмите пробел для начала игры или для паузы.";
            // 
            // labelPause
            // 
            this.labelPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPause.AutoSize = true;
            this.labelPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPause.Location = new System.Drawing.Point(289, 221);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(207, 63);
            this.labelPause.TabIndex = 3;
            this.labelPause.Text = "ПАУЗА";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 509);
            this.Controls.Add(this.labelPause);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelCount);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Arkanoid";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelPause;
    }
}

