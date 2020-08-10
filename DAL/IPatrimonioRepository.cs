using System.Collections.Generic;
using APIPatrimonio.Models;

namespace APIPatrimonio.DAL
{
    internal interface IPatrimonioRepository
    {
        List<Patrimonio> GetPatrimonios();
        Patrimonio GetSinglePatrimonio(long Id);
        void InsertPatrimonio(Patrimonio NewPatrimonio);
        bool DeletePatrimonio(long Id);
        void UpdatePatrimonio(Patrimonio NewPatrimonio);

        
    }
}