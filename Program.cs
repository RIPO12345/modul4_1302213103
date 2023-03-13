using System;
using System.Collections.Generic;

class KodeBuah
{
    private Dictionary<string, string> tabelKodeBuah = new Dictionary<string, string>
    {
        {"Apel", "A00"},
        {"Aprikot", "B00"},
        {"Alpukat", "C00"},
        {"Pisang", "D00"},
        {"Paprika", "E00"},
        {"Blackberry", "F00"},
        {"Ceri", "H00"},
        {"Kelapa", "I00"},
        {"Jagung", "J00"}
    };

    public string getKodeBuah(string buah)
    {
        if (tabelKodeBuah.ContainsKey(buah))
        {
            return tabelKodeBuah[buah];
        }
        else
        {
            return "Kode buah tidak ditemukan.";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodeBuah kodepos = new KodeBuah();

        Console.WriteLine(kodepos.getKodeBuah("Apel")); 
        Console.WriteLine(kodepos.getKodeBuah("Aprikot")); 
        Console.WriteLine(kodepos.getKodeBuah("Alpukat")); 
        Console.WriteLine(kodepos.getKodeBuah("Pisang")); 
        Console.WriteLine(kodepos.getKodeBuah("Paprika")); 
        Console.WriteLine(kodepos.getKodeBuah("Blackberry")); 
        Console.WriteLine(kodepos.getKodeBuah("Ceri")); 
        Console.WriteLine(kodepos.getKodeBuah("Kelapa")); 
        Console.WriteLine(kodepos.getKodeBuah("Jagung"));  
        Console.WriteLine(kodepos.getKodeBuah("Durian")); // Output: Kode buah tidak ditemukan.
    }
}
