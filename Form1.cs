using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PDF_Resume_Creator
{
    public partial class PDFResumeForm : Form
    {
        public PDFResumeForm()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {

            StreamWriter file = new StreamWriter(@"D:\Claudio Abuloc Files\Contact Tracing\Resume.json", true);
            file.WriteLine("Name: " + FirstNametextBox.Text + SurnametextBox.Text);
            file.WriteLine("Phone: " + PhonetextBox.Text);
            file.WriteLine("Email: " + EmailtextBox.Text);
            file.WriteLine("Home: " + HometextBox.Text);
            file.WriteLine("Skills: " + SkillstextBox.Text);
            file.WriteLine("Elementary School: " + ElementarytextBox.Text + "" + SYElementarytextBox.Text);
            file.WriteLine("High School: " + HighSchooltextBox.Text + "" + SYHighschooltextBox.Text);
            file.WriteLine("College/University: " + CollegetextBox.Text + "" + SYCollegetextBox.Text);
            file.WriteLine("Awards: " + AwardstextBox.Text);
            file.WriteLine("Certification: " + CertificationtextBox.Text);
            file.WriteLine("Work Experience: " + WorkExperiencetextBox.Text);
            file.Close();
            FirstNametextBox.Text = "";
            SurnametextBox.Text = "";
            PhonetextBox.Text = "";
            EmailtextBox.Text = "";
            HometextBox.Text = "";
            SkillstextBox.Text = "";
            ElementarytextBox.Text = "";
            HighSchooltextBox.Text = "";
            CollegetextBox.Text = "";
            AwardstextBox.Text = "";
            CertificationtextBox.Text = "";
            WorkExperiencetextBox.Text = "";
        }

        private void Readbutton_Click(object sender, EventArgs e)
        {
            ReadlistBox.Items.Clear();
            StreamReader reader = new StreamReader(@"D:\Claudio Abuloc Files\Contact Tracing\Resume.json");
            while (!reader.EndOfStream)
            {
                ReadlistBox.Items.Add(reader.ReadLine());
            }
            reader.Close();

        }

        private void PDFbutton_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER,10,10,42,35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(SurnametextBox.Text+FirstNametextBox.Text+".pdf", FileMode.Create));
            doc.Open();
            Paragraph Name = new Paragraph ("Name: " + FirstNametextBox.Text + SurnametextBox.Text);
            Paragraph Phone = new Paragraph("Phone: " + PhonetextBox.Text);
            Paragraph Email = new Paragraph("Email: " + EmailtextBox.Text);
            Paragraph Home = new Paragraph("Home: " + HometextBox.Text);
            Paragraph Skills = new Paragraph("Skills: " + SkillstextBox.Text);
            Paragraph Elementary = new Paragraph("Elementary School: " + ElementarytextBox.Text + "" + SYElementarytextBox.Text);
            Paragraph HS = new Paragraph("High School: " + HighSchooltextBox.Text + "" + SYHighschooltextBox.Text);
            Paragraph College = new Paragraph("College/University: " + CollegetextBox.Text + "" + SYCollegetextBox.Text);
            Paragraph Awards = new Paragraph("Awards: " + AwardstextBox.Text);
            Paragraph Certification = new Paragraph("Certification: " + CertificationtextBox.Text);
            Paragraph Work = new Paragraph("Work Experience: " + WorkExperiencetextBox.Text);
            doc.Add(Name);
            
     
            doc.Add (Phone);
            
            doc.Add(Email);
            
            doc.Add((Home));
            
            doc.Add(Skills);
            
            doc.Add ((Elementary));
            
            doc.Add(HS);
            
            doc.Add(College);
            
            doc.Add(Awards);
            
            doc.Add((Certification));
            
            doc.Add (Work);
            doc.Close();

        }
    }
}
