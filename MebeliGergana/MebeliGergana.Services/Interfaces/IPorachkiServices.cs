using MebeliGergana.Models.BindingModels;
using MebeliGergana.Models.ViewModels.User;

namespace MebeliGergana.Services.Interfaces
{
    public interface IPorachkiServices
    {
        CurrentUserViewModel GetClient(string currentUserId);
        void SavePorachka(PorachkaBindingModel model);
    }
}