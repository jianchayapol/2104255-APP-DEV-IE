using iTextSharp.text;
using iTextSharp.text.pdf;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ProductiveDay : Form
    {

        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        Form4 form4 = new Form4();

        class ThingsToDo : IComparable<ThingsToDo>
        {
            string title;
            string description;
            int priorityLevel;
            int dueTime;
            string subject;
            string status;
            string url;

            public ThingsToDo(string subject, string title, string description, int priorityLevel, int dueTime, string status, string url)
            {
                this.subject = subject;
                this.title = title;
                this.description = description;
                this.priorityLevel = priorityLevel;
                this.dueTime = dueTime;
                this.status = "Waiting..";
                this.url = url;
            }

            public int CompareTo(ThingsToDo other)
            {

                if (this.getDueTime() != other.getDueTime())
                {
                    if (this.getDueTime() > other.getDueTime()) return 1;
                    else return -1;
                }
                if (this.getPriorityLevel() != other.getPriorityLevel())
                    if (this.getPriorityLevel() < other.getPriorityLevel()) return 1;
                    else return -1;
                return 1;
            }
            public string getTitle()
            {
                return this.title;
            }

            public string getDescription()
            {
                return this.description;
            }

            public int getPriorityLevel()
            {
                return this.priorityLevel;
            }

            public int getDueTime()
            {
                return this.dueTime;
            }

            public string getUrl()
            {
                return this.url;

            }

            public string getStatus()
            {
                return this.status;
            }

            public string getSubject()
            {
                return this.subject;
            }

            public Bitmap getQR()
            {
                return generateQRcode(this.url);
            }
        }

        private void notifyWithin24Due()
        {
            string alert = "";
            s = new SortedSet<ThingsToDo>();
            int h = 5;
            sortFromCSV();
            foreach (ThingsToDo thing in s)
            {
                DateTime anotherDay = UnixTimeStampToDateTime(thing.getDueTime());
                DateTime today = DateTime.Now;
                if ((anotherDay - today).TotalDays <= 1)
                {
                    string subj = "";
                    if (thing.getSubject() != "") subj = " [" + thing.getSubject() + "] ";
                    alert += "   " +thing.getTitle() + subj + "\r\n";
                    h++;
                }
            }

            if (alert == "") alert = "Nothing dues in 24 hours\r\n";

            Tulpep.NotificationWindow.PopupNotifier popup = new Tulpep.NotificationWindow.PopupNotifier();
            
            popup.ShowGrip = false;
            popup.HeaderHeight = 20;
            popup.TitlePadding = new Padding(3);
            popup.ContentPadding = new Padding(3);
            popup.AnimationDuration = 1000;
            popup.AnimationInterval = 1;
            popup.HeaderColor = Color.FromArgb(125, 164, 200);
            popup.ShowCloseButton = true;
            popup.TitleText = "[Auto Message]   Due in 24 hours ";
            popup.ContentText = alert;
            popup.Scroll = true;
            popup.Size = new Size(400,  h*2*8);
            popup.Popup();
        }

        private static Bitmap generateQRcode(string url)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(180);

            Bitmap qr180 = new Bitmap(qrCodeImage,90, 90);
            return qr180;
        }


        // MAIN
        public ProductiveDay()
        {
            InitializeComponent();
            timer1.Start();
            if (!File.Exists("lists-to-do.csv")) using (StreamWriter w = File.AppendText("lists-to-do.csv")) ;

            notifyWithin24Due();

            showOnGrid();


            greetWordList.Add("Working Hard?");
            greetWordList.Add("Cheer Up!");
            greetWordList.Add("Let's gooooo");
            greetWordList.Add("working on progress..");
            greetWordList.Add("Fighting and Get A!");
            greetWordList.Add("Good Vibes");
            greetWordList.Add("Study Mode?");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.mycourseville.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.blackboard.chula.ac.th");
        }

        private void githubLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.github.com/jianchayapol");
        }

        private void mycoursevilleLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.mycourseville.com");
        }

        private void blackboardLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://blackboard.it.chula.ac.th/");
        }

        private void regChulaLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.reg.chula.ac.th");
        }

        private void ProductiveDay_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void exportAsPdf_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                string d = DateTime.Now.ToShortDateString();
                sfd.FileName = "to-do_" + d.Replace("/","-")+ ".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null && cell.Value is string) pdfTable.AddCell(cell.Value.ToString());
                                    else pdfTable.AddCell(" ");
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !", "Info");
            }
        }

  
      
        SortedSet<ThingsToDo> s = new SortedSet<ThingsToDo>();

        long t = 0;
        List<string> greetWordList = new List<string>();

        public static long ToUnixTimestamp(DateTime target)
        {
            var date = new DateTime(1970, 1, 1, 0, 0, 0, target.Kind);
            var unixTimestamp = System.Convert.ToInt64((target - date).TotalSeconds);

            return unixTimestamp;
        }

        private void sortFromCSV()
        { 
            string[] lines = System.IO.File.ReadAllLines("lists-to-do.csv");
            DataTable dt = new DataTable();
            if (lines.Length > 0)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');
                    if (data.Length != 7) continue;
                        DataRow dr = dt.NewRow();
                    if ( ToUnixTimestamp(DateTime.Now) - long.Parse(data[4]) < 12*60*60) // 12 hours to be clear
                    {
                        ThingsToDo tmp = new ThingsToDo(data[0], data[1], data[2], int.Parse(data[3]), int.Parse(data[4]), data[5], data[6]);
                        s.Add(tmp);
                    }
                    
                }
            }
            return ;
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }


        private  void showOnGrid()
        {

            s = new SortedSet<ThingsToDo>();

            sortFromCSV();

            DataTable dt = new DataTable();

            dt.Columns.Add("Title");
            dt.Columns.Add("Subject");
            dt.Columns.Add("Description");
            dt.Columns.Add("url");
            dt.Columns.Add("Dates");
            dt.Columns.Add("Status");
            
            foreach (ThingsToDo item in s)
            {

                DataRow dr = dt.NewRow();
                dr["Subject"] = item.getSubject();
                dr["Title"] = item.getTitle();
                dr["Description"] = item.getDescription();
                dr["Dates"] = UnixTimeStampToDateTime(item.getDueTime()).ToLongDateString();
                
                dr["Status"] = item.getStatus();
                dr["url"] = item.getUrl();

                
                dt.Rows.Add(dr);
            }
            
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            for(int i=0 ; i< dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                if (i % 2 != 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
                
                else if (dataGridView1.Rows[i].Cells[8].Value.ToString().Equals("Complete.."))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }

        }

        private void addItem_Click(object sender, EventArgs e)
        {
            form3.Show();
            showOnGrid();
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.ColumnIndex == 1)
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
                {
                    string urlLink = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    if (urlLink == "") MessageBox.Show("URL NOT FOUND");
                    else
                    {
                        Bitmap qr = generateQRcode(urlLink);
                        pictureBox4.Image = qr;
                        
                    }
                }
            }
            else if (e.ColumnIndex == 2)
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
                {
                    
                    string title =  dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + " (" +  dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + " )";
                    string des = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    form2.showDesc(title, des);

                    string urlLink = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    if (urlLink != "")
                    {
                        Bitmap qr = generateQRcode(urlLink);
                        form2.showQRform2(qr);

                    }


                    form2.Show();
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += 1;
            if (t % 10 == 1)
            {
                time_now.Text = DateTime.Now.ToString();
                Refresh();
            }
            
            if(t% 100 == 0) 
            {
                var random = new Random();
                int index = random.Next(greetWordList.Count);
                greetLabel.Text = greetWordList[index];
                greetLabel.ForeColor = randomColor();
            }

        }

        private Color randomColor()
        {
            Random rnd = new Random();
            Color c = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            return c;
        }

        private void calendar_show_Click(object sender, EventArgs e)
        {
            form4.Show();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            showOnGrid();
            Refresh();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void comingEvents_Click(object sender, EventArgs e)
        {
            notifyWithin24Due();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
        }
    }
}
