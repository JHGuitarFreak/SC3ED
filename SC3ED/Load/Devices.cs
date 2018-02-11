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
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace SC3ED
{
	partial class Read
	{
		public static void Devices()
		{
			Window.ICOM.Checked = Functions.ReadOffsetBool(Vars.ICOM[0]);
			Window.VarianceKey.Checked = Functions.ReadOffsetBool(Vars.VarianceKey[0]);
			Window.CrygncPloxis.Checked = Functions.ReadOffsetBool(Vars.CrygncPloxis[0]);
			Window.DaktakRecords.Checked = Functions.ReadOffsetBool(Vars.DaktakRecords[0]);
			Window.DakTranslator.Checked = Functions.ReadOffsetBool(Vars.DakTranslator[0]);
			Window.DmgdMmrnmhrm.Checked = Functions.ReadOffsetBool(Vars.DmgdMmrnmhrm[0]);
			Window.PrecDataPack.Checked = Functions.ReadOffsetBool(Vars.PrecDataPack[0]);
			Window.DaktakDataPack.Checked = Functions.ReadOffsetBool(Vars.DaktakDataPack[0]);
			Window.UltronPart.Checked = Functions.ReadOffsetBool(Vars.UltronPart[0]);
			Window.RprdMmrnmhrm.Checked = Functions.ReadOffsetBool(Vars.RprdMmrnmhrm[0]);
			Window.ConcRock.Checked = Functions.ReadOffsetBool(Vars.ConcRock[0]);
			Window.DeadConcRock.Checked = Functions.ReadOffsetBool(Vars.DeadConcRock[0]);
			Window.AntiMatter.Checked = Functions.ReadOffsetBool(Vars.AntiMatter[0]);
			Window.AntMttrScoop.Checked = Functions.ReadOffsetBool(Vars.AntMttrScoop[0]);
			Window.OwaAntMttrVssl.Checked = Functions.ReadOffsetBool(Vars.OwaAntMttrVssl[0]);
			Window.CrshdPrecShip.Checked = Functions.ReadOffsetBool(Vars.CrshdPrecShip[0]);
			Window.ChenjesuMinds.Checked = Functions.ReadOffsetBool(Vars.ChenjesuMinds[0]);
			Window.Unknown.Checked = Functions.ReadOffsetBool(Vars.Unknown[0]);
			Window.SunDevice.Checked = Functions.ReadOffsetBool(Vars.SunDevice[0]);
			Window.MndlssTchTeam.Checked = Functions.ReadOffsetBool(Vars.MndlssTchTeam[0]);

			Window.Ultron.Checked = Functions.ReadOffsetBool(Vars.Ultron[0]);
			if(Functions.ReadOffsetBool(Vars.Ultron[0]) == true){
				Stream.Seek(Vars.Ultron[1], SeekOrigin.Begin);
				Stream.Read(FileBuffer, 0, 1);
				if (FileBuffer[0] == 64) {
					Window.UltronStatus.Value = 1;
				} else if (FileBuffer[0] == 68){
					Window.UltronStatus.Value = 2;
				} else if (FileBuffer[0] == 192){
					Window.UltronStatus.Value = 3;
				} else {                
					Window.UltronStatus.Value = 0;
				}
			}

			Window.VuxDNAMatrix.Checked = Functions.ReadOffsetBool(Vars.VuxDNAMatrix[0]);
			Window.VyroIngoMtrx.Checked = Functions.ReadOffsetBool(Vars.VyroIngoMtrx[0]);
			Window.CombinedMtrx.Checked = Functions.ReadOffsetBool(Vars.CombinedMtrx[0]);
			Window.XchagAbsorber.Checked = Functions.ReadOffsetBool(Vars.XchagAbsorber[0]);
			Window.ComatoseHarika.Checked = Functions.ReadOffsetBool(Vars.ComatoseHarika[0]);

			Window.AntMttrGrid.Checked = Functions.ReadOffsetBool(Vars.AntMttrGrid[0]);
			if (Functions.ReadOffsetBool(Vars.AntMttrGrid[0]) == true)
			{
				Window.AntMttrGridCpcty.Value = Functions.ReadOffset(Vars.AntMttrGrid[2], 4);
			}

			Window.ChmmrSplitter.Checked = Functions.ReadOffsetBool(Vars.ChmmrSplitter[0]);
			Window.KTangContainer.Checked = Functions.ReadOffsetBool(Vars.KTangContainer[0]);
			Window.XchaggerSerum.Checked = Functions.ReadOffsetBool(Vars.XchaggerSerum[0]);
			Window.MArkCntrlUnit.Checked = Functions.ReadOffsetBool(Vars.MArkCntrlUnit[0]);
			Window.PlsmaRegroover.Checked = Functions.ReadOffsetBool(Vars.PlsmaRegroover[0]);
			Window.BrassRatchet.Checked = Functions.ReadOffsetBool(Vars.BrassRatchet[0]);
			Window.SgnlDeflector.Checked = Functions.ReadOffsetBool(Vars.SgnlDeflector[0]);
			Window.SntnceThresher.Checked = Functions.ReadOffsetBool(Vars.SntnceThresher[0]);
			Window.SntnceCollator.Checked = Functions.ReadOffsetBool(Vars.SntnceCollator[0]);
			Window.SntnceNotation.Checked = Functions.ReadOffsetBool(Vars.SntnceNotation[0]);
			Window.SntntEnrgyCllctr.Checked = Functions.ReadOffsetBool(Vars.SntntEnrgyCllctr[0]);
			Window.XchaggerHives.Checked = Functions.ReadOffsetBool(Vars.XchaggerHives[0]);
			Window.IvorySheath.Checked = Functions.ReadOffsetBool(Vars.IvorySheath[0]);
			Window.MarbleFlange.Checked = Functions.ReadOffsetBool(Vars.MarbleFlange[0]);
			Window.PlateCrystal.Checked = Functions.ReadOffsetBool(Vars.PlateCrystal[0]);
			Window.RedSpiralRail.Checked = Functions.ReadOffsetBool(Vars.RedSpiralRail[0]);
			Window.EbonHinge.Checked = Functions.ReadOffsetBool(Vars.EbonHinge[0]);
			Window.Ortog.Checked = Functions.ReadOffsetBool(Vars.Ortog[0]);
		}
	}
}
