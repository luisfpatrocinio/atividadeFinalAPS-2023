#nullable disable
using System.ComponentModel.DataAnnotations;
namespace LuisFPatrocinio.Models
{
    public class Categoria
    {
        [Display(Name="Código da Categoria")]
        public int Id {get;set;}
        public string Nome {get;set;}
        public virtual ICollection<Produto> Produtos {get;set;}
    }
}