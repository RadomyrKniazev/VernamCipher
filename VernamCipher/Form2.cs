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

namespace VernamCipher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        string encrypt;
        string key;

        private void CheckFilesButton_Click(object sender, EventArgs e)
        {
            encrypt = File.ReadAllText("encrypt.txt");
            key = File.ReadAllText("key.txt");
            if ((encrypt != "" && key != "") && (encrypt.Length == key.Length))
            {
                MessageBox.Show("You may decrypt", "Check files");
                DecryptButton.Enabled = true;
            }
            else if (encrypt == "" || key == "")
            {
                MessageBox.Show("File with cipher or key is empty", "Error");
            }
            else
            {
                MessageBox.Show("Key length is not equal cipher length", "Error");
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
             encrypt = File.ReadAllText("encrypt.txt");
             key = File.ReadAllText("key.txt");

             encrypt.ToCharArray();
             key.ToCharArray();

             StringBuilder builder = new StringBuilder();
             for (int i = 0; i < encrypt.Length; i++)
             {
                 builder.Append((char)(encrypt[i] ^ key[i]));
             }
             string decrypt = builder.ToString();
             
             File.WriteAllText("decrypt.txt", decrypt);
             File.WriteAllText("key.txt", string.Empty);
             DecryptButton.Enabled = false;
             OpenDecryptButton.Enabled = true;
        }

        private void OpenDecryptButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("decrypt.txt");
        }

        private void GoToEncryptButton_Click(object sender, EventArgs e)
        {
            Form1 encryptForm = new Form1();
            encryptForm.Show();
            Hide();
        }

        private void OpenEncryptButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("encrypt.txt");
        }

        private void OpenKeyButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("key.txt");
        }

        public void DeleteAllDataButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText("key.txt", string.Empty);
            File.WriteAllText("encrypt.txt", string.Empty);
            File.WriteAllText("decrypt.txt", string.Empty);
            MessageBox.Show("All data were successfully deleted!", "Delete all data");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
             if (File.ReadAllText("encrypt.txt") != "" || File.ReadAllText("key.txt") != "" || File.ReadAllText("decrypt.txt") != "")
             {
                 DialogResult dr = MessageBox.Show("File`s data are not deleted. Delete them?", "Exit", MessageBoxButtons.YesNo);
                 if(dr == DialogResult.Yes)
                 {
                    DeleteAllDataButton.PerformClick();
                    Application.Exit();
                 }
                 else if(dr == DialogResult.No)
                 {
                    Application.Exit();
                 }
             }
            else Application.Exit();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Шифр Вернама (інша назва: англ. one-time pad - схема одноразових блокнотів) — у криптографії система симетричного шифрування, " +
                            "винайдена в 1917 році співробітниками AT&T Мейджором Джозефом Моборном і Гільбертом Вернамом. Шифр Вернама є єдиною системою " +
                            "шифрування, для якої доведена абсолютна криптографічна стійкість. Для утворення шифртексту повідомлення об'єднується операцією " +
                            "XOR з ключем (названим одноразовим блокнотом або шифроблокнотом)." +
                            "При цьому ключ повинен мати три критично важливі властивості:\n" +
                                "1.Бути справді випадковим;\n" +
                                "2.Збігатися за розміром з заданим відкритим текстом;\n" +
                                "3.Застосовуватися тільки один раз.\n" +
                             "Vername's code (another name: one-time pad) is a system of symmetric encryption in cryptography," +
                             "Invented in 1917 by AT & T Magazine by Joseph Moborn and Gilbert Vernam. Vernam's code is the only system" +
                             "encryption, for which absolute cryptographic stability is proved. To create a ciphertext, the message is combined with an operation" +
                             "XOR with a key (called a disposable notebook or cipherblock)." +
                             "The key must have three critical properties: \n" +
                             "1.Really random; \n" +
                             "2.Step in size with given open text; \n" +
                             "3.Used only once. \n", "About");

        }

        private void InstructionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Шифрувати та розшифровувати можна тільки текст англійської мови!\n" +
                            "Щоб розшифрувати текст, потрібно:\n" +
                                "1) відкрити файл \"encrypt.txt\", натиснувши на кнопку \"open encrypt file\" і ввести шифр;\n" +
                                "2) відкрити файл \"key.txt\", натиснувши на кнопку \"open key file\" і ввести ключ;\n" +
                                "3) натиснути на кнопку \"Check files\";\n" +
                                "4) натиснути на кнопку \"Decrypt\";\n" +
                             "Відкрити зашифрований файл можна, натиснувши на кнопку\"Open decrypt\"\n" +
                             "При натисканні на кнопку \"Delete all data\", ви видаляєте усі дані, крім тексту, який зашифровуєте\n" +
                             "Кнопка \"About\" дозволить вам дізнатись коротко про шифр Вернама.\n " +
                             "Щоб закрити програму, натисніть на кнопку \"Exit\"\n " +
                             "To decrypt text, you need:\n" +
                                "1) open file \"encrypt\" and enter encrypt;\n" +
                                "2) open file \"key.txt\" and enter key;\n" +
                                "3) press the button \"Check files\"\n" +
                                "4) press the button \"Decrypt\"\n" +
                             "To open the decrypted file, press the button\"Open decrypt\"\n" +
                             "Clicked the button \"Delete all data\" you delete all data except for the text that encrypt" +
                             "Clicked the button \"About\" can tell about Vernam Cipher\n" +
                             "Click the button \"Exit\" to exit", "Instruction");
        }
    }
}
