using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using AutoMapper;
using MebeliGergana.Data;
using MebeliGergana.Data.Interfaces;
using MebeliGergana.Models.BindingModels;
using MebeliGergana.Models.EntityModels;
using MebeliGergana.Models.ViewModels.User;
using MebeliGergana.Services.Interfaces;

namespace MebeliGergana.Services.UserServices
{
   public class PorachkiServices:Service, IPorachkiServices
   {

        public CurrentUserViewModel GetClient(string currentUserId)
        {
            ApplicationUser user = this.Context.Users.Find(currentUserId);
            CurrentUserViewModel userModel = Mapper.Map<ApplicationUser, CurrentUserViewModel>(user);
            return userModel;
        }

        public void SavePorachka(PorachkaBindingModel model)
        {
            Porachka porachka=new Porachka()
            {
                IzdelieDescription = $"{model.Type}, {model.Name}, {model.Description}, {model.Color}",
                Kolichestvo = model.Broi,
                FinalPrice = model.Broi*model.Price,
                IsActive = true,
                PorachkaFullName = $"{model.FirstName} {model.LastName}",
                PorachkaPhoneNumber = model.PhoneNumber,
                ///PorachkaEmail = model.Email,
                PorachkaAdress = model.Adress
            };
            ApplicationUser user = this.Context.Users.Find(model.ClientId);
            porachka.Client = user;
            Supplier supplier = this.Context.Suppliers.Find(model.SupplierId);
            porachka.Supplier = supplier;
            this.Context.Porachki.Add(porachka);
            this.Context.SaveChanges();

        }
    }
}
