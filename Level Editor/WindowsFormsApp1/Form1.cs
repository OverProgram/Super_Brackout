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

            string[] textOfFile = new string[3];
            textOfFile[0] = "char " + Path.GetFileNameWithoutExtension(saveDialog.FileName) + "[] = {";
            textOfFile[1] = "\t";
            Stream file = saveDialog.OpenFile ();
            for (int i = 0; i < brickGrid.Length - 1; i++) {
                textOfFile[1] += brickGrid[i].SelectedIndex.ToString () + ", ";
            }
            textOfFile[1] += brickGrid[brickGrid.Length - 1].SelectedIndex.ToString () + ", ";
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
            int num;
            foreach (char character in array) {
                if (int.TryParse (character.ToString(), out num)) {
                    brickGrid[j].SelectedIndex = num;
                    j++;
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
    }
}
