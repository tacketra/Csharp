using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DiffPdfDirectoryApplication
{
    class DiffPdfDirectoryCompare
    {
        static void Main(string[] args)
        {
            // report =    "C:\Users\Ryan lenovo\Desktop\compareOutput"
            // path1 =     "C:\Users\Ryan lenovo\Desktop\compareDir"
            // path2 =     "C:\Users\Ryan lenovo\Desktop\compareDir2"
            // bat =       "C:\Users\Ryan lenovo\Desktop\diffBat.bat"

            //below, diffpdfc takes 3 arguments when run from cprompt, the report pdf(arg 1) made from comparing pdf1(arg2) and pdf2(arg3)
            //In this we pass directories where we want to save all the reports, the directory where all of the old pdfs are(pdf1) and the new(pdf2)
            Console.WriteLine("type the full path to where you want to save diffpdf reports of comparing dir1 and dir2, type it like C:\\Users\\Me\\repoDir");
            //String reportDir = @"";
            String reportDir = @Console.ReadLine();
            //reportDir = @"C:\Users\Ryan lenovo\Desktop\compareOutput";

            Console.WriteLine("type the full path to the directory containing the old pdfs, or a directory containing directories containing the old pdfs etc., type it like C:\\Users\\Me\\Desktop\\oldDir");
            String pdfDir1 = @Console.ReadLine();
            Console.WriteLine("type the full path to the directory containing the new pdfs, or a directory containing directories containing the new pdfs etc., type it like C:\\Users\\Me\\Desktop\\newDir");
            String pdfDir2 = @Console.ReadLine();
            //pdfDir2 = @"C:\Users\Ryan lenovo\Desktop\compareDir";
            Console.WriteLine("type the full path to the diffBat.bat, it runs diffPDFc, type it like C:\\Users\\Me\\Desktop\\diffBat.bat");
            String batDir = @Console.ReadLine();
            Console.WriteLine("starting comparisons, only pdfs that do not match will genereate a report in the reportDir specified");
            //String reportDir = @args[0], pdfDir1 = @args[1], pdfDir2 = @args[2], batDir = @args[3];
            reportDir += "\\";
            //String repy = Console.ReadLine();
            //Console.WriteLine(repy);
            //path1 = @"C:\Users\Ryan lenovo\Desktop\compareDir"; //the directory that contains all the pdfs to compare against the pdfs in path2's directory.
            //path1 = args[0];

            //for both of these paths the dir chosen could be a dir containing dirs with pdfs inside of them, as long as pdf names are in same order in path1 & 2
            //path2 = @"C:\Users\Ryan lenovo\Desktop\compareDir2";
            String pdf1 = @"";//pdf1 is a single pdf from the directory from path1, pdf2 is a signle pdf from the directory for path2
            String pdf2 = @"";
            String report = @"C:\Users\Ryan lenovo\Desktop\compareOutput\";//report dir
            String pdf1Name = "", pdf2Name = "";
           // Directory.SetCurrentDirectory(batDir);
            //string[] files = Directory.GetFiles(path, "*ProfileHandler.cs", SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(pdfDir1, "*", SearchOption.AllDirectories); //old pdfs from path1 to compare against new pdfs in files2
            string[] files2 = Directory.GetFiles(pdfDir2, "*", SearchOption.AllDirectories);
            //string[] dirs = Directory.GetDirectories(path1, "*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine("file: " + file);
            }
            foreach (string file in files2)
            {
                Console.WriteLine("file2: " + file);
            }

            if (files.Length == files2.Length)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    pdf1Name = (files.GetValue(i)).ToString(); //finish adding pdfname to 
                    pdf2Name = (files2.GetValue(i)).ToString(); 
                    int lastSlash = pdf1Name.LastIndexOf("\\"), lastSlash2 = pdf2Name.LastIndexOf("\\");
                    //Console.WriteLine("last slash pdf1 location is " + lastSlash);
                    pdf1Name = pdf1Name.Substring(lastSlash +1, pdf1Name.Length - lastSlash -1);
                    pdf2Name = pdf2Name.Substring(lastSlash2 + 1, pdf2Name.Length - lastSlash2 - 1);
                    Console.WriteLine("pdf1Nme is " + pdf1Name + " and pdf2 name is : " + pdf2Name);
                    //haven't tested yet!

                    
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    //startInfo.WorkingDirectory = batDir ;//bat directory

                    //pdf1 = @"C:\Users\Ryan lenovo\Desktop\compareDir\heyFirst\dir1\hey1.pdf";
                    pdf1 = (files.GetValue(i)).ToString();
                    pdf1 = "\"" + pdf1 + "\"";          // slashes are added to the report, pdf1 and pdf2 arguments to get aroud 

                    //errors if any of the dirs in these contain a name with a space, if pdf1 was @"C:\dir name" it would cause error w/o slash fix

                   // pdf2 = @"C:\Users\Ryan lenovo\Desktop\compareDir2\heyNew\dir3\hey3.pdf";
                    pdf2 = (files2.GetValue(i)).ToString();
                    pdf2 = "\"" + pdf2 + "\"";

                    //report = @"C:\Users\Ryan lenovo\Desktop\compareOutput\ReportForwasup.pdf";
                    //report = "\"" + report + "\"";
                    startInfo.FileName = batDir;
                    //process.Verb = "diffpdfc";
                    startInfo.Arguments = "\"" + reportDir + "report_" + pdf1Name + "_VS_" + pdf2Name + "\"" +" " + pdf1 + " " + pdf2;//add slashes to get around having spaces in a directory
                    //process.WindowStyle = ProcessWindowStyle.Hidden;//

                    // System.Diagnostics.Process.Start("CMD.exe", argum);
                    //System.Diagnostics.Process.Start("CMD.exe", @"C:\Users\Ryan lenovo\Desktop\ech.bat");
                    process.StartInfo = startInfo;
                    bool startPass = process.Start();
                    Console.WriteLine("did start pass: " + startPass);
                    //string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    //process.StandardInput.Write(@"diffpdfc -r compareOutput/reportPeep.pdf compareDir/heyFirst/dir1/hey1.pdf compareDir2/heyNew/dir2/hey2.pdf");
                    //process.StandardInput.Write(temp);
                    //System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                    // process.WaitForExit();

                    //Console.Read();
                     
                }
            }
            else
            {
                Console.WriteLine("directory 1 has " + files.Length + " pdfs and directory 2 has " + files2.Length + " pdfs, they need to contain the same amount of pdfs!" );
            }
           // Console.ReadLine();
            
        }

        
    }
}

