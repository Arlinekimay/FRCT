using FRCT.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRCT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random Run = new Random();
           this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            List<Produit> produit = new List<Produit>
            {
                new Produit("001","telephone",3,90000),
                new Produit("as5","ecran",1,5000),
                new Produit ("qsd4","canape",5,17000),
                new Produit ("srt2","ventilateur",2,14000),


            };
            List<Client> client = new List<Client>()
            {
                new Client("kama","marie","falone@yooh.com",55427798),

            };

           
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", produit));
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2",client));
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();

        }
    }
}
