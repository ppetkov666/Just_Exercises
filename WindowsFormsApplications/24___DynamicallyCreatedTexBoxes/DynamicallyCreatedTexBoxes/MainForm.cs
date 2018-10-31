using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicallyCreatedTexBoxes
{
    public partial class MainForm : Form
    {
        private static List<TextBox> textBoxList;
        private static List<Label> labelList;
        private static string textToBeChanged;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void itemOpen_Click(object sender, EventArgs e)
        {
            //First we create list of parameters where we will store the text
            List<string> parameters = new List<string>();
            // we will catch everything between this open and closed brackets
            string begin = "[[";
            string end = "]]";
            // when we click on Open - OpenFileDialog will be called and we will choose the file
            DialogResult result = openFileDialog.ShowDialog();
            if (result != DialogResult.OK) return;
            // if everything is ok we clear all controls if any exists
            DisplayPnl.Controls.Clear();
            // then we get the directory
            string dir = openFileDialog.FileName;
            //read all lines of text on string array
            string[] lines = File.ReadAllLines(dir);
            // and here we get all the text who we will need at the end of the program when we have to replace it
            textToBeChanged = File.ReadAllText(dir);
            //declare string variable which we will use later
            string param;
            // inthe foreach loop we go through all the lines of text and if there any between our[[  and ]] brackets
            // we get this  text as param and add it to our list of parameters
            foreach (var line in lines)
            {
                if (line.Contains(begin) && line.Contains(end))
                {  
                    int startIndex = line.IndexOf(begin);
                    int endIndex = line.LastIndexOf(end);
                    int length = (endIndex - startIndex) - 2 ;
                    param = line.Substring(startIndex + 2, length);
                    parameters.Add(param);
                }
            }
            // after we have all the parameters we create 2 lists where we will keep  labels and text boxes which will be created dynamically
            // and then added to controls of our DisplatPnl
            textBoxList = new List<TextBox>();
            labelList = new List<Label>();

            for (int i = 0; i < parameters.Count; i++)
            {
                labelList.Add(CreateLabel(parameters[i], i));
                textBoxList.Add(CreateTextBox(i));
            }

            for (int i = 0; i < parameters.Count; i++)
            {
                this.DisplayPnl.Controls.Add(textBoxList[i]);
                this.DisplayPnl.Controls.Add(labelList[i]);
            }
            itemSaveAs.Enabled = true;
        }

        private void itemSaveAs_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();
            if (result != DialogResult.OK) return;
            string filePath = saveFileDialog.FileName;
            File.WriteAllText(filePath, SaveText(textToBeChanged));
            string fileName = Path.GetFileName(filePath);
            string message = string.Format("File {0} saved", fileName);
            MessageBox.Show(message);
        }

        //label
        private Label CreateLabel(string parameter, int index)
        {
            Label dynamicLabel = new Label();
            dynamicLabel.Text = parameter;
            dynamicLabel.Location = new Point(0, 10 + (index * 30));
            dynamicLabel.Size = new Size(160, 30);
            return dynamicLabel;
        }

        //TextBox
        private TextBox CreateTextBox(int index)
        {
            TextBox dynamicTextBox = new TextBox();
            dynamicTextBox.Location = new Point(180, 10 + (index * 30));
            dynamicTextBox.Size = new Size(270, 22);
            return dynamicTextBox;
        }

        private string SaveText(string text)
        {
            for (int i = 0; i < labelList.Count; i++)
            {
                if (text.Contains(labelList[i].Text))
                {
                    text = text.Replace(labelList[i].Text, textBoxList[i].Text);
                }
            }
            return text;
        }    
    }
}
