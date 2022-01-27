CriarDiretoriosGlobo();
CriarArquivo();
var origem = Path.Combine(Environment.CurrentDirectory,"brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory,
                                        "globo",
                                        "América do Sul",
                                        "Argentina",
                                        "argentina.txt");
//MoverArquivo(origem,destino);
CopiarArquivo(origem,destino);

static void CopiarArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe");
        return;
    }
    if(File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo já existe na pasta de destino");
        return;
    }
    File.Copy(pathOrigem,pathDestino);
}

static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe");
        return;
    }
    if(File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo já existe na pasta de destino");
        return;
    }
    File.Move(pathOrigem,pathDestino);
}
static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory,"brasil.txt");
    if(!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Polulação : 231MM");
        sw.WriteLine("IDH : 0,901");
        sw.WriteLine("Dados atualizados em : 25/01/2022");
    }

}
static void CriarDiretoriosGlobo()
{
    var path = Path.Combine(Environment.CurrentDirectory,"globo");
    if(!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path);
        var dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
        var dirAmCentral = dirGlobo.CreateSubdirectory("América Central");
        var dirAmSul = dirGlobo.CreateSubdirectory("América do Sul");

        dirAmNorte.CreateSubdirectory("USA");
        dirAmNorte.CreateSubdirectory("Mexico");
        dirAmNorte.CreateSubdirectory("Canada");

        dirAmCentral.CreateSubdirectory("Costa Rica");
        dirAmCentral.CreateSubdirectory("Panama");

        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Uruguai");
    }

}


