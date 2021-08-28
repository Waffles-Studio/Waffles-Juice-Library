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
using PdfiumViewer;

namespace Toshokan_Project_Beta
{
    public partial class VPdf : Form
    {
        PdfiumViewer.PdfViewer pdf;
        public VPdf()
        {
            InitializeComponent();
            pdf = new PdfViewer();
            this.Controls.Add(pdf);
            pdf.Size = new Size(612, 710);
            most();
        }

        public void most()
        {
            openfile(UserData.Path);
        }

        public void openfile(string filepath)
        {
            byte[] bytes = File.ReadAllBytes(filepath);
            var stream = new MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;
        }


    }
}
