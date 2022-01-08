using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;

namespace Szofttech_GyakDemo01
{
    public class ReadXML
    {
        public class ReadRealXML
        {
            internal static MainData XMLRead(string location)
            {
				MainData aviso = new MainData();
                XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(aviso.GetType());
                using (StreamReader reader = new StreamReader(location))
                {
                    return (MainData)xmlSerializer.Deserialize(reader);
                }
            }
        }


    }
	[XmlRoot(ElementName = "felhasznalok")]
	public class Felhasznalok
	{
		[XmlElement(ElementName = "nev")]
		public string Nev { get; set; }
		[XmlElement(ElementName = "email")]
		public string Email { get; set; }
		[XmlElement(ElementName = "jogosultsag")]
		public string Jogosultsag { get; set; }
		[XmlElement(ElementName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "vendegek")]
	public class Vendegek
	{
		[XmlElement(ElementName = "nev")]
		public string Nev { get; set; }
		[XmlElement(ElementName = "irszam")]
		public string Irszam { get; set; }
		[XmlElement(ElementName = "varos")]
		public string Varos { get; set; }
		[XmlElement(ElementName = "cim")]
		public string Cim { get; set; }
		[XmlElement(ElementName = "telefeon")]
		public string Telefeon { get; set; }
	}

	[XmlRoot(ElementName = "rendelesek")]
	public class Rendelesek
	{
		[XmlElement(ElementName = "osszeg")]
		public string Osszeg { get; set; }
		[XmlElement(ElementName = "tipus")]
		public string Tipus { get; set; }
		[XmlElement(ElementName = "datum")]
		public string Datum { get; set; }
		[XmlElement(ElementName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "termekek")]
	public class Termekek
	{
		[XmlElement(ElementName = "elnevezes")]
		public string Elnevezes { get; set; }
		[XmlElement(ElementName = "tipus")]
		public string Tipus { get; set; }
		[XmlElement(ElementName = "kategoria")]
		public string Kategoria { get; set; }
		[XmlElement(ElementName = "ar")]
		public string Ar { get; set; }
		[XmlElement(ElementName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "alapanyagok")]
	public class Alapanyagok
	{
		[XmlElement(ElementName = "elnevezes")]
		public string Elnevezes { get; set; }
		[XmlElement(ElementName = "mertekegyseg")]
		public string Mertekegyseg { get; set; }
		[XmlElement(ElementName = "id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "alapanyagraktar")]
	public class Alapanyagraktar
	{
		[XmlElement(ElementName = "mennyiseg")]
		public string Mennyiseg { get; set; }
		[XmlElement(ElementName = "minimum")]
		public string Minimum { get; set; }
	}

	[XmlRoot(ElementName = "menuk")]
	public class Menuk
	{
		[XmlElement(ElementName = "id")]
		public string Id { get; set; }
		[XmlElement(ElementName = "elnevezes")]
		public string Elnevezes { get; set; }
		[XmlElement(ElementName = "ar")]
		public string Ar { get; set; }
	}

	[XmlRoot(ElementName = "adatok")]
	public class Adatok
	{
		[XmlElement(ElementName = "felhasznalok")]
		public Felhasznalok Felhasznalok { get; set; }
		[XmlElement(ElementName = "vendegek")]
		public Vendegek Vendegek { get; set; }
		[XmlElement(ElementName = "rendelesek")]
		public Rendelesek Rendelesek { get; set; }
		[XmlElement(ElementName = "termekek")]
		public Termekek Termekek { get; set; }
		[XmlElement(ElementName = "alapanyagok")]
		public Alapanyagok Alapanyagok { get; set; }
		[XmlElement(ElementName = "alapanyagraktar")]
		public Alapanyagraktar Alapanyagraktar { get; set; }
		[XmlElement(ElementName = "menuk")]
		public Menuk Menuk { get; set; }
	}

	[XmlRoot(ElementName = "MainData")]
	public class MainData
	{
		[XmlElement(ElementName = "adatok")]
		public List<Adatok> Adatok { get; set; }
	}
}
