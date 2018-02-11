/*SC3ED: Star Control Kessari Quadrant Save Editor

Copyright (C) 2018 Serosis

This program is free software: you can redistribute it and/or modify  
it under the terms of the GNU General Public License as published by  
the Free Software Foundation, version 3.

This program is distributed in the hope that it will be useful, but 
WITHOUT ANY WARRANTY; without even the implied warranty of 
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU 
General Public License for more details.

You should have received a copy of the GNU General Public License 
along with this program. If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SC3ED
{
    partial class Write
    {
        public static void Devices()
        {
            Functions.WriteOffsetBool(Vars.ICOM[0], Write.Window.ICOM.Checked);
            Functions.WriteOffsetBool(Vars.VarianceKey[0], Write.Window.VarianceKey.Checked);

            Write.Stream.Seek(Vars.CrygncPloxis[0], SeekOrigin.Begin);
            Write.Num = (Write.Window.CrygncPloxis.Checked == true) ? 255 : 240;
            Write.FileBuffer = BitConverter.GetBytes(Write.Num);
            Write.Stream.Write(Write.FileBuffer, 0, 1);

            Functions.WriteOffsetBool(Vars.DaktakRecords[0], Write.Window.DaktakRecords.Checked);
            Functions.WriteOffsetBool(Vars.DakTranslator[0], Write.Window.DakTranslator.Checked);
            Functions.WriteOffsetBool(Vars.DmgdMmrnmhrm[0], Write.Window.DmgdMmrnmhrm.Checked);
            Functions.WriteOffsetBool(Vars.PrecDataPack[0], Write.Window.PrecDataPack.Checked);
            Functions.WriteOffsetBool(Vars.DaktakDataPack[0], Write.Window.DaktakDataPack.Checked);
            Functions.WriteOffsetBool(Vars.UltronPart[0], Write.Window.UltronPart.Checked);
            Functions.WriteOffsetBool(Vars.RprdMmrnmhrm[0], Write.Window.RprdMmrnmhrm.Checked);
            Functions.WriteOffsetBool(Vars.ConcRock[0], Write.Window.ConcRock.Checked);
            Functions.WriteOffsetBool(Vars.DeadConcRock[0], Write.Window.DeadConcRock.Checked);
            Functions.WriteOffsetBool(Vars.AntiMatter[0], Write.Window.AntiMatter.Checked);
            Functions.WriteOffsetBool(Vars.AntMttrScoop[0], Write.Window.AntMttrScoop.Checked);
            Functions.WriteOffsetBool(Vars.OwaAntMttrVssl[0], Write.Window.OwaAntMttrVssl.Checked);
            Functions.WriteOffsetBool(Vars.CrshdPrecShip[0], Write.Window.CrshdPrecShip.Checked);
            Functions.WriteOffsetBool(Vars.ChenjesuMinds[0], Write.Window.ChenjesuMinds.Checked);
            Functions.WriteOffsetBool(Vars.Unknown[0], Write.Window.Unknown.Checked);
            Functions.WriteOffsetBool(Vars.SunDevice[0], Write.Window.SunDevice.Checked);
            Functions.WriteOffsetBool(Vars.MndlssTchTeam[0], Write.Window.MndlssTchTeam.Checked);

            Functions.WriteOffsetBool(Vars.Ultron[0], Write.Window.Ultron.Checked);
            
            if(Write.Window.Ultron.Checked == true){
                Write.Stream.Seek(Vars.Ultron[1], SeekOrigin.Begin);
                if (Write.Window.UltronStatus.Value == 1) {
                    Write.Num = 64;
                } else if (Write.Window.UltronStatus.Value == 2){
                    Write.Num = 68;
                } else if (Write.Window.UltronStatus.Value == 3){
                    Write.Num = 192;
                } else {                
                    Write.Num = 0;
                }
                Write.FileBuffer = BitConverter.GetBytes(Write.Num);
                Write.Stream.Write(Write.FileBuffer, 0, 1);
            } else {                
                Write.Stream.Seek(Vars.Ultron[1], SeekOrigin.Begin);
                Write.Num = 0;
                Write.FileBuffer = BitConverter.GetBytes(Write.Num);
                Write.Stream.Write(Write.FileBuffer, 0, 1);
            }

            Functions.WriteOffsetBool(Vars.VuxDNAMatrix[0], Write.Window.VuxDNAMatrix.Checked);
            Functions.WriteOffsetBool(Vars.VyroIngoMtrx[0], Write.Window.VyroIngoMtrx.Checked);
            Functions.WriteOffsetBool(Vars.CombinedMtrx[0], Write.Window.CombinedMtrx.Checked);
            Functions.WriteOffsetBool(Vars.XchagAbsorber[0], Write.Window.XchagAbsorber.Checked);
            Functions.WriteOffsetBool(Vars.ComatoseHarika[0], Write.Window.ComatoseHarika.Checked);
            Functions.WriteOffsetBool(Vars.AntMttrGrid[0], Write.Window.AntMttrGrid.Checked);
            Functions.WriteOffsetBool(Vars.ChmmrSplitter[0], Write.Window.ChmmrSplitter.Checked);
            Functions.WriteOffsetBool(Vars.KTangContainer[0], Write.Window.KTangContainer.Checked);
            Functions.WriteOffsetBool(Vars.XchaggerSerum[0], Write.Window.XchaggerSerum.Checked);
            Functions.WriteOffsetBool(Vars.MArkCntrlUnit[0], Write.Window.MArkCntrlUnit.Checked);
            Functions.WriteOffsetBool(Vars.PlsmaRegroover[0], Write.Window.PlsmaRegroover.Checked);
            Functions.WriteOffsetBool(Vars.BrassRatchet[0], Write.Window.BrassRatchet.Checked);
            Functions.WriteOffsetBool(Vars.SgnlDeflector[0], Write.Window.SgnlDeflector.Checked);
            Functions.WriteOffsetBool(Vars.SntnceThresher[0], Write.Window.SntnceThresher.Checked);
            Functions.WriteOffsetBool(Vars.SntnceCollator[0], Write.Window.SntnceCollator.Checked);
            Functions.WriteOffsetBool(Vars.SntnceNotation[0], Write.Window.SntnceNotation.Checked);
            Functions.WriteOffsetBool(Vars.SntntEnrgyCllctr[0], Write.Window.SntntEnrgyCllctr.Checked);
            Functions.WriteOffsetBool(Vars.XchaggerHives[0], Write.Window.XchaggerHives.Checked);
            Functions.WriteOffsetBool(Vars.IvorySheath[0], Write.Window.IvorySheath.Checked);
            Functions.WriteOffsetBool(Vars.MarbleFlange[0], Write.Window.MarbleFlange.Checked);
            Functions.WriteOffsetBool(Vars.PlateCrystal[0], Write.Window.PlateCrystal.Checked);
            Functions.WriteOffsetBool(Vars.RedSpiralRail[0], Write.Window.RedSpiralRail.Checked);
            Functions.WriteOffsetBool(Vars.EbonHinge[0], Write.Window.EbonHinge.Checked);
            Functions.WriteOffsetBool(Vars.Ortog[0], Write.Window.Ortog.Checked);
        }
    }
}
