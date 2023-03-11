// See https://aka.ms/new-console-template for more information

using System;

class KodePos
{
    public string getKodePos(string kelurahan)
    {
        switch (kelurahan)
        {
            case "Batununggal":
                return "40266";
            case "Kujangsari":
                return "40287";
            case "Mengger":
                return "40257";
            case "Wates":
                return "40256";
            case "Cijaura":
                return "40287";
            case "Jatisari":
                return "40286";
            case "Margasari":
                return "40286";
            case "Sekejati":
                return "40286";
            case "Kebonwaru":
                return "40272";
            case "Maleer":
                return "40274";
            case "Samoja":
                return "40273";
            default:
                return "Kode Pos Tidak Ditemukan";

        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos kode = new KodePos();

        string kdBatununggal = kode.getKodePos("Batununggal");
        Console.WriteLine("Kode Pos Batununggal : " + kdBatununggal);
        string kdWates = kode.getKodePos("Wates");
        Console.WriteLine("Kode Pos Wates : " + kdWates);
    }
}

