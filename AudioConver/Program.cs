using System;
using System.IO;
using NAudio.Wave;
using NAudio.Lame;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Ingrese el directorio de origen:");
        string sourceDirectory = Console.ReadLine();

        if (!Directory.Exists(sourceDirectory))
        {
            Console.WriteLine("El directorio de origen no existe.");
            return;
        }

        Console.WriteLine("Ingrese el directorio de destino:");
        string destinationDirectory = Console.ReadLine();

        if (!Directory.Exists(destinationDirectory))
        {
            Directory.CreateDirectory(destinationDirectory);
        }

        string[] audioFiles = Directory.GetFiles(sourceDirectory, "*.*", SearchOption.AllDirectories);

        foreach (string filePath in audioFiles)
        {
            if (Path.GetExtension(filePath).Equals(".m4a", StringComparison.OrdinalIgnoreCase) ||
                Path.GetExtension(filePath).Equals(".opus", StringComparison.OrdinalIgnoreCase))
            {
                string mp3FilePath = Path.Combine(destinationDirectory, Path.GetFileNameWithoutExtension(filePath) + ".mp3");

                ConvertToMp3(filePath, mp3FilePath);
            }
        }

        Console.WriteLine("Conversion completed.");
    }

    static void ConvertToMp3(string inputFilePath, string outputFilePath)
    {
        using (var reader = new MediaFoundationReader(inputFilePath))
        {
            var quality = new LAMEPreset();
    
            using (var writer = new LameMP3FileWriter(outputFilePath, reader.WaveFormat, quality))
            {
                reader.CopyTo(writer);
            }
        }
    }
}
