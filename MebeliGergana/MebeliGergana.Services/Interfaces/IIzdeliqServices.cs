using System.Collections.Generic;
using MebeliGergana.Models.ViewModels;

namespace MebeliGergana.Services.Interfaces
{
    public interface IIzdeliqServices
    {
        ICollection<IzdeliqViewModel> GetIzdeliqSpalnqModels();
        ICollection<IzdeliqViewModel> GetIzdeliqDetsciModel();
        ICollection<IzdeliqViewModel> GetIzdeliqSekciiModel();
        ICollection<IzdeliqViewModel> GetIzdeliqPortmantaModel();
        ICollection<IzdeliqViewModel> GetIzdeliqKuhniModel();
        ICollection<IzdeliqViewModel> GetIzdeliqMasiModel();
        DetailsViewModel GetDetailsViewModel(int id, string izdelie);
    }
}