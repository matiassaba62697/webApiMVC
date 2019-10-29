using curso.WebApiMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace curso.WebApiMVC.Utils
{
    public static class ApiResponse
    {
        public static Response GetResponse(int code) {

            Response resultError = new Response();
            try
            {

                ApplicationDbContext _context = new ApplicationDbContext();
                Response result = _context.Response.Where(r => r.code == code).FirstOrDefault();
                if (result != null)
                {
                    return result;
                }
                else
                {
                    System.ArgumentException argEX = new System.ArgumentException("parametro erroeno");
                    throw argEX;
                }

            }
            catch(Exception e) {
                resultError.code = 400;
                resultError.message = "Bad Request";
                resultError.description = "Se completo la tansaccion.\n Por Favor comunique con el administrador ";
                LogErrores.crearLog(e);
                return resultError;
            }
        
        }
    }
}