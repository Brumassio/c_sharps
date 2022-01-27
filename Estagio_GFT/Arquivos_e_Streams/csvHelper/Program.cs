using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;
using csvHelper.Model;
using csvHelper.Mapping;

//erCsvComOutroDelimitador();
EscreverCsv();

static void EscreverCsv()
{
    var path = Path.Combine(
    Environment.CurrentDirectory,
    "Saida");

    var di = new DirectoryInfo(path);
    if(!di.Exists)
        di.Create();
    
    path = Path.Combine(path,"usuarios.csv");

    var pessoas = new List<Pessoa>()
    {
        new Pessoa()
        {
            Nome= "Joseph Robert",
            Email = "jose@gmail.com",
            Telefone = 123456,
        },
        new Pessoa()
        {
            Nome= "Emilio de Carvalho",
            Email = "ecorn@gmail.com",
            Telefone = 12345623,
        },
        new Pessoa()
        {
            Nome= "Ronald",
            Email = "ronald@gmail.com",
            Telefone = 654321,
        },
        new Pessoa()
        {
            Nome= "Paulo",
            Email = "paul@gmail.com",
            Telefone = 644545,
        }
    };

    using var sr = new StreamWriter(path);
    var csvConfig = new CsvConfiguration(CultureInfo.InstalledUICulture)
    {
        Delimiter = "|"
    };
    using var csWritter = new CsvWriter(sr,csvConfig);
    csWritter.WriteRecords(pessoas);
}
static void LerCsvComOutroDelimitador()
{
    var path = Path.Combine(
    Environment.CurrentDirectory,
    "Entrada",
    "Livros-preco-com-vírcula.csv");

    var fi = new FileInfo(path);

    if(!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe!");

    using var sr = new StreamReader(fi.FullName); 
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };

    using var csvReader = new CsvReader(sr,csvConfig);
    csvReader.Context.RegisterClassMap<LivroMap>();
    var registros = csvReader.GetRecords<Livrocs>().ToList();

    foreach (var registro in registros)
    {
        Console.WriteLine($"Titulo: {registro.Titulo}");
        Console.WriteLine($"Lançamento: {registro.Lancamento}");
        Console.WriteLine($"Preço: {registro.Preco}");
        Console.WriteLine($"Autor: {registro.Autor}");
        Console.WriteLine("-------------------------");
    }
}

static void LerCsvComClasse()
{
    var path = Path.Combine(
    Environment.CurrentDirectory,
    "Entrada",
    "novos-usuarios.csv");

    var fi = new FileInfo(path);

    if(!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe!");

    using var sr = new StreamReader(fi.FullName); 
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr,csvConfig);

    var registros = csvReader.GetRecords<Usuario>();

    foreach (var registro in registros)
    {
        Console.WriteLine($"nome: {registro.Nome}");
        Console.WriteLine($"Email: {registro.Email}");
        Console.WriteLine($"Telefone: {registro.Telefone}");
        Console.WriteLine("-------------------------");
    }
}

static void LerCsvcomDynamic()
{
    var path = Path.Combine(
    Environment.CurrentDirectory,
    "Entrada",
    "Produtos.csv");

    var fi = new FileInfo(path);

    if(!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não existe!");

    using var sr = new StreamReader(fi.FullName); 
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr,csvConfig);

    var registros = csvReader.GetRecords<dynamic>();

    foreach (var registro in registros)
    {
        Console.WriteLine($"nome: {registro.Produto}");
        Console.WriteLine($"marca: {registro.Marca}");
        Console.WriteLine($"preço: {registro.Preco}");
    }
}

Console.WriteLine("digite [enter] para finalizar");
Console.ReadLine();
