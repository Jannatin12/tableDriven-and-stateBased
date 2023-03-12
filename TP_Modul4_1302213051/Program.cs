// See https://aka.ms/new-console-template for more information

using System;

class KodePos
{
    private readonly Dictionary<string, string> kodePos = new Dictionary<string, string>
    {
        {"Batununggal", "40266"}, {"Kujangsari", "40287"},
        {"Mengger", "40267"}, {"Wates", "40256"},
        {"Cijaura", "40287"}, {"Jatisari", "40286"},
        {"Margasari", "40286"}, {"Sekejati", "40286"},
        {"Kebonwaru", "40272"}, {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    public string getKodePos(string kelurahan)
    {
        if (kodePos.TryGetValue(kelurahan, out string kode))
        {
            return kode;
        }
        else
        {
            return "Kode Pos Tidak Ditemukan";
        }
    }
}

public class DoorMachine
{
    private State state;

    public DoorMachine()
    {
        state = State.Locked;
        Console.WriteLine("Pintu terkunci");
    }

    public void Lock()
    {
        if (state == State.Unlocked)
        {
            state = State.Locked;
            Console.WriteLine("Pintu terkunci");
        }
    }

    public void Unlock()
    {
        if (state == State.Locked)
        {
            state = State.Unlocked;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    private enum State
    {
        Locked,
        Unlocked
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos kode = new KodePos();

        Console.WriteLine("Output Table Driven");
        string kdBatununggal = kode.getKodePos("Batununggal");
        Console.WriteLine("Kode Pos Batununggal : " + kdBatununggal);
        string kdWates = kode.getKodePos("Wates");
        Console.WriteLine("Kode Pos Wates : " + kdWates);

        Console.WriteLine(" ");

        Console.WriteLine("Output State Based");
        DoorMachine pintu = new DoorMachine();
        pintu.Lock();
        pintu.Unlock();

        Console.ReadLine();
    }
}

