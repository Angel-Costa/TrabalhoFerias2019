using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    interface ICidadeRepository
    {
        List<Cidade> ObterTodos(string busca);

        bool Update(Cidade cidade);

        int Inserir(Cidade cidade);

        bool Delete(int id);

        Cidade ObterPeloId(int id);
    }
}
