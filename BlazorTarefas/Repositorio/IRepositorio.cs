using BlazorTarefas.Entidades;

using System.Collections.Generic;

namespace BlazorTarefas.Repositorio
{
    public interface IRepositorio
    {
        List<Tarefa> ObterTarefas();
    }
}
