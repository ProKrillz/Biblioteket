namespace Biblioteket
{
    public class Bog
    {
        string _titel;
        string _forfatter;
        string _isbnNummer;
        DateTime _udlaansdato;
        public string Titel
        {
            get
            { 
                return _titel; 
            }
            set
            {
                _titel = value;
            }
        }
        public string Forfatter
        {
            get
            { 
                return _forfatter; 
            }
            set
            {
                _forfatter = value;
            }
        }
        public string IsbnNummer
        {
            get
            {
                return _isbnNummer;
            }
            set
            {
                _isbnNummer = value;
            }
        }
        public DateTime Udlaansdato
        {
            get
            {
                return _udlaansdato;
            }
            set
            {
                _udlaansdato = value;
            }
        }

    }
}
