using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace atv01_3b_DS.Models
{
    public class modeloExemplo
    {

        public string cod { get; set; }

        [Required(ErrorMessage ="Nome obrigatório")]
        [DisplayName("Nome do Cliente")]
        public string nome { get; set; }

    }
}