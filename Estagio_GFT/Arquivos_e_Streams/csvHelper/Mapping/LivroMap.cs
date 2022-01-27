using  CsvHelper.Configuration;
using System.Globalization;
using csvHelper.Model;

namespace csvHelper.Mapping
{
    public class LivroMap : ClassMap<Livrocs>
    {
        public LivroMap()
        {
            Map(x => x.Titulo).Name("titulo");
            Map(x =>x.Preco)
                .Name("preço")
                .TypeConverterOption
                .CultureInfo(CultureInfo.GetCultureInfo("pt-BR"));
            Map(x => x.Autor).Name("autor");
            Map(x => x.Lancamento)
            .Name("lançamento")
            .TypeConverterOption
            .Format(new [] {"dd/MM/yyyy"});;
        }
    }
}