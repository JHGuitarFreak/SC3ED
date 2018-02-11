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
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using Microsoft.Win32;

namespace SC3ED
{
	public partial class Main : Form
	{
		private string CurrentDir;
		private string CurrentFile = "";
		public static string FileName = "";
		RegistryKey localKey;

		public Main() {
			InitializeComponent();
			GOGDir();
			Object[] items = StarSystem.StarList();
			foreach (StarSystem item in items)
			{
				CurrentStar.Items.Add(item.Text);
			}
		}


		private void GOGDir(){
			if (Environment.Is64BitOperatingSystem) {
				localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			} else {
				localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
			}

			if (localKey.OpenSubKey("SOFTWARE\\GOG.com\\GOGSC3") != null) {
				CurrentDir = localKey.OpenSubKey("SOFTWARE\\GOG.com\\GOGSC3").GetValue("PATH").ToString() + "STARCON3";
			} else {
				CurrentDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			}        
		}

		private void OpenFile(object sender, EventArgs e) {

			System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
			openFileDialog.Title = "Open Save File";
			openFileDialog.Filter = "Save File (*.SAV)|*.SAV";
			openFileDialog.InitialDirectory = CurrentDir;

			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				CurrentFile = openFileDialog.FileName;
				FileName = Path.GetFileName(CurrentFile);
				this.Text = "Star Control 3 Editor - " + FileName;
				this.Reload.Enabled = true;
				this.Save.Enabled = true;
				this.tabControl1.Enabled = true;

				Read.Open(CurrentFile, this);
				CurrentDir = CurrentFile;
			}
		}

		private void ReloadFile(object sender, EventArgs e) {
			Read.Open(CurrentFile, this);
		}

		private void SaveChanges(object sender, EventArgs e) {
			Write.Save(CurrentFile, this);
		}

		private void ExitProgram(object sender, EventArgs e) {
			Application.Exit();
		}


		private void UltronStatusChanged(object sender, EventArgs e) {
			if (UltronStatus.Value == 1){
				Ultron.Text = "Ultron (Half Fixed)";
			} else if (UltronStatus.Value == 2){
				Ultron.Text = "Ultron (Almost There)";
			} else if (UltronStatus.Value == 3){
				Ultron.Text = "Ultron (Fixed)";
			} else {
				Ultron.Text = "Ultron (Broken)";
			}
		}

		private void UltronChecked(object sender, EventArgs e) {
			if (Ultron.Checked == false){
				UltronStatus.Value = 0;
			}
		}

		private void MaxOutCrew(object sender, EventArgs e)
		{
			foreach(Control control in tabCrew.Controls)
			{
				if(control.GetType() == typeof(NumericUpDown))
				{
					NumericUpDown NumUpDown = (NumericUpDown)control;
					NumUpDown.Value = 9999;
				}
			}   
		}

		private void HaveAllDevices(object sender, EventArgs e)
		{
			foreach(Control control in DevicesPage1.Controls)
			{
				if(control.GetType() == typeof(CheckBox))
				{
					CheckBox checkbox = (CheckBox)control;
					checkbox.Checked = true;
				}
			} 
			foreach(Control control in DevicesPage2.Controls)
			{
				if(control.GetType() == typeof(CheckBox))
				{
					CheckBox checkbox = (CheckBox)control;
					checkbox.Checked = true;
				}
			}    

		}

		private void HaveAllArtifacts(object sender, EventArgs e)
		{
			foreach(Control control in tabArtifacts.Controls)
			{
				if(control.GetType() == typeof(CheckBox))
				{
					CheckBox checkbox = (CheckBox)control;
					checkbox.Checked = true;
				}
			}       
		}
		private void MaxItOut(object sender, EventArgs e)
		{
			Fuel.Value = 99999999;
			ResUnits.Value = 99999999;
			LandingPods.Value = 99999999;
		}
	}
}
