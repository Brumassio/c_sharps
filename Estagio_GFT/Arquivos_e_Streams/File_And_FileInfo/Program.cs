using static System.Console;

WriteLine("Digite o nome do arquivo");
var nome = ReadLine();

foreach(var @char in Path.GetInvalidFileNameChars())
{
    nome = nome.Replace(@char, '-');
}

var path = Path.Combine(Environment.CurrentDirectory,$"{nome}.txt");

CriarArquivo(path);

WriteLine("Digite enter para finalizar ...");
ReadLine();

static  void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Está a linha 1 do arquivo");
        sw.WriteLine("Está a linha 2 do arquivo");
        sw.WriteLine("Está a linha 3 do arquivo");
    }
    catch 
    {
        
        WriteLine("Erro nome inváilido");
    }

}
