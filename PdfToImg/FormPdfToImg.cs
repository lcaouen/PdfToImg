using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PdfToImg
{
    public partial class FormPdfToImg : Form
    {
        public FormPdfToImg()
        {
            InitializeComponent();
        }

        private void labelSource_Click(object sender, EventArgs e)
        {

        }

        private void buttonSrc_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSrc.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonDst_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDst.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            buttonSrc.Enabled = false;
            buttonDst.Enabled = false;
            buttonStart.Enabled = false;
            textBoxSrc.Enabled = false;
            textBoxDst.Enabled = false;

            try
            {
                string[] lstPDF = Directory.GetFiles(textBoxSrc.Text, "*.pdf", SearchOption.AllDirectories);
                progressBar.Maximum = lstPDF.Length;
                for (int iPDF = 0; iPDF < lstPDF.Length; iPDF++)
                {
                    string strFileName = lstPDF[iPDF];
                    FileInfo fi = new FileInfo(strFileName);
                    string strDirectoryName = fi.Name;
                    strDirectoryName = textBoxDst.Text + "\\" + strDirectoryName.Replace(".pdf", "");
                    if (!Directory.Exists(strDirectoryName)) Directory.CreateDirectory(strDirectoryName);

                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "pdfimages.EXE";
                    startInfo.Arguments = "-j \"" + strFileName + "\" \"" + strDirectoryName + "\\img\"";
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    Process oProcess = Process.Start(startInfo);
                    oProcess.WaitForExit();
                    progressBar.Value = iPDF + 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            buttonSrc.Enabled = true;
            buttonDst.Enabled = true;
            buttonStart.Enabled = true;
            textBoxSrc.Enabled = true;
            textBoxDst.Enabled = true;

        }
    }
}
