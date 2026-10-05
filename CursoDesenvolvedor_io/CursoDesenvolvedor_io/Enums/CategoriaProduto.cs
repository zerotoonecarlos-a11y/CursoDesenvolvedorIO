using System.ComponentModel.DataAnnotations;

namespace CursoDesenvolvedor_io.Enums;

public enum CategoriaProduto
{
    [Display(Name = "Alimentos")]
    Alimentos = 1,

    [Display(Name = "Bebidas")]
    Bebidas = 2,

    [Display(Name = "Limpeza")]
    Limpeza = 3,

    [Display(Name = "Higiene pessoal")]
    Higiene = 4
}