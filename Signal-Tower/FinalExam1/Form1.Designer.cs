
namespace FinalExam1
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
            this.add = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.outputSignal = new System.Windows.Forms.TextBox();
            this.showAll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.Button();
            this.xy = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.showform2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.removeOverlapTower = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(38, 116);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(101, 46);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "radius:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 31);
            this.textBox3.TabIndex = 5;
            // 
            // outputSignal
            // 
            this.outputSignal.Location = new System.Drawing.Point(38, 179);
            this.outputSignal.Multiline = true;
            this.outputSignal.Name = "outputSignal";
            this.outputSignal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputSignal.Size = new System.Drawing.Size(290, 211);
            this.outputSignal.TabIndex = 7;
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(165, 116);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(163, 46);
            this.showAll.TabIndex = 8;
            this.showAll.Text = "Show All";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(395, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 481);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(38, 471);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(290, 46);
            this.delete.TabIndex = 10;
            this.delete.Text = "Remove Selected Tower(s)";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // xy
            // 
            this.xy.AutoSize = true;
            this.xy.Location = new System.Drawing.Point(43, 533);
            this.xy.Name = "xy";
            this.xy.Size = new System.Drawing.Size(0, 25);
            this.xy.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(276, 533);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(52, 25);
            this.timeLabel.TabIndex = 12;
            this.timeLabel.Text = "time";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(36, 579);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(113, 43);
            this.start.TabIndex = 13;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(185, 579);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(113, 43);
            this.stop.TabIndex = 14;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(185, 638);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(113, 43);
            this.importButton.TabIndex = 16;
            this.importButton.Text = "import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(36, 638);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(113, 43);
            this.save.TabIndex = 15;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // showform2
            // 
            this.showform2.Location = new System.Drawing.Point(395, 16);
            this.showform2.Name = "showform2";
            this.showform2.Size = new System.Drawing.Size(163, 46);
            this.showform2.TabIndex = 17;
            this.showform2.Text = "Show Form2";
            this.showform2.UseVisualStyleBackColor = true;
            this.showform2.Click += new System.EventHandler(this.showform2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "Hide Form2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeOverlapTower
            // 
            this.removeOverlapTower.Location = new System.Drawing.Point(38, 410);
            this.removeOverlapTower.Name = "removeOverlapTower";
            this.removeOverlapTower.Size = new System.Drawing.Size(290, 46);
            this.removeOverlapTower.TabIndex = 19;
            this.removeOverlapTower.Text = "Remove Overlap Tower(s)";
            this.removeOverlapTower.UseVisualStyleBackColor = true;
            this.removeOverlapTower.Click += new System.EventHandler(this.removeOverlapTower_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 752);
            this.Controls.Add(this.removeOverlapTower);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showform2);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.save);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.xy);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.outputSignal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox outputSignal;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label xy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button showform2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button removeOverlapTower;
    }
}

