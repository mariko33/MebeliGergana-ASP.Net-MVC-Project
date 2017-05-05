using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using MebeliGergana.Data.Interfaces;
using MebeliGergana.Models.BindingModels;
using MebeliGergana.Models.EntityModels;
using MebeliGergana.Models.ViewModels;
using MebeliGergana.Models.ViewModels.Admin;
using MebeliGergana.Services.Interfaces;

namespace MebeliGergana.Services.AdminSereces
{
    public class ProductsServices:Service, IProductsServices
    {

        public ICollection<ProductViewModel> GetSpalniViewMoedel()
        {
            var spalni = this.Context.Spalni;
            IList<ProductViewModel>models= new List<ProductViewModel>();
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
                //SuppliersViewModel model = new SuppliersViewModel()
                //{
                //    Id = supplier.Id,
                //    Name = supplier.Name
                //};
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
            Supplier supplier = this.Context.Suppliers.Find(model.SupplierId);
            spalnq.Supplier = supplier;
            if (model.ImageName != null && model.ImageName.ContentLength > 0)
            {
                using (var reader = new BinaryReader(model.ImageName.InputStream))
                {
                    spalnq.ImagePicture = reader.ReadBytes(model.ImageName.ContentLength);
                }
            }
            
            this.Context.Spalni.Add(spalnq);
            this.Context.SaveChanges();
        }

        public FullProductViewModel GetSpalnqById(int id)
        {
            Spalnq spalnq = this.Context.Spalni.Find(id);
            FullProductViewModel model = Mapper.Map<Spalnq, FullProductViewModel>(spalnq);
            return model;
        }

        public void EditSpalnq(EditIzdlieBindingModel model)
        {
            Spalnq spalnq = this.Context.Spalni.Find(model.Id);
            spalnq.CatNumber = model.CatNumber;
            spalnq.Color = model.Color;
            spalnq.Description = model.Description;
            spalnq.NalichnostBr = model.NalichnostBr;
            spalnq.Name = model.Name;
            spalnq.Price = model.Price;
            spalnq.Razmeri = model.Razmeri;
            spalnq.Type = model.Type;

            if (model.ImageName != null && model.ImageName.ContentLength > 0)
            {
                using (var reader = new BinaryReader(model.ImageName.InputStream))
                {
                    spalnq.ImagePicture = reader.ReadBytes(model.ImageName.ContentLength);
                }
            }

            this.Context.SaveChanges();

        }

        public DeleteProductViewModel GetDeleteSpalnqViewModel(int id)
        {
            Spalnq spalnq = this.Context.Spalni.Find(id);
            DeleteProductViewModel model = Mapper.Map<Spalnq, DeleteProductViewModel>(spalnq);
            return model;
        }

        public void DeleteSpalnq(DeleteIzdelieBindingModel model)
        {
            Spalnq spalnq = this.Context.Spalni.Find(model.Id);
            this.Context.Spalni.Remove(spalnq);
            this.Context.SaveChanges();
        }

        //**********************************************************************************************

        public ICollection<ProductViewModel> GetDetskiViewMoedel()
        {
            var detski = this.Context.Detski;
            IList<ProductViewModel> models = new List<ProductViewModel>();
            foreach (var detska in detski)
            {
                ProductViewModel model = Mapper.Map<Detska, ProductViewModel>(detska);
                models.Add(model);
            }

            return models;
        }

        public void AddDetski(IzdeliqBindingModel model)
        {
            Detska detska = new Detska()
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
            Supplier supplier = this.Context.Suppliers.Find(model.SupplierId);
            detska.Supplier = supplier;
            if (model.ImageName != null && model.ImageName.ContentLength > 0)
            {
                using (var reader = new BinaryReader(model.ImageName.InputStream))
                {
                    detska.ImagePicture = reader.ReadBytes(model.ImageName.ContentLength);
                }
            }

            this.Context.Detski.Add(detska);
            this.Context.SaveChanges();
        }

        public FullProductViewModel GetDetskaById(int id)
        {
            Detska detska = this.Context.Detski.Find(id);
            FullProductViewModel model = Mapper.Map<Detska, FullProductViewModel>(detska);
            return model;
        }

        public void EditDetski(EditIzdlieBindingModel model)
        {
            Detska detska = this.Context.Detski.Find(model.Id);
            detska.CatNumber = model.CatNumber;
            detska.Color = model.Color;
            detska.Description = model.Description;
            detska.NalichnostBr = model.NalichnostBr;
            detska.Name = model.Name;
            detska.Price = model.Price;
            detska.Razmeri = model.Razmeri;
            detska.Type = model.Type;

            if (model.ImageName != null && model.ImageName.ContentLength > 0)
            {
                using (var reader = new BinaryReader(model.ImageName.InputStream))
                {
                    detska.ImagePicture = reader.ReadBytes(model.ImageName.ContentLength);
                }
            }

            this.Context.SaveChanges();
        }

        public DeleteProductViewModel GetDeleteDetskaViewModel(int id)
        {
            Detska detska = this.Context.Detski.Find(id);
            DeleteProductViewModel model = Mapper.Map<Detska, DeleteProductViewModel>(detska);
            return model;
        }

        public void DeleteDetski(DeleteIzdelieBindingModel model)
        {
            Detska detska = this.Context.Detski.Find(model.Id);
            this.Context.Detski.Remove(detska);
            this.Context.SaveChanges();
        }

        //************************************************************************************


        public ICollection<ProductViewModel> GetSekciiViewMoedel()
        {
            var sekcii = this.Context.Sekcii;
            IList<ProductViewModel> models = new List<ProductViewModel>();
            foreach (var sekciq in sekcii)
            {
                ProductViewModel model = Mapper.Map<Sekciq, ProductViewModel>(sekciq);
                models.Add(model);
            }

            return models;
        }


        public void AddSekcii(IzdeliqBindingModel model)
        {
            Sekciq sekciq = new Sekciq()
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
            Supplier supplier = this.Context.Suppliers.Find(model.SupplierId);
            sekciq.Supplier = supplier;
            if (model.ImageName != null && model.ImageName.ContentLength > 0)
            {
                using (var reader = new BinaryReader(model.ImageName.InputStream))
                {
                    sekciq.ImagePicture = reader.ReadBytes(model.ImageName.ContentLength);
                }
            }

            this.Context.Sekcii.Add(sekciq);
            this.Context.SaveChanges();
        }

        public DeleteProductViewModel GetDeleteSekciqViewModel(int id)
        {
            Sekciq sekciq = this.Context.Sekcii.Find(id);
            DeleteProductViewModel model = Mapper.Map<Sekciq, DeleteProductViewModel>(sekciq);
            return model;
        }

        public void DeleteSekcii(DeleteIzdelieBindingModel model)
        {
            Sekciq sekciq = this.Context.Sekcii.Find(model.Id);
            this.Context.Sekcii.Remove(sekciq);
            this.Context.SaveChanges();
        }

        public FullProductViewModel GetSekciqById(int id)
        {
            Sekciq sekciq = this.Context.Sekcii.Find(id);
            FullProductViewModel model = Mapper.Map<Sekciq, FullProductViewModel>(sekciq);
            return model;
        }

        public void EditSekcii(EditIzdlieBindingModel model)
        {
            Sekciq sekciq = this.Context.Sekcii.Find(model.Id);
            sekciq.CatNumber = model.CatNumber;
            sekciq.Color = model.Color;
            sekciq.Description = model.Description;
            sekciq.NalichnostBr = model.NalichnostBr;
            sekciq.Name = model.Name;
            sekciq.Price = model.Price;
            sekciq.Razmeri = model.Razmeri;
            sekciq.Type = model.Type;

            if (model.ImageName != null && model.ImageName.ContentLength > 0)
            {
                using (var reader = new BinaryReader(model.ImageName.InputStream))
                {
                    sekciq.ImagePicture = reader.ReadBytes(model.ImageName.ContentLength);
                }
            }

            this.Context.SaveChanges();
        }

        //*****************************************************************************************

        public ICollection<ProductViewModel> GetPortmantaViewMoedel()
        {
            var portmanta = this.Context.Portmanta;
            IList<ProductViewModel> models = new List<ProductViewModel>();
            foreach (var portmanto in portmanta)
            {
                ProductViewModel model = Mapper.Map<Portmanto, ProductViewModel>(portmanto);
                models.Add(model);
            }

            return models;
        }

        public void AddPortmanta(IzdeliqBindingModel model)
        {
            Portmanto portmanto = new Portmanto()
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
            Supplier supplier = this.Context.Suppliers.Find(model.SupplierId);
            portmanto.Supplier = supplier;
            if (model.ImageName != null && model.ImageName.ContentLength > 0)
            {
                using (var reader = new BinaryReader(model.ImageName.InputStream))
                {
                    portmanto.ImagePicture = reader.ReadBytes(model.ImageName.ContentLength);
                }
            }

            this.Context.Portmanta.Add(portmanto);
            this.Context.SaveChanges();
        }

        public FullProductViewModel GetPortmantoById(int id)
        {
            Portmanto portmanto = this.Context.Portmanta.Find(id);
            FullProductViewModel model = Mapper.Map<Portmanto, FullProductViewModel>(portmanto);
            return model;
        }

        public void EditPortmanta(EditIzdlieBindingModel model)
        {
            Portmanto portmanto = this.Context.Portmanta.Find(model.Id);
            portmanto.CatNumber = model.CatNumber;
            portmanto.Color = model.Color;
            portmanto.Description = model.Description;
            portmanto.NalichnostBr = model.NalichnostBr;
            portmanto.Name = model.Name;
            portmanto.Price = model.Price;
            portmanto.Razmeri = model.Razmeri;
            portmanto.Type = model.Type;

            if (model.ImageName != null && model.ImageName.ContentLength > 0)
            {
                using (var reader = new BinaryReader(model.ImageName.InputStream))
                {
                    portmanto.ImagePicture = reader.ReadBytes(model.ImageName.ContentLength);
                }
            }

            this.Context.SaveChanges();
        }

        public DeleteProductViewModel GetDeletePortmantoViewModel(int id)
        {
            Portmanto portmanto = this.Context.Portmanta.Find(id);
            DeleteProductViewModel model = Mapper.Map<Portmanto, DeleteProductViewModel>(portmanto);
            return model;
        }

        public void DeletePortmanta(DeleteIzdelieBindingModel model)
        {
            Portmanto portmanto = this.Context.Portmanta.Find(model.Id);
            this.Context.Portmanta.Remove(portmanto);
            this.Context.SaveChanges();
        }

        //***************************************************************************************************


        public ICollection<ProductViewModel> GetKuhniViewMoedel()
        {
            var kuhni = this.Context.Kuhni;
            IList<ProductViewModel> models = new List<ProductViewModel>();
            foreach (var kuhnq in kuhni)
            {
                ProductViewModel model = Mapper.Map<Kuhnq, ProductViewModel>(kuhnq);
                models.Add(model);
            }

            return models;
        }


        public void AddKuhni(IzdeliqBindingModel model)
        {
            Kuhnq kuhnq = new Kuhnq()
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
            Supplier supplier = this.Context.Suppliers.Find(model.SupplierId);
            kuhnq.Supplier = supplier;
            if (model.ImageName != null && model.ImageName.ContentLength > 0)
            {
                using (var reader = new BinaryReader(model.ImageName.InputStream))
                {
                    kuhnq.ImagePicture = reader.ReadBytes(model.ImageName.ContentLength);
                }
            }

            this.Context.Kuhni.Add(kuhnq);
            this.Context.SaveChanges();
        }

        public FullProductViewModel GetKuhnqById(int id)
        {
            Kuhnq kuhnq = this.Context.Kuhni.Find(id);
            FullProductViewModel model = Mapper.Map<Kuhnq, FullProductViewModel>(kuhnq);
            return model;
        }

        public void EditKuhni(EditIzdlieBindingModel model)
        {
            Kuhnq kuhnq = this.Context.Kuhni.Find(model.Id);
            kuhnq.CatNumber = model.CatNumber;
            kuhnq.Color = model.Color;
            kuhnq.Description = model.Description;
            kuhnq.NalichnostBr = model.NalichnostBr;
            kuhnq.Name = model.Name;
            kuhnq.Price = model.Price;
            kuhnq.Razmeri = model.Razmeri;
            kuhnq.Type = model.Type;

            if (model.ImageName != null && model.ImageName.ContentLength > 0)
            {
                using (var reader = new BinaryReader(model.ImageName.InputStream))
                {
                    kuhnq.ImagePicture = reader.ReadBytes(model.ImageName.ContentLength);
                }
            }

            this.Context.SaveChanges();
        }

        public DeleteProductViewModel GetDeleteKuhnqViewModel(int id)
        {
            Kuhnq kuhnq = this.Context.Kuhni.Find(id);
            DeleteProductViewModel model = Mapper.Map<Kuhnq, DeleteProductViewModel>(kuhnq);
            return model;
        }

        public void DeleteKuhni(DeleteIzdelieBindingModel model)
        {
            Kuhnq kuhnq = this.Context.Kuhni.Find(model.Id);
            this.Context.Kuhni.Remove(kuhnq);
            this.Context.SaveChanges();
        }

        //********************************************************************************************


        public ICollection<ProductViewModel> GetMasiViewMoedel()
        {
            var masi = this.Context.Masi;
            IList<ProductViewModel> models = new List<ProductViewModel>();
            foreach (var masa in masi)
            {
                ProductViewModel model = Mapper.Map<Masa, ProductViewModel>(masa);
                models.Add(model);
            }

            return models;
        }

        public void AddMasi(IzdeliqBindingModel model)
        {
            Masa masa = new Masa()
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
            Supplier supplier = this.Context.Suppliers.Find(model.SupplierId);
            masa.Supplier = supplier;
            if (model.ImageName != null && model.ImageName.ContentLength > 0)
            {
                using (var reader = new BinaryReader(model.ImageName.InputStream))
                {
                    masa.ImagePicture = reader.ReadBytes(model.ImageName.ContentLength);
                }
            }

            this.Context.Masi.Add(masa);
            this.Context.SaveChanges();
        }

        public FullProductViewModel GetMasaById(int id)
        {
            Masa masa = this.Context.Masi.Find(id);
            FullProductViewModel model = Mapper.Map<Masa, FullProductViewModel>(masa);
            return model;
        }

        public void EditMasi(EditIzdlieBindingModel model)
        {
            Masa masa = this.Context.Masi.Find(model.Id);
            masa.CatNumber = model.CatNumber;
            masa.Color = model.Color;
            masa.Description = model.Description;
            masa.NalichnostBr = model.NalichnostBr;
            masa.Name = model.Name;
            masa.Price = model.Price;
            masa.Razmeri = model.Razmeri;
            masa.Type = model.Type;

            if (model.ImageName != null && model.ImageName.ContentLength > 0)
            {
                using (var reader = new BinaryReader(model.ImageName.InputStream))
                {
                    masa.ImagePicture = reader.ReadBytes(model.ImageName.ContentLength);
                }
            }

            this.Context.SaveChanges();
        }

        public DeleteProductViewModel GetDeleteMasaViewModel(int id)
        {
            Masa masa = this.Context.Masi.Find(id);
            DeleteProductViewModel model = Mapper.Map<Masa, DeleteProductViewModel>(masa);
            return model;
        }

        public void DeleteMasi(DeleteIzdelieBindingModel model)
        {
            Masa masa = this.Context.Masi.Find(model.Id);
            this.Context.Masi.Remove(masa);
            this.Context.SaveChanges();
        }

        public void AddSupplier(AddSupplierBindingModel model)
        {
            Supplier supplier=new Supplier()
            {
                Name = model.Name,
                Telephone = model.Telephone
            };
            this.Context.Suppliers.Add(supplier);
            this.Context.SaveChanges();
        }

        public EditSupplierViewModel EditSupplier(int id)
        {
            Supplier supplier = this.Context.Suppliers.Find(id);
            EditSupplierViewModel model = Mapper.Map<Supplier,EditSupplierViewModel>(supplier);
            return model;

        }

        public void SaveEditSupplier(EditSupplierBindingModel model)
        {
            Supplier supplier = this.Context.Suppliers.Find(model.Id);
            supplier.Name = model.Name;
            supplier.Telephone = model.Telephone;
            this.Context.SaveChanges();
        }

        public SuppliersViewModel GetDeleteSuppliersViewModel(int id)
        {
            Supplier supplier = this.Context.Suppliers.Find(id);
            SuppliersViewModel model = Mapper.Map<Supplier, SuppliersViewModel> (supplier);
            return model;
        }

        public void DeleteSupplier(DeleteSupplierBindingModel model)
        {
            Supplier supplier = this.Context.Suppliers.Find(model.Id);
            this.Context.Suppliers.Remove(supplier);
            this.Context.SaveChanges();
        }

        public ICollection<PorachkaViewModel> GetPorachkiViewMoedel()
        {
            var porachki = this.Context.Porachki.OrderByDescending(p=>p.Id);
            IList<PorachkaViewModel> models = new List<PorachkaViewModel>();
            foreach (var porachka in porachki)
            {
                PorachkaViewModel model = Mapper.Map<Porachka, PorachkaViewModel>(porachka);
                models.Add(model);
            }

            return models;
        }

        public PorachkaViewModel GetPorackaFinish(int id)
        {
            Porachka porachka = this.Context.Porachki.Find(id);
            PorachkaViewModel model = Mapper.Map<Porachka, PorachkaViewModel>(porachka);
            return model;

        }

        public void FinishPorachka(PorachkaFinishBindingModel model)
        {
            Porachka porachka = this.Context.Porachki.Find(model.Id);
            porachka.IsActive = model.IsActive;
            this.Context.SaveChanges();
        }

        public ICollection<PorachkaViewModel> GetActivePorachkiViewMoedel()
        {
            var porachki = this.Context.Porachki.Where(p=>p.IsActive);
            IList<PorachkaViewModel> models = new List<PorachkaViewModel>();
            foreach (var porachka in porachki)
            {
                PorachkaViewModel model = Mapper.Map<Porachka, PorachkaViewModel>(porachka);
                models.Add(model);
            }

            return models;
        }
    }
}