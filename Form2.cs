using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace prace_dyplomowe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitializeForm();



        }

        private void InitializeForm()
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode rootNode = doc.CreateElement("Form");
            doc.AppendChild(rootNode);

            XmlNode kierunek = doc.CreateElement("Kierunek");
            kierunek.InnerText = textBox1.Text;
            rootNode.AppendChild(kierunek);

            XmlNode zakres = doc.CreateElement("Studia_w_zakresie");
            zakres.InnerText = textBox2.Text;
            rootNode.AppendChild(zakres);

            XmlNode tytul = doc.CreateElement("Tytuł_pracy");
            tytul.InnerText = textBox3.Text;
            rootNode.AppendChild(tytul);

            XmlNode nr_album = doc.CreateElement("Nr_albumu");
            nr_album.InnerText = textBox4.Text;
            rootNode.AppendChild(nr_album);

            XmlNode profil = doc.CreateElement("Profil_studiów");
            profil.InnerText = textBox5.Text;
            rootNode.AppendChild(profil);

            XmlNode forma = doc.CreateElement("Forma_studiów");
            forma.InnerText = textBox6.Text;
            rootNode.AppendChild(forma);

            XmlNode poziom = doc.CreateElement("Poziom_studiów");
            poziom.InnerText = textBox7.Text;
            rootNode.AppendChild(poziom);

            XmlNode wersja_ang = doc.CreateElement("Wersja_angielska_tytułu");
            wersja_ang.InnerText = textBox8.Text;
            rootNode.AppendChild(wersja_ang);

            XmlNode dane = doc.CreateElement("Dane_wejściowe");
            dane.InnerText = textBox9.Text;
            rootNode.AppendChild(dane);

            XmlNode zakres_pracy = doc.CreateElement("Zakres_pracy");
            zakres_pracy.InnerText = textBox10.Text;
            rootNode.AppendChild(zakres_pracy);

            XmlNode termin_oddania = doc.CreateElement("Termin_oddania_pracy");
            termin_oddania.InnerText = textBox11.Text;
            rootNode.AppendChild(termin_oddania);

            XmlNode promotor = doc.CreateElement("Promotor");
            promotor.InnerText = textBox21.Text;
            rootNode.AppendChild(promotor);

            XmlNode recenzent = doc.CreateElement("Recenzent");
            recenzent.InnerText = textBox32.Text;
            rootNode.AppendChild(recenzent);

            XmlNode jednostka = doc.CreateElement("Jednostka_organizacyjna");
            jednostka.InnerText = textBox22.Text;
            rootNode.AppendChild(jednostka);

            XmlNode podsumowanie = doc.CreateElement("Podsumowanie_oceny_merytorycznej");
            podsumowanie.InnerText = textBox23.Text;
            rootNode.AppendChild(podsumowanie);

            XmlNode liczbowo = doc.CreateElement("Ocena_liczbowo");
            liczbowo.InnerText = textBox24.Text;
            rootNode.AppendChild(liczbowo);

            XmlNode slownie = doc.CreateElement("Ocena_słownie");
            slownie.InnerText = textBox25.Text;
            rootNode.AppendChild(slownie);

            XmlNode imiona = doc.CreateElement("Imiona_i_nazwisko");
            imiona.InnerText = textBox26.Text;
            rootNode.AppendChild(imiona);

            XmlNode data_urodzenia = doc.CreateElement("Data_urodzenia");
            data_urodzenia.InnerText = textBox27.Text;
            rootNode.AppendChild(data_urodzenia);

            XmlNode miejsce = doc.CreateElement("Miejsce_urodzenia");
            miejsce.InnerText = textBox28.Text;
            rootNode.AppendChild(miejsce);

            XmlNode ocena_egz = doc.CreateElement("Ocena_egzaminu");
            ocena_egz.InnerText = textBox12.Text;
            rootNode.AppendChild(ocena_egz);

            XmlNode data_egz = doc.CreateElement("Data_egzaminu_dyplomowego");
            data_egz.InnerText = textBox29.Text;
            rootNode.AppendChild(data_egz);

            XmlNode data_rozp = doc.CreateElement("Data_rozpoczęcia_studiów");
            data_rozp.InnerText = textBox30.Text;
            rootNode.AppendChild(data_rozp);

            XmlNode przewodniczacy = doc.CreateElement("Przewodniczący");
            przewodniczacy.InnerText = textBox31.Text;
            rootNode.AppendChild(przewodniczacy);

            XmlNode wynik_slownie = doc.CreateElement("Wynik_studiów_słownie");
            wynik_slownie.InnerText = textBox33.Text;
            rootNode.AppendChild(wynik_slownie);

            XmlNode wynik_liczbowo = doc.CreateElement("Wynik_studiów_liczbowo");
            wynik_liczbowo.InnerText = textBox34.Text;
            rootNode.AppendChild(wynik_liczbowo);

            XmlNode pytania = doc.CreateElement("Zadanie_pytania");
            pytania.InnerText = textBox35.Text;
            rootNode.AppendChild(pytania);

            XmlNode imie1 = doc.CreateElement("Imie_i_nazwisko_1");
            imie1.InnerText = textBox13.Text;
            rootNode.AppendChild(imie1);

            XmlNode nr1 = doc.CreateElement("Nr_albumu_1");
            nr1.InnerText = textBox17.Text;
            rootNode.AppendChild(nr1);

            XmlNode imie2 = doc.CreateElement("Imie_i_nazwisko_2");
            imie2.InnerText = textBox14.Text;
            rootNode.AppendChild(imie2);

            XmlNode nr2 = doc.CreateElement("Nr_albumu_2");
            nr2.InnerText = textBox18.Text;
            rootNode.AppendChild(nr2);

            XmlNode imie3 = doc.CreateElement("Imie_i_nazwisko_3");
            imie3.InnerText = textBox15.Text;
            rootNode.AppendChild(imie3);

            XmlNode nr3 = doc.CreateElement("Nr_albumu_3");
            nr3.InnerText = textBox19.Text;
            rootNode.AppendChild(nr3);

            XmlNode imie4 = doc.CreateElement("Imie_i_nazwisko_4");
            imie4.InnerText = textBox16.Text;
            rootNode.AppendChild(imie4);

            XmlNode nr4 = doc.CreateElement("Nr_albumu_4");
            kierunek.InnerText = textBox20.Text;
            rootNode.AppendChild(nr4);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML files (*.xml)|*.xml";
            saveFileDialog1.Title = "Save XML File";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.FileName = "form.xml";
            saveFileDialog1.InitialDirectory = Path.Combine(saveFileDialog1.InitialDirectory, "prace_dyplomowe");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                doc.Save(Path.Combine(saveFileDialog1.InitialDirectory, saveFileDialog1.FileName));
            }

        }

        [XmlRoot(ElementName = "Form")]
        public class Odczyt
        {
            [XmlElement(ElementName = "Kierunek")]
            public string Kierunek { get; set; }

            [XmlElement(ElementName = "Studia_w_zakresie")]
            public string Studia_w_zakresie { get; set; }

            [XmlElement(ElementName = "Tytuł_pracy")]
            public string Tytuł_pracy { get; set; }

            [XmlElement(ElementName = "Nr_albumu")]
            public string Nr_albumu { get; set; }

            [XmlElement(ElementName = "Profil_studiów")]
            public string Profil_studiów { get; set; }

            [XmlElement(ElementName = "Forma_studiów")]
            public string Forma_studiów { get; set; }

            [XmlElement(ElementName = "Poziom_studiów")]
            public string Poziom_studiów { get; set; }

            [XmlElement(ElementName = "Wersja_angielska_tytułu")]
            public string Wersja_angielska_tytułu { get; set; }

            [XmlElement(ElementName = "Dane_wejściowe")]
            public string Dane_wejściowe { get; set; }

            [XmlElement(ElementName = "Zakres_pracy")]
            public string Zakres_pracy { get; set; }

            [XmlElement(ElementName = "Termin_oddania_pracy")]
            public string Termin_oddania_pracy { get; set; }

            [XmlElement(ElementName = "Promotor")]
            public string Promotor { get; set; }

            [XmlElement(ElementName = "Recenzent")]
            public string Recenzent { get; set; }

            [XmlElement(ElementName = "Jednostka_organizacyjna")]
            public string Jednostka_organizacyjna { get; set; }

            [XmlElement(ElementName = "Podsumowanie_oceny_merytorycznej")]
            public string Podsumowanie_oceny_merytorycznej { get; set; }

            [XmlElement(ElementName = "Ocena_liczbowo")]
            public string Ocena_liczbowo { get; set; }

            [XmlElement(ElementName = "Ocena_słownie")]
            public string Ocena_słownie { get; set; }

            [XmlElement(ElementName = "Imiona_i_nazwisko")]
            public string Imiona_i_nazwisko { get; set; }

            [XmlElement(ElementName = "Data_urodzenia")]
            public string Data_urodzenia { get; set; }

            [XmlElement(ElementName = "Miejsce_urodzenia")]
            public string Miejsce_urodzenia { get; set; }

            [XmlElement(ElementName = "Ocena_egzaminu")]
            public string Ocena_egzaminu { get; set; }

            [XmlElement(ElementName = "Data_egzaminu_dyplomowego")]
            public string Data_egzaminu_dyplomowego { get; set; }


            private void button2_Click(object sender, EventArgs e)
            {
                
                


            }

            private void label35_Click(object sender, EventArgs e)
            {

            }

            private void label36_Click(object sender, EventArgs e)
            {

            }

            private void textBox32_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "XML files (*.xml)|*.xml";
            openFileDialog1.Title = "Open XML File";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.InitialDirectory = Path.Combine(openFileDialog1.InitialDirectory, "prace_dyplomowe");

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                doc.Load(openFileDialog1.FileName);
                textBox1.Text = doc.SelectSingleNode("/Form/Kierunek").InnerText;
                textBox2.Text = doc.SelectSingleNode("/Form/Studia_w_zakresie").InnerText;
                textBox3.Text = doc.SelectSingleNode("/Form/Tytuł_pracy").InnerText;
                textBox4.Text = doc.SelectSingleNode("/Form/Nr_albumu").InnerText;
                textBox5.Text = doc.SelectSingleNode("/Form/Profil_studiów").InnerText;
                textBox6.Text = doc.SelectSingleNode("/Form/Forma_studiów").InnerText;
                textBox7.Text = doc.SelectSingleNode("/Form/Poziom_studiów").InnerText;
                textBox8.Text = doc.SelectSingleNode("/Form/Wersja_angielska_tytułu").InnerText;
                textBox9.Text = doc.SelectSingleNode("/Form/Dane_wejściowe").InnerText;
                textBox10.Text = doc.SelectSingleNode("/Form/Zakres_pracy").InnerText;
                textBox11.Text = doc.SelectSingleNode("/Form/Termin_oddania_pracy").InnerText;
                textBox21.Text = doc.SelectSingleNode("/Form/Promotor").InnerText;
                textBox32.Text = doc.SelectSingleNode("/Form/Recenzent").InnerText;
                textBox22.Text = doc.SelectSingleNode("/Form/Jednostka_organizacyjna").InnerText;
                textBox23.Text = doc.SelectSingleNode("/Form/Podsumowanie_oceny_merytorycznej").InnerText;
                textBox24.Text = doc.SelectSingleNode("/Form/Ocena_liczbowo").InnerText;
                textBox25.Text = doc.SelectSingleNode("/Form/Ocena_słownie").InnerText;
                textBox26.Text = doc.SelectSingleNode("/Form/Imiona_i_nazwisko").InnerText;
                textBox27.Text = doc.SelectSingleNode("/Form/Data_urodzenia").InnerText;
                textBox28.Text = doc.SelectSingleNode("/Form/Miejsce_urodzenia").InnerText;
                textBox12.Text = doc.SelectSingleNode("/Form/Ocena_egzaminu").InnerText;
                textBox29.Text = doc.SelectSingleNode("/Form/Data_egzaminu_dyplomowego").InnerText;
                textBox30.Text = doc.SelectSingleNode("/Form/Data_rozpoczęcia_studiów").InnerText;
                textBox31.Text = doc.SelectSingleNode("/Form/Przewodniczący").InnerText;
                textBox33.Text = doc.SelectSingleNode("/Form/Wynik_studiów_słownie").InnerText;
                textBox34.Text = doc.SelectSingleNode("/Form/Wynik_studiów_liczbowo").InnerText;
                textBox35.Text = doc.SelectSingleNode("/Form/Zadanie_pytania").InnerText;
                textBox13.Text = doc.SelectSingleNode("/Form/Imie_i_nazwisko_1").InnerText;
                textBox17.Text = doc.SelectSingleNode("/Form/Nr_albumu_1").InnerText;
                textBox14.Text = doc.SelectSingleNode("/Form/Imie_i_nazwisko_2").InnerText;
                textBox18.Text = doc.SelectSingleNode("/Form/Nr_albumu_2").InnerText;
                textBox15.Text = doc.SelectSingleNode("/Form/Imie_i_nazwisko_3").InnerText;
                textBox19.Text = doc.SelectSingleNode("/Form/Nr_albumu_3").InnerText;
                textBox16.Text = doc.SelectSingleNode("/Form/Imie_i_nazwisko_4").InnerText;
                textBox20.Text = doc.SelectSingleNode("/Form/Nr_albumu_4").InnerText;
            }

        }
    }
}
