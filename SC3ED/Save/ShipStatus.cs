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
		public static void ShipStatus()
		{
			// Save Name
			Stream.Seek(Vars.SaveName, SeekOrigin.Begin);
			FileBuffer = Functions.StringToByte(Window.SaveName.Text, 78);
			Stream.Write(FileBuffer, 0, 78);

			Functions.WriteOffset(Vars.Clock, Window.Clock.Value, 2, 65535);
			Functions.WriteOffset(Vars.CurrentDay, (Window.CurrentDay.Value - 1), 2, 65535);
			Functions.WriteOffset(Vars.ResUnits, Window.ResUnits.Value, 4, 99999999);
			Functions.WriteOffset(Vars.Fuel, Window.Fuel.Value, 4, 99999999);
			Functions.WriteOffset(Vars.LandingPods, Window.LandingPods.Value, 4, 99999999);

			
			Stream.Seek(Vars.CurrentStar, SeekOrigin.Begin);
			Num = (int)Window.CurrentStar.SelectedIndex;
			FileBuffer = BitConverter.GetBytes(Num);
			Stream.Write(FileBuffer, 0, 1);
		}
	}
}
