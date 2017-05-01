using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MebeliGergana.Data.Mocks;
using MebeliGergana.Models.BindingModels;
using MebeliGergana.Models.EntityModels;
using MebeliGergana.Models.ViewModels;
using MebeliGergana.Models.ViewModels.Admin;
using MebeliGergana.Services.Interfaces;

namespace MebeliGergana.Services.TestServices
{
   public class ProductsServicesTest:IProductsServices
    {
        private FackeMebeliGerganaContext Context;

        public ProductsServicesTest()
        {
            this.Context=new FackeMebeliGerganaContext();
        }

        public ICollection<ProductViewModel> GetSpalniViewMoedel()
        {
            var spalni = this.Context.Spalni;
            IList<ProductViewModel> models = new List<ProductViewModel>();
            foreach (var saplnq in spalni)
            {
                ProductViewModel model = Mapper.Map<Spalnq, ProductViewModel>(saplnq);
                models.Add(model);
            }

            return models;
        }

        public ICollection<SuppliersViewModel> GetSuppliers()
        {
            var suppliers = this.Context.Suppliers;
            IList<SuppliersViewModel> models = new List<SuppliersViewModel>();
            foreach (var supplier in suppliers)
            {
                SuppliersViewModel model = Mapper.Map<Supplier, SuppliersViewModel>(supplier);
                models.Add(model);
            }
            return models;
        }

        public void AddSpalnq(IzdeliqBindingModel model)
        {
            Spalnq spalnq = new Spalnq()
            {
                CatNumber = model.CatNumber,
                Color = model.Color,
                Description = model.Description,
                Price = model.Price,
                Name = model.Name,
                Razmeri = model.Razmeri,
                Type = model.Type,
                NalichnostBr = model.NalichnostBr

            };
            
            this.Context.Spalni.Add(spalnq);
            
        }

        public FullProductViewModel GetSpalnqById(int id)
        {
            throw new NotImplementedException();
        }

        public void EditSpalnq(EditIzdlieBindingModel model)
        {
            throw new NotImplementedException();
        }

        public DeleteProductViewModel GetDeleteSpalnqViewModel(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteSpalnq(DeleteIzdelieBindingModel model)
        {
            throw new NotImplementedException();
        }

        public ICollection<ProductViewModel> GetDetskiViewMoedel()
        {
            throw new NotImplementedException();
        }

        public void AddDetski(IzdeliqBindingModel model)
        {
            throw new NotImplementedException();
        }

        public FullProductViewModel GetDetskaById(int id)
        {
            throw new NotImplementedException();
        }

        public void EditDetski(EditIzdlieBindingModel model)
        {
            throw new NotImplementedException();
        }

        public DeleteProductViewModel GetDeleteDetskaViewModel(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteDetski(DeleteIzdelieBindingModel model)
        {
            throw new NotImplementedException();
        }

        public ICollection<ProductViewModel> GetSekciiViewMoedel()
        {
            throw new NotImplementedException();
        }

        public void AddSekcii(IzdeliqBindingModel model)
        {
            throw new NotImplementedException();
        }

        public DeleteProductViewModel GetDeleteSekciqViewModel(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteSekcii(DeleteIzdelieBindingModel model)
        {
            throw new NotImplementedException();
        }

        public FullProductViewModel GetSekciqById(int id)
        {
            throw new NotImplementedException();
        }

        public void EditSekcii(EditIzdlieBindingModel model)
        {
            throw new NotImplementedException();
        }

        public ICollection<ProductViewModel> GetPortmantaViewMoedel()
        {
            throw new NotImplementedException();
        }

        public void AddPortmanta(IzdeliqBindingModel model)
        {
            throw new NotImplementedException();
        }

        public FullProductViewModel GetPortmantoById(int id)
        {
            throw new NotImplementedException();
        }

        public void EditPortmanta(EditIzdlieBindingModel model)
        {
            throw new NotImplementedException();
        }

        public DeleteProductViewModel GetDeletePortmantoViewModel(int id)
        {
            throw new NotImplementedException();
        }

        public void DeletePortmanta(DeleteIzdelieBindingModel model)
        {
            throw new NotImplementedException();
        }

        public ICollection<ProductViewModel> GetKuhniViewMoedel()
        {
            throw new NotImplementedException();
        }

        public void AddKuhni(IzdeliqBindingModel model)
        {
            throw new NotImplementedException();
        }

        public FullProductViewModel GetKuhnqById(int id)
        {
            throw new NotImplementedException();
        }

        public void EditKuhni(EditIzdlieBindingModel model)
        {
            throw new NotImplementedException();
        }

        public DeleteProductViewModel GetDeleteKuhnqViewModel(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteKuhni(DeleteIzdelieBindingModel model)
        {
            throw new NotImplementedException();
        }

        public ICollection<ProductViewModel> GetMasiViewMoedel()
        {
            throw new NotImplementedException();
        }

        public void AddMasi(IzdeliqBindingModel model)
        {
            throw new NotImplementedException();
        }

        public FullProductViewModel GetMasaById(int id)
        {
            throw new NotImplementedException();
        }

        public void EditMasi(EditIzdlieBindingModel model)
        {
            throw new NotImplementedException();
        }

        public DeleteProductViewModel GetDeleteMasaViewModel(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteMasi(DeleteIzdelieBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
