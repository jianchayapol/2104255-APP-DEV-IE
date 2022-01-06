
namespace FinalProject
{
    partial class ProductiveDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductiveDay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.greetLabel = new System.Windows.Forms.Label();
            this.time_now = new System.Windows.Forms.Label();
            this.exportAsPdf = new System.Windows.Forms.Button();
            this.mycoursevilleLink = new System.Windows.Forms.Button();
            this.blackboardLink = new System.Windows.Forms.Button();
            this.regChulaLink = new System.Windows.Forms.Button();
            this.addevents = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Checklist = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.urlQR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Desc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addItem = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.githubLink = new System.Windows.Forms.Button();
            this.calendar_show = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.comingEvents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 931);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Bahnschrift", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(261, 54);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(268, 45);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Productive Day";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // greetLabel
            // 
            this.greetLabel.AutoSize = true;
            this.greetLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetLabel.Location = new System.Drawing.Point(262, 105);
            this.greetLabel.Name = "greetLabel";
            this.greetLabel.Size = new System.Drawing.Size(330, 39);
            this.greetLabel.TabIndex = 2;
            this.greetLabel.Text = "working on progress..";
            this.greetLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // time_now
            // 
            this.time_now.AutoSize = true;
            this.time_now.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_now.Location = new System.Drawing.Point(658, 113);
            this.time_now.Name = "time_now";
            this.time_now.Size = new System.Drawing.Size(0, 29);
            this.time_now.TabIndex = 5;
            // 
            // exportAsPdf
            // 
            this.exportAsPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exportAsPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportAsPdf.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportAsPdf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exportAsPdf.Location = new System.Drawing.Point(-1, 514);
            this.exportAsPdf.Name = "exportAsPdf";
            this.exportAsPdf.Size = new System.Drawing.Size(240, 89);
            this.exportAsPdf.TabIndex = 8;
            this.exportAsPdf.Text = "Export as pdf";
            this.exportAsPdf.UseVisualStyleBackColor = false;
            this.exportAsPdf.Click += new System.EventHandler(this.exportAsPdf_Click);
            // 
            // mycoursevilleLink
            // 
            this.mycoursevilleLink.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mycoursevilleLink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mycoursevilleLink.BackgroundImage")));
            this.mycoursevilleLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mycoursevilleLink.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mycoursevilleLink.Location = new System.Drawing.Point(269, 787);
            this.mycoursevilleLink.Name = "mycoursevilleLink";
            this.mycoursevilleLink.Size = new System.Drawing.Size(164, 54);
            this.mycoursevilleLink.TabIndex = 15;
            this.mycoursevilleLink.UseVisualStyleBackColor = false;
            this.mycoursevilleLink.Click += new System.EventHandler(this.mycoursevilleLink_Click);
            // 
            // blackboardLink
            // 
            this.blackboardLink.BackColor = System.Drawing.Color.WhiteSmoke;
            this.blackboardLink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blackboardLink.BackgroundImage")));
            this.blackboardLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackboardLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.blackboardLink.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.blackboardLink.Location = new System.Drawing.Point(464, 787);
            this.blackboardLink.Name = "blackboardLink";
            this.blackboardLink.Size = new System.Drawing.Size(164, 54);
            this.blackboardLink.TabIndex = 14;
            this.blackboardLink.Text = "Blackboard.it";
            this.blackboardLink.UseVisualStyleBackColor = false;
            this.blackboardLink.Click += new System.EventHandler(this.blackboardLink_Click);
            // 
            // regChulaLink
            // 
            this.regChulaLink.BackColor = System.Drawing.Color.WhiteSmoke;
            this.regChulaLink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regChulaLink.BackgroundImage")));
            this.regChulaLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.regChulaLink.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.regChulaLink.Location = new System.Drawing.Point(663, 787);
            this.regChulaLink.Name = "regChulaLink";
            this.regChulaLink.Size = new System.Drawing.Size(164, 54);
            this.regChulaLink.TabIndex = 13;
            this.regChulaLink.UseVisualStyleBackColor = false;
            this.regChulaLink.Click += new System.EventHandler(this.regChulaLink_Click);
            // 
            // addevents
            // 
            this.addevents.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.addevents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(92)))));
            this.addevents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addevents.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addevents.Location = new System.Drawing.Point(0, 323);
            this.addevents.Name = "addevents";
            this.addevents.Size = new System.Drawing.Size(297, 89);
            this.addevents.TabIndex = 9;
            this.addevents.Text = "Add New Event";
            this.addevents.UseVisualStyleBackColor = false;
            this.addevents.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pictureBox2.Location = new System.Drawing.Point(239, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(908, 545);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checklist,
            this.urlQR,
            this.Desc});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(239, 191);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(904, 560);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(904, 530);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Checklist
            // 
            this.Checklist.FillWeight = 200F;
            this.Checklist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Checklist.HeaderText = "check";
            this.Checklist.MinimumWidth = 10;
            this.Checklist.Name = "Checklist";
            this.Checklist.ToolTipText = "Click!";
            this.Checklist.Width = 60;
            // 
            // urlQR
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urlQR.DefaultCellStyle = dataGridViewCellStyle1;
            this.urlQR.FillWeight = 120F;
            this.urlQR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.urlQR.HeaderText = "🔎 QR";
            this.urlQR.MinimumWidth = 10;
            this.urlQR.Name = "urlQR";
            this.urlQR.ToolTipText = "Generate QRcode ";
            this.urlQR.Width = 45;
            // 
            // Desc
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc.DefaultCellStyle = dataGridViewCellStyle2;
            this.Desc.FillWeight = 120F;
            this.Desc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Desc.HeaderText = "desc";
            this.Desc.MinimumWidth = 10;
            this.Desc.Name = "Desc";
            this.Desc.Text = "Desc";
            this.Desc.ToolTipText = "Click! (Description)";
            this.Desc.Width = 45;
            // 
            // addItem
            // 
            this.addItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addItem.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addItem.Location = new System.Drawing.Point(0, 418);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(240, 89);
            this.addItem.TabIndex = 21;
            this.addItem.Text = "Add new item";
            this.addItem.UseVisualStyleBackColor = false;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(29, 72);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(180, 180);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // githubLink
            // 
            this.githubLink.BackColor = System.Drawing.Color.Black;
            this.githubLink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("githubLink.BackgroundImage")));
            this.githubLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.githubLink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.githubLink.ForeColor = System.Drawing.Color.Transparent;
            this.githubLink.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.githubLink.Location = new System.Drawing.Point(39, 787);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(164, 54);
            this.githubLink.TabIndex = 24;
            this.githubLink.UseVisualStyleBackColor = false;
            this.githubLink.Click += new System.EventHandler(this.githubLink_Click);
            // 
            // calendar_show
            // 
            this.calendar_show.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calendar_show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calendar_show.BackgroundImage")));
            this.calendar_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.calendar_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calendar_show.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar_show.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calendar_show.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.calendar_show.Location = new System.Drawing.Point(862, 787);
            this.calendar_show.Name = "calendar_show";
            this.calendar_show.Size = new System.Drawing.Size(167, 54);
            this.calendar_show.TabIndex = 25;
            this.calendar_show.UseVisualStyleBackColor = false;
            this.calendar_show.Click += new System.EventHandler(this.calendar_show_Click);
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reload.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reload.Location = new System.Drawing.Point(0, 322);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(240, 89);
            this.reload.TabIndex = 26;
            this.reload.Text = "Reload";
            this.reload.UseVisualStyleBackColor = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // comingEvents
            // 
            this.comingEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comingEvents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comingEvents.Font = new System.Drawing.Font("Bahnschrift", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comingEvents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comingEvents.Location = new System.Drawing.Point(0, 610);
            this.comingEvents.Name = "comingEvents";
            this.comingEvents.Size = new System.Drawing.Size(240, 89);
            this.comingEvents.TabIndex = 27;
            this.comingEvents.Text = "Coming Events";
            this.comingEvents.UseVisualStyleBackColor = false;
            this.comingEvents.Click += new System.EventHandler(this.comingEvents_Click);
            // 
            // ProductiveDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1142, 864);
            this.Controls.Add(this.comingEvents);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.calendar_show);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.mycoursevilleLink);
            this.Controls.Add(this.blackboardLink);
            this.Controls.Add(this.regChulaLink);
            this.Controls.Add(this.exportAsPdf);
            this.Controls.Add(this.time_now);
            this.Controls.Add(this.greetLabel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductiveDay";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProductiveDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label greetLabel;
        private System.Windows.Forms.Label time_now;
        private System.Windows.Forms.Button exportAsPdf;
        private System.Windows.Forms.Button mycoursevilleLink;
        private System.Windows.Forms.Button blackboardLink;
        private System.Windows.Forms.Button regChulaLink;
        private System.Windows.Forms.Button addevents;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button githubLink;
        private System.Windows.Forms.Button calendar_show;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Button comingEvents;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checklist;
        private System.Windows.Forms.DataGridViewButtonColumn urlQR;
        private System.Windows.Forms.DataGridViewButtonColumn Desc;
    }
}

