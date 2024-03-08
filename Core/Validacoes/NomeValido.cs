using Core.DTOs;
using System.ComponentModel.DataAnnotations;

namespace Core.Validacoes
{
    public class NomeValido : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var pessoa = (PessoaDTO) value;

            if (string.IsNullOrEmpty(pessoa.Nome))
                return new ValidationResult("Nome não informado");

            if (pessoa.Nome.Length > 100)
                return new ValidationResult("Nome informado não pode ser maior que 100 caracteres");

            if (pessoa.Nome.Length < 3)
                return new ValidationResult("Nome deve conter pelo menos 3 caracteres");


            return ValidationResult.Success;

        }
    }
}
