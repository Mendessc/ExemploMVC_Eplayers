using System.Collections.Generic;
using MVC_EPlayers.Models;

namespace MVC_EPlayers.Interfaces
{
    public interface IJogador
    {
         void Criar (Jogador j);
        
        List<Jogador> LerTodos();

        void Alterar(Jogador j);

        void Deletar (int id);
    }
}