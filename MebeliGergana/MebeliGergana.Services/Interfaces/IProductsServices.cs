using System.Collections.Generic;
using MebeliGergana.Models.BindingModels;
using MebeliGergana.Models.ViewModels;
using MebeliGergana.Models.ViewModels.Admin;

namespace MebeliGergana.Services.Interfaces
{
    public interface IProductsServices
    {
        ICollection<ProductViewModel> GetSpalniViewMoedel();
        ICollection<SuppliersViewModel> GetSuppliers();
        void AddSpalnq(IzdeliqBindingModel model);
        FullProductViewModel GetSpalnqById(int id);
        void EditSpalnq(EditIzdlieBindingModel model);
        DeleteProductViewModel GetDeleteSpalnqViewModel(int id);
        void DeleteSpalnq(DeleteIzdelieBindingModel model);
        ICollection<ProductViewModel> GetDetskiViewMoedel();
        void AddDetski(IzdeliqBindingModel model);
        FullProductViewModel GetDetskaById(int id);
        void EditDetski(EditIzdlieBindingModel model);
        DeleteProductViewModel GetDeleteDetskaViewModel(int id);
        void DeleteDetski(DeleteIzdelieBindingModel model);
        ICollection<ProductViewModel> GetSekciiViewMoedel();
        void AddSekcii(IzdeliqBindingModel model);
        DeleteProductViewModel GetDeleteSekciqViewModel(int id);
        void DeleteSekcii(DeleteIzdelieBindingModel model);
        FullProductViewModel GetSekciqById(int id);
        void EditSekcii(EditIzdlieBindingModel model);
        ICollection<ProductViewModel> GetPortmantaViewMoedel();
        void AddPortmanta(IzdeliqBindingModel model);
        FullProductViewModel GetPortmantoById(int id);
        void EditPortmanta(EditIzdlieBindingModel model);
        DeleteProductViewModel GetDeletePortmantoViewModel(int id);
        void DeletePortmanta(DeleteIzdelieBindingModel model);
        ICollection<ProductViewModel> GetKuhniViewMoedel();
        void AddKuhni(IzdeliqBindingModel model);
        FullProductViewModel GetKuhnqById(int id);
        void EditKuhni(EditIzdlieBindingModel model);
        DeleteProductViewModel GetDeleteKuhnqViewModel(int id);
        void DeleteKuhni(DeleteIzdelieBindingModel model);
        ICollection<ProductViewModel> GetMasiViewMoedel();
        void AddMasi(IzdeliqBindingModel model);
        FullProductViewModel GetMasaById(int id);
        void EditMasi(EditIzdlieBindingModel model);
        DeleteProductViewModel GetDeleteMasaViewModel(int id);
        void DeleteMasi(DeleteIzdelieBindingModel model);
        void AddSupplier(AddSupplierBindingModel model);
        EditSupplierViewModel EditSupplier(int id);
        void SaveEditSupplier(EditSupplierBindingModel model);
        SuppliersViewModel GetDeleteSuppliersViewModel(int id);
        void DeleteSupplier(DeleteSupplierBindingModel model);
        ICollection<PorachkaViewModel> GetPorachkiViewMoedel();
        PorachkaViewModel GetPorackaFinish(int id);
        void FinishPorachka(PorachkaFinishBindingModel model);
        ICollection<PorachkaViewModel> GetActivePorachkiViewMoedel();
    }
}