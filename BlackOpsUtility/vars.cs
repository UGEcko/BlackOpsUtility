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
        public enum mapName
        {
            Verruckt,
            Five,
            CallOfTheDead,
            Moon,
            NachtDerUntoten,
            KinoDerToten,
            DerRiese,
            ShiNoNuma,
            Origins,
            MobOfTheDead,
            Buried,
            DieRise,
            Nuketown,
            Town,
            Farm,
            ShadowsOfEvil,
            DerEisendrache
        }
        public enum bo1Map
        {
            Nacht,
            Kino,
            Shino,
            DerRiese,
            CallDead,
            Moon,
            Verruckt,
            Five
        }
        public enum bo2Map
        {
            Origins,
            MobDead,
            Buried,
            DRise,
            Nuke,
            Town,
            Farm
        }
        public enum bo3Map
        {
            Nacht,
            Kino,
            Origins,
            Shino,
            Shadows,
            DerEisen,
            Moon,
            Verruckt
        }

        [Flags]
        public enum GVMap
        {
            // B01
            bo1Nacht = bo1Map.Nacht,
            bo1Kino = bo1Map.Kino,
            bo1Shino = bo1Map.Shino,
            bo1DerRiese = bo1Map.DerRiese,
            bo1CallDead = bo1Map.CallDead,
            bo1Moon = bo1Map.Moon,
            bo1Verruckt = bo1Map.Verruckt,
            bo1Five = bo1Map.Five,
            // B02
            bo2Origins = bo2Map.Origins,
            bo2MobDead = bo2Map.MobDead,
            bo2Buried = bo2Map.Buried,
            bo2DRise = bo2Map.DRise,
            bo2Nuke = bo2Map.Nuke,
            bo2Town = bo2Map.Town,
            bo2Farm = bo2Map.Farm,
            // B03
            bo3Nacht = bo3Map.Nacht,
            bo3Kino = bo3Map.Kino,
            bo3Origins = bo3Map.Origins,
            bo3Shino = bo3Map.Shino,
            bo3Shadows = bo3Map.Shadows,
            bo3DerEisen = bo3Map.DerEisen,
            bo3Moon = bo3Map.Moon,
            bo3Verruckt = bo3Map.Verruckt  
        }

        public enum targetName
        {
            CommonLocations,
            SpecialWeapons,
            RoundStats,
            EasterEggs
        }


        // I guess I can add the map target function here just to clear any confusion
        public void mapSelect(GVMap map)
        {
            mapInfoPanel.Visible = true;
            mapInfoPanel.BringToFront();
            B01MapPanel.Enabled = false;
            b02MapPanel.Enabled= false;
            B03MapPanel.Enabled = true;
            targetsPanel.Visible = true;
            targetInfoLabel.Visible = false;
            // Ill just log rn so I know it works
            Console.WriteLine("Map: " + map);
            string thing = map.ToString();
            mapInfoLabel.Text = thing;
        }
        
        public void targetSelect(targetName targ)
        {
            Console.WriteLine("Target: " + targ);
            string targetName = targ.ToString();
            if(targetInfoLabel.Visible == false)
            {
                targetInfoLabel.Visible = true;
            }
            
            targetInfoLabel.Text = targetName;
        }

    }
}
