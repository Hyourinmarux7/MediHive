using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CData
{
    public class CMain
    {
        /// <summary>
        /// Stammklasse mit Hauptelementen
        /// </summary>
        private string titel;
        private string pic;                 // Pfadangabe Bild ??
        private static string maindir;      // Pfadangabe Hauptverzeichnis
        private string dir;                 // Pfadangabe Objektverzeichnis
        private string expl;                // Kurze Beschreibung
        private string link;                // Link (Verlinkung / Infosuche)
        private int val;                    // Bewertung (1-5) Grafische Darstellung
        private int stat;                   // (1-3) gesehen-pausiert-gestoppt

        public CMain(string t)
        {
            titel = t;                  // Titel Pflichtfeld
            pic = "none";               // std. Bild festlegen;
            dir = "Kein Verzeichnis";   
            expl = "Keine Beschreibung";
            link = "Kein Link";
            val = 0;
            stat = 0;
        }

        public CMain(string t, string p, string md, string d, string ex, string l, int v, int st)
        {
            titel = t;
            pic = p;               
            dir = d;
            expl = ex;
            link = l;
            val = v;
            stat = st;
        }


        //Get/ Set-Methoden für alle Attribute
        public string Titel
        {
            get
            {
                return titel;
            }
            set
            {
                titel = value;
            }
        }
        public string Pic
        {
            get
            {
                return pic;
            }
            set
            {
                pic = value;
            }
        }
        public string mdir
        {
            get
            {
                return maindir;
            }
            set
            {
                maindir = value;
            }
        }
        public string Dir
        {
            get
            {
                return dir;
            }
            set
            {
                dir = value;
            }
        }
        public string Expl
        {
            get
            {
                return expl;
            }
            set
            {
                expl = value;
            }
        }
        public string Link
        {
            get{
                return link;
            }
            set{
                link=value;
            }
        } 
        public int Val
        {
            get
            {
                return val;
            }
            set
            {
                val=value;
            }
        }
        public int Stat
        {
            get
            {
                return stat;
            }
            set
            {
                stat = value;
            }
        }

    }

    class CMovie : CMain
    {

    }

    class CSeries : CMain
    {
        private int anzep;      // Vorhandene Folgen
        private int curep;      // Aktuelle Folge
        private int seasson;    // Staffel
        
        // Get/Set- Methoden
        public int Anzep
        {
            get
            {
                return anzep;
            }
            set
            {
                anzep = value;
            }
        }
        public int Curep
        {
            get
            {
                return curep;
            }
            set
            {
                curep = value;
            }
        }
        public int Seasson
        {
            get
            {
                return seasson;
            }
            set
            {
                seasson = value;
            }
        }


        
    }
}
