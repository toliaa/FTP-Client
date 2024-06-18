using System;
using System.IO;
using System.Windows.Forms;

namespace FTPClient
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        // Метод, який виконується при натисканні кнопки "Save"
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Збереження налаштувань у файл
            using (var writer = new StreamWriter("settings.txt"))
            {
                writer.WriteLine($"Host={textBoxHost.Text}"); // Запис хоста
                writer.WriteLine($"Username={textBoxUsername.Text}"); // Запис імені користувача
                writer.WriteLine($"Password={textBoxPassword.Text}"); // Запис пароля
            }
            MessageBox.Show("Settings saved successfully."); // Повідомлення про успішне збереження
        }

        // Метод, який виконується при завантаженні форми
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Завантаження налаштувань з файлу, якщо файл існує
            if (File.Exists("settings.txt"))
            {
                var lines = File.ReadAllLines("settings.txt"); // Зчитування всіх рядків з файлу
                foreach (var line in lines)
                {
                    var parts = line.Split('='); // Розділення рядка на частини за допомогою роздільника '='
                    if (parts.Length == 2)
                    {
                        switch (parts[0])
                        {
                            case "Host":
                                textBoxHost.Text = parts[1]; // Встановлення тексту у поле хоста
                                break;
                            case "Username":
                                textBoxUsername.Text = parts[1]; // Встановлення тексту у поле імені користувача
                                break;
                            case "Password":
                                textBoxPassword.Text = parts[1]; // Встановлення тексту у поле пароля
                                break;
                        }
                    }
                }
            }
        }
    }
}
