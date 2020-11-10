using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SearchForlder
{
    public partial class SearchFolder : Form
    {
        List<string> ListFiles = new List<string>();
        public SearchFolder()
        {
            InitializeComponent();
        }
        private void FloderButton_Click_1(object sender, EventArgs e)
        {
            ListFiles.Clear();
            using (var FBD = new FolderBrowserDialog())
            {
                if (FBD.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.Url = new Uri(FBD.SelectedPath);
                    TextPath.Text = FBD.SelectedPath.Replace("\\","/");
                    foreach (string Item in Directory.GetFiles(FBD.SelectedPath))
                    {
                        imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(Item));
                        FileInfo info = new FileInfo(Item);
                        ListFiles.Add(info.FullName);
                    }
                }
            }
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (TextPath.Text.Length > 1)
            {
                ButtonSearch.CanSelect.Equals(true);
                Process p = new Process();
                p.StartInfo.FileName = @"DuplicateFolderFinder.exe";
                p.StartInfo.Arguments = @"--dir=" + TextPath.Text.Replace("file:///", "");
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.Start();
                p.WaitForExit();
                var TextFromJson = File.ReadAllText(@"data.json".Replace("\\", "/"));
                var duplicate = JsonConvert.DeserializeObject<List<Duplicate>>(TextFromJson);
                int counter = 0;
                string size_text = string.Empty;
                int counterColor = 0;
                
                TextFind.Items.Clear();
                foreach (Duplicate item in duplicate)
                {
                    foreach (string dir in item.folders)
                    {
                        TextFind.Items.Add(dir);
                        if (item.size < 1024)
                            size_text = item.size.ToString() + " байт";
                        else if (item.size < Math.Pow(1024, 2))
                            size_text = Math.Round((double)item.size / 1024, 2).ToString() + " КБ";
                        else if (item.size < Math.Pow(1024, 3))
                            size_text = Math.Round(item.size / Math.Pow(1024, 2), 2).ToString() + " МБ";
                        else 
                            size_text = Math.Round(item.size / Math.Pow(1024, 3), 2).ToString() + " ГБ";
                        TextFind.Items[counter].SubItems.Add(size_text);
                        TextFind.Items[counter].Tag = counterColor;
                        if (counterColor % 2 == 0)
                        {
                            TextFind.Items[counter].BackColor = Color.White;
                        }
                        else
                        {
                            TextFind.Items[counter].BackColor = Color.Wheat;
                        }
                        counter++;
                    }
                    counterColor++;
                }
            }
            else
            {
                ButtonSearch.CanSelect.Equals(false);
            }
        }
        private void OpenJsonButton_Click(object sender, EventArgs e)
        {
            ListFiles.Clear();
            using (var OFD = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "JSON files (*.json)|*.json",
                Title = "Open text file"
            })
            {

                if (OFD.ShowDialog() == DialogResult.OK)
                {

                    var TextFromJson = File.ReadAllText(OFD.FileName);
                    var duplicate = JsonConvert.DeserializeObject<List<Duplicate>>(TextFromJson);
                    int counter = 0;
                    string size_text = string.Empty;
                    int counterColor = 0;
                    TextFind.Items.Clear();
                    foreach (Duplicate item in duplicate)
                    {
                        foreach (string dir in item.folders)
                        {
                            TextFind.Items.Add(dir);
                            if (item.size < 1024)
                                size_text = item.size.ToString() + " байт";
                            else if (item.size < Math.Pow(1024, 2))
                                size_text = Math.Round((double)item.size / 1024, 2).ToString() + " КБ";
                            else if (item.size < Math.Pow(1024, 3))
                                size_text = Math.Round(item.size / Math.Pow(1024, 2), 2).ToString() + " МБ";
                            else
                                size_text = Math.Round(item.size / Math.Pow(1024, 3), 2).ToString() + " ГБ";
                            TextFind.Items[counter].SubItems.Add(size_text);
                            TextFind.Items[counter].Tag = counterColor;
                            if (counterColor % 2 == 0)
                            {
                                TextFind.Items[counter].BackColor = Color.White;
                            }
                            else
                            {
                                TextFind.Items[counter].BackColor = Color.Wheat;
                            }
                            counter++;
                        }
                        counterColor++;
                    }
                }
            }
        }
        private void OpenDuplicateFolder_Click(object sender, EventArgs e)
        {
            if (TextFind.Items.Count != 0)
            {
                OpenDuplicateFolder.CanSelect.Equals(true);
                ListFiles.Clear();
                var name = TextFind.SelectedItems[0].Text;
                if (Directory.Exists(name))
                {
                    webBrowser1.Url = new Uri(name);
                    foreach (string Item in Directory.GetFiles(name))
                    {
                        imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(Item));
                        FileInfo info = new FileInfo(Item);
                        ListFiles.Add(info.FullName);
                    }
                }
                else
                {
                    MessageBox.Show("Path not found");
                }
            }
            else
            {
                OpenDuplicateFolder.CanSelect.Equals(false);
            }
        }
        private void SaveText_Click(object sender, EventArgs e)
        {
            if (TextFind.Items.Count != 0)
            {
                OpenDuplicateFolder.CanSelect.Equals(true);
                ListFiles.Clear();
                var name = TextFind.SelectedItems[0].Text;
                Clipboard.SetText(name);
                MessageBox.Show("Путь скопирован");
            }
            else
            {
                OpenDuplicateFolder.CanSelect.Equals(false);
            }
        }
        private void TextPath_KeyDown(object sender, KeyEventArgs e)
        {
            ListFiles.Clear();
            if (e.KeyCode == Keys.Enter)
            {
                if (Directory.Exists(TextPath.Text))
                {
                    webBrowser1.Url = new Uri(TextPath.Text);
                    foreach (string Item in Directory.GetFiles(TextPath.Text))
                    {
                        imageList1.Images.Add(Icon.ExtractAssociatedIcon(Item));
                        FileInfo info = new FileInfo(Item);
                        ListFiles.Add(info.FullName);
                    }
                }
                else
                {
                    MessageBox.Show("Path not found");
                }
            }
        }
        private void OpenTextFindFolderWithWindows_Click(object sender, EventArgs e)
        {
            if (TextFind.Items.Count != 0)
            {
                OpenDuplicateFolder.CanSelect.Equals(true);
                ListFiles.Clear();
                var name = TextFind.SelectedItems[0].Text;
                Process.Start(name);
            }
            else
            {
                OpenDuplicateFolder.CanSelect.Equals(false);
            }
        }
        private void DeleteDuplicateFolder_Click(object sender, EventArgs e)
        {
            if (TextFind.Items.Count != 0)
            {
                OpenDuplicateFolder.CanSelect.Equals(true);
                for (int i = TextFind.CheckedItems.Count - 1; i >= 0; i--)
                {
                    FileSystem.DeleteDirectory(TextFind.CheckedItems[i].Text, UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
                    TextFind.Items.Remove(TextFind.CheckedItems[i]);
                }
            }
            else
            {
                OpenDuplicateFolder.CanSelect.Equals(false);
            }
        }
        /*private void TextFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListFiles.Clear();
            if (TextFind.SelectedItems.Count > 0)
            {
                TextPath.Text = TextFind.SelectedItems[0].Text;
                webBrowser1.Url = new Uri(TextPath.Text);
                foreach (string Item in Directory.GetFiles(TextPath.Text))
                {
                    imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(Item));
                    FileInfo info = new FileInfo(Item);
                    ListFiles.Add(info.FullName);
                }
            }
        }*/
        private void TextFind_DoubleClick(object sender, EventArgs e)
        {
            ListFiles.Clear();
            if (TextFind.SelectedItems.Count > 0)
            {
                ListFiles.Clear();
                var name = TextFind.SelectedItems[0].Text;
                Process.Start(name);
            }
        }
        private void Forward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }
        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            TextPath.Text = webBrowser1.Url.ToString().Replace("file:///", "");
        }
    }
}
