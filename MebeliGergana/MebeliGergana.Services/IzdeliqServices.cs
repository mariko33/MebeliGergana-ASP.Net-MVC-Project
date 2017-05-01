using MebeliGergana.Models.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MebeliGergana.Data;
using MebeliGergana.Data.Interfaces;
using MebeliGergana.Models.BindingModels;
using MebeliGergana.Models.EntityModels;
using MebeliGergana.Services.Helpers;
using MebeliGergana.Services.Interfaces;

namespace MebeliGergana.Services
{
    public class IzdeliqServices : Service, IIzdeliqServices
    {
        
        //public IzdeliqServices(IMebeliGerganaContext context)
        //{
        //    this.Context = (MebeliGerganaContext) context;
        //}

        //public void AddSpalnq(IzdeliqBindingModel model)
        //{
        //    Spalnq spalnq = new Spalnq()
        //    {
        //        CatNumber = model.CatNumber,
        //        Color = model.Color,
        //        Description = model.Description,
        //        Price = model.Price,
        //        Name = model.Name,
        //        Razmeri = model.Razmeri,
        //        Type = model.Type
        //    };
        //    Supplier supplier = this.Context.Suppliers.Find(model.SupplierId);
        //    spalnq.Supplier = supplier;
        //    //byte[] arr;
        //    //ImageConverter converter = new ImageConverter();
        //    //arr = (byte[])converter.ConvertTo(model.ImageName, typeof(byte[]));
        //    //spalnq.Image = arr;
        //    //var ms = new MemoryStream();

        //    //model.ImageName.InputStream.CopyTo(ms);
        //    //spalnq.Image = ms.ToArray();

        //    //spalnq.Image = ImgConverter.imageToByteArray(model.ImageName);
        //    //string path = Path.GetFullPath(model.ImageName);
        //    //spalnq.Image = File.ReadAllBytes(path);
        //    if (model.ImageName!=null && model.ImageName.ContentLength>0)
        //    {
        //        using (var reader = new BinaryReader(model.ImageName.InputStream))
        //        {
        //            spalnq.ImagePicture = reader.ReadBytes(model.ImageName.ContentLength);
        //        }
        //    }
        //    //spalnq.Image = model.ImageName;
        //        this.Context.Spalni.Add(spalnq);
        //        this.Context.SaveChanges();
        //    }

        public ICollection<IzdeliqViewModel> GetIzdeliqSpalnqModels()
        {
            var spalni = this.Context.Spalni;
            IList<IzdeliqViewModel>viewModels=new List<IzdeliqViewModel>();
            foreach (var spalnq in spalni)
            {
                IzdeliqViewModel viewModel=new IzdeliqViewModel()
                {
                    Id = spalnq.Id,
                    Name = spalnq.Name,
                    ImagePicture = spalnq.ImagePicture
                };
                viewModels.Add(viewModel);
            }
            return viewModels;
        }

        public ICollection<IzdeliqViewModel> GetIzdeliqDetsciModel()
        {
            var detsci = this.Context.Detski;
            IList<IzdeliqViewModel>models=new List<IzdeliqViewModel>();
            foreach (var detsca in detsci)
            {
                IzdeliqViewModel model = Mapper.Map<Detska, IzdeliqViewModel>(detsca);
                models.Add(model);
            }
            return models;
        }

        public ICollection<IzdeliqViewModel> GetIzdeliqSekciiModel()
        {
            var sekcii = this.Context.Sekcii;
            IList<IzdeliqViewModel>models=new List<IzdeliqViewModel>();
            foreach (var sekciq in sekcii)
            {
                IzdeliqViewModel model = Mapper.Map<Sekciq, IzdeliqViewModel>(sekciq);
                models.Add(model);
            }
            return models;
        }

        public ICollection<IzdeliqViewModel> GetIzdeliqPortmantaModel()
        {
            var potmanta = this.Context.Portmanta;
            IList<IzdeliqViewModel>models=new List<IzdeliqViewModel>();
            foreach (var portmanto in potmanta)
            {
                IzdeliqViewModel model = Mapper.Map<Portmanto, IzdeliqViewModel>(portmanto);
                models.Add(model);
            }
            return models;
        }

        public ICollection<IzdeliqViewModel> GetIzdeliqKuhniModel()
        {
            var kuhni = this.Context.Kuhni;
            IList<IzdeliqViewModel>models=new List<IzdeliqViewModel>();
            foreach (var kuhnq in kuhni)
            {
                IzdeliqViewModel model = Mapper.Map<Kuhnq, IzdeliqViewModel>(kuhnq);
                models.Add(model);
            }
            return models;
        }

        public ICollection<IzdeliqViewModel> GetIzdeliqMasiModel()
        {
            var masi = this.Context.Masi;
            ICollection<IzdeliqViewModel> models=new List<IzdeliqViewModel>();
            foreach (var masa in masi)
            {
                IzdeliqViewModel model = Mapper.Map<Masa, IzdeliqViewModel>(masa);
                models.Add(model);
            }
            return models;
        }

        public DetailsViewModel GetDetailsViewModel(int id, string izdelie)
        {
            DetailsViewModel model=new DetailsViewModel();
            switch (izdelie)
            {
                case "Spalni":
                    var spalnq = this.Context.Spalni.Find(id);
                    model = Mapper.Map<Spalnq, DetailsViewModel>(spalnq);
                    
                    break;
                case "Detsci":
                    var detska = this.Context.Detski.Find(id);
                    model = Mapper.Map<Detska, DetailsViewModel>(detska);
                    break;
                case "Kuhni":
                    var kuhnq = this.Context.Kuhni.Find(id);
                    model = Mapper.Map<Kuhnq, DetailsViewModel>(kuhnq);
                    break;
                case "Masi":
                    var masa = this.Context.Masi.Find(id);
                    model = Mapper.Map<Masa, DetailsViewModel>(masa);
                    break;
                case "Portmanta":
                    var portmanto = this.Context.Portmanta.Find(id);
                    model = Mapper.Map<Portmanto, DetailsViewModel>(portmanto);
                    break;
                case "Sekcii":
                    var sekciq = this.Context.Sekcii.Find(id);
                    model = Mapper.Map<Sekciq, DetailsViewModel>(sekciq);
                    break;

            }
            return model;
        }

        //public ApplicationUser GetClient(string currentUserId)
        //{
        //    ApplicationUser user = this.Context.Users.Find(currentUserId);
        //        return user;
        //}
    }
    }

