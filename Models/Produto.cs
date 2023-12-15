#nullable disable

using System.ComponentModel.DataAnnotations.Schema;

namespace LuisFPatrocinio.Models;

public class Produto{
    public int Id {get; set;}
    public string Descricao {get; set;}
    public string PathImagem {get; set;}
    public decimal Preco {get; set;}
    public int Quantidade {get; set;}
    [ForeignKey("Categoria")]
    public int CategoriaId {get;set;}
    public virtual Categoria Categoria {get;set;}
}