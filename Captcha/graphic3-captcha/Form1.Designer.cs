
namespace graphic3_captcha
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
            this.upload = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // upload
            // 
            this.upload.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.upload.Location = new System.Drawing.Point(44, 72);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(112, 47);
            this.upload.TabIndex = 0;
            this.upload.Text = "upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // run
            // 
            this.run.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run.ForeColor = System.Drawing.Color.DarkGreen;
            this.run.Location = new System.Drawing.Point(44, 168);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(112, 47);
            this.run.TabIndex = 1;
            this.run.Text = "run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(215, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(702, 425);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.DarkRed;
            this.save.Location = new System.Drawing.Point(44, 261);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(112, 47);
            this.save.TabIndex = 3;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(215, 473);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(702, 11);
            this.progressBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 525);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.run);
            this.Controls.Add(this.upload);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

