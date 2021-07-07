using System.Collections.Generic;
using Exemplo_EplayersMvc.Models;

namespace Exemplo_EplayersMvc.Interfaces
{
    public interface IEquipe
    {
         void Criar(Equipe e);

         List<Equipe> LerTodas();

         void Alterar(Equipe e);

         void Deletar(int id);
    }
}