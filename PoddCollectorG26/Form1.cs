using System.Xml;

namespace PoddCollectorG26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LaggTillPod_Click(object sender, EventArgs e)
        {
            string rssUrl = URL.Text;
            string podcastNamn = PodNamn.Text;
            string selectedKategori = ComboCat.SelectedItem as string;

            if (!string.IsNullOrWhiteSpace(rssUrl))
            {
                try
                {
                    XmlDocument rssDoc = new XmlDocument();
                    rssDoc.Load(rssUrl);

                    XmlNode titleNode = rssDoc.SelectSingleNode("/rss/channel/title");
                    string podcastTitle = titleNode.InnerText;


                    PodBox.Items.Add(podcastTitle);
                    PodBox.Items.Add(podcastNamn);
                    PodBox.Items.Add(selectedKategori);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Denna Rss URL är ej korrekt");
            }
        }

        private void LaggTillCat_Click(object sender, EventArgs e)
        {
            string nyKategori = CatNamn.Text;

            if (!string.IsNullOrWhiteSpace(nyKategori))
            {

                CatBox.Items.Add(nyKategori);
                ComboCat.Items.Add(nyKategori);
                CatNamn.Clear();

            }
        }

        private void BortCat_Click(object sender, EventArgs e)
        {
            int valtIndex = CatBox.SelectedIndex;

            if (valtIndex != -1)
            {
                CatBox.Items.RemoveAt(valtIndex); // Ta bort objektet från ListBox.
                ComboCat.Items.RemoveAt(valtIndex);
            }
        }

        private void AndraCat_Click(object sender, EventArgs e)
        {
            int valtIndex = CatBox.SelectedIndex;

            if (valtIndex != -1)
            {
                string nyttNamn = CatNamn.Text;



                if (!string.IsNullOrWhiteSpace(nyttNamn))
                {
                    CatBox.Items[valtIndex] = nyttNamn; // Uppdatera ListBox.
                    ComboCat.Items[valtIndex] = nyttNamn; // Uppdatera ComboBox.

                    // Rensa TextBox efter ändringen.
                    CatNamn.Clear();
                }
            }
        }
    }
}