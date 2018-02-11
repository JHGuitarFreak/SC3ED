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
		public static void Crew()
		{
			Functions.WriteOffset(Vars.ArilouCrew, Window.ArilouCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.ChmmrCrew, Window.ChmmrCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.ClairCrew, Window.ClairCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.DaktakCrew, Window.DaktakCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.DoogCrew, Window.DoogCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.ExquivanCrew, Window.ExquivanCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.GreenMyconCrew, Window.GreenMyconCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.HarikaCrew, Window.HarikaCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.HeraldCrew, Window.HeraldCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.HumanCrew, Window.HumanCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.KohrAhCrew, Window.KohrAhCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.KTangCrew, Window.KTangCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.LkCrew, Window.LkCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.MyconCrew, Window.MyconCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.OrtogCrew, Window.OrtogCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.OrzCrew, Window.OrzCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.OwaCrew, Window.OwaCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.PkunkCrew, Window.PkunkCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.PloxisCrew, Window.PloxisCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.PloxCEOCrew, Window.PloxCEOCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.SpathiCrew, Window.SpathiCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.SyreenCrew, Window.SyreenCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.ArilouCrew, Window.ArilouCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.UrQuanCrew, Window.UrQuanCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.UtwigCrew, Window.UtwigCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.VuxCrew, Window.VuxCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.VyroIngoCrew, Window.VyroIngoCrew.Value, 4, 9999);
			Functions.WriteOffset(Vars.XchaggCrew, Window.XchaggCrew.Value, 4, 9999);
		}
	}
}
