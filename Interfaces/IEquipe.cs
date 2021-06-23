using System.Collections.Generic;
using MVC_EPlayers.Models;

namespace MVC_EPlayers.Interfaces
{
    public interface IEquipe
    {
         void Criar (Equipe e);

         List<Equipe> LerTodas();

         void Alterar (Equipe e);

         void Deletar (int id);
    }
}