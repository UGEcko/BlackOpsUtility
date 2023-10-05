using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackOpsUtility;

namespace BlackOpsUtility
{
    public partial class mainMenu
    {
        // VERSION BUTTONS
        public void bo1SelectButton_Click(object sender, EventArgs e)
        {
            versionPanelSwitch(GameVersion.Bo1);
        }
        private void bo2SelectButton_Click(object sender, EventArgs e)
        {
            versionPanelSwitch(GameVersion.Bo2);
        }

        private void bo3SelectButton_Click(object sender, EventArgs e)
        {
            versionPanelSwitch(GameVersion.Bo3);
        }

        // BLACK OPS 1 MAP BUTTONS
        private void NachtderUntotenB01Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo1Nacht);
        }

        private void KinoderTotenB01Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo1Kino);
        }

        private void ShiNoNumaB01Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo1Shino);
        }

        private void DerRieseB01Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo1DerRiese);
        }

        private void CalloftheDeadB01Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo1CallDead);
        }

        private void MoonB01Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo1Moon);
        }

        private void VerrucktB01Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo1Verruckt);
        }

        private void FiveB01Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo1Five);
        }

        // BLACK OPS 2 MAP BUTTONS
        private void nuketownZombiesB02Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo2Nuke);
        }

        private void townB02Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo2Town);
        }

        private void farmB02Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo2Farm);
        }

        private void originsB02Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo2Origins);
        }

        private void moboftheDeadB02Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo2MobDead);
        }

        private void buriedB02Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo2Buried);
        }

        private void dieRiseB02Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo2DRise);
        }

        // BLACK OPS 3 MAP BUTTONS
        private void nachtderUntotenB03Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo3Nacht);
        }

        private void kinoderTotenB03Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo3Kino);
        }

        private void shadowsOfEvilB03Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo3Shadows);
        }

        private void derEisendracheB03Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo3DerEisen);
        }

        private void moonB03Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo3Moon);
        }

        private void originsB03Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo3Origins);
        }

        private void shiNoNumaB03Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo3Shino);
        }

        private void verrucktB03Button_Click(object sender, EventArgs e)
        {
            mapSelect(GVMap.bo3Verruckt);
        }

        // Other

        private void mapInfoExitButton_Click(object sender, EventArgs e) // Map info panel exit button
        {
            mapInfoPanel.Visible = false;
            targetsPanel.Visible = false;
            B01MapPanel.Enabled = true;
            b02MapPanel.Enabled = true;
            B03MapPanel.Enabled = true;
        }

        private void specialWeaponsButton_Click(object sender, EventArgs e)
        {
            targetSelect(targetName.SpecialWeapons);
        }

        private void commonLocationsButton_Click(object sender, EventArgs e)
        {
            targetSelect(targetName.CommonLocations);
        }

        private void roundStatsButton_Click(object sender, EventArgs e)
        {
            targetSelect(targetName.RoundStats);
        }

        private void easterEggsButton_Click(object sender, EventArgs e)
        {
            targetSelect(targetName.EasterEggs);
        }

    }
}
