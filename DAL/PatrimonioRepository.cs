using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;
using APIPatrimonio.Models;

namespace APIPatrimonio.DAL
{
    public class PatrimonioRepository : IPatrimonioRepository
    {

        private readonly IDbConnection conexao;

        
        public PatrimonioRepository(IConfiguration conf) => conexao =  new SqlConnection(conf.GetConnectionString("BasePatrimonios"));

        public List<Patrimonio> GetPatrimonios()
        {
            return this.conexao.Query<Patrimonio>("SELECT * FROM Patrimonios").ToList();
        }
        public Patrimonio GetSinglePatrimonio(long Id)
        {
            return this.conexao.Query<Patrimonio>("SELECT * FROM Patrimonios WHERE @tombo = N_Tombo", new { tombo = Id}).SingleOrDefault();
        }
        public void InsertPatrimonio(Patrimonio NewPatrimonio)
        {
            this.conexao.Execute(@"INSERT Patrimonios(MarcaId,Nome, Descricao) VALUES (@NewMarcaId, @NewNome, @NewDescricao)",
            new{NewMarcaId = NewPatrimonio.MarcaId,NewNome = NewPatrimonio.Nome,NewDescricao = NewPatrimonio.Descricao });
            
        }
        public bool DeletePatrimonio(long Id)
        {
            int n = this.conexao.Execute(@"DELETE FROM Patrimonios WHERE @tombo = N_Tombo", new { tombo = Id});

            if(n > 0 ) return true;

            return false;
        }
        public void UpdatePatrimonio(Patrimonio NewPatrimonio)  
        {
            this.conexao.Execute("UPDATE Patrimonios SET MarcaId=@NewMarcaId ,Nome=@NewNome , Descricao=@NewDescricao WHERE N_Tombo=" + NewPatrimonio.N_Tombo,
            new{NewMarcaId = NewPatrimonio.MarcaId, NewNome = NewPatrimonio.Nome, NewDescricao = NewPatrimonio.Descricao });

        }
    }
}