using Microsoft.AspNetCore.Mvc;

namespace Silas.ViewComponents
{
    public class  RigthPanelViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string userRole, int id)
        {
            // Aquí puedes realizar lógica adicional o cargar datos si es necesario.
            // Por ejemplo, si deseas obtener datos adicionales según el userRole.
            // En este ejemplo, simplemente se pasa el userRole al componente.
            return View("LeftPanel", userRole);
        }

    }
}
