using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations

namespace Campanha_sugestao.Models
{
    public class RESPONSAVEL
    {
        [Required(ErrorMessage = "O id do responsável é obrigatorio", AllowEmptyStrings = false)]
        [Display(Name = "Digite o código de identificação do funcionário")]
        [StringLength 6, MinimumLength = 6)]
        public int Id_responsavel { get; set; }
        public int Id_funcionario { get; set; }
        public int Id_empresa { get; set; }
        
    }
}