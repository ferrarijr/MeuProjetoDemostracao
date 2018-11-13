using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace MeuProjetoEntrevista.Models
{
    [Table("Pessoas")]
    public class Pessoa
    {
        public int Id { get; set; }

        [Display(Name = "Pessoa")]
        public bool pessoaFisica { get; set; }
        
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        [RequiredIf("pessoaFisica", true)]
        public string CPF { get; set; }
        
        
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [Required(AllowEmptyStrings = true)]
        [RegularExpression(@"^\d{2}.?\d{3}.?\d{3}/?\d{4}-?\d{2}$", ErrorMessage = "Esse não é um CNPJ válido")]
        [RequiredIf("pessoaFisica", false)]
        public string CNPJ { get; set; }

        //[IdadeMinimaAno(19) ]
        //[Display(Name = "Data de Nascimento")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //[DataType(DataType.Date, ErrorMessage = "Data invalida")]
        [Display(Name = "Data Nascimento")]
        [Required(ErrorMessage = "Informe sua idade")]
        [IdadeMinima(19)]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Display(Name = "Nome/Razão Social")]
        public string Nome_RazaoSocial { get; set; }

        [Required]
        [Display(Name = "Sobre Nome/Fantasia")]
        public string SobreNome_Fantasia { get; set; }

        [Required]
        public string CEP { get; set; }

        [Required]
        public string Logradouro { get; set; }

        [Required]
        [Display(Name ="Número")]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string UF { get; set; }
    }
}