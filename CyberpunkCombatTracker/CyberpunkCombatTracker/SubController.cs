using System;
using System.Drawing;
using System.Windows.Forms;

namespace CyberpunkCombatTracker
{
    public partial class SubController : Form
    {
        private int actorID = -1;
        private int actorHealth = 0;
        private int actorAmmo = 0;
        private int actorBdyArmor = 0;
        private int actorHedArmor = 0;
        private int actorMaxHealth = 0;
        private int actorMaxAmmo = 0;

        public SubController()
        {
            InitializeComponent();
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


        public void setStates(string id, string health, string maxHealth, string ammo, string maxAmmo, string bodyArmor, string headArmor, string notes) 
        {
            actorID = tryParse(id);
            lblID.Text = id;
                        
            actorHealth = tryParse(health);
            actorMaxHealth = tryParse(maxHealth);
            txtHealth.Text = actorHealth.ToString();
            lblMaxHealth.Text = actorMaxHealth.ToString();

            actorAmmo = tryParse(ammo);
            actorMaxAmmo = tryParse(maxAmmo);
            txtAmmo.Text = actorAmmo.ToString();
            lblMaxAmmo.Text = actorMaxAmmo.ToString();

            actorBdyArmor = tryParse(bodyArmor);
            txtBdyArmor.Text = actorBdyArmor.ToString();

            actorHedArmor = tryParse(headArmor);
            txtHedArmor.Text = actorHedArmor.ToString();

            txtNotes.Text = notes;
        }

        public string getStates() 
        {

            string strVals = actorID + ":" + actorHealth.ToString() + ":" + actorMaxHealth.ToString() 
                + ":" + actorAmmo.ToString() + ":" + actorMaxAmmo.ToString() + ":" + actorBdyArmor.ToString() + ":" + actorHedArmor.ToString() + ":" + txtNotes.Text;


            return strVals;
        }
        
        public int getID()
        {
            return actorID;

        }



        private void btnDmgAffirm_Click(object sender, EventArgs e)
        {
            //Deal Damage
            int damage = tryParse(txtDmg.Text);
            bool isMelee = checkMeleeDmg.Checked;
            bool isAP = checkAPDmg.Checked;

            bool isBody = radBodyDmg.Checked;
            bool isHead = radHeadDmg.Checked;

            if (isBody && ((!isMelee && damage > actorBdyArmor) || (isMelee && damage > actorBdyArmor / 2)))
            {
                if (isMelee) { actorHealth -= damage - actorBdyArmor / 2; }
                else { actorHealth -= damage - actorBdyArmor; }

                txtHealth.Text = actorHealth.ToString();
                healthChanged();

                actorBdyArmor -= 1;
                if (isAP) { actorBdyArmor -= 1; }
                armorCheck();
                txtBdyArmor.Text = actorBdyArmor.ToString();
            }
            if (isHead && ((!isMelee && damage > actorHedArmor) || (isMelee && damage > actorHedArmor / 2)))
            {
                if (isMelee) { actorHealth -= damage * 2 - actorHedArmor / 2; }
                else { actorHealth -= damage * 2 - actorHedArmor; }

                txtHealth.Text = actorHealth.ToString();
                healthChanged();

                actorHedArmor -= 1;
                if (isAP) { actorHedArmor -= 1; }
                armorCheck();
                txtBdyArmor.Text = actorHedArmor.ToString();

            }
        }


        private void healthChanged() 
        {
            if (actorHealth <= (actorMaxHealth / 2)) { grpPanel.BackColor = Color.Red;}
            if (actorHealth > (actorMaxHealth / 2)) { grpPanel.BackColor = SystemColors.Control; }
        }

        private void armorCheck() 
        {
            if (actorBdyArmor < 0) 
            { 
                actorBdyArmor = 0;
                txtBdyArmor.Text = "0";
            }

            if (actorHedArmor < 0) 
            { 
                actorHedArmor = 0;
                txtHedArmor.Text = "0";
            }
        }


        private void btnAddHealth_Click(object sender, EventArgs e)
        {
            actorHealth += 1;
            txtHealth.Text = actorHealth.ToString();
            healthChanged();
        }

        private void btnReduceHealth_Click(object sender, EventArgs e)
        {
            actorHealth -= 1;
            txtHealth.Text = actorHealth.ToString();
            healthChanged();
        }

        private void btnAddBdyArmor_Click(object sender, EventArgs e)
        {
            actorBdyArmor += 1;
            txtBdyArmor.Text = actorBdyArmor.ToString();
            armorCheck();
        }

        private void btnReduceBdyArmor_Click(object sender, EventArgs e)
        {
            actorBdyArmor -= 1;
            txtBdyArmor.Text = actorBdyArmor.ToString();
            armorCheck();
        }

        private void btnAddHedArmor_Click(object sender, EventArgs e)
        {
            actorHedArmor += 1;
            txtHedArmor.Text = actorHedArmor.ToString();
            armorCheck();
        }

        private void btnReduceHedArmor_Click(object sender, EventArgs e)
        {
            actorHedArmor -= 1;
            txtHedArmor.Text = actorHedArmor.ToString();
            armorCheck();
        }

        private void btnAddAmmo_Click(object sender, EventArgs e)
        {
            actorAmmo += 1;
            txtAmmo.Text = actorAmmo.ToString();
        }

        private void btnReduceAmmo_Click(object sender, EventArgs e)
        {
            actorAmmo -= 1;
            txtAmmo.Text = actorAmmo.ToString();
        }

        private void btnAmmoReload_Click(object sender, EventArgs e)
        {
            actorAmmo = actorMaxAmmo;
            txtAmmo.Text = actorAmmo.ToString();
        }

        private void btnMaxAmmo_Click(object sender, EventArgs e)
        {
            actorMaxAmmo = actorAmmo;
            lblMaxAmmo.Text = actorMaxAmmo.ToString();
        }

        private void btnMaxHealth_Click(object sender, EventArgs e)
        {
            actorMaxHealth = actorHealth;
            lblMaxHealth.Text = actorMaxHealth.ToString();

        }

        private void txtHealth_TextChanged(object sender, EventArgs e)
        {
            actorHealth = tryParse(txtHealth.Text);
            healthChanged();
        }

        private void txtBdyArmor_TextChanged(object sender, EventArgs e)
        {
            actorBdyArmor = tryParse(txtBdyArmor.Text);
            armorCheck();
        }

        private void txtHedArmor_TextChanged(object sender, EventArgs e)
        {
            actorHedArmor = tryParse(txtHedArmor.Text);
            armorCheck();

        }

        private void txtAmmo_TextChanged(object sender, EventArgs e)
        {
            actorAmmo = tryParse(txtAmmo.Text);
        }
    }
}
