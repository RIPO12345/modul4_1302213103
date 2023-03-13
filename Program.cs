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


class PosisiKarakterGame
{
    private State currentState;

    public PosisiKarakterGame()
    {
        currentState = new Berdiri();
    }

    public void SetState(State state)
    {
        currentState = state;
        currentState.DisplayState();
    }
}

interface State
{
    void DisplayState();
}

class Berdiri : State
{
    public void DisplayState()
    {
        Console.WriteLine("posisi standby");
    }
}

class Tengkurap : State
{
    public void DisplayState()
    {
        Console.WriteLine("posisi istirahat");
    }
}


class Program
{
    static void Main(string[] args)
    {
        KodeBuah kodebuah = new KodeBuah();

        Console.WriteLine(kodebuah.getKodeBuah("Apel")); 
        Console.WriteLine(kodebuah.getKodeBuah("Aprikot")); 
        Console.WriteLine(kodebuah.getKodeBuah("Alpukat")); 
        Console.WriteLine(kodebuah.getKodeBuah("Pisang")); 
        Console.WriteLine(kodebuah.getKodeBuah("Paprika")); 
        Console.WriteLine(kodebuah.getKodeBuah("Blackberry")); 
        Console.WriteLine(kodebuah.getKodeBuah("Ceri")); 
        Console.WriteLine(kodebuah.getKodeBuah("Kelapa")); 
        Console.WriteLine(kodebuah.getKodeBuah("Jagung"));  
        Console.WriteLine(kodebuah.getKodeBuah("Durian")); // Output: Kode buah tidak ditemukan.
        PosisiKarakterGame posisikaraktergame = new PosisiKarakterGame();

        // Mengubah state menjadi Berdiri
        posisikaraktergame.SetState(new Berdiri());

        // Mengubah state menjadi Tengkurap
        posisikaraktergame.SetState(new Tengkurap());
    }
}
