using static System.Console;
CriaCsv();
WriteLine("\n\n Pressione [enter] para finalizar");
ReadLine();

static void CriaCsv()
{
    var path = Path.Combine(
    Environment.CurrentDirectory,
    "Saida");

    var pessoas = new List<Pessoa>()
    {
        new Pessoa()
        {
            Nome = "Joseph",
            Email = "joseph@gmail.com",
            Telefone = 123456,
            Nascimento = new DateOnly(year: 1970, month:2,day:20),

        },
        new Pessoa()
        {
            Nome = "Kikuti",
            Email = "ki@gmail.com",
            Telefone = 1234568,
            Nascimento = new DateOnly(year: 1932, month:2,day:22),

        },
        new Pessoa()
        {
            Nome = "Ronald",
            Email = "ronald@gmail.com",
            Telefone = 1234566,
            Nascimento = new DateOnly(year: 1990, month:3,day:30),

        }
    };

    var di = new DirectoryInfo(path);
    if(!di.Exists)
    {
        di.Create();
        path = Path.Combine(path,"usuario.csv");
    }
    using var sw = new StreamWriter(path);
    sw.WriteLine("nome,email,telefone,nascimento");
    foreach (var pessoa in pessoas)
    {
        var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
        sw.WriteLine(linha);
    }
}

static void LerCsv()
{
    var path = Path.Combine(
        Environment.CurrentDirectory,
        "Entrada",
        "usuarios-exportacao.csv");
    if(File.Exists(path))
    {
        using var sr = new StreamReader(path);
        var cabecalho = sr.ReadLine()?.Split(',');
        while(true)
        {
            var registro = sr.ReadLine()?.Split(',');
            if(registro == null) break;
            if(cabecalho.Length != registro.Length)
            {
                WriteLine("Arquivo fora do padrão");
                break;
            }
            for (int i = 0; i < registro.Length; i++)
            {
                WriteLine($"{cabecalho?[i]}:{registro[i]}");
            }
            WriteLine("---------------");
        }
    }
    else
    {
        WriteLine($"o arquivo {path} não existe!!");
    }

}

class Pessoa
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Telefone { get; set; }
    public DateOnly Nascimento { get; set; }
}