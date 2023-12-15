#nullable disable
using System.ComponentModel.DataAnnotations.Schema;
namespace LuisFPatrocinio.Models;

public class Carrinho {
    public int Id {get; set;}
    public virtual ICollection<Produto> Produtos {get;set;}
    [ForeignKey("Usuario")]
    public virtual int UsuarioId {get;set;}
    public virtual Usuario Usuario {get;set;}
}
