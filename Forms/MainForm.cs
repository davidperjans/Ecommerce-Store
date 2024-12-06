using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webshop.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }










        /*                      NAV-Bar                     */
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnElectronics_Click(object sender, EventArgs e)
        {
            homeUC1.Visible = false;
            clothesUC1.Visible = false;
            electronicsUC1.Visible = true;
            homedecorUC1.Visible = false;
            jewelryUC1.Visible = false;
            cartUC1.Visible = false;

            pnlClothes.Visible = false;
            pnlElectronics.Visible = true;
            pnlHomedecor.Visible = false;
            pnlJewelry.Visible = false;
            pnlShowcart.Visible = false;
        }
        private void btnHomedecor_Click(object sender, EventArgs e)
        {
            homeUC1.Visible = false;
            clothesUC1.Visible = false;
            electronicsUC1.Visible = false;
            homedecorUC1.Visible = true;
            jewelryUC1.Visible = false;
            cartUC1.Visible = false;

            pnlClothes.Visible = false;
            pnlElectronics.Visible = false;
            pnlHomedecor.Visible = true;
            pnlJewelry.Visible = false;
            pnlShowcart.Visible = false;
        }
        private void btnClothes_Click(object sender, EventArgs e)
        {
            homeUC1.Visible = false;
            clothesUC1.Visible = true;
            electronicsUC1.Visible = false;
            homedecorUC1.Visible = false;
            jewelryUC1.Visible = false;
            cartUC1.Visible = false;

            pnlClothes.Visible = true;
            pnlElectronics.Visible = false;
            pnlHomedecor.Visible = false;
            pnlJewelry.Visible = false;
            pnlShowcart.Visible = false;
        }
        private void btnJewelry_Click(object sender, EventArgs e)
        {
            homeUC1.Visible = false;
            clothesUC1.Visible = false;
            electronicsUC1.Visible = false;
            homedecorUC1.Visible = false;
            jewelryUC1.Visible = true;
            cartUC1.Visible = false;

            pnlClothes.Visible = false;
            pnlElectronics.Visible = false;
            pnlHomedecor.Visible = false;
            pnlJewelry.Visible = true;
            pnlShowcart.Visible = false;
        }
        private void btnLogo_Click(object sender, EventArgs e)
        {
            homeUC1.Visible = true;
            clothesUC1.Visible = false;
            electronicsUC1.Visible = false;
            homedecorUC1.Visible = false;
            jewelryUC1.Visible = false;
            cartUC1.Visible = false;

            pnlClothes.Visible = false;
            pnlElectronics.Visible = false;
            pnlHomedecor.Visible = false;
            pnlJewelry.Visible = false;
            pnlShowcart.Visible = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            homeUC1.Visible = true;
            clothesUC1.Visible = false;
            electronicsUC1.Visible = false;
            homedecorUC1.Visible = false;
            jewelryUC1.Visible = false;
            cartUC1.Visible = false;

            pnlClothes.Visible = false;
            pnlElectronics.Visible = false;
            pnlHomedecor.Visible = false;
            pnlJewelry.Visible = false;
            pnlShowcart.Visible = false;
        }
        private void btnShowcart_Click(object sender, EventArgs e)
        {
            homeUC1.Visible = false;
            clothesUC1.Visible = false;
            electronicsUC1.Visible = false;
            homedecorUC1.Visible = false;
            jewelryUC1.Visible = false;
            cartUC1.Visible = true;

            pnlClothes.Visible = false;
            pnlElectronics.Visible = false;
            pnlHomedecor.Visible = false;
            pnlJewelry.Visible = false;
            pnlShowcart.Visible = true;
        }

        /*                                                  */
    }
}
