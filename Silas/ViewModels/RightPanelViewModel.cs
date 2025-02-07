using Silas.Models.Applies;

namespace Silas.ViewModels
{
    public class RightPanelViewModel
    {

        public string userRole { get; set; }
        public List<Apply> datalist { get; set; }

        public static implicit operator RightPanelViewModel(RightPanelViewModel v)
        {
            throw new NotImplementedException();
        }
    }
}
