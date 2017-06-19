using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SistemaAcademico.Models;
using SistemaAcademico.DataModel;
using SistemaAcademico.DTOS;
using SistemaAcademico.Classes;

namespace SistemaAcademico.Controllers.Api
{
    public class MenuOptionsController : ApiController
    {
        private AcademicSystemContext context;

        public MenuOptionsController()
        {
            context = new DataModel.AcademicSystemContext();
        }

        // GET api/<controller>
        public IEnumerable<object> Get()
        {
            var menuOptions = context.OpcionesDelMenu.Select(m => new
            {
                url = m.Link,
                title = m.Title,
                icon = m.Icon
            }).ToList();
            context.Dispose();
            return menuOptions;
        }

        // POST api/<controller>
        public object Post(MenuOption MenuOption)
        {
            if (ModelState.IsValid)
            {
                context.OpcionesDelMenu.Add(MenuOption);
                context.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            else return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }

        // PUT api/<controller>/5
        public object Put(MenuOption menuoption)
        {
            var current = context.OpcionesDelMenu.Where(m => m.id == menuoption.id).FirstOrDefault();
            current.Icon = menuoption.Icon;
            current.Link = menuoption.Link;
            current.Title = menuoption.Title;
            current.Description = menuoption.Description; context.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // DELETE api/<controller>/5
        public object Delete(int id)
        {
            try
            {
                context.OpcionesDelMenu.Remove(context.OpcionesDelMenu.Where(m => m.id == id).First());
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                if (e.InnerException != null) return Request.CreateResponse(HttpStatusCode.InternalServerError);
                else return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

        }
    }
}