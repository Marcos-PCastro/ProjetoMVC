using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMVC.Models;

[Table("Categorias")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }
    [StringLength(100, ErrorMessage = "O Tamanho máximo são 100 caracteres")]
    [Required(ErrorMessage ="Informe o nome da categoria")]
    [Display(Name ="Nome")]
    public string CategoriaNome { get; set; }
    [StringLength(200, ErrorMessage = "O Tamanho máximo são 100 caracteres")]
    [Required(ErrorMessage = "Informe a descrição da Categoria")]
    [Display(Name = "Nome")]
    public string Descricao { get; set; }


}
