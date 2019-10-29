using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace curso.WebApiMVC.Models
{
    public class Response
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdResponse { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public string description { get; set; }

        [NotMapped]
        public dynamic result { get; set; }
    }
}