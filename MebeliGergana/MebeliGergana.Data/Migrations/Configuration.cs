using System.Drawing;
using System.IO;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Web.Hosting;
using MebeliGergana.Models.EntityModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace MebeliGergana.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Drawing.Imaging;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MebeliGergana.Data.MebeliGerganaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MebeliGergana.Data.MebeliGerganaContext context)
        {
            //if (!context.Roles.Any( role => role.Name == "User"))
            //{
            //    //Add in database role if didn't exist
            //    var store = new RoleStore<IdentityRole>(context);
            //    var manage = new RoleManager<IdentityRole>(store);
            //    var role = new IdentityRole("User");
            //    manage.Create(role);

            //}
            //if (!context.Roles.Any( role => role.Name == "Admin"))
            //{
            //    var store = new RoleStore<IdentityRole>(context);
            //    var manage = new RoleManager<IdentityRole>(store);
            //    var role = new IdentityRole("Admin");
            //    manage.Create(role);
            //}
            //context.Suppliers.AddOrUpdate(supplier=>supplier.Name, new Supplier[]
            //{
            //    new Supplier()
            //    {
            //        Name = "GoldApolo",
            //        Telephone = "898678975"
            //    }, 
            //});
            
            //context.Spalni.AddOrUpdate(spalnq=>spalnq.Name, new Spalnq[]
            //{
                //new Spalnq()
                //{
                //    Name = "Виктория",
                //    Color = "бяло 16/ черно 16/ бял лакобел",
                //    Description = "Комплект -включва легло за матрак 160/200 с амортисьорен механизъм, нощни шкафчета 2бр, гардероб плъзгащи врати Ш180см ",
                //    Price = 1274,
                //    Supplier=context.Suppliers.Find(1),
                //    ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Spalni/victoriq3.jpg"),
                //    Type = "Спален комплект"

                //}, 
                //new Spalnq()
                //{
                  
                //    Name = "Виченца",
                //    Color = "бяло гланц 18/ черно огледален гланц 18/ еко кожа (18мм ПДЧ)",
                //    Description = "Комплект -включва легло за матрак 160/200 с амортисьорен механизъм, нощни шкафчета 2бр, гардероб плъзгащи врати Ш225см  /система Hettich, Germany/",
                //    Price = 1399,
                //    Supplier = context.Suppliers.Find(1),
                //    ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+ "Images/Apolo/Spalni/VichencaB&W.jpg"),
                //    Type = "Спален комплект"
                //}, 
                //new Spalnq()
                //{
                //    Name = "Карла",
                //    Color = "пясъчен дъб 16/ венге 16/ еко кожа ",
                //    Description = "Комплект -включва легло за матрак 160/200 с амортисьорен механизъм, нощни шкафчета 2бр, гардероб плъзгащи врати Ш180см  /система Hettich, Germany/",
                //    Price = 899,
                //    Supplier = context.Suppliers.Find(1),
                //    ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Spalni/Karla.jpg"),
                //    Type = "Спален комплект"
                //},
                //new Spalnq()
                //{
                //    Name = "Далас",
                //    Color = "пясъчен дъб 16/ лате 16/ еко кожа",
                //    Description = "Комплект -включва легло за матрак 160/200 с амортисьорен механизъм, нощни шкафчета 2бр, гардероб плъзгащи врати Ш200см  /система Hettich, Germany/",
                //    Price = 899,
                //    Supplier = context.Suppliers.Find(1),
                //    ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Spalni/DalasLATE.jpg"),
                //    Type = "Спален комплект"
                //},
                //new Spalnq()
                //{
                //    Name = "Кастел",
                //    Color = " бяло 16/ червено гланц 18;",
                //    Description = "Комплект -включва легло за матрак 160/200  с амортисьорен механизъм, нощни шкафчета 2бр, гардероб плъзгащи врати; RGB осветление",
                //    Price = 899,
                //    Supplier = context.Suppliers.Find(1),
                //    ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Spalni/kastel_white.jpg"),
                //    Type = "Спален комплект"
                //},
           // });
            
            // context.Detski.AddOrUpdate(detska=>detska.Name, new Detska[]
            //{
            //    new Detska()
            //    {
            //        Name = "Рики",
            //        Color = "тъмна сонома 16/ бяло 16/ лайм 16",
            //        Description = "Комплект - включва двуетажно легло; секция; гардероб двукрил (рафтове + рафт и лост); бюро с надстройка ",
            //        Price = 669,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Detski/riki_Lime.jpg"),
            //        Type = "Детско обзавеждане"

            //    },

            //    new Detska()
            //    {
            //        Name = "Томас",
            //        Color = "лилаво 18/пясъчен дъб 18/виолет 18",
            //        Description = "Комплект - включва секция с гардероб, ракла, 2 броя легло за матрак 82/190",
            //        Price = 669,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Detski/Tomas_lila.jpg"),
            //        Type = "Детско обзавеждане"

            //    },
            //     new Detska()
            //    {
            //        Name = "Джъстин",
            //        Color = "венге 16/пясъчен дъб 16/оранжево 18",
            //        Description = "Комплект - включва секция, нощно шкафче, легло за матрак 120/190",
            //        Price = 669,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Detski/Justin_orange.jpg"),
            //        Type = "Детско обзавеждане"

            //    },

            //     new Detska()
            //    {
            //        Name = "Томас Лайм",
            //        Color = "венге 16/бяло 16/ лайм 16",
            //        Description = "Комплект - включва секция, нощно шкафче, легло за матрак 120/190",
            //        Price = 669,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Detski/Tomas_lime.jpg"),
            //        Type = "Детско обзавеждане"

            //    },

            //});

            //context.Kuhni.AddOrUpdate(kuhnq=>kuhnq.Name, new Kuhnq[]
            //{
            //    new Kuhnq()
            //    {
            //        Name = "Елинор",
            //        Color = " Декор корпус: Тъмен дъб 18мм; Декор лице: долен ред- черно огледален гланц 18мм;горен ред- МДФ лилаво огледален гланц 19мм,Оникс Egger дебелина 30мм",
            //        Description = "Кухня - конфигурация,Quadro водачи и панти Silent System (плавно прибиране)",
            //        Price = 999,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Kuhni/Elinor.jpg"),
            //        Type = "Кухня - конфигурация",
            //        Razmeri = "2,60 м (18мм ПДЧ, 1мм кант)"


            //    },

            //    new Kuhnq()
            //    {
            //        Name = "Венеция",
            //        Color = "Декор корпус: Тъмен дъб 18мм;Декор лице: Бордо огледален гланц 18мм; МДФ профил инокс;ТУП: Титан Egger дебелина 30мм",
            //        Description = "Кухня - конфигурация,Quadro водачи и панти Silent System (плавно прибиране) ",
            //        Price = 999,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Kuhni/venecia.jpg"),
            //        Type = "Кухня - конфигурация",
            //        Razmeri = "2,60 м (18мм ПДЧ, 1мм кант)"


            //    },

            //      new Kuhnq()
            //    {
            //        Name = "Елада",
            //        Color = "Декор: Тъмен дъб/ Бял матрикс гланц/ Декоративен профил ТУП: Оникс Egger дебелина 30мм",
            //        Description = "Кухня - конфигурация,Quadro водачи и панти Silent System (плавно прибиране) ",
            //        Price = 899,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Kuhni/Elada.jpg"),
            //        Type = "Кухня - конфигурация",
            //        Razmeri = "2,60 м (18мм ПДЧ, 1мм кант)"


            //    },

            //        new Kuhnq()
            //    {
            //        Name = "Елвира",
            //        Color = "Декор: Дъб кремона/ Пасифик/ Декоративен профил",
            //        Description = "Кухня - конфигурация",
            //        Price = 699,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Kuhni/ELVIRA.jpg"),
            //        Type = "Кухня - конфигурация",
            //        Razmeri = "2,60 м "


            //    },

            //        new Kuhnq()
            //    {
            //        Name = "Сити",
            //        Color = "Декор: Венге 16/ дъб сонома 8, МДФ профил венге",
            //        Description = "Кухня - конфигурация",
            //        Price = 699,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Kuhni/CITYsonoma.jpg"),
            //        Type = "Кухня - конфигурация",
            //        Razmeri = "2,60 м "


            //    },
            //           new Kuhnq()
            //    {
            //        Name = "Тоскана",
            //        Color = "Декор корпус: Тъмен дъб  16;Декор лице горен ред: тъмен периер 18мм, кант 1мм;Декор лице долен ред: светъл периер 18мм, кант 1мм;ТУП: Оникс Egger дебелина 30мм",
            //        Description = "Кухня - конфигурация,Quadro водачи и панти Silent System (плавно прибиране)",
            //        Price = 799,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Kuhni/Toscana.jpg"),
            //        Type = "Кухня - конфигурация",
            //        Razmeri = "2,60 м "


            //    },




           // });

            //context.Masi.AddOrUpdate(masa=>masa.Name, new Masa[]
            //{
            //    new Masa()
            //    {
            //        Name = "Елада - Разтегателна",
            //        Color = "бяло (плот) 16/ черно 16/ черен декоративен профил; ",
            //        Description = "Трапезна маса, разтегателна",
            //        Price = 149,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Masi/EladaR_bialoCherenProfil.jpg"),
            //        Type = "Трапезна маса"

            //    },
            //    new Masa()
            //    {
            //        Name = "Елада - Разтегателна",
            //        Color = "черно (плот) 16/ бяло 16/ бял  декоративен профил;  ",
            //        Description = "Трапезна маса, разтегателна",
            //        Price = 149,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Masi/EladaR_ChernoBialProfil.jpg"),
            //        Type = "Трапезна маса"

            //    },
            //    new Masa()
            //    {
            //        Name = "Елада - Разтегателна",
            //        Color = "пасифик (плот) 16/ дъб кремона 16/ черен декоративен профил;",
            //        Description = "Трапезна маса, разтегателна",
            //        Price = 149,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Masi/EladaR_pasificCherenProfil.jpg"),
            //        Type = "Трапезна маса"

            //    },

            //    new Masa()
            //    {
            //        Name = "Равена - Разтегателна",
            //        Color = "швейцарска круша 16/ МДФ профил круша с орнаменти;",
            //        Description = "Трапезна маса, разтегателна",
            //        Price = 209,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Masi/masaRavena_krushaR.jpg"),
            //        Type = "Трапезна маса"

            //    },

            //     new Masa()
            //    {
            //        Name = "Дафне - Разтегателна",
            //        Color = "дъб сонома",
            //        Description = "Трапезна маса, разтегателна, 120, плот и крака 25 мм, бленди 16 мм",
            //        Price = 228,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Masi/DafneP_sonoma.jpg"),
            //        Type = "Трапезна маса"

            //    },

            //      new Masa()
            //    {
            //        Name = "Дафне - Разтегателна",
            //        Color = "венге,дъб сонома",
            //        Description = "Трапезна маса, разтегателна, 120, плот и крака 25 мм, бленди 16 мм",
            //        Price = 228,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Masi/DafneP_sonomaWenge.jpg"),
            //        Type = "Трапезна маса"

            //    },

            //       new Masa()
            //    {
            //        Name = "Дафне - Разтегателна",
            //        Color = "венге,дъб сонома",
            //        Description = "Трапезна маса, разтегателна, 120, плот и крака 25 мм, бленди 16 мм",
            //        Price = 228,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Masi/DafneP_sonomaWenge.jpg"),
            //        Type = "Трапезна маса"

            //    },
            //});

            //context.Portmanta.AddOrUpdate(port=>port.Name, new Portmanto[]
            //{
            //    new Portmanto()
            //    {
            //        Name = "Фани",
            //        Color = "дъб кремона/ дъб сонома",
            //        Description = "Портманто (ПДЧ 16 мм)",
            //        Price = 199,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Portmanta/Fini.jpg"),
            //        Type = "Портманто"
            //    },
            //    new Portmanto()
            //    {
            //        Name = "Виго",
            //        Color = "венге/пясъчен дъб;",
            //        Description = "Портманто (ПДЧ 16 мм)",
            //        Price = 249,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Portmanta/VIGO_venge.jpg"),
            //        Type = "Портманто"
            //    },

            //    new Portmanto()
            //    {
            //        Name = "Моне",
            //        Color = "дъб кремона/дъб сонома;",
            //        Description = "Портманто (ПДЧ 16 мм)",
            //        Price = 199,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Portmanta/Mone_cremona_sonoma_print.jpg"),
            //        Type = "Портманто"
            //    },

            //     new Portmanto()
            //    {
            //        Name = "Сахара",
            //        Color = "венге/пясъчен дъб",
            //        Description = "Портманто (ПДЧ 16 мм)",
            //        Price = 336,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Portmanta/sahara_venge.jpg"),
            //        Type = "Портманто"
            //    },

            //      new Portmanto()
            //    {
            //        Name = "Кали",
            //        Color = "чери",
            //        Description = "Портманто (ПДЧ 16 мм)",
            //        Price = 249,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Portmanta/kali_chery.jpg"),
            //        Type = "Портманто"
            //    },

            //       new Portmanto()
            //    {
            //        Name = "Валя",
            //        Color = "дъб кремона",
            //        Description = "Портманто (ПДЧ 16 мм)",
            //        Price = 229,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Portmanta/VALIAkremona.jpg"),
            //        Type = "Портманто"
            //    },

            //});

            //context.Sekcii.AddOrUpdate(sekciq=>sekciq.Name, new Sekciq[]
            //{
            //    new Sekciq()
            //    {
            //        Name = "Ида - Кремона",
            //        Color = "дъб кремона 16/дъб сонома 16 ",
            //        Description = "Обзавеждане за дневна",
            //        Price = 299,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Sekcii/IDA_kremona.jpg"),
            //        Type = "Секция"
            //    },
            //    new Sekciq()
            //    {
            //        Name = "Невада",
            //        Color = "венге 16/ дъб сонома 16(с ЛЕД осветление)",
            //        Description = "Обзавеждане за дневна",
            //        Price = 349,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Sekcii/NEVADA.jpg"),
            //        Type = "Секция"
            //    },

            //     new Sekciq()
            //    {
            //        Name = "Аризона",
            //        Color = "пясъчен дъб 16/ лате 16;с ЛЕД осветление",
            //        Description = "Обзавеждане за дневна",
            //        Price = 399,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Sekcii/Arizona_Late.jpg"),
            //        Type = "Секция"
            //    },
            //});
        }
    }
       
}
