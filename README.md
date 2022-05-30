# Biblotek

## Author

Thomas Damkjær

## Description

In this program you can create persons and a libery. 

## Class

1. __Person__

    * string navn
    * string email
2. __Laaner__

    * public int laanerNummer
    * public Laaner(int laanerNummer, string laanerNavn, string email)

3. __Bog__
    
    * string _titel
    * string _forfatter
    * string _isbnNummer
    * DateTime _udlaansdato

4. __Biblotek__

    * string _biblioteksNavn
    * List< Laaner > _laaners
    * List< Bog > _boger
    * int _laanerNummer
    * public Bibliotek(string name)

## Methods

* __HentBibliotek()__

    Get _biblioteksNavn and DateTime.Today and returns as a string

* __OpretLaaner(string laanerNavn, string email)__

    Creat a object with constructor from Laaner with int ++laanerNummer and uses two strings as the parameters and adds to _laaners

* __OpretBog(string titel, string forfatter, string isbnNummer)__

    Create new bog object with parameters and add it to _boger.

* __HentLaaner / FindLaaner(int laanerNummer)__

    Get laaner from _laaners with the samme value as the parameter and create a new object with samme info from laaner. return a string with laaner info or error if the list is empty.

* __HentAlleLaanere()__

    Gets all values from _laaners and return one string.

* __HentAlleBogere()__

    Gets all values from _boger and return one string.

* __ValgPerson(int laanerNummer)__

    Use parameters to find Person in _laaners and return Person object.

* __ValgBog(string bogTitel)__

    Use parameters to find Bog in _boger and return Bog object.

* __LaanBog(Bog bogen)__

    Use parameter to rent bog to Person.

## Known issus

You can create a user wtih enter press.

if you input a number in ValgPerson where the number is not in list the program will crash.