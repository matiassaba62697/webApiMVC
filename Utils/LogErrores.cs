using curso.WebApiMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace curso.WebApiMVC.Utils
{
    /// <summary>
    /// <create>
    /// matias 29/010/2019
    /// </create>
    /// </summary>
    public class LogErrores
    {
        public static void crearLog(Exception ex, string comentarios="") {

            var st = new StackTrace(ex, true);
            var informationError = st.GetFrames()
                .Select(frame => new
                {
                    FileName = frame.GetFileName(),
                    LineNumber = frame.GetFileLineNumber(),
                    ColumnNumber = frame.GetFileColumnNumber(),
                    Method = frame.GetMethod(),
                    Class = frame.GetMethod().DeclaringType,
                }).FirstOrDefault();
            LogErroresSistema log = new LogErroresSistema
            {
                FechaLogError = DateTime.Now,
                HelpLink = (ex.HelpLink == null) ? "" : ex.HelpLink.ToString(),
                HResul = (ex.HResult == 0) ? "" : ex.HResult.ToString(),
                InnerExeption = (ex.InnerException == null) ? "" : ex.InnerException.ToString(),
                ClaseLogError = informationError.Class.ToString(),
                MetodoLogError = informationError.LineNumber.ToString(),
                Source = ex.Source.ToString(),
                StackTrace = ex.StackTrace.ToString(),
                TargetSize = ex.StackTrace.ToString(),
                ComentarioDesarrolador = comentarios
            };
            InsertLog(log);
        }

        private static void InsertLog(LogErroresSistema log) {
            ApplicationDbContext _context = new ApplicationDbContext();
            try {
                _context.LogErroresSistema.Add(log);
                _context.SaveChanges();
            }
            catch (Exception ex) {
                throw ex; 
            }
        }
    
    }

}