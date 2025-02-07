using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using Silas.Models;
using Silas.Models.Companies;
using Silas.Models.Offers;
=======
using Microsoft.AspNetCore.Mvc.Formatters;
using Silas.Models;
using Silas.Models.Companies;
using Silas.Models.Offers;
using Silas.ViewModels;
using System.Reflection;
>>>>>>> panelderecho1

namespace Silas.ViewComponents
{
    public class LeftPanelViewComponent : ViewComponent
    {
        private readonly OfferService _offerService;

        public LeftPanelViewComponent(OfferService offerService)
        {
            _offerService = offerService;
        }


        public async Task<IViewComponentResult> InvokeAsync(string userRole, int userId)
        {
<<<<<<< HEAD
        
            List<Offer> offers = await _offerService.GetOffersByCompanyIdAsync(11);
            var model = new LeftPanelViewModel
            {
                userRole = userRole,
                datalist = offers
            };

            return View("LeftPanel", model);
        
        }
    }
}
=======
            List<Offer> offers = await _offerService.GetOffersByCompanyIdAsync(userId);
            if (userRole == "company")
            {
                var model = new LeftPanelViewModel
                {
                    userRole = userRole,
                    datalist = offers
                };
                return View("LeftPanel", model);

            }
            else if (userRole == "student")
            {
                //OTRA COSA
            }
            else
            {
                //EL ADMIN, OTRA COSA
            }

            return View("LeftPanel");
        }
    }
}
>>>>>>> panelderecho1
