using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCR_Garage_Management
{
    public partial class frm_About : Form
    {
        public frm_About()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "mailto:phillipgibbings@hotmail.com?subject=Garage Management Software";
            proc.Start();
        }

        private void frm_About_Load(object sender, EventArgs e)
        {
            var assemblyFullName = Assembly.GetExecutingAssembly().FullName;
            var assemblyName = assemblyFullName.Split(',')[0].Split('=')[0];
            var version = assemblyFullName.Split(',')[1].Split('=')[1];
            string Revision = @".\About\About.txt";
            
            lblAssembllyName.Text = "Assembly Name: " + assemblyName;
            lblAssemblyVersion.Text = "Assembly Version: " + version;

            if(File.Exists(Revision))
            {
                rtbRevision.LoadFile(Revision, RichTextBoxStreamType.PlainText);
            }
            else
            {
                rtbRevision.Text = "Unable to locate About File";
            }
        }
    }
}
