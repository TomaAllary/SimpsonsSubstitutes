using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheThingAboutTheSimpsons {
    public partial class MainForm : Form {
        private FormAboutUs aboutUs = new FormAboutUs();
        private FormOurMission ourMission = new FormOurMission();

        Dictionary<string, string> charactersSubdtitutes = new Dictionary<string, string>();

        CharactersSet SimpsonsCharacters;
        CharactersSet SubstituteCharacters;

        Episode episode;
        private int episodeIt;
        private Point position = new Point();
        

        public MainForm() {

            InitializeComponent();
            ourMission.setMainMenu(this);
            ourMission.setPosition();
            aboutUs.setMainMenu(this);
            aboutUs.setPosition();
        }

        public void LoadRdmEpisode() {
            string text = System.IO.File.ReadAllText("summaries.txt");
            List<Episode> episodes = new List<Episode>();

            text = text.ToLower();
            int it = -1;
            while (text != "") {
                string line = text.Substring(0, text.IndexOf('\n'));
                if (line.Contains('#')) {
                    it++;

                    var i = line.IndexOf('#');
                    string epName = line.Substring(0, i - 2);
                    string date = line.Substring(line.IndexOf('\t') + 1).TrimEnd('\r');

                    episodes.Add(new Episode(epName, date, it + 1));
                }
                else {
                    //Console.WriteLine(line);
                    episodes[it].summary = line;
                }
                text = text.Remove(0, text.IndexOf('\n') + 1);
            }

            Random rnd = new Random();
            episode = episodes[rnd.Next(0, episodes.Count - 1)];
        }

        public void LoadCharactersSet(string setName) {

        }

        private void submitBtn_Click(object sender, EventArgs e) {
            LoadRdmEpisode();
            ChangeCharacters();
        }

        public void ChangeCharacters() {
            if (SubstituteCharacters == null)
                SubstituteCharacters = SimpsonsCharacters;

            foreach(string name in SimpsonsCharacters.charactersName) {
                if (episode.summary.Contains(name)) {
                    //random substitute
                    if (!charactersSubdtitutes.ContainsKey(name)) {
                        Random rnd = new Random();
                        charactersSubdtitutes.Add(name, SubstituteCharacters.charactersName[rnd.Next(0, SubstituteCharacters.charactersName.Count - 1)]);
                    }
                    episode.summary.Replace(name, charactersSubdtitutes[name]);

                }
                if (episode.summary.Contains(name + "'s")) {
                    //random substitute
                    if (!charactersSubdtitutes.ContainsKey(name)) {
                        Random rnd = new Random();
                        charactersSubdtitutes.Add(name, SubstituteCharacters.charactersName[rnd.Next(0, SubstituteCharacters.charactersName.Count - 1)]);
                    }
                    episode.summary.Replace(name + "'s", charactersSubdtitutes[name] + "'s");

                }
            }
        }

        private void aboutUsBtn_Click(object sender, EventArgs e)
        {
            aboutUs.setPosition();
            this.Hide();
            aboutUs.Show();
        }

        private void ourMissionBtn_Click(object sender, EventArgs e)
        {
            ourMission.setPosition();
            this.Hide();
            ourMission.Show();
        }

        public void setPosition(Form lastForm) {
            position.X = lastForm.Location.X;
            position.Y = lastForm.Location.Y;
            this.Location = position;
        }

        private void showEpisode() {
            episodeViewer1.Title.Text = episode.Title;
            episodeViewer1.episodeNbLb.Text = "Episode #" + episode.EpisodeNb.ToString();
            episodeViewer1.seasonNbLb.Text = "Season #" + episode.Season.ToString();
            episodeViewer1.dateLb.Text = episode.Date;
            episodeViewer1.summaryLb.Text = episode.summary;
        }



    }
}
