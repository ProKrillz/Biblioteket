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
3. __Biblotek__

    * string _biblioteksNavn
    * List< Laaner > _laaners
    * int _laanerNummer
    * public Bibliotek(string name)

## Methods

* __HentBibliotek()__

    Get _biblioteksNavn and DateTime.Today and returns as a string

* __OpretLaaner(string laanerNavn, string email)__

    Creat a object with constructor from Laaner with int ++laanerNummer and uses two strings as the parameters and adds to _laaners

* __HentLaaner(int laanerNummer)__

    Get laaner from _laaners with the samme value as the parameter and create a new object with samme info from laaner. return a string with laaner info or error if the list is empty.

* __HentAlleLaanere()__

    Gets all values from _laaners and return one string.