using System;
/*using System.Collections.Generic;

class KodePos
{
       private static readonly Dictionary<string, string> kodePosMap = new Dictionary<string, string>
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    public static string GetKodePos(string kelurahan)
    {
        return kodePosMap.TryGetValue(kelurahan, out string kodePos) ? kodePos : "Kode Pos Tidak Ditemukan";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Daftar Kode Pos:");
        Console.WriteLine("-----------------");

        foreach (var entry in new List<string>
        {
            "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari",
            "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja"
        })
        {
            Console.WriteLine($"{entry}: {KodePos.GetKodePos(entry)}");
        }

        Console.Write("\nMasukkan nama kelurahan: ");
        string input = Console.ReadLine();
        Console.WriteLine($"Kode Pos {input}: {KodePos.GetKodePos(input)}");
    }
}


public enum DoorState
{
    Terkunci,
    Terbuka
}

public class DoorMachine
{
    private DoorState state;

    public DoorMachine()
    {
        state = DoorState.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void KunciPintu()
    {
        if (state == DoorState.Terkunci)
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
        else
        {
            state = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }

    public void BukaPintu()
    {
        if (state == DoorState.Terbuka)
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
        else
        {
            state = DoorState.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }
}

class Program
{
    static void Main()
    {
        DoorMachine pintu = new DoorMachine();

        Console.WriteLine("\nMenekan tombol buka...");
        pintu.BukaPintu();

        Console.WriteLine("\nMenekan tombol kunci...");
        pintu.KunciPintu();
    }
}
*/