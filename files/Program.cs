using files.Entities;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;

string path = "D:\\temp\\products.csv";
List<Product> products = new List<Product>();

try
{
    string[] lines = File.ReadAllLines(path);
    
    foreach(string line in lines)
    {
        string[] words = line.Split(',');
        products.Add(new Product(words[0], double.Parse(words[1], CultureInfo.InvariantCulture), int.Parse(words[2])));
    }

    string outDir = "D:\\temp\\out\\";

    if (!File.Exists(outDir))
    {
        Directory.CreateDirectory(outDir);
    }
    
    using (StreamWriter sr = new StreamWriter(File.Create("D:\\temp\\out\\summary.csv")))
    {
        foreach(Product p in products)
        {
            sr.WriteLine(p);
        }
    };

}
catch(IOException e)
{
    Console.WriteLine("An error occurred"+ e.Message);
}
    
   
