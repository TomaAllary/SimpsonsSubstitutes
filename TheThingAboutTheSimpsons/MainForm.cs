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

            LoadSimpsonsCharactersSet();
            LoadCharactersSet("southpark.txt");

            InitializeComponent();
            ourMission.setMainMenu(this);
            ourMission.setPosition();
            aboutUs.setMainMenu(this);
            aboutUs.setPosition();
        }

        public void LoadRdmEpisode() {
            charactersSubdtitutes.Clear();
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
                    episodes[it].summary = " " + line;
                }
                text = text.Remove(0, text.IndexOf('\n') + 1);
            }

            Random rnd = new Random();
            episode = episodes[rnd.Next(0, episodes.Count - 1)];
        }

        private void LoadSimpsonsCharactersSet() {
            SimpsonsCharacters = new CharactersSet("Simpsons");
            List<string> listSim = new List<string>();
            string[] longtextSim = System.IO.File.ReadAllLines("simpsons.txt");
            for (int i = 0; i < longtextSim.Length; i++) {
                listSim.Add(" " + longtextSim[i].Remove(longtextSim[i].IndexOf('\t')).ToLower());
            }
            SimpsonsCharacters.charactersName = listSim;
        }

        public void LoadCharactersSet(string setName) {
            SubstituteCharacters = new CharactersSet(setName.Substring(0, setName.Length - 5));

            List<string> listSim = new List<string>();
            string[] longtextSim = System.IO.File.ReadAllLines(setName);
            for (int i = 0; i < longtextSim.Length; i++) {
                listSim.Add(" " + longtextSim[i].Remove(longtextSim[i].IndexOf('\t')));
            }
            SubstituteCharacters.charactersName = listSim;
        }
        public void LoadPokemonsCharactersSet() {
            SubstituteCharacters = new CharactersSet("Pokemon");
            List<string> listPok = new List<string>();
            string[] longtextPok = System.IO.File.ReadAllLines("pokemon.txt");
            for (int i = 0; i < longtextPok.Length; i++) {
                longtextPok[i] = longtextPok[i].Remove(0, 12);
                listPok.Add(" " + longtextPok[i].Remove(longtextPok[i].IndexOf('\t')));
            }
            SubstituteCharacters.charactersName = listPok;
        }

        private void submitBtn_Click(object sender, EventArgs e) {
            LoadRdmEpisode();
            ChangeCharacters();
            showEpisode();
        }

        public void ChangeCharacters() {
            if (SubstituteCharacters == null)
                SubstituteCharacters = SimpsonsCharacters;
            Random rnd = new Random();

            foreach (string name in SimpsonsCharacters.charactersName) {
                if (episode.summary.Contains(name)) {
                    if ((name == " simpsons" || name == " simpson family") && SubstituteCharacters.GroupName != null) {
                        episode.summary = episode.summary.Replace(name, SubstituteCharacters.GroupName);
                    }
                    else {
                        //random substitute
                        if (!charactersSubdtitutes.ContainsKey(name)) {
                            charactersSubdtitutes.Add(name, SubstituteCharacters.charactersName[rnd.Next(0, SubstituteCharacters.charactersName.Count - 1)]);
                        }
                        episode.summary = episode.summary.Replace(name, charactersSubdtitutes[name]);
                    }
                }
                if (episode.summary.Contains(name + "'s")) {
                    //random substitute
                    if (!charactersSubdtitutes.ContainsKey(name)) {
                        charactersSubdtitutes.Add(name, SubstituteCharacters.charactersName[rnd.Next(0, SubstituteCharacters.charactersName.Count - 1)]);
                    }
                    episode.summary = episode.summary.Replace(name + "'s", charactersSubdtitutes[name] + "'s");

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
            episodeViewer1.Visible = true;
            episodeViewer1.Title.Text = episode.Title;
            episodeViewer1.episodeNbLb.Text = "Episode #" + episode.EpisodeNb.ToString();
            episodeViewer1.seasonNbLb.Text = "Season #" + episode.Season.ToString();
            episodeViewer1.dateLb.Text = episode.Date;
            episodeViewer1.summaryLb.Text = episode.summary;
        }

        private void pokemonBtn_Click(object sender, EventArgs e) {
            LoadPokemonsCharactersSet();
            SubstituteCharacters.GroupName = " pokemons";

        }

        private void button3_Click(object sender, EventArgs e) {
            LoadCharactersSet("southpark.txt");
            SubstituteCharacters.GroupName = " people of southpark";

        }

        private void button1_Click(object sender, EventArgs e) {
            LoadCharactersSet("futurama.txt");
            SubstituteCharacters.GroupName = " planet express crew";
        }

        private void button2_Click(object sender, EventArgs e) {
            LoadCharactersSet("simpsons.txt");
        }
    }
}
