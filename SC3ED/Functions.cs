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

namespace SC3ED
{
    internal class Functions
    {    
        public static byte[] StringToByte(string String, int arrayLength){
            byte[] array = new byte[Math.Max(arrayLength, String.Length)];
            for (int i = 0; i < arrayLength; i++){
                array[i] = 0;
            }
            for (int j = 0; j < String.Length; j++){
                array[j] = (byte)String[j];
            }
            return array;
        }

        public static int ReadOffset(int Offset, int ByteLength, int Is16or32 = 32){
            Read.Stream.Seek(Offset, SeekOrigin.Begin);
            Read.Stream.Read(Read.FileBuffer, 0, ByteLength);
            int Query = (Is16or32 == 16) ? BitConverter.ToUInt16(Read.FileBuffer, 0) : BitConverter.ToInt32(Read.FileBuffer, 0);
            return Query;
        }
        public static bool ReadOffsetBool(int Offset, bool IsResearch = false){
            bool ReadBool;
            Read.Stream.Seek(Offset, SeekOrigin.Begin);
            Read.Stream.Read(Read.FileBuffer, 0, 1);
            if (IsResearch == true){
                ReadBool = (Read.FileBuffer[0] == 36) ? true : false;
            } else {
                ReadBool = (Read.FileBuffer[0] == 255) ? true : false;
            }
            return ReadBool;
        }

        public static void WriteOffset(int Offset, decimal SpinnerValue, int ByteLength, int Limit){
            Write.Stream.Seek(Offset, SeekOrigin.Begin);
            Write.Num = Decimal.ToInt32(SpinnerValue);
            if (Write.Num >= Limit){
                Write.Num = Limit;
            }
            Write.FileBuffer = BitConverter.GetBytes(Write.Num);
            Write.Stream.Write(Write.FileBuffer, 0, ByteLength);
        }
        public static void WriteOffsetBool(int Offset, bool Checked, bool IsResearch = false){
            Write.Stream.Seek(Offset, SeekOrigin.Begin);
            if (IsResearch == true){
                Write.Num = (Checked == true) ? 36 : 4;
            } else {
                Write.Num = (Checked == true) ? 255 : 254;
            }
            Write.FileBuffer = BitConverter.GetBytes(Write.Num);
            Write.Stream.Write(Write.FileBuffer, 0, 1);
        }
    }
}
