using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using MetroFramework.Forms;
using MetroFramework.Properties;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Threading;
using MetroFramework.Controls;

namespace HashCreater
{
    public partial class hashGeneratorForm : MetroForm
    {

        public List<List <string>> allHashs = new List<List <string>>();

        public List<string> countFilesList = new List<string>();

        public hashGeneratorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager;
        }

        private void selectFolderButton_Changed(object sender, EventArgs e)
        {
            countFilesList.Clear();
            countFiles(modPath.Text);
            filesFound.Text = countFilesList.Count.ToString();
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            using (var fbd = browseFolderMods)
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    modPath.Text = fbd.SelectedPath;

                    countFilesList.Clear();
                    countFiles(modPath.Text);
                    filesFound.Text = "Files found: " + countFilesList.Count.ToString();
                }
            }
        }

        private void modPath_Click(object sender, EventArgs e)
        {

        }

        public class TextBoxWriter : TextWriter
        {
            MetroTextBox _output = null;

            public TextBoxWriter(MetroTextBox output)
            {
                _output = output;
            }

            public override void Write(char value)
            {
                base.Write(value);
                _output.AppendText(value.ToString());
            }

            public override Encoding Encoding
            {
                get { return System.Text.Encoding.UTF8; }
            }
        }

        private void versionTextBot_Click(object sender, EventArgs e)
        {
            if (versionTextBot.Text == "Enter version")
            {
                versionTextBot.Text = "";
            };
        }

        private void versionTextBot_TextChanged(object sender, EventArgs e)
        {

        }

        private void generateHashes_Click(object sender, EventArgs e)
        {
            getHashsOfAllFiles(modPath.Text);
            allHashs.Clear();
        }

        private string getHash(string file)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(file))
                {
                    byte[] bytes = md5.ComputeHash(stream);
                    StringBuilder result = new StringBuilder(bytes.Length * 2);
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        result.Append(bytes[i].ToString(true ? "X2" : "x2"));
                    }
                    return result.ToString();
                }
            }
        }

        public void countFiles(String path)
        {
            try
            {
                foreach (string f in Directory.GetFiles(path))
                {
                    countFilesList.Add(f);

                }
                foreach (string d in Directory.GetDirectories(path))
                {
                    countFiles(d);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void getHashsOfAllFiles(String path)
        {
           try
            {
                foreach (string f in Directory.GetFiles(path))
                {
                    List<String> add = new List<String>();
                    add.Add(f);
                    add.Add(getHash(f).ToLower());
                    allHashs.Add(add);

                    Console.SetOut(new TextBoxWriter(ausgabe));
                    Console.WriteLine(f);
                    
                }
                foreach (string d in Directory.GetDirectories(path))
                {
                    getHashsOfAllFiles(d);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
