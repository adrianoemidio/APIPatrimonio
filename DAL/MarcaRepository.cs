using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Linq;
using Dapper;
using APIPatrimonio.Models;


namespace APIPatrimonio.DAL
{
 
    public class MarcaRepository : IMarcaRepository
    {
        private readonly IDbConnection conexao;

        public MarcaRepository(IConfiguration conf)  => conexao = new SqlConnection(conf.GetConnectionString("BasePatrimonios"));
        public List<Marca> GetMarcas()
        {
            return this.conexao.Query<Marca>("SELECT * FROM Marcas").ToList();
        }
        public Marca GetSingleMarca(long Id)
        {
             return this.conexao.Query<Marca>("SELECT * FROM Marcas WHERE @GMarca = MarcaId", new { GMarca = Id}).SingleOrDefault();
        }

        public List<Patrimonio> GetPatrimoniosMarca(long Id)
        {
            return this.conexao.Query<Patrimonio>("SELECT * FROM Patrimonios WHERE @GMarca = MarcaId", new { GMarca = Id}).ToList();
        }
        public void InsertMarca(Marca NewMarca)
        {
            this.conexao.Execute(@"INSERT Marcas(Nome) VALUES (@NewNome)",
            new{NewNome = NewMarca.Nome});
        }
        public void DeleteMarca(long Id)
        {
            this.conexao.Execute(@"DELETE FROM Patrimonios WHERE @GMarca = MarcaId", new { GMarca = Id});
            this.conexao.Execute(@"DELETE FROM Marcas WHERE @GMarca = MarcaId", new { GMarca = Id});
        }
        public void UpdateMarca(Marca NewMarca)
        {
            this.conexao.Execute("UPDATE Marcas SET Nome=@NewNome WHERE MarcaId=" + NewMarca.MarcaId,
            new{NewNome = NewMarca.Nome});
        }
    }

}