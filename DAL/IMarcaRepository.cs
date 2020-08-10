using System.Collections.Generic;
using APIPatrimonio.Models;

namespace APIPatrimonio.DAL
{
    internal interface IMarcaRepository
    {
        List<Marca> GetMarcas();
        Marca GetSingleMarca(long Id);
        List<Patrimonio> GetPatrimoniosMarca(long Id);
        void InsertMarca(Marca NewMarca);
        void DeleteMarca(long Id);
        void UpdateMarca(Marca NewMarca);
        
    }
}