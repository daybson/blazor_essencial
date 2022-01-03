using CodeBehind.Services;

using Microsoft.AspNetCore.Components;

namespace CodeBehind.Pages
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;
        
        [Inject]
        ServicoDemo ServicoDemo { get; set; }

        protected void IncrementCount()
        {
            currentCount++;
            ServicoDemo.Valor = currentCount;
        }
    }
}
