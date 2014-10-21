using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DiffPdfDirectoryApplicationGUI
{
    public partial class DiffPdfDirGui : Form
    {
        String reportDir = @"";//path to  direcory where the comparison of the all the pdfs in pdfDir1 vs pdfDir2 will be stored
        String pdfDir1 = @"", pdfDir2 = @"";
        String pdf1Name = "", pdf2Name = "";

        public DiffPdfDirGui()
        {
            InitializeComponent();
        }

        private void Directory1Button_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Directory1Text.Text = folderBrowserDialog1.SelectedPath;
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath,"*",  SearchOption.AllDirectories);
            }
        }


        private void Directory1Text_TextChanged(object sender, EventArgs e) { }

        private void Directory2Button_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Directory2Text.Text = folderBrowserDialog1.SelectedPath;
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*", SearchOption.AllDirectories);
            }
        }

        private void Directory2Text_TextChanged(object sender, EventArgs e){}
        private void ComparisonOutputDirectoryText_TextChanged(object sender, EventArgs e){}

        //probably could add a check to see if passed in directory exists or not
        private void StartComparison_Click(object sender, EventArgs e)
        {
            if (Directory1Text.Text == "")
            {
                MessageBox.Show("you need to give an entry for Directory1");
                return;
            }
            else if (Directory2Text.Text == "")
            {
                MessageBox.Show("you need to give an entry for Directory2");
                return;
            }
            else if (ComparisonOutputDirectoryText.Text == "")
            {
                MessageBox.Show("you need to give an entry for the Comparison Output Directory");
                return;
            }
            pdfDir1 = @Directory1Text.Text;
            pdfDir2 = @Directory2Text.Text;
            reportDir = @ComparisonOutputDirectoryText.Text;
            reportDir += "\\";//will error out if path to report directory doesn't have a backslash at the end, should 
                              //add error checking to see if it already ends with a backslash
            String pdf1 = @"";//pdf1 is a single pdf from the directory from path1, pdf2 is a single pdf from the directory for path2
            String pdf2 = @"";
            string[] files = Directory.GetFiles(pdfDir1, "*", SearchOption.AllDirectories); //old pdfs from path1 to compare against new pdfs in files2
            string[] files2 = Directory.GetFiles(pdfDir2, "*", SearchOption.AllDirectories);

            if (files.Length == files2.Length)
            {
                
                ComparisonCount.Visible = true; // 0/3 of files compared , then 1/3 etc.
                progressBar1.Visible = true; // green bar that fills up equal to the percentage of files done being compared
                progressBar1.Maximum = files.Length; //if bar max size = 3 for the 3 files, it incremenets by 1/3 each time etc.
                progressBar1.Minimum = 0;
                ComparisonCount.Text = 0.ToString() + "/" + (files.Length).ToString();
                progressBar1.Value = 0;
                progressBar1.Step = 1;
                for (int i = 0; i < files.Length; i++)
                {
                    progressBar1.PerformStep();
                    pdf1Name = (files.GetValue(i)).ToString(); //finish adding pdfname to 
                    pdf2Name = (files2.GetValue(i)).ToString();
                    int lastSlash = pdf1Name.LastIndexOf("\\"), lastSlash2 = pdf2Name.LastIndexOf("\\");
                    //Console.WriteLine("last slash pdf1 location is " + lastSlash);
                    pdf1Name = pdf1Name.Substring(lastSlash + 1, pdf1Name.Length - lastSlash - 1);
                    pdf2Name = pdf2Name.Substring(lastSlash2 + 1, pdf2Name.Length - lastSlash2 - 1);
                    pdf1 = (files.GetValue(i)).ToString();
                    pdf1 = "\"" + pdf1 + "\"";          // slashes are added to the report, pdf1 and pdf2 arguments to get aroud 
                    //errors if any of the dirs in these contain a name with a space, if pdf1 was @"C:\dir name" it would cause error w/o slash fix
                    pdf2 = (files2.GetValue(i)).ToString();
                    pdf2 = "\"" + pdf2 + "\"";

                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(
                        /*"C:\\Program Files (x86)\\DiffPDFc\\diffpdfc",*/"diffpdfc", 
                         "-r " +  "\"" + reportDir + "report_" + pdf1Name + "_VS_" + pdf2Name + "\"" + " " + pdf1 + " " + pdf2);
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.CreateNoWindow = false;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    ComparisonCount.Text = (i+1).ToString() + "/" + (files.Length).ToString();
                    //progressBar1.PerformStep();
                }
                ComparisonCount.Text = "done";
            }
            else
            {
                Console.WriteLine("directory 1 has " + files.Length + " pdfs and directory 2 has " + files2.Length + " pdfs, they need to contain the same amount of pdfs!");
            }
            // Console.ReadLine();
            
        }

        private void ComparisonOutputDirectoryButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                ComparisonOutputDirectoryText.Text = folderBrowserDialog1.SelectedPath;
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*", SearchOption.AllDirectories);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e){}


    }
}
