using System.Net.Cache;
using System.Reflection.Metadata;

//public class Human
//{
//    public string name { get; set; }
//    public int age { get; set; }
//    public string nationality { get; set; }

//    public Human(string Name, int Age, string Nationality)
//    {
//        this.name = Name;
//        this.age = Age;
//        this.nationality = Nationality;
//    }
//    public virtual void ShowInfo()
//    {
//        Console.WriteLine($"Adi - {name}\nYasi - {age}\nMilliyeti - {nationality}");
//    }

//}

//public class Builder : Human
//{
//    public string CompanyName { get; set; }

//    public Builder(string Name, int Age, string Nationality, string companyname)
//        : base(Name, Age, Nationality)
//    {
//        CompanyName = companyname;
//    }

//    public virtual void ShowInfo()
//    {
//        base.ShowInfo();
//        Console.WriteLine($"Sirketin adi - {CompanyName}");
//    }
//}

//public class Sailor : Human
//{
//    public string ShipName { get; set; }

//    public Sailor(string Name, int Age, string Nationality, string shipname)
//        : base(Name, Age, Nationality)
//    {
//        ShipName = shipname;
//    }
//    public virtual void ShowInfo()
//    {
//        base.ShowInfo();
//        Console.WriteLine($"Geminin adi - {ShipName}");
//    }
//}

//public class Pilot : Human
//{
//    public string? AircraftName { get; set; }
//    public Pilot(string Name, int Age, string Nationality, string aircraftname)
//        : base(Name, Age, Nationality)
//    {
//        AircraftName = aircraftname;
//    }

//    public virtual void ShowInfo()
//    {
//        base.ShowInfo();
//        Console.WriteLine($"Teyyarenin adi - {AircraftName}");
//    }
//}

//public class Program
//{
//    static void Main()
//    {
//        Builder builder = new Builder("Behruz", 17, "Arab", "AZERISIQ");
//        Console.WriteLine("Fehle: ");
//        builder.ShowInfo();
//        Console.WriteLine();

//        Sailor sailor = new Sailor("Akif", 25, "Azerbaijan", "Palmolive");
//        Console.WriteLine("Denizci: ");
//        sailor.ShowInfo();
//        Console.WriteLine();

//        Pilot pilot = new Pilot("Murad", 22, "Azerbaijan", "AZAL");
//        Console.WriteLine("Pilot: ");
//        pilot.ShowInfo();

//    }
//}

//public class Passport
//{
//    public string? Name { get; set; }
//    public int Age { get; set; }
//    public string? Nationality { get; set; }

//    public Passport(string? name, int age, string nationality)
//    {
//        Name = name;
//        Age = age;
//        Nationality = nationality;
//    }

//    public virtual void ShowInfo()
//    {
//        Console.WriteLine($"Adi - {Name}");
//        Console.WriteLine($"Yasi - {Age}");
//        Console.WriteLine($"Milliyeti - {Nationality}");
//    }


//}
//public class ForeignPassport : Passport
//{
//    public string VisaAbout { get; set; }
//    public int ForeignPassNum { get; set; }

//    public ForeignPassport(string? name, int age, string nationality, string visaAbout, int foreignPassNum)
//        : base(name, age, nationality)
//    {
//        ForeignPassNum = foreignPassNum;
//        VisaAbout = visaAbout;
//    }
//    public virtual void ShowInfo()
//    {
//        base.ShowInfo();
//        Console.WriteLine($"Visa melumatlari - {VisaAbout}");
//        Console.WriteLine($"Xarici passportun nomresi - {ForeignPassNum}");
//    }
//}
//public class Program
//{
//    static void Main()
//    {
//        Passport passport = new Passport("Murad", 22, "Azerbaijan");
//        passport.ShowInfo();
//        Console.WriteLine();

//           Console.WriteLine("Xarici Passport: ");
//        ForeignPassport foreignPassport = new ForeignPassport
//            ("Murad", 22, "Azerbaijan", "Visa novu - Business\nVerilen olke - United States of America", 12345678);
//        foreignPassport.ShowInfo();
//    }
//}

//public class Animals
//{
//    public string Name { get; set; }

//    public string Character { get; set; }

//    public Animals(string name, string character)
//    {
//        Name = name;
//        Character = character;
//    }
//    public virtual void ShowInfo()
//    {
//        Console.WriteLine($"Adi - {Name}\nXarakteri - {Character}");
//    }
//}
//public class Peleng : Animals
//{
//    public string Suret { get; set; }
//    public Peleng(string name, string character, string suret)
//        : base(name, character)
//    {
//        Suret = suret;
//    }

//    public virtual void ShowInfo()
//    {
//        base.ShowInfo();
//        Console.WriteLine($"Sureti - {Suret}");
//    }

//}

//public class Timsah : Animals
//{
//    public string Yirtici { get; set; }
//    public Timsah(string name, string character, string yirtici)
//        : base(name, character)
//    {
//        Yirtici = yirtici;
//    }

//    public virtual void ShowInfo()
//    {
//        base.ShowInfo();
//        Console.WriteLine($"Haqqinda - {Yirtici}");
//    }

//}

//public class Kenguru : Animals
//{
//    public string TullanmaHundurluyu { get; set; }
//    public Kenguru(string name, string character, string tullanmaHundurluyu)
//        : base(name, character)
//    {
//        TullanmaHundurluyu = tullanmaHundurluyu;
//    }

//    public virtual void ShowInfo()
//    {
//        base.ShowInfo();
//        Console.WriteLine($"Tullanma Hundurluyu - {TullanmaHundurluyu}");
//    }

//}
//public class Program
//{
//     static void Main()
//    {
//        Peleng peleng = new Peleng("Bengal Pelengi", "Yırtıcı ve süretli", "80 km/saat");
//        peleng.ShowInfo();
//        Console.WriteLine();

//        Timsah timsah = new Timsah("Nil Timsahı", "Suya uyğun yırtıcı", "Yırtıcı");
//        timsah.ShowInfo();
//        Console.WriteLine();

//        Kenguru kenguru = new Kenguru("Qırmızı Kenguru", "Aile canlısı", "3 metr");
//        kenguru.ShowInfo();
//    }
//}

