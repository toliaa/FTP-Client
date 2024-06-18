using FluentFTP;
using System;
using System.IO;
using System.Windows.Forms;

namespace FTPClient
{
    public partial class MainForm : Form
    {
        private FtpClient client; // Поле для зберігання клієнта FTP

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // Підключення до FTP-сервера
            client = new FtpClient(textBoxHost.Text, textBoxUsername.Text, textBoxPassword.Text);
            client.Connect();
            MessageBox.Show("Connected!");
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            // Завантаження файлу на FTP-сервер
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = openFileDialog.FileName;
                string remoteFilePath = textBoxRemotePath.Text + "/" + Path.GetFileName(localFilePath);
                client.UploadFile(localFilePath, remoteFilePath, FtpRemoteExists.Overwrite);
                MessageBox.Show("File uploaded!");
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            // Завантаження файлу з FTP-сервера
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string remoteFilePath = textBoxRemotePath.Text;
                string localFilePath = saveFileDialog.FileName;
                client.DownloadFile(localFilePath, remoteFilePath);
                MessageBox.Show("File downloaded!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Видалення файлу на FTP-сервері
            string remoteFilePath = textBoxRemotePath.Text;
            client.DeleteFile(remoteFilePath);
            MessageBox.Show("File deleted!");
        }

        private void buttonCreateDir_Click(object sender, EventArgs e)
        {
            // Створення каталогу на FTP-сервері
            string dirName = InputBox.Show("Create Directory", "Enter directory name:");
            if (!string.IsNullOrEmpty(dirName))
            {
                client.CreateDirectory(textBoxRemotePath.Text + "/" + dirName);
                MessageBox.Show("Directory created!");
            }
        }

        private void buttonDeleteDir_Click(object sender, EventArgs e)
        {
            // Видалення каталогу на FTP-сервері
            string dirPath = textBoxRemotePath.Text;
            client.DeleteDirectory(dirPath);
            MessageBox.Show("Directory deleted!");
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            // Перейменування файлу або каталогу на FTP-сервері
            string newName = InputBox.Show("Rename File/Directory", "Enter new name:");
            if (!string.IsNullOrEmpty(newName))
            {
                client.Rename(textBoxRemotePath.Text, Path.GetDirectoryName(textBoxRemotePath.Text) + "/" + newName);
                MessageBox.Show("Renamed!");
            }
        }

        private void buttonListFiles_Click(object sender, EventArgs e)
        {
            // Отримання списку файлів на FTP-сервері
            listView.Items.Clear();
            foreach (FtpListItem item in client.GetListing(textBoxRemotePath.Text))
            {
                ListViewItem listItem = new ListViewItem(item.Name);
                listItem.SubItems.Add(item.Size.ToString());
                listItem.SubItems.Add(item.Modified.ToString());
                listView.Items.Add(listItem);
            }
        }

        private void buttonAppe_Click(object sender, EventArgs e)
        {
            // Дописування до файлу на FTP-сервері
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = openFileDialog.FileName;
                string remoteFilePath = textBoxRemotePath.Text + "/" + Path.GetFileName(localFilePath);
                using (Stream fileStream = new FileStream(localFilePath, FileMode.Open, FileAccess.Read))
                using (Stream ftpStream = client.OpenAppend(remoteFilePath))
                {
                    fileStream.CopyTo(ftpStream);
                }
                MessageBox.Show("File appended!");
            }
        }

        private void buttonMdt_Click(object sender, EventArgs e)
        {
            // Отримання часу останньої модифікації файлу на FTP-сервері
            string remoteFilePath = textBoxRemotePath.Text;
            DateTime modifiedTime = client.GetModifiedTime(remoteFilePath);
            MessageBox.Show("Modified time: " + modifiedTime);
        }

        private void buttonSize_Click(object sender, EventArgs e)
        {
            // Отримання розміру файлу на FTP-сервері
            string remoteFilePath = textBoxRemotePath.Text;
            long fileSize = client.GetFileSize(remoteFilePath);
            MessageBox.Show("File size: " + fileSize);
        }

        private void buttonNlist_Click(object sender, EventArgs e)
        {
            // Отримання списку імен файлів на FTP-сервері
            listView.Items.Clear();
            foreach (string item in client.GetNameListing(textBoxRemotePath.Text))
            {
                listView.Items.Add(new ListViewItem(item));
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            // Отримання повного списку файлів і каталогів на FTP-сервері
            listView.Items.Clear();
            foreach (FtpListItem item in client.GetListing(textBoxRemotePath.Text))
            {
                ListViewItem listItem = new ListViewItem(item.Name);
                listItem.SubItems.Add(item.Size.ToString());
                listItem.SubItems.Add(item.Modified.ToString());
                listView.Items.Add(listItem);
            }
        }

        private void buttonStou_Click(object sender, EventArgs e)
        {
            // Завантаження файлу на FTP-сервер із унікальним іменем
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = saveFileDialog.FileName;
                string remoteFilePath = textBoxRemotePath.Text + "/" + Path.GetFileName(localFilePath);
                client.UploadFile(localFilePath, remoteFilePath, FtpRemoteExists.NoCheck, true);
                MessageBox.Show("File uploaded with unique name!");
            }
        }
    }
}
