using System;
using System.Globalization;
using Produtos;

namespace Arquivos
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sourceFile =
                @"C:\temp\sourceFile.csv";
            string targetFile =
                @"C:\temp\out\targetFile.csv";

            List<Produto> produtos = new List<Produto>();

            try
            {
                using (StreamReader streamReader = File.OpenText(sourceFile))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string[] line = streamReader.ReadLine().Split(',');
                        string nome = line[0];
                        double preco = Convert.ToDouble((line[1]), CultureInfo.InvariantCulture);
                        int quantidade = Convert.ToInt32(line[2]);

                        produtos.Add(new Produto(nome, preco, quantidade));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("ERRO: " + e.Message);
            }

            try
            {
                using (StreamWriter streamWriter = File.AppendText(targetFile))
                {
                    foreach (Produto produto in produtos)
                    {
                        streamWriter.WriteLine(produto.Nome + "," +
                                               produto.PrecoTotal().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("ERRO: " + e.Message);
            }
        }
    }
}