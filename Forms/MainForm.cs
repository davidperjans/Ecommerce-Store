using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Webshop.Cards;
using Webshop.Classes;
using Webshop.Pages;

namespace Webshop.Forms
{
    public partial class MainForm : Form
    {
        private Cart _cart;
        public MainForm()
        {
            InitializeComponent();
            _cart = new Cart();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowPanelAndControl(homeUC1, pnlHome);

            electronicsUC1.InitializeData(_cart);
            clothesUC1.InitializeData(_cart);
            homedecorUC1.InitializeData(_cart);
            jewelryUC1.InitializeData(_cart);
            cartUC1.InitializeData(_cart);
        }

        /*                      NAV-Bar                     */
        private void ShowPanelAndControl(UserControl controlToShow, Panel activePanel)
        {
            // Göm alla UserControls
            var userControls = new List<UserControl> { cartUC1, jewelryUC1, clothesUC1, electronicsUC1, homedecorUC1 };
            foreach (var control in userControls)
            {
                control.Visible = false;
            }

            // Visa det önskade UserControl
            controlToShow.Visible = true;
            controlToShow.BringToFront();

            // Återställ alla panelers bakgrund
            var panels = new List<Panel> { pnlShowcart, pnlJewelry, pnlClothes, pnlHomedecor, pnlElectronics };
            foreach (var panel in panels)
            {
                panel.BackColor = Color.LightSkyBlue;
            }

            // Markera den aktiva panelen
            activePanel.BackColor = Color.White;
            if (activePanel == pnlHome)
            {
                activePanel.BackColor = Color.LightSkyBlue;
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnElectronics_Click(object sender, EventArgs e)
        {
            ShowPanelAndControl(electronicsUC1, pnlElectronics);
        }
        private void btnHomedecor_Click(object sender, EventArgs e)
        {
            ShowPanelAndControl(homedecorUC1, pnlHomedecor);
        }
        private void btnClothes_Click(object sender, EventArgs e)
        {
            ShowPanelAndControl(clothesUC1, pnlClothes);
        }
        private void btnJewelry_Click(object sender, EventArgs e)
        {
            ShowPanelAndControl(jewelryUC1, pnlJewelry);
        }
        private void btnLogo_Click(object sender, EventArgs e)
        {
            ShowPanelAndControl(homeUC1, pnlHome);
        }     
        private void btnShowcart_Click(object sender, EventArgs e)
        {
            ShowPanelAndControl(cartUC1, pnlShowcart);
        }
        /*                                                  */
    }
}
