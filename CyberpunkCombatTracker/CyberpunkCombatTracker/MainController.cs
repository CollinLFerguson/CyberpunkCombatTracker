using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CyberpunkCombatTracker
{
    public partial class MainControllerForm : Form
    {
        public List<SubController> subControllers = new List<SubController>(); //Holds all SubControllers
        private int currentId = 0; //Keeps track of the next available ID for a SubController.


        public MainControllerForm()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            clearSubcontrollers();
            currentId = 0;

            int temp = tryParse(textAmount.Text);


            for (int i = 0; i < temp; i++) 
            {
                subControllers.Add(new SubController());
                subControllers[i].TopLevel = false;
                subControllers[i].setStates(currentId.ToString(), textHealth.Text, textHealth.Text, textAmmo.Text, textAmmo.Text, textArmorB.Text, textArmorH.Text, textNotes.Text);
                this.Controls.Add(subControllers[i]);
                subControllers[i].Show();
                currentId += 1;
            }
            fixResolution();

        }
        private void fixResolution() 
            /// Fixes the placement of the SubControllers after the form is resized or new nodes are added.
        {
            int mainFormWidth = this.Size.Width;
            int spacingX = 10; //
            int spacingY = 10;
            int numSubScenes = subControllers.Count();
            if(numSubScenes < 1) { return;}

            int subSceneX = subControllers[0].Size.Width;
            int subSceneY = subControllers[0].Size.Height;

            int numColumns = (int)((mainFormWidth - subSceneX - spacingX - 20) / (subSceneX));
            int numRows;

            if (numColumns == 0)
            {
                numRows = numSubScenes / (numColumns + 1);
            }
            else
            {
                numRows = numSubScenes / numColumns;
            }

            int i = 0;
            for (int r = 0; r <= numRows; r++)
            {
                for (int c = 0; c <= numColumns; c++)
                {
                    if (i < numSubScenes)
                    {
                        subControllers[i].Left = ((c * subSceneX) + spacingX);
                        subControllers[i].Top = ((r * subSceneY) + (r * spacingY) + 100);
                    }
                    else
                    {
                        
                        return;
                    }
                    i++;
                }
            }
        }

        private void clearSubcontrollers()
        {
            for (int i = 0; i < subControllers.Count(); i++)
            {

                this.Controls.Remove(subControllers[i]);
                subControllers[i].Close();

                subControllers[i].Dispose();

            }
            subControllers.Clear();

        }

        private void MainControllerForm_Resize(object sender, EventArgs e)
        {
            fixResolution();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.Title = "Save a text file.";
            saveFileDialog1.ShowDialog();


            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.File.Create(saveFileDialog1.FileName));


                for (int i = 0; i < subControllers.Count; i++)
                {

                    sw.Write(subControllers[i].getStates() + "\n");

                }
                sw.Dispose();
            }
            catch 
            {
                Console.WriteLine(e);
                return;
            }
        }

        private int tryParse(string str)
        {
            try
            {
                return int.Parse(str);
            }
            catch
            {
                return 0;
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearSubcontrollers();
            
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Load a text file.";

            openFileDialog1.ShowDialog();
            
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                string line;
                string[] values = new string[8];
                int i = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    values = line.Split(':');

                    subControllers.Add(new SubController());
                    subControllers[i].TopLevel = false;
                    subControllers[i].setStates(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7]);
                    this.Controls.Add(subControllers[i]);
                    subControllers[i].Show();
                    currentId = int.Parse(values[0]) + 1;

                    i++;
                }
                sr.Dispose();
                fixResolution();

            }
            catch
            {
                Console.WriteLine(e);
                return;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int temp = tryParse(textAmount.Text);
            int getCount = subControllers.Count;

            for (int i = getCount; i < (getCount + temp); i++)
            {
                subControllers.Add(new SubController());
                subControllers[i].TopLevel = false;
                subControllers[i].setStates(currentId.ToString(), textHealth.Text, textHealth.Text, textAmmo.Text, textAmmo.Text, textArmorB.Text, textArmorH.Text, textNotes.Text);
                this.Controls.Add(subControllers[i]);
                subControllers[i].Show();
                currentId += 1;
            }
            
            fixResolution();

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int temp = tryParse(textAmount.Text);

            for(int i = 0; i < subControllers.Count; i++)
            {
                if(subControllers[i].getID() == temp)
                {
                    this.Controls.Remove(subControllers[i]);
                    subControllers[i].Dispose();
                    subControllers.RemoveAt(i);
                }
            }
            fixResolution();

        }
    }
}
