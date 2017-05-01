using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MebeliGergana.Models.EntityModels;
using MebeliGergana.Models.ViewModels;
using MebeliGergana.Models.ViewModels.Admin;
using MebeliGergana.Models.ViewModels.User;

namespace MebeliGergana.Web.Helpers
{
    public static class MappConfig
    {
        public static void ConfigerMapping()
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<ICollection<Supplier>, ICollection<SuppliersViewModel>>();
                expression.CreateMap<List<Spalnq>, List<ProductViewModel>>();
                expression.CreateMap<Spalnq, ProductViewModel>();
                expression.CreateMap<Detska, ProductViewModel>();
                expression.CreateMap<Sekciq, ProductViewModel>();
                expression.CreateMap<Portmanto, ProductViewModel>();
                expression.CreateMap<Kuhnq, ProductViewModel>();
                expression.CreateMap<Masa, ProductViewModel>();

                expression.CreateMap<Supplier, SuppliersViewModel>();

                expression.CreateMap<Spalnq, FullProductViewModel>();
                expression.CreateMap<Detska, FullProductViewModel>();
                expression.CreateMap<Sekciq, FullProductViewModel>();
                expression.CreateMap<Portmanto, FullProductViewModel>();
                expression.CreateMap<Kuhnq, FullProductViewModel>();
                expression.CreateMap<Masa, FullProductViewModel>();

                expression.CreateMap<Spalnq, DeleteProductViewModel>();
                expression.CreateMap<Detska, DeleteProductViewModel>();
                expression.CreateMap<Sekciq, DeleteProductViewModel>();
                expression.CreateMap<Portmanto, DeleteProductViewModel>();
                expression.CreateMap<Kuhnq, DeleteProductViewModel>();
                expression.CreateMap<Masa, DeleteProductViewModel>();

                expression.CreateMap<Detska, IzdeliqViewModel>();
                expression.CreateMap<Sekciq, IzdeliqViewModel>();
                expression.CreateMap<Portmanto, IzdeliqViewModel>();
                expression.CreateMap<Kuhnq, IzdeliqViewModel>();
                expression.CreateMap<Spalnq, IzdeliqViewModel>();
                expression.CreateMap<Masa, IzdeliqViewModel>();

                expression.CreateMap<Spalnq, DetailsViewModel>();
                expression.CreateMap<Detska, DetailsViewModel>();
                expression.CreateMap<Kuhnq, DetailsViewModel>();
                expression.CreateMap<Masa, DetailsViewModel>();
                expression.CreateMap<Portmanto, DetailsViewModel>();
                expression.CreateMap<Sekciq, DetailsViewModel>();

                expression.CreateMap<ApplicationUser, CurrentUserViewModel>();

            });
        }
    }
}