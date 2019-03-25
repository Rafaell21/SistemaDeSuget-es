using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations

namespace Campanha_sugestao.Models
{
    public class PERGUNTAS
    {
        
        public int Id_perguntas { get; set; }
        
        public int Id_Campanha { get; set; }
       
        public string Pergunta1 { get; set; }

       
        public string Pergunta2 { get; set; }

       
        public string Pergunta3 { get; set; }

        
        public string Pergunta4 { get; set; }

       
        public string Pergunta5 { get; set; }

        
        public string Pergunta6 { get; set; }

        
        public string Pergunta7 { get; set; }

    }
}