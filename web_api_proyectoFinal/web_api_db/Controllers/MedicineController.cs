using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using web_api_db.Models;
namespace web_api_db.Models{
   public class Conexion : DbContext{
    public Conexion(DbContextOptions<Conexion> options) : base (options){}
        public DbSet<Medicines> Medicines {get;set;}
    }

   [Route("api/[controller]")] 
   public class MedicinesController : ControllerBase{
      private readonly Conexion dbConexion;
      public MedicinesController(Conexion db){
         dbConexion=db;
      }
    
      [HttpGet]
      public async Task<ActionResult> Get(){
         return Ok(await dbConexion.Medicines.ToArrayAsync());
      }
   }
}