using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APIPatrimonio.Models;
using APIPatrimonio.DAL;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace APIPatrimonio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatrimoniosController : ControllerBase
    {
        //GET patrimonios - Obter todos os patrimônios 
        [HttpGet]
        public List<Patrimonio> GetPatrimonios([FromServices]IConfiguration conf)
        {
            return new PatrimonioRepository(conf).GetPatrimonios();
        }

        //GET patrimonios/{id} - Obter um patrimônio por ID 
        [HttpGet("{id}")]
        public Patrimonio GetOnePatrimonio(long id,[FromServices]IConfiguration conf)
        {
            return new PatrimonioRepository(conf).GetSinglePatrimonio(id);
        }

        //POST patrimonios - Inserir um novo patrimônio 
        [HttpPost]
        public void PostPatrimonio([FromBody]Patrimonio NewPatrimonio,[FromServices]IConfiguration conf)
        {
            new PatrimonioRepository(conf).InsertPatrimonio(NewPatrimonio);

        }


        //PUT patrimonios/{id} - Alterar os dados de um patrimônio
        [HttpPut("{id}")]
        public void PutPatrimonio(long id,[FromBody]Patrimonio NewPatrimonio,[FromServices]IConfiguration conf)
        {
            NewPatrimonio.N_Tombo = id;

            new PatrimonioRepository(conf).UpdatePatrimonio(NewPatrimonio);

        } 

        //DELETE patrimonios/{id} - Excluir um patrimônio 
        [HttpDelete("{id}")]
        public bool Delete(long id,[FromServices]IConfiguration conf)
        {
           return new PatrimonioRepository(conf).DeletePatrimonio(id);

        }


        
    }
}