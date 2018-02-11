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
		public static void Artifacts()
		{
			Functions.WriteOffsetBool(Vars.ChmmrArti[0], Window.ChmmrArti.Checked);
			Functions.WriteOffsetBool(Vars.ChmmrArti[1], Window.ChmmrArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.ClairArti[0], Window.ClairArti.Checked);
			Functions.WriteOffsetBool(Vars.ClairArti[1], Window.ClairArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.DoogArti[0], Window.DoogArti.Checked);
			Functions.WriteOffsetBool(Vars.DoogArti[1], Window.DoogArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.ExquivanArti[0], Window.ExquivanArti.Checked);
			Functions.WriteOffsetBool(Vars.ExquivanArti[1], Window.ExquivanArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.Mystery01Arti[0], Window.Mystery01Arti.Checked);
			Functions.WriteOffsetBool(Vars.Mystery01Arti[1], Window.Mystery01ArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.HarikaArti[0], Window.HarikaArti.Checked);
			Functions.WriteOffsetBool(Vars.HarikaArti[1], Window.HarikaArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.Mystery02Arti[0], Window.Mystery02Arti.Checked);
			Functions.WriteOffsetBool(Vars.Mystery02Arti[1], Window.Mystery02ArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.HumanArti[0], Window.HumanArti.Checked);
			Functions.WriteOffsetBool(Vars.HumanArti[1], Window.HumanArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.KohrAhArti[0], Window.KohrAhArti.Checked);
			Functions.WriteOffsetBool(Vars.KohrAhArti[1], Window.KohrAhArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.Mystery03Arti[0], Window.Mystery03Arti.Checked);
			Functions.WriteOffsetBool(Vars.Mystery03Arti[1], Window.Mystery03ArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.MyconArti[0], Window.MyconArti.Checked);
			Functions.WriteOffsetBool(Vars.MyconArti[1], Window.MyconArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.OrzArti[0], Window.OrzArti.Checked);
			Functions.WriteOffsetBool(Vars.OrzArti[1], Window.OrzArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.OwaArti[0], Window.OwaArti.Checked);
			Functions.WriteOffsetBool(Vars.OwaArti[1], Window.OwaArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.PkunkArti[0], Window.PkunkArti.Checked);
			Functions.WriteOffsetBool(Vars.PkunkArti[1], Window.PkunkArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.SpathiArti[0], Window.SpathiArti.Checked);
			Functions.WriteOffsetBool(Vars.SpathiArti[1], Window.SpathiArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.SyreenArti[0], Window.SyreenArti.Checked);
			Functions.WriteOffsetBool(Vars.SyreenArti[1], Window.SyreenArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.UrQuanArti[0], Window.UrQuanArti.Checked);
			Functions.WriteOffsetBool(Vars.UrQuanArti[1], Window.UrQuanArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.UtwigArti[0], Window.UtwigArti.Checked);
			Functions.WriteOffsetBool(Vars.UtwigArti[1], Window.UtwigArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.VuxArti[0], Window.VuxArti.Checked);
			Functions.WriteOffsetBool(Vars.VuxArti[1], Window.VuxArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.VyroIngoArti[0], Window.VyroIngoArti.Checked);
			Functions.WriteOffsetBool(Vars.VyroIngoArti[1], Window.VyroIngoArtiR.Checked, true);

			Functions.WriteOffsetBool(Vars.Mystery04Arti[0], Window.Mystery04Arti.Checked);
			Functions.WriteOffsetBool(Vars.Mystery04Arti[1], Window.Mystery04ArtiR.Checked, true);
		}
	}
}
