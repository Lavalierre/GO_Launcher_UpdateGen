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
using System.Security.Cryptography;
using System.Xml;

namespace GO_Launcher_UpdateGen
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void selectFilePathBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = selectFilesPath.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(selectFilesPath.SelectedPath))
            {
                selectFilePathInput.Text = selectFilesPath.SelectedPath;
            }
        }

        private void selectOutputPathBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = selectOutputPath.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(selectOutputPath.SelectedPath))
            {
                selectOutputPathInput.Text = selectOutputPath.SelectedPath;
            }
        }

        public static List<String> GetAllFiles(string directory)
        {
            return Directory.GetFiles(directory, "*", SearchOption.AllDirectories).ToList();
        }

        public static string GetFileMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void startUpdateGenButton_Click(object sender, EventArgs e)
        {
            if (selectFilesPath.SelectedPath.Length != 0 && selectOutputPath.SelectedPath.Length != 0)
            {
                resultString.ForeColor = Color.FromArgb(255, 0, 0, 0);
                // Creating files directory
                if (!Directory.Exists(selectOutputPath.SelectedPath + "/files/"))
                    Directory.CreateDirectory(selectOutputPath.SelectedPath + "/files/");

                // Creating XML document
                XmlDocument doc         = new XmlDocument();
                XmlElement rootElement  = (XmlElement)doc.AppendChild(doc.CreateElement("file_list"));

                // Processing file list
                var fileList = GetAllFiles(selectFilesPath.SelectedPath);
                foreach(string path in fileList)
                {
                    resultString.Text = "Processing " + Path.GetFileName(path) + "...";

                    XmlElement fileElement = (XmlElement)rootElement.AppendChild(doc.CreateElement("file"));

                    // Generating MD5
                    string md5 = GetFileMD5(path);
                    fileElement.AppendChild(doc.CreateElement("md5")).InnerText         = md5;

                    // Generating file name
                    fileElement.AppendChild(doc.CreateElement("fileName")).InnerText    = Path.GetFileName(path);

                    // Generating file url
                    fileElement.AppendChild(doc.CreateElement("fileUrl")).InnerText     = Path.GetFileName(path);

                    // Generating file path
                    Uri originalPathUri = new Uri(selectFilesPath.SelectedPath + "\\");
                    Uri filePathUri     = new Uri(Path.GetDirectoryName(path) + "/");
                    Uri diff            = originalPathUri.MakeRelativeUri(filePathUri);
                    if (diff.OriginalString != "")
                        fileElement.AppendChild(doc.CreateElement("filePath")).InnerText    = diff.OriginalString;
                    else
                        fileElement.AppendChild(doc.CreateElement("filePath")).InnerText    = "/";

                    File.Copy(path, selectOutputPath.SelectedPath + "\\files\\" + Path.GetFileName(path), true);
                }

                resultString.ForeColor  = Color.FromArgb(255, 0, 255, 0);
                resultString.Text       = "Update successfully generated!";
                doc.Save(selectOutputPath.SelectedPath + "/files.xml");

                // Generating version.xml
                if (versionInput.Text.Length != 0)
                {
                    doc = new XmlDocument();
                    rootElement = (XmlElement)doc.AppendChild(doc.CreateElement("info"));
                    rootElement.AppendChild(doc.CreateElement("version")).InnerText = versionInput.Text;
                    doc.Save(selectOutputPath.SelectedPath + "/version.xml");
                }
            }
        }
    }
}
