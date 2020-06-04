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
using System.Globalization;

namespace main_title_editor
{
    public partial class Form1 : Form
    {
        public string childName;
        public string background;
        public byte[] childNameByte;
        public byte[] backgroundByte;
        public float[] val = new float[4];

        public int childNamePos, backgroundPos, childNameLength, backgroundLength;
        public int[] valPos = new int[4];
        public byte[] bytes;
        public byte[] newBytes;
        public byte[] pattern1 = { 0x61, 0x73, 0x73, 0x65, 0x74, 0x5c, 0x63, 0x68, 0x61, 0x72};
        public byte[] pattern2 = { 0x73, 0x74, 0x61, 0x67, 0x65, 0x5c };
        public byte[] pattern3 = { 0x6c, 0x69, 0x76, 0x65, 0x32, 0x64, 0x5f };
        public List<int> position;
        public bool loaded = false;
        public byte[] newChildName, newBackground;
        public float[] newVal = new float[4];
        public int newChildNameLength, newBackgroundLength;

        public byte[][] substBytes = new byte[3][];
        public int[] length = new int[3];
        public int[] newLength = new int[3];
        public int[] pos = new int[4];
        public int[] perm = new int [4];

        public Form1()
        {
            InitializeComponent();
        }

        private string ByteToString(byte[] strByte)
        {
            string str = Encoding.Default.GetString(strByte);
            return str;
        }

        private byte[] StringToByte(string str)
        {
            byte[] strByte = Encoding.UTF8.GetBytes(str);
            return strByte;
        }

        private void printTextBox()
        {
            childNameTextBox.Text = childName;
            backgroundTextBox.Text = background;
            aTextBox.Text = val[0].ToString();
            bTextBox.Text = val[1].ToString();
            cTextBox.Text = val[2].ToString();
            dTextBox.Text = val[3].ToString();
        }

        private bool fileParser(string filename)
        {
            var childNameBytes = new byte[0x10];
            var backgroundBytes = new byte[0x20];
            var pos = new int[3];
            
            getBytes(filename);
            if ((pos[0] = searchBytePattern(pattern1, bytes)) == 0)
                return false;
            if ((pos[1] = searchBytePattern(pattern2, bytes)) == 0)
                return false;
            if ((pos[2] = searchBytePattern(pattern3, bytes)) == 0)
                return false;

            childNamePos = pos[0] + 16;
            backgroundPos = pos[1] + 15;
            valPos[0] = pos[2] + 0x23;
            valPos[1] = valPos[0] + 0x4;
            valPos[2] = valPos[1] + 0x8;
            valPos[3] = valPos[2] + 0x4;

            Array.Copy(bytes, childNamePos, childNameBytes, 0, 0x10);
            Array.Copy(bytes, backgroundPos, backgroundBytes, 0, 0x20);

            childName = ByteToString(childNameBytes).Split('\\')[0];
            background = ByteToString(backgroundBytes).Split('\\')[0];

            childNameLength = childName.Length;
            backgroundLength = background.Length;

            Array.Resize(ref childNameByte, childNameLength);
            Array.Resize(ref backgroundByte, backgroundLength);
            childNameByte = StringToByte(childName);
            backgroundByte = StringToByte(background);

            for (int i = 0; i < 4; i++)
                val[i] = BitConverter.ToSingle(bytes, valPos[i]);


            printTextBox();
            return true;
        }

        static public int searchBytePattern(byte[] pattern, byte[] bytes)
        {
            for (int i = 0; i < bytes.Length; i++)
            {
                if (pattern[0] == bytes[i] && bytes.Length - i >= pattern.Length)
                {
                    bool ismatch = true;
                    for (int j = 1; j < pattern.Length && ismatch == true; j++)
                    {
                        if (bytes[i + j] != pattern[j])
                            ismatch = false;
                    }
                    if (ismatch)
                        return i;
                }
            }
            return 0;
        }

        public void getBytes(string filename)
        {
            bytes = File.ReadAllBytes(filename);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void ErrorOpenFile()
        {
            MessageBox.Show($"Cannot read child info!\nPlease check your file.\n");
        }

        private void openFileToolStripMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open file...";
            openFile.Filter = "mvd files (.mvd)|*.mvd|All files (*.*)|(*.*)";
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFile.FileName))
                {
                    var size = new FileInfo(openFile.FileName).Length;
                    if (size > 0x80000)
                        ErrorOpenFile();

                    if (!fileParser(openFile.FileName))
                        ErrorOpenFile();
                    else
                        loaded = true;
                }
                else
                    ErrorOpenFile();
            }
        }

        private void openTab_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void ErrorNotLoaded()
        {
            MessageBox.Show($"You should load main_title_****.mvd file first!\n");
        }

        private void ErrorNotFloat()
        {
            MessageBox.Show($"Positions and scales should be a number.\nTry again.\n");
        }

        private void permutation()
        {
            int[] prio = { 0, 0, 0 };

            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    if (pos[i] < pos[j])
                        prio[j] += 1;
                    else prio[i] += 1;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (prio[j] == i)
                        perm[i] = j;
                }
            }
            
            perm[3] = 3;
        }

        private int copyBytes()
        {
            int newPos = 0, newSize = pos[3];

            for (int i = 0; i < 3; i++)
            {
                newSize += newLength[i];
                newSize -= length[i];
            }
            Array.Resize(ref newBytes, newSize);

            Array.Copy(bytes, 0, newBytes, newPos, pos[perm[0]]);
            newPos += pos[perm[0]];
            for (int i = 0; i < 3; i++)
            {
                Array.Copy(substBytes[perm[i]], 0, newBytes, newPos, newLength[perm[i]]);
                newPos += newLength[perm[i]];
                Array.Copy(bytes, pos[perm[i]] + length[perm[i]], newBytes, newPos, pos[perm[i + 1]] - pos[perm[i]] - length[i]);
                newPos += pos[perm[i + 1]] - pos[perm[i]] - length[perm[i]];
            }

            return newPos;
        }

        private void saveNewBytes()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save file...";
            saveFile.Filter = "mvd files (.mvd)|*.mvd|All files (*.*)|(*.*)";
            saveFile.DefaultExt = "mvd";
            
            saveFile.CheckPathExists = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFile.FileName, newBytes);
            }
        }

        private void generateNewBytes()
        {
            int valLength = 0x14, newValLength = 0x14;
            var newValBytes = new byte[0x20];

            Array.Copy(BitConverter.GetBytes(newVal[0]), 0, newValBytes, 0x0, 0x4);
            Array.Copy(BitConverter.GetBytes(newVal[1]), 0, newValBytes, 0x4, 0x4);
            Array.Copy(bytes, valPos[1] + 0x4, newValBytes, 0x8, 0x4);
            Array.Copy(BitConverter.GetBytes(newVal[2]), 0, newValBytes, 0xc, 4);
            Array.Copy(BitConverter.GetBytes(newVal[3]), 0, newValBytes, 0x10, 4);

            substBytes[0] = newChildName;
            substBytes[1] = newBackground;
            substBytes[2] = newValBytes;
            
            pos[0] = childNamePos;
            pos[1] = backgroundPos;
            pos[2] = valPos[0];
            pos[3] = bytes.Length;

            length[0] = childNameLength;
            length[1] = backgroundLength;
            length[2] = valLength;

            newLength[0] = newChildNameLength;
            newLength[1] = newBackgroundLength;
            newLength[2] = newValLength;
            
            permutation();

            copyBytes();

            saveNewBytes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new float[4];
            string[] str = { newATextBox.Text, newBTextBox.Text, newCTextBox.Text, newDTextBox.Text };

            if (!loaded)
            {
                ErrorNotLoaded();
            }

            for (int i = 0; i < 4; i++)
            {
                if (string.IsNullOrEmpty(str[i]))
                    newVal[i] = val[i];
                else if (!float.TryParse(str[i], out newVal[i]))
                {
                    ErrorNotFloat();
                    return;
                }
            }
            
            if (string.IsNullOrEmpty(newChildNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(newChildNameTextBox.Text))
            {
                newChildName = childNameByte.ToArray();
                newChildNameLength = childNameLength;
            }
            else
            {
                newChildName = StringToByte(newChildNameTextBox.Text);
                newChildNameLength = newChildNameTextBox.TextLength;
            }

            if (string.IsNullOrEmpty(newBackgroundTextBox.Text) ||
                string.IsNullOrWhiteSpace(newBackgroundTextBox.Text))
            {
                newBackground = backgroundByte.ToArray();
                newBackgroundLength = backgroundLength;
            }
            else
            {
                newBackground = StringToByte(newBackgroundTextBox.Text);
                newBackgroundLength = newBackgroundTextBox.TextLength;
            }

            generateNewBytes();
        }
    }
}
