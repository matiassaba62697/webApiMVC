using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace curso.WebApiMVC.Models
{ 

    public class LogErroresSistema
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLog { get; set; }
        public DateTime FechaLogError { get; set; }
        public string Controlador { get; set; }
        public string ClaseLogError { get; set; }
        public string MetodoLogError { get; set; }
        public string HelpLink { get; set; }
        public string HResul { get; set; }
        public string InnerExeption { get; set; }
        public string Source { get; set; }
        public string StackTrace { get; set; }
        public string TargetSize { get; set; }
        public string ComentarioDesarrolador { get; set; }
    }
}