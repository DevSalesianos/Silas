using Microsoft.AspNetCore.Mvc;
using Silas.Models;
using Silas.Models.Companies;

namespace Silas.ViewComponents
{

    public class  RightPanelViewComponent: ViewComponent
    {

        
		private readonly CompanyService _companyService;

        public RightPanelViewComponent(CompanyService companyService)
		{
			_companyService = companyService;
		}


		public async Task<IViewComponentResult> InvokeAsync(string userRole, int id)
        {
            // Aquí puedes realizar lógica adicional o cargar datos si es necesario.
            // Por ejemplo, si deseas obtener datos adicionales según el userRole.
            // En este ejemplo, simplemente se pasa el userRole al componente.

            var appliesList = await _companyService.ListAplliesByCompanyId(id);

            var model = new RightPanelViewModel
			{
				userRole = userRole,
				datalist = appliesList
			};

			return View("RightPanel", model);
        }

    }
}
