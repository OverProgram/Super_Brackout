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
using Microsoft.VisualBasic;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        ComboBox[] brickGrid;

        Color lightestGreen = Color.FromArgb (155, 188, 15);
        Color lightGreen = Color.FromArgb (139, 172, 15);
        Color darkGreen = Color.FromArgb (48, 98, 48);
        Color darkestGreen = Color.FromArgb (15, 56, 15);

        public Form1 () {
            InitializeComponent ();

            brickGrid = new ComboBox[] {brick1, brick2, brick3, brick4, brick5, brick6, brick7, brick8, brick9, brick10, brick11, brick12, brick13, brick14, brick15, brick16, brick17, brick18, brick19, brick20, brick21, brick22, brick23, brick24, brick25, brick26, brick27, brick28, brick29, brick30, brick31, brick32, brick33, brick34, brick35, brick36, brick37, brick38, brick39, brick40, brick41, brick42, brick43, brick44, brick45, brick46, brick47, brick48, brick49, brick50, brick51, brick52, brick53, brick54, brick55, brick56, brick57, brick58, brick59, brick60};
            foreach (ComboBox brick in brickGrid) {
                brick.SelectedIndex = 0;
                brick.BackColor = lightestGreen;
                brick.SelectedValueChanged += new EventHandler (ColorAccordingToIndex);
            }
        }

        private void Export_Click (object sender, EventArgs e) {
            saveDialog.ShowDialog ();

            if (saveDialog.FileName == "") {
                return;
            }
            string stageName = Interaction.InputBox ("Enter stage name:");
            List<string> textOfFile = new List<string> ();
            textOfFile.Add ("char " + stageName + "[] = {");
            int j = 0;
            Stream file = saveDialog.OpenFile ();
            string headerPath = GetHeaderPath (saveDialog.FileName);
            Stream header = new FileStream (headerPath, FileMode.Create);
            for (int i = 0; i < brickGrid.Length - 1; i++) {
                if (i % 10 == 0) {
                    j++;
                    textOfFile.Add ("\t");
                }
                textOfFile[j] += brickGrid[i].SelectedIndex.ToString () + ", ";
            }
            textOfFile[j] += brickGrid[brickGrid.Length - 1].SelectedIndex.ToString ();
            textOfFile.Add ("};");

            using (StreamWriter streamWriter = new StreamWriter (file)) {
                foreach (string line in textOfFile) {
                    streamWriter.WriteLine (line);
                }
            }

            using (StreamWriter streamWriter = new StreamWriter (header)) {
                streamWriter.WriteLine ("char " + stageName + "[];");
            }
        }

        private string GetHeaderPath (string path) {
            string headerPath = "";
            char[] fileName = path.ToCharArray ();
            for (int chara = 0; chara < fileName.Length; chara++) {
                if (chara < fileName.Length - 2) {
                    headerPath += fileName[chara];
                }
            }
            headerPath += ".h";

            return headerPath;
        }

        private void button1_Click (object sender, EventArgs e) {
            exportPath.ShowDialog ();
        }

        private void Form1_Load (object sender, EventArgs e) {

        }

        private void lodeButton_Click (object sender, EventArgs e) {
            loadDialog.ShowDialog ();

            if (loadDialog.FileName == "") {
                return;
            }

            Stream file = loadDialog.OpenFile ();
            List<string> textInFile = new List<string>();

            using (StreamReader streamReader = new StreamReader (file)) {
                while (!streamReader.EndOfStream) {
                    textInFile.Add (streamReader.ReadLine ());
                }
            }
            if (textInFile.Count == 9) {
                int j = 0;
                int num;
                for (int line = 1; line <= 7; line++) {
                    foreach (char character in textInFile[line].ToCharArray()) {
                        if (int.TryParse (character.ToString (), out num)) {
                            brickGrid[j].SelectedIndex = num;
                            j++;
                        }
                    }
                }
                if (j != brickGrid.Length) {
                    MessageBox.Show ("Error:\nTried to load invalid file");
                }
            } else {
                string input = Interaction.InputBox ("File contains multiple stages\nWhich one to load:");
                int line;
                if (int.TryParse (input, out line)) {
                    line = (line * 9) - 8;
                    int lineLimit = line + 6;
                    int j = 0;
                    for (; line <= lineLimit; line++) {
                        int num;
                        char[] array = textInFile[line].ToCharArray ();
                        foreach (char character in array) {
                            if (int.TryParse (character.ToString (), out num)) {
                                brickGrid[j].SelectedIndex = num;
                                j++;
                            }
                        }
                    }
                    if (j != brickGrid.Length) {
                        MessageBox.Show ("Error:\nTried to load invalid file or stage");
                    }
                } else {
                    MessageBox.Show ("Invalid input");
                }
            }
        }

        private void ColorAccordingToIndex (object sender, EventArgs e) {
            ComboBox brick = (ComboBox) sender;

            switch (brick.SelectedIndex) {
                case 0:
                    brick.BackColor = lightestGreen;
                    break;
                case 1:
                    brick.BackColor = lightGreen;
                    break;
                case 2:
                    brick.BackColor = darkGreen;
                    break;
                case 3:
                    brick.BackColor = darkestGreen;
                    break;
            }
        }

        private void addButton_Click (object sender, EventArgs e) {
            addDialog.ShowDialog ();

            if (addDialog.FileName == "") {
                return;
            }

            List<string> textToFile = new List<string> ();
            string stageName = Interaction.InputBox ("Enter stage name:");
            textToFile.Add ("char " + stageName + "[] = {");
            int j = 0;
            string file = addDialog.FileName;
            string header = GetHeaderPath (file);
            for (int i = 0; i < brickGrid.Length - 1; i++) {
                if (i % 10 == 0) {
                    j++;
                    textToFile.Add ("\t");
                }
                textToFile[j] += brickGrid[i].SelectedIndex.ToString () + ", ";
            }
            textToFile[j] += brickGrid[brickGrid.Length - 1].SelectedIndex.ToString ();
            textToFile.Add ("};");

            try {
                using (StreamWriter streamWriter = new StreamWriter (header, true)) {
                    streamWriter.WriteLine ("char " + stageName + "[];");
                }
            } catch (IOException) {
                MessageBox.Show ("Header file not found");
                return;
            }

            using (StreamWriter streamWriter = new StreamWriter (file, append: true)) {
                foreach (string line in textToFile) {
                    streamWriter.WriteLine (line);
                }
            }

        }

        private void ResetBricks () {
            foreach (ComboBox brick in brickGrid) {
                brick.SelectedIndex = 0;
            }
        }

        private void clearButton_Click (object sender, EventArgs e) {
            ResetBricks ();
        }
    }
}
