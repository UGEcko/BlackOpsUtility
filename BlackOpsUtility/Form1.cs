using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackOpsUtility;

namespace BlackOpsUtility
{
    public partial class mainMenu : Form
    {

        public Color normalColor = Color.FromArgb(1, 39, 37, 55);
        public Color toggledColor = Color.DarkSlateBlue;
        public Color validGreen = Color.Green;
        public Color invalidRed = Color.Red;



        public enum GameVersion
        {
            Bo1,
            Bo2,
            Bo3
        }

        public void log(string text) // Wack ass way to make console writeline easier
        {
            Console.WriteLine(text);
        }
        public void panelHandler(GameVersion version) // Also did the validate versionInfo box bc why not
        {
            versionInfo.ForeColor = validGreen;

            switch(version)
            {
                case GameVersion.Bo1:
                    B01MapPanel.Visible = true;
                    b02MapPanel.Visible = false;
                    B03MapPanel.Visible = false;
                    B01MapPanel.Enabled = true;
                    b02MapPanel.Enabled = false;
                    B03MapPanel.Enabled = false;
                    versionInfo.Text = "Black Ops 1";
                    break;
                case GameVersion.Bo2:
                    B01MapPanel.Visible = false;
                    b02MapPanel.Visible = true;
                    B03MapPanel.Visible = false;
                    B01MapPanel.Enabled = false;
                    b02MapPanel.Enabled = true;
                    B03MapPanel.Enabled = false;
                    versionInfo.Text = "Black Ops 2";
                    break;
                case GameVersion.Bo3:
                    B01MapPanel.Visible = false;
                    b02MapPanel.Visible = false;
                    B03MapPanel.Visible = true;
                    B01MapPanel.Enabled = false;
                    b02MapPanel.Enabled = false;
                    B03MapPanel.Enabled = true;
                    versionInfo.Text = "Black Ops 3";
                    break;
            }
        }

        public void versionPanelSwitch(GameVersion version)
        {
            switch (version)
            {
                case GameVersion.Bo1:
                    log("BO1 Selected.");
                    panelHandler(GameVersion.Bo1);
                    break;
                case GameVersion.Bo2:
                    log("BO3 Selected.");
                    panelHandler(GameVersion.Bo2);
                    break;
                case GameVersion.Bo3:
                    log("BO3 Selected.");
                    panelHandler(GameVersion.Bo3);
                    break;

            }
        }

        public mainMenu()
        {
            InitializeComponent();
            
        }

        
    }
}
