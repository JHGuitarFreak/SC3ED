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
        public static void ShipStatus()
        {
            // Save Name
            Stream.Seek(Vars.SaveName, SeekOrigin.Begin);
            Stream.Read(FileBuffer, 0, 78);
            Window.SaveName.Text = Encoding.UTF8.GetString(FileBuffer);
            
            Window.Clock.Value = Functions.ReadOffset(Vars.Clock, 2, 16);
            Window.CurrentDay.Value = (Functions.ReadOffset(Vars.CurrentDay, 2, 16) + 1);

            Window.ResUnits.Value = Functions.ReadOffset(Vars.ResUnits, 4);
            Window.Fuel.Value = Functions.ReadOffset(Vars.Fuel, 4);
            Window.LandingPods.Value = Functions.ReadOffset(Vars.LandingPods, 4);

            
            Stream.Seek(Vars.CurrentStar, SeekOrigin.Begin);
            Stream.Read(FileBuffer, 0, 1);
            Window.CurrentStar.SelectedIndex = FileBuffer[0];
        }
    }
}
