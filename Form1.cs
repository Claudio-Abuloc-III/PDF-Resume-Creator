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
        }
    }
}
