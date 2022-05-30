namespace Biblioteket
{
    public class Person
    {
        string _name;
        string _email;
        List<Bog> _boger = new();
        public string Name
        {
            get
            { 
                return _name; 
            }
            set
            { 
                _name = value;
            }
        }
        public string Email
        {
            get
            { 
                return _email;
            }
            set
            { 
                _email = value; 
            }
        }
        public List<Bog> Boger
        {
            get
            {
                return _boger;
            }
            set
            {
                _boger = value;
            }
        }
        /// <summary>
        /// udlånner bog til brugere
        /// </summary>
        /// <param name="bogen"></param>
        /// <returns>string</returns>
        public string LaanBog(Bog bogen)
        {
            if (bogen != null)
            {
                bogen.Udlaansdato = DateTime.Now;
                _boger.Add(bogen);
                return $"{bogen.Titel} er udlånt";
            }
            return "Der er sket en fejl";
        }

    }
}