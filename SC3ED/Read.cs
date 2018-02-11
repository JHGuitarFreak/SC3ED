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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SC3ED
{
    partial class Read
    {
        public static FileStream Stream;
        public static Main Window;
        public static byte[] FileBuffer;

        public static void Open(string FileName, Main window)
        {
            if (!File.Exists(FileName))
            {
                MessageBox.Show("Could not find path: " + FileName);
                return;
            }

            Stream = new FileStream(FileName, FileMode.Open);
            int FileSize = (int)Stream.Length;  // get file length
            FileBuffer = new byte[FileSize];    // create buffer
            Window = window;

            ShipStatus();
            Crew();
            Devices();
            Artifacts();

            Stream.Close();
            Stream.Dispose();
        }    
    }    
}
