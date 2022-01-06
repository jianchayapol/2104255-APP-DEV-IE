
namespace sampleQuiz2
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
            this.start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(36, 55);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(106, 53);
            this.start.TabIndex = 0;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(45, 158);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(24, 25);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(319, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 640);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(36, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 56);
            this.textBox1.TabIndex = 3;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(36, 219);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(106, 44);
            this.clear.TabIndex = 4;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(160, 375);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(106, 44);
            this.show.TabIndex = 5;
            this.show.Text = "show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(36, 375);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(106, 44);
            this.hide.TabIndex = 6;
            this.hide.Text = "hide";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(36, 589);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(106, 44);
            this.save.TabIndex = 8;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(160, 589);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(106, 44);
            this.import.TabIndex = 7;
            this.import.Text = "import";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(36, 503);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 56);
            this.textBox2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 662);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "get password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 795);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.save);
            this.Controls.Add(this.import);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.show);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

