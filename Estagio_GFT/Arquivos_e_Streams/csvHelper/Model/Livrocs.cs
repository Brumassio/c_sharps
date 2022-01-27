using CsvHelper.Configuration.Attributes;
namespace csvHelper.Model
{
    public class Livrocs
    {
       // [Name("titulo")]
        public string Titulo { get; set; }
        //[Name("autor")]

        public string Autor { get; set; }
        //[Name("preço")]
        //[CultureInfo("pt-BR")]
        public decimal Preco { get; set; }
        //[Name("lançamento")]
        //[Format("dd/MM/yyyy")]
       public DateOnly Lancamento { get; set; }
    }
}