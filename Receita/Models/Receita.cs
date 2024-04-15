namespace Receita.Models;

    public class Receitas
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<string> Tipo { get; set; } = [];
        public string Preparo { get; set; }
        public string Imagem { get; set; }
    }
