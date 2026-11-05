using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Introduzca una cadena muy larga que me obliga Rafael Infante Renedo");
        string cadenaLarga= Console.ReadLine();

        Console.WriteLine($"Introduzca una palabra para buscar en la cadena muy larga que quería Rafael Infante Renedo");
        string palabra= Console.ReadLine();
        int primera=0;
        int ultima=0;
        if (cadenaLarga.Contains(palabra))
        {
            string nuevapalabra="";
            for (int i = palabra.Length-1;i>=0;i--)
            {
                nuevapalabra+=palabra[i];
            }
            string palabraOtra = nuevapalabra.ToLower();
            primera = cadenaLarga.IndexOf(palabra);
            ultima = cadenaLarga.LastIndexOf(palabra);
            cadenaLarga= cadenaLarga.Replace(palabra,palabraOtra);
        }
        
        Console.WriteLine($"La palabra se encuentra por primera vez en {primera} y la ultima en {ultima}");
        Console.WriteLine(cadenaLarga);
    }
}