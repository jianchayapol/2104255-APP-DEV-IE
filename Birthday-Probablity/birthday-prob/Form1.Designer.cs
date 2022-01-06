
namespace birthday_prob
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.student = new System.Windows.Forms.Label();
            this.n_students = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birthday 🍰";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 96);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(269, 477);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(337, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "output : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "0 %";
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.Location = new System.Drawing.Point(218, 43);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(118, 25);
            this.student.TabIndex = 8;
            this.student.Text = "#students :";
            // 
            // n_students
            // 
            this.n_students.Location = new System.Drawing.Point(345, 41);
            this.n_students.Name = "n_students";
            this.n_students.Size = new System.Drawing.Size(100, 31);
            this.n_students.TabIndex = 7;
            this.n_students.TextChanged += new System.EventHandler(this.n_students_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(337, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 612);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.student);
            this.Controls.Add(this.n_students);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label student;
        private System.Windows.Forms.TextBox n_students;
        private System.Windows.Forms.Button button2;
    }
}

