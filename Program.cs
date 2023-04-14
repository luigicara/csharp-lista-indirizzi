namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main()
        {
            List<Indirizzo> indirizzi =  new List<Indirizzo>();

            StreamReader reader = File.OpenText("dati\\addresses.csv");

            int index = 0;
            while (!reader.EndOfStream)
            {
          
                try
                {
                    string? line = reader.ReadLine();

                    if (line != null && index != 0)
                    {
                        string[] valori = line.Split(',');

                        Console.WriteLine($"UTENTE: {index}");
                        if (valori.Length != 6)
                            throw new Exception("Il numero di valori inseriti non corrisponde ai campi richiesti");
                        else
                        {
                            Console.WriteLine($"\tNome: {valori[0]}");
                            Console.WriteLine($"\tCognome: {valori[1]}");
                            Console.WriteLine($"\tVia: {valori[2]}");
                            Console.WriteLine($"\tCittà: {valori[3]}");
                            Console.WriteLine($"\tProvincia: {valori[4]}");
                            Console.WriteLine($"\tCAP: {valori[5]}");

                            indirizzi.Add(new Indirizzo(valori[0], valori[1], valori[2], valori[3], valori[4], valori[5]));
                        }
                    }
                    index++;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Si è verificato un problema: " + ex.Message);

                    index++;
                }
                catch (Exception e)
                {

                    Console.WriteLine("Si è verificato un problema: " + e.Message);

                    index++;
                }

            }

            reader.Close();

            foreach (Indirizzo indirizzo in indirizzi)
                Console.WriteLine(indirizzo.ToString());
        }
    }
}