using BlazorTarefas.Entidades;

using System.Collections.Generic;

namespace BlazorTarefas.Repositorio
{
    public class Repositorio : IRepositorio
    {
        public List<Tarefa> ObterTarefas()
        {
            return new List<Tarefa>()
            {
                new Tarefa
                {
                    ID = new System.Guid(),
                    Descricao = "Fazer o curso de Blazor",
                    Concluida = false,
                    DataCriacao = new System.DateTime(2021, 12, 15)
                },
                new Tarefa
                {
                    ID = new System.Guid(),
                    Descricao = "Gravar aulas",
                    Concluida = false,
                    DataCriacao = new System.DateTime(2021, 12, 28)
                },
            };
        }
    }
}
