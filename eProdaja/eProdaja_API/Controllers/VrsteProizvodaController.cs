﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using eProdaja_API.Models;

namespace eProdaja_API.Controllers
{
    public class VrsteProizvodaController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        //api/VrsteProizvoda
        public List<VrsteProizvoda> GetVrsteProizvoda()
        {
            return db.VrsteProizvoda.OrderBy(x => x.Naziv).ToList();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}