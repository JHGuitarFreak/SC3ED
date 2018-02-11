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
using System.Collections.Generic;

namespace SC3ED
{
	class Vars
	{
		public byte HexCode { get; private set; }
		public string Text { get; private set; }

		// Offsets
		public const byte SaveName = 0;

		public const byte Clock = 80;
		public const byte CurrentDay = 82;

		public const byte CurrentStar = 88;

		//Crew
		public const short ArilouCrew = 12396;
		public const short ChmmrCrew = 12404;
		public const short ClairCrew = 12412;
		public const short DaktakCrew = 12420;
		public const short DoogCrew = 12428;
		public const short ExquivanCrew = 12436;
		public const short GreenMyconCrew = 12444;
		public const short HarikaCrew = 12452;
		public const short HeraldCrew = 12460;
		public const short HumanCrew = 12468;
		public const short KohrAhCrew = 12476;
		public const short KTangCrew = 12484;
		public const short LkCrew = 12492;
		public const short MyconCrew = 12500;
		public const short OrtogCrew = 12508;
		public const short OrzCrew = 12516;
		public const short OwaCrew = 12524;
		public const short PkunkCrew = 12532;
		public const short PloxisCrew = 12540;
		public const short PloxCEOCrew = 12548;
		public const short SpathiCrew = 12556;
		public const short SyreenCrew = 12564;
		public const short UrQuanCrew = 12572;
		public const short UtwigCrew = 12580;
		public const short VuxCrew = 12588;
		public const short VyroIngoCrew = 12596;
		public const short XchaggCrew = 12604;

		//Ship Status
		public const short LandingPods = 12828;
		public const short ResUnits = 12964;
		public const short Fuel = 12972;

		//Devices
		// I do not know if the second byte is used for all devices but it is here just in case
		public static int[] ICOM = { 12832, 12834 };
		public static int[] VarianceKey = { 12840, 12842 };
		public static int[] CrygncPloxis = { 12848, 12850 };
		public static int[] DaktakRecords = { 12856, 12858 };
		public static int[] DakTranslator = { 12864, 12866 };
		public static int[] DmgdMmrnmhrm = { 12872, 12874 };
		public static int[] PrecDataPack = { 12880, 12882 };
		public static int[] DaktakDataPack = { 12888, 12890 };
		public static int[] UltronPart = { 12896, 12898 };
		public static int[] RprdMmrnmhrm = { 12904, 12906 };
		public static int[] ConcRock = { 12912, 12914 };
		public static int[] DeadConcRock = { 12920, 12922 };
		public static int[] AntiMatter = { 12928, 12930 };
		public static int[] AntMttrScoop = { 12936, 12938 };
		public static int[] OwaAntMttrVssl = { 12944, 12946 };
		public static int[] CrshdPrecShip = { 12952, 12954 };
		public static int[] ChenjesuMinds = { 12976, 12978 };
		public static int[] Unknown = { 12984, 12986 };
		public static int[] SunDevice = { 12992, 12994 };
		public static int[] MndlssTchTeam = { 13000, 13002 };
		public static int[] Ultron = { 13008, 13010 }; // 2nd Byte 00-Broken 40-Partially Fixed C0-Fixed
		public static int[] VuxDNAMatrix = { 13016, 13018 };
		public static int[] VyroIngoMtrx = { 13024, 13026 };
		public static int[] CombinedMtrx = { 13032, 13034 };
		public static int[] XchagAbsorber = { 13040, 13042 };
		public static int[] ComatoseHarika = { 13048, 13050 };
		public static int[] AntMttrGrid = { 13056, 13058, 13060 }; // 3rd Byte for Grid Capacity
		public static int[] ChmmrSplitter = { 13064, 13066 };
		public static int[] KTangContainer = { 13072, 13074 };
		public static int[] XchaggerSerum = { 13080, 13082 };
		public static int[] MArkCntrlUnit = { 13088, 13090 };
		public static int[] PlsmaRegroover = { 13096, 13098 };
		public static int[] BrassRatchet = { 13104, 13106 };
		public static int[] SgnlDeflector = { 13112, 13114 };
		public static int[] SntnceThresher = { 13120, 13122 };
		public static int[] SntnceCollator = { 13128, 13130 };
		public static int[] SntnceNotation = { 13136, 13138 };
		public static int[] SntntEnrgyCllctr = { 13144, 13146 };
		public static int[] XchaggerHives = { 13152, 13154 };
		public static int[] IvorySheath = { 13160, 13162 };
		public static int[] MarbleFlange = { 13168, 13170 };
		public static int[] PlateCrystal = { 13176, 13178 };
		public static int[] RedSpiralRail = { 13184, 13186 };
		public static int[] EbonHinge = { 13192, 13194 };
		public static int[] Ortog = { 13200, 13202 };

		//Artifacts //2nd byte 04-Not Researched 24-Researched
		public static int[] ChmmrArti = { 13208, 13210 };
		public static int[] ClairArti = { 13216, 13218 };
		public static int[] DoogArti = { 13224, 13226 };
		public static int[] ExquivanArti = { 13232, 13234 };
		public static int[] Mystery01Arti = { 13240, 13242 };
		public static int[] HarikaArti = { 13248, 13250 };
		public static int[] Mystery02Arti = { 13256, 13258 };
		public static int[] HumanArti = { 13264, 13266 };
		public static int[] KohrAhArti = { 13272, 13274 };
		public static int[] Mystery03Arti = { 13280, 13282 };
		public static int[] MyconArti = { 13288, 13290 };
		public static int[] OrzArti = { 13296, 13298 };
		public static int[] OwaArti = { 13304, 13306 };
		public static int[] PkunkArti = { 13312, 13314 };
		public static int[] SpathiArti = { 13320, 13322 };
		public static int[] SyreenArti = { 13328, 13330 };
		public static int[] UrQuanArti = { 13336, 13338 };
		public static int[] UtwigArti = { 13344, 13346 };
		public static int[] VuxArti = { 13352, 13354 };
		public static int[] VyroIngoArti = { 13360, 13362 };
		public static int[] Mystery04Arti = { 13368, 13370 };



		//Fleet
		public static int[] ColShip = { 20418, 20419, 20420, 20421, 20422 };

		//Star Systems
		public static int[] Velpunia = { };
		public static int[] VisitedStars = { 9399, 792, 5 }; 
		
	}
	class StarSystem
	{
		public byte HexCode { get; private set; }
		public string Text { get; private set; }

		public StarSystem(byte hexcode, string text)
		{
			HexCode = hexcode;
			Text = text;
		}
		
		public static object[] StarList()
		{
			object[] Stars = new object[] 
			{ 
				new StarSystem(0x00, "Acubens"),
				new StarSystem(0x01, "Adapa"),
				new StarSystem(0x02, "Adonis"),
				new StarSystem(0x03, "Aeolus"),
				new StarSystem(0x04, "Aesculapius"),
				new StarSystem(0x05, "Agapemone"),
				new StarSystem(0x06, "Agni"),
				new StarSystem(0x07, "Albireo"),
				new StarSystem(0x08, "Alioth"),
				new StarSystem(0x09, "Alkes"),
				new StarSystem(0x0A, "Aludra"),
				new StarSystem(0x0B, "Alula - Rainbow World"),
				new StarSystem(0x0C, "Anshar - Exquivan Homeworld"),
				new StarSystem(0x0D, "Antaeus"),
				new StarSystem(0x0E, "Apollon"),
				new StarSystem(0x0F, "Arcadia - Pkunk System"),
				new StarSystem(0x10, "Argus - K'tang Colony"),
				new StarSystem(0x11, "Ashur"),
				new StarSystem(0x12, "Asselus"),
				new StarSystem(0x13, "Astarte - Syreen System"),
				new StarSystem(0x14, "Atropos"),
				new StarSystem(0x15, "Aurora"),
				new StarSystem(0x16, "Azazel - Q-Space Portal G"),
				new StarSystem(0x17, "Begregren"),
				new StarSystem(0x18, "Benten"),
				new StarSystem(0x19, "Besta"),
				new StarSystem(0x1A, "Bluatis"),
				new StarSystem(0x1B, "Brona"),
				new StarSystem(0x1C, "Caduceus"),
				new StarSystem(0x1D, "Calliope"),
				new StarSystem(0x1E, "SysCalypso"),
				new StarSystem(0x1F, "Cassandra"),
				new StarSystem(0x20, "Cecrops"),
				new StarSystem(0x21, "Cerberus"),
				new StarSystem(0x22, "Ceres"),
				new StarSystem(0x23, "Charybdis"),
				new StarSystem(0x24, "Chloris"),
				new StarSystem(0x25, "Circinus"),
				new StarSystem(0x26, "Clotho"),
				new StarSystem(0x27, "Cronos - Clair System"),
				new StarSystem(0x28, "Cybele"),
				new StarSystem(0x29, "Daikoku"),
				new StarSystem(0x2A, "Daphne"),
				new StarSystem(0x2B, "Demeter"),
				new StarSystem(0x2C, "Dschubba"),
				new StarSystem(0x2D, "Eltanin - Anomaly 2"),
				new StarSystem(0x2E, "Enkidu - Clair Queen"),
				new StarSystem(0x2F, "Enlil"),
				new StarSystem(0x30, "Erato - Vux Renegade"),
				new StarSystem(0x31, "Ettenrub"),
				new StarSystem(0x32, "Eumenides"),
				new StarSystem(0x33, "Euterpe"),
				new StarSystem(0x34, "Faunus"),
				new StarSystem(0x35, "Fomalhaut - Utwig System"),
				new StarSystem(0x36, "Freya"),
				new StarSystem(0x37, "Ganesha"),
				new StarSystem(0x38, "Gienah"),
				new StarSystem(0x39, "Goshen - Spathi System"),
				new StarSystem(0x3A, "Hanuman"),
				new StarSystem(0x3B, "Hathor"),
				new StarSystem(0x3C, "Hecaton"),
				new StarSystem(0x3D, "Helios - Earthling System"),
				new StarSystem(0x3E, "Hestia"),
				new StarSystem(0x3F, "Houyhnhnm"),
				new StarSystem(0x40, "Horus"),
				new StarSystem(0x41, "Morgoth"),
				new StarSystem(0x42, "Hypnus - Chmmr System"),
				new StarSystem(0x43, "Indra - Rainbow World"),
				new StarSystem(0x44, "Izanagi - Vyro-Ingo Homeworld"),
				new StarSystem(0x45, "Izanami - Doog Colony"),
				new StarSystem(0x46, "Janus - Mycon System"),
				new StarSystem(0x47, "Juventas"),
				new StarSystem(0x48, "Kentaurus - Rainbow World"),
				new StarSystem(0x49, "Kreisa"),
				new StarSystem(0x4A, "Lachesis"),
				new StarSystem(0x4B, "Lakshmi"),
				new StarSystem(0x4C, "Lapita"),
				new StarSystem(0x4D, "Lares"),
				new StarSystem(0x4E, "Mahakala"),
				new StarSystem(0x4F, "Melpomene"),
				new StarSystem(0x50, "Merpenet"),
				new StarSystem(0x51, "Minerva"),
				new StarSystem(0x52, "Mnemosyne - Owa Homeworld"),
				new StarSystem(0x53, "Moirai"),
				new StarSystem(0x54, "Morpheus"),
				new StarSystem(0x55, "Muhlifain - Orz Colony"),
				new StarSystem(0x56, "Namluhs"),
				new StarSystem(0x57, "Nebusta"),
				new StarSystem(0x58, "Nekkar"),
				new StarSystem(0x59, "Niobe"),
				new StarSystem(0x5A, "Nyx - Q-Space Portal M"),
				new StarSystem(0x5B, "Osiris"),
				new StarSystem(0x5C, "Pauguk - K'tang Base"),
				new StarSystem(0x5D, "Penates"),
				new StarSystem(0x5E, "Picus - Anomaly 1"),
				new StarSystem(0x5F, "Polyhymnia"),
				new StarSystem(0x60, "Porrima"),
				new StarSystem(0x61, "Priapus"),
				new StarSystem(0x62, "Proserpina"),
				new StarSystem(0x63, "Rahu"),
				new StarSystem(0x64, "Rasalas"),
				new StarSystem(0x65, "Rendnil"),
				new StarSystem(0x66, "Rhiannon"),
				new StarSystem(0x67, "Rudra"),
				new StarSystem(0x68, "Sadatoni"),
				new StarSystem(0x69, "Salacia - Vux System"),
				new StarSystem(0x6A, "Sarasvati"),
				new StarSystem(0x6B, "Scylla"),
				new StarSystem(0x6C, "Secinus"),
				new StarSystem(0x6D, "Selene"),
				new StarSystem(0x6E, "Shaula"),
				new StarSystem(0x6F, "Silenus"),
				new StarSystem(0x70, "Tammuz"),
				new StarSystem(0x71, "Terebelum"),
				new StarSystem(0x72, "Terpsichore"),
				new StarSystem(0x73, "Themis"),
				new StarSystem(0x74, "Tractorus"),
				new StarSystem(0x75, "Tyche - Anomaly 3"),
				new StarSystem(0x76, "Typhon"),
				new StarSystem(0x77, "Velpunia - Ur-Quan System"),
				new StarSystem(0x78, "Vesta"),
				new StarSystem(0x79, "Victoria"),
				new StarSystem(0x7A, "Xipe - Q-Space Portal F"),
				new StarSystem(0x7B, "Xochipilli"),
				new StarSystem(0x7C, "Yelir"),
				new StarSystem(0x7D, "Yggdrasil"),
				new StarSystem(0x7E, "Zaniah"),
				new StarSystem(0x7F, "Zosma - Xchagger Homeworld"),
				new StarSystem(0x80, "QSM"),
				new StarSystem(0x81, "QSG"),
				new StarSystem(0x82, "QSF"),
				new StarSystem(0x83, "Highpoint"),
			};
			return Stars;
		}
	}
}
