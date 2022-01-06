
namespace graphic2_growing_ball
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            this.time_now = new System.Windows.Forms.Label();
            this.toTheRight = new System.Windows.Forms.Button();
            this.toTheLeft = new System.Windows.Forms.Button();
            this.killed = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(160, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(802, 582);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stop.ForeColor = System.Drawing.Color.Firebrick;
            this.stop.Location = new System.Drawing.Point(21, 111);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(110, 44);
            this.stop.TabIndex = 3;
            this.stop.Text = "Pause";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.WhiteSmoke;
            this.start.ForeColor = System.Drawing.Color.Green;
            this.start.Location = new System.Drawing.Point(21, 36);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(110, 44);
            this.start.TabIndex = 4;
            this.start.Text = "▶️ Start ";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // time_now
            // 
            this.time_now.AutoSize = true;
            this.time_now.Location = new System.Drawing.Point(71, 183);
            this.time_now.Name = "time_now";
            this.time_now.Size = new System.Drawing.Size(42, 25);
            this.time_now.TabIndex = 5;
            this.time_now.Text = "0.0";
            // 
            // toTheRight
            // 
            this.toTheRight.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.toTheRight.Location = new System.Drawing.Point(56, 264);
            this.toTheRight.Name = "toTheRight";
            this.toTheRight.Size = new System.Drawing.Size(75, 344);
            this.toTheRight.TabIndex = 7;
            this.toTheRight.Text = ">>";
            this.toTheRight.UseVisualStyleBackColor = true;
            this.toTheRight.Click += new System.EventHandler(this.toTheRight_Click);
            // 
            // toTheLeft
            // 
            this.toTheLeft.Location = new System.Drawing.Point(994, 264);
            this.toTheLeft.Name = "toTheLeft";
            this.toTheLeft.Size = new System.Drawing.Size(75, 344);
            this.toTheLeft.TabIndex = 8;
            this.toTheLeft.Text = "<<";
            this.toTheLeft.UseVisualStyleBackColor = true;
            this.toTheLeft.Click += new System.EventHandler(this.toTheLeft_Click);
            // 
            // killed
            // 
            this.killed.AutoSize = true;
            this.killed.Location = new System.Drawing.Point(922, 543);
            this.killed.Name = "killed";
            this.killed.Size = new System.Drawing.Size(24, 25);
            this.killed.TabIndex = 9;
            this.killed.Text = "0";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clear.ForeColor = System.Drawing.Color.Firebrick;
            this.clear.Location = new System.Drawing.Point(994, 36);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(110, 44);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 645);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.killed);
            this.Controls.Add(this.toTheLeft);
            this.Controls.Add(this.toTheRight);
            this.Controls.Add(this.time_now);
            this.Controls.Add(this.start);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label time_now;
        private System.Windows.Forms.Button toTheRight;
        private System.Windows.Forms.Button toTheLeft;
        private System.Windows.Forms.Label killed;
        private System.Windows.Forms.Button clear;
    }
}

