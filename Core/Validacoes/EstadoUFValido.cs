using Core.DTOs;
using System.ComponentModel.DataAnnotations;

namespace Core.Validacoes
{
    public class EstadoUFValido : ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var pessoa = (PessoaDTO) value;

            if (string.IsNullOrEmpty(pessoa.UF))
                return new ValidationResult("Estado/UF não informado");

            if (pessoa.UF.Length != 2)
                return new ValidationResult("Estado/UF informado deve conter 2 caracteres");
           
            return ValidationResult.Success;
        }
    }
}
