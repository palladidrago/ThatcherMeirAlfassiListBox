using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace ThatcherSongListBox___Ashi_Alfassi__Meir_Di_Capua
{
    public partial class SongListBox : Form
    {
        public SongListBox()
        {
            InitializeComponent();
            player = new SoundPlayer();
        }
        SoundPlayer player;

        private int HeightSum()
        {
            return lyricBox.ItemHeight * lyricBox.Items.Count;
        }

        private async void SongPlay(object sender, EventArgs e)
        {
            //Plays a song and shows its' lyrics.
            //Take song from button text.

            string song = (sender as Button).Text.Replace(" ","");
            
            
            //Start player.
            Stream s = Properties.Resources.ResourceManager.GetObject(song) as Stream;
            player.Stream = s;
            player.Play();

            //Disable button.
            ((Button)sender).Enabled = false;

            //Save bottom and item height for later use.
            int formHeight = this.Height;
            int lyricBoxItemHeight = lyricBox.ItemHeight;

            //Load song lyrics.
            string songLyrics = Properties.Resources.ResourceManager.GetObject(song + "Lyrics") as String;
            string[] songLines = System.Text.RegularExpressions.Regex.Split(songLyrics, Environment.NewLine);

            //Starting time, and vars.
            int startTime = int.Parse(songLines[0]);
            await Task.Delay(startTime);
            int prevTime = startTime, curTime;

            //Lyric showing
            for (int i = 1; i < songLines.Length; i += 2)
            {
                lyricBox.Items.Add(songLines[i]);
                lyricBox.SelectedIndex = lyricBox.Items.Count - 1;
                if (HeightSum() > lyricBox.Height && lyricBox.Bottom < formHeight - lyricBoxItemHeight * 2)
                {
                    lyricBox.Height += lyricBoxItemHeight;
                }
                curTime = int.Parse(songLines[i + 1]);
                await Task.Delay(curTime - prevTime);
                prevTime = curTime;
            }
            ((Button)sender).Enabled = false;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Explanation: Click the button to play iCarly's intro, and the lyrics will be shown in the listbox";
        }
    }
}
