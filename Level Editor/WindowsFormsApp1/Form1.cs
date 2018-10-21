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

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        CheckBox[] brickGrid;

        public Form1 () {
            InitializeComponent ();

            brickGrid = new CheckBox[] {checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8};
        }

        private void Export_Click (object sender, EventArgs e) {
            saveDialog.ShowDialog ();

            string[] textOfFile = new string[3];
            textOfFile[0] = "char " + Path.GetFileNameWithoutExtension(saveDialog.FileName) + "[] = {";
            textOfFile[1] = "\t";
            Stream file = saveDialog.OpenFile ();
            for (int i = 0; i < brickGrid.Length - 1; i++) {
                if (brickGrid[i].Checked) {
                    textOfFile[1] += "1";
                } else {
                    textOfFile[1] += "0";
                }
                textOfFile[1] += ", ";
            }
            if (brickGrid[brickGrid.Length-1].Checked) {
                textOfFile[1] += "1";
            } else {
                textOfFile[1] += "0";
            }
            textOfFile[2] += "};";

            using (StreamWriter streamWriter = new StreamWriter (file)) {
                foreach (string line in textOfFile) {
                    streamWriter.WriteLine (line);
                }
            }
        }

        private void button1_Click (object sender, EventArgs e) {
            exportPath.ShowDialog ();
        }

        private void Form1_Load (object sender, EventArgs e) {

        }

        private void lodeButton_Click (object sender, EventArgs e) {
            loadDialog.ShowDialog ();

            Stream file = loadDialog.OpenFile ();
            string[] textInFile = new string[3];

            using (StreamReader streamReader = new StreamReader (file)) {
                for (int i = 0; i < 3; i++) {
                    textInFile[i] = streamReader.ReadLine ();
                }
            }

            char[] array = textInFile[1].ToCharArray ();
            int j = 0;
            foreach (char character in array) {
                if (character == '1') {
                    brickGrid[j].Checked = true;
                    j++;
                } else if (character == '0') {
                    brickGrid[j].Checked = false;
                    j++;
                }
            }
        }
    }
}
