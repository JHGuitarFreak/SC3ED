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
        public static void Artifacts()
        {
            Window.ChmmrArti.Checked = Functions.ReadOffsetBool(Vars.ChmmrArti[0]);
            Window.ChmmrArtiR.Checked = Functions.ReadOffsetBool(Vars.ChmmrArti[1], true);

            Window.ClairArti.Checked = Functions.ReadOffsetBool(Vars.ClairArti[0]);
            Window.ClairArtiR.Checked = Functions.ReadOffsetBool(Vars.ClairArti[1], true);

            Window.DoogArti.Checked = Functions.ReadOffsetBool(Vars.DoogArti[0]);
            Window.DoogArtiR.Checked = Functions.ReadOffsetBool(Vars.DoogArti[1], true);

            Window.ExquivanArti.Checked = Functions.ReadOffsetBool(Vars.ExquivanArti[0]);
            Window.ExquivanArtiR.Checked = Functions.ReadOffsetBool(Vars.ExquivanArti[1], true);

            Window.Mystery01Arti.Checked = Functions.ReadOffsetBool(Vars.Mystery01Arti[0]);
            Window.Mystery01ArtiR.Checked = Functions.ReadOffsetBool(Vars.Mystery01Arti[1], true);

            Window.HarikaArti.Checked = Functions.ReadOffsetBool(Vars.HarikaArti[0]);
            Window.HarikaArtiR.Checked = Functions.ReadOffsetBool(Vars.HarikaArti[1], true);

            Window.Mystery02Arti.Checked = Functions.ReadOffsetBool(Vars.Mystery02Arti[0]);
            Window.Mystery02ArtiR.Checked = Functions.ReadOffsetBool(Vars.Mystery02Arti[1], true);

            Window.HumanArti.Checked = Functions.ReadOffsetBool(Vars.HumanArti[0]);
            Window.HumanArtiR.Checked = Functions.ReadOffsetBool(Vars.HumanArti[1], true);

            Window.KohrAhArti.Checked = Functions.ReadOffsetBool(Vars.KohrAhArti[0]);
            Window.KohrAhArtiR.Checked = Functions.ReadOffsetBool(Vars.KohrAhArti[1], true);

            Window.Mystery03Arti.Checked = Functions.ReadOffsetBool(Vars.Mystery03Arti[0]);
            Window.Mystery03ArtiR.Checked = Functions.ReadOffsetBool(Vars.Mystery03Arti[1], true);

            Window.MyconArti.Checked = Functions.ReadOffsetBool(Vars.MyconArti[0]);
            Window.MyconArtiR.Checked = Functions.ReadOffsetBool(Vars.MyconArti[1], true);

            Window.OrzArti.Checked = Functions.ReadOffsetBool(Vars.OrzArti[0]);
            Window.OrzArtiR.Checked = Functions.ReadOffsetBool(Vars.OrzArti[1], true);

            Window.OwaArti.Checked = Functions.ReadOffsetBool(Vars.OwaArti[0]);
            Window.OwaArtiR.Checked = Functions.ReadOffsetBool(Vars.OwaArti[1], true);

            Window.PkunkArti.Checked = Functions.ReadOffsetBool(Vars.PkunkArti[0]);
            Window.PkunkArtiR.Checked = Functions.ReadOffsetBool(Vars.PkunkArti[1], true);

            Window.SpathiArti.Checked = Functions.ReadOffsetBool(Vars.SpathiArti[0]);
            Window.SpathiArtiR.Checked = Functions.ReadOffsetBool(Vars.SpathiArti[1], true);

            Window.SyreenArti.Checked = Functions.ReadOffsetBool(Vars.SyreenArti[0]);
            Window.SyreenArtiR.Checked = Functions.ReadOffsetBool(Vars.SyreenArti[1], true);

            Window.UrQuanArti.Checked = Functions.ReadOffsetBool(Vars.UrQuanArti[0]);
            Window.UrQuanArtiR.Checked = Functions.ReadOffsetBool(Vars.UrQuanArti[1], true);

            Window.UtwigArti.Checked = Functions.ReadOffsetBool(Vars.UtwigArti[0]);
            Window.UtwigArtiR.Checked = Functions.ReadOffsetBool(Vars.UtwigArti[1], true);

            Window.VuxArti.Checked = Functions.ReadOffsetBool(Vars.VuxArti[0]);
            Window.VuxArtiR.Checked = Functions.ReadOffsetBool(Vars.VuxArti[1], true);

            Window.VyroIngoArti.Checked = Functions.ReadOffsetBool(Vars.VyroIngoArti[0]);
            Window.VyroIngoArtiR.Checked = Functions.ReadOffsetBool(Vars.VyroIngoArti[1], true);

            Window.Mystery04Arti.Checked = Functions.ReadOffsetBool(Vars.Mystery04Arti[0]);
            Window.Mystery04ArtiR.Checked = Functions.ReadOffsetBool(Vars.Mystery04Arti[1], true);
        }
    }
}
