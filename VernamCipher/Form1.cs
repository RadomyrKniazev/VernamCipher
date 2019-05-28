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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if(File.Exists("encrypt.txt") == false)
            using (myStream = File.Create("encrypt.txt"))
            {
                myStream.Close();
            }
            if (File.Exists("decrypt.txt") == false)
            using (myStream = File.Create("decrypt.txt"))
            {
                myStream.Close();
            }
            if (File.Exists("key.txt") == false)
            using (myStream = File.Create("key.txt"))
            {
                myStream.Close();
            }
        }
        public string fileName;
        string text;
        string key;
        Stream myStream;

        public void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        public void SelectFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt) | *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                text = File.ReadAllText(fileName);
            }
            if (text == "")
            {
                MessageBox.Show("File is empty", "Error");
            }   
        }

        private void GenerateKeyButton_Click(object sender, EventArgs e)
        {
            text = File.ReadAllText(fileName);
            char[] key = new char[text.Length];
            Random random = new Random();

            for (int i = 0; i < text.Length; i++)
            {
                key[i] = (char)(random.Next(0x0020, 0x007E)); //0x0020, 0x007E - unicode table
            }
            string strKey = new string(key);
            File.WriteAllText("key.txt", strKey);            
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            text = File.ReadAllText(fileName);
            key = File.ReadAllText("key.txt");
            
            if ((text != "" && key != "") && (text.Length == key.Length))
            {
                key.ToCharArray();
                text.ToCharArray();
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < text.Length; i++)
                {
                    builder.Append((char)(text[i] ^ key[i]));
                }
                string encrypt = builder.ToString();
                File.WriteAllText("encrypt.txt", encrypt);
            }
            else if(text == "" || key == "")
            {
                MessageBox.Show("File with text or key empty", "Error");
            }
            else MessageBox.Show("Key length is not equal encrypt length", "Error");

        }

        private void OpenEncryptButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("encrypt.txt");
        }

        private void OpenKeyButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("key.txt");
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
                                "3.Застосовуватися тільки один раз.", "About");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (File.ReadAllText("encrypt.txt") != "" || File.ReadAllText("key.txt") != "" || File.ReadAllText("decrypt.txt") != "")
            {
                DialogResult dr = MessageBox.Show("File`s data are not deleted. Delete them?", "Exit", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    DeleteAllDataButton.PerformClick();
                    Application.Exit();
                }
                else if (dr == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else Application.Exit();
        }

        private void InstructionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Шифрувати та розшифровувати можна тільки текст англійської мови!\n" +
                "Щоб зашифрувати текст, потрібно:\n" +
                                "1) обрати файл натиснувши на кнопку \"Select a file\";\n" +
                                "2) натиснути на кнопку \"Encrypt\";\n" +
                             "Відкрити зашифрований файл можна, натиснувши на кнопку\"Open encrypt\"\n" +
                             "При натисканні на кнопку \"Delete all files\", ви видаляєте усі файли, крім тексту, який зашифровуєте\n" +
                             "Кнопка \"About\" дозволить вам дізнатись коротко про шифр Вернама.\n " +
                             "Щоб закрити програму, натисніть на кнопку \"Exit\"\n " +
                             "You can encrypt only English text" +
                             "To encrypt text, you need:\n" +
                                "1) select a file, which wants to encrypt;\n" +
                                "2) press the button\"Encrypt\";\n" +
                             "To open the encrypted file, press the button\"Open encrypt\"\n" +
                             "Clicked the button \"Delete all files\" you delete all files except for the text that encrypt" +
                             "Clicked the button \"About\" can tell about Vernam Cipher\n" +
                             "Click the button \"Exit\" to exit", "Instruction");

        }

        private void GoToDecryptButton_Click(object sender, EventArgs e)
        {            
            Form2 decryptForm = new Form2();
            decryptForm.Show();
            Hide();
        }

        private void DeleteAllDataButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText("key.txt", string.Empty);
            File.WriteAllText("encrypt.txt", string.Empty);
            File.WriteAllText("decrypt.txt", string.Empty);
            MessageBox.Show("All data were successfully deleted!", "Delete all data");
        }

    }
}
