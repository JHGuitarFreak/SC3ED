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
        public static void Crew()
        {
            Window.ArilouCrew.Value = Functions.ReadOffset(Vars.ArilouCrew, 4);
            Window.ClairCrew.Value = Functions.ReadOffset(Vars.ClairCrew, 4);
            Window.DaktakCrew.Value = Functions.ReadOffset(Vars.DaktakCrew, 4);
            Window.DoogCrew.Value = Functions.ReadOffset(Vars.DoogCrew, 4);
            Window.ExquivanCrew.Value = Functions.ReadOffset(Vars.ExquivanCrew, 4);
            Window.GreenMyconCrew.Value = Functions.ReadOffset(Vars.GreenMyconCrew, 4);
            Window.HarikaCrew.Value = Functions.ReadOffset(Vars.HarikaCrew, 4);
            Window.HeraldCrew.Value = Functions.ReadOffset(Vars.HeraldCrew, 4);
            Window.HumanCrew.Value = Functions.ReadOffset(Vars.HumanCrew, 4);
            Window.KohrAhCrew.Value = Functions.ReadOffset(Vars.KohrAhCrew, 4);
            Window.KTangCrew.Value = Functions.ReadOffset(Vars.KTangCrew, 4);
            Window.LkCrew.Value = Functions.ReadOffset(Vars.LkCrew, 4);
            Window.MyconCrew.Value = Functions.ReadOffset(Vars.MyconCrew, 4);
            Window.OrtogCrew.Value = Functions.ReadOffset(Vars.OrtogCrew, 4);
            Window.OrzCrew.Value = Functions.ReadOffset(Vars.OrzCrew, 4);
            Window.OwaCrew.Value = Functions.ReadOffset(Vars.OwaCrew, 4);
            Window.PkunkCrew.Value = Functions.ReadOffset(Vars.PkunkCrew, 4);
            Window.PloxisCrew.Value = Functions.ReadOffset(Vars.PloxisCrew, 4);
            Window.PloxCEOCrew.Value = Functions.ReadOffset(Vars.PloxCEOCrew, 4);
            Window.SpathiCrew.Value = Functions.ReadOffset(Vars.SpathiCrew, 4);
            Window.SyreenCrew.Value = Functions.ReadOffset(Vars.SyreenCrew, 4);
            Window.UrQuanCrew.Value = Functions.ReadOffset(Vars.UrQuanCrew, 4);
            Window.UtwigCrew.Value = Functions.ReadOffset(Vars.UtwigCrew, 4);
            Window.VuxCrew.Value = Functions.ReadOffset(Vars.VuxCrew, 4);
            Window.VyroIngoCrew.Value = Functions.ReadOffset(Vars.VyroIngoCrew, 4);
            Window.ArilouCrew.Value = Functions.ReadOffset(Vars.ArilouCrew, 4);
            Window.XchaggCrew.Value = Functions.ReadOffset(Vars.XchaggCrew, 4);
        }
    }
}
