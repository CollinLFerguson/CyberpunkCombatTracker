
namespace CyberpunkCombatTracker
{
    partial class MainControllerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textArmorH = new System.Windows.Forms.TextBox();
            this.textArmorB = new System.Windows.Forms.TextBox();
            this.textHealth = new System.Windows.Forms.TextBox();
            this.textAmmo = new System.Windows.Forms.TextBox();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.textNotes = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblAmmo = new System.Windows.Forms.Label();
            this.lblArmorB = new System.Windows.Forms.Label();
            this.lblArmorH = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.menuFormControl = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuFormControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(451, 41);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 7;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textArmorH
            // 
            this.textArmorH.Location = new System.Drawing.Point(151, 44);
            this.textArmorH.Name = "textArmorH";
            this.textArmorH.Size = new System.Drawing.Size(40, 20);
            this.textArmorH.TabIndex = 4;
            // 
            // textArmorB
            // 
            this.textArmorB.Location = new System.Drawing.Point(105, 44);
            this.textArmorB.Name = "textArmorB";
            this.textArmorB.Size = new System.Drawing.Size(40, 20);
            this.textArmorB.TabIndex = 3;
            // 
            // textHealth
            // 
            this.textHealth.Location = new System.Drawing.Point(10, 44);
            this.textHealth.Name = "textHealth";
            this.textHealth.Size = new System.Drawing.Size(40, 20);
            this.textHealth.TabIndex = 0;
            // 
            // textAmmo
            // 
            this.textAmmo.Location = new System.Drawing.Point(59, 44);
            this.textAmmo.Name = "textAmmo";
            this.textAmmo.Size = new System.Drawing.Size(40, 20);
            this.textAmmo.TabIndex = 2;
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(405, 44);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(40, 20);
            this.textAmount.TabIndex = 6;
            // 
            // textNotes
            // 
            this.textNotes.Location = new System.Drawing.Point(198, 44);
            this.textNotes.Multiline = true;
            this.textNotes.Name = "textNotes";
            this.textNotes.Size = new System.Drawing.Size(200, 40);
            this.textNotes.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(532, 42);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(613, 42);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 11;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(7, 28);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(38, 13);
            this.lblHealth.TabIndex = 9;
            this.lblHealth.Text = "Health";
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.Location = new System.Drawing.Point(56, 28);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(36, 13);
            this.lblAmmo.TabIndex = 10;
            this.lblAmmo.Text = "Ammo";
            // 
            // lblArmorB
            // 
            this.lblArmorB.AutoSize = true;
            this.lblArmorB.Location = new System.Drawing.Point(104, 28);
            this.lblArmorB.Name = "lblArmorB";
            this.lblArmorB.Size = new System.Drawing.Size(44, 13);
            this.lblArmorB.TabIndex = 11;
            this.lblArmorB.Text = "Body Ar";
            // 
            // lblArmorH
            // 
            this.lblArmorH.AutoSize = true;
            this.lblArmorH.Location = new System.Drawing.Point(149, 28);
            this.lblArmorH.Name = "lblArmorH";
            this.lblArmorH.Size = new System.Drawing.Size(46, 13);
            this.lblArmorH.TabIndex = 12;
            this.lblArmorH.Text = "Head Ar";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(197, 28);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 13;
            this.lblNotes.Text = "Notes";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(402, 27);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "Amount";
            // 
            // menuFormControl
            // 
            this.menuFormControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuFormControl.Location = new System.Drawing.Point(0, 0);
            this.menuFormControl.Name = "menuFormControl";
            this.menuFormControl.Size = new System.Drawing.Size(784, 24);
            this.menuFormControl.TabIndex = 15;
            this.menuFormControl.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "Scene.txt";
            this.saveFileDialog1.Filter = "\"Text Files|*.txt\"";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Text Files|*.txt\"";
            // 
            // MainControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 250);
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblArmorH);
            this.Controls.Add(this.lblArmorB);
            this.Controls.Add(this.lblAmmo);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textNotes);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.textHealth);
            this.Controls.Add(this.textAmmo);
            this.Controls.Add(this.textArmorB);
            this.Controls.Add(this.textArmorH);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.menuFormControl);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuFormControl;
            this.Name = "MainControllerForm";
            this.Text = "Cyberpunk Combat Tracker";
            this.Resize += new System.EventHandler(this.MainControllerForm_Resize);
            this.menuFormControl.ResumeLayout(false);
            this.menuFormControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textArmorH;
        private System.Windows.Forms.TextBox textArmorB;
        private System.Windows.Forms.TextBox textHealth;
        private System.Windows.Forms.TextBox textAmmo;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.TextBox textNotes;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.Label lblArmorB;
        private System.Windows.Forms.Label lblArmorH;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.MenuStrip menuFormControl;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

