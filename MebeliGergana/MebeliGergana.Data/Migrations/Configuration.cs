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
                //    Name = "��������",
                //    Color = "���� 16/ ����� 16/ ��� �������",
                //    Description = "�������� -������� ����� �� ������ 160/200 � ������������ ���������, ����� �������� 2��, �������� �������� ����� �180�� ",
                //    Price = 1274,
                //    Supplier=context.Suppliers.Find(1),
                //    ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Spalni/victoriq3.jpg"),
                //    Type = "������ ��������"

                //}, 
                //new Spalnq()
                //{
                  
                //    Name = "�������",
                //    Color = "���� ����� 18/ ����� ��������� ����� 18/ ��� ���� (18�� ���)",
                //    Description = "�������� -������� ����� �� ������ 160/200 � ������������ ���������, ����� �������� 2��, �������� �������� ����� �225��  /������� Hettich, Germany/",
                //    Price = 1399,
                //    Supplier = context.Suppliers.Find(1),
                //    ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+ "Images/Apolo/Spalni/VichencaB&W.jpg"),
                //    Type = "������ ��������"
                //}, 
                //new Spalnq()
                //{
                //    Name = "�����",
                //    Color = "������� ��� 16/ ����� 16/ ��� ���� ",
                //    Description = "�������� -������� ����� �� ������ 160/200 � ������������ ���������, ����� �������� 2��, �������� �������� ����� �180��  /������� Hettich, Germany/",
                //    Price = 899,
                //    Supplier = context.Suppliers.Find(1),
                //    ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Spalni/Karla.jpg"),
                //    Type = "������ ��������"
                //},
                //new Spalnq()
                //{
                //    Name = "�����",
                //    Color = "������� ��� 16/ ���� 16/ ��� ����",
                //    Description = "�������� -������� ����� �� ������ 160/200 � ������������ ���������, ����� �������� 2��, �������� �������� ����� �200��  /������� Hettich, Germany/",
                //    Price = 899,
                //    Supplier = context.Suppliers.Find(1),
                //    ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Spalni/DalasLATE.jpg"),
                //    Type = "������ ��������"
                //},
                //new Spalnq()
                //{
                //    Name = "������",
                //    Color = " ���� 16/ ������� ����� 18;",
                //    Description = "�������� -������� ����� �� ������ 160/200  � ������������ ���������, ����� �������� 2��, �������� �������� �����; RGB ����������",
                //    Price = 899,
                //    Supplier = context.Suppliers.Find(1),
                //    ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Spalni/kastel_white.jpg"),
                //    Type = "������ ��������"
                //},
           // });
            
            // context.Detski.AddOrUpdate(detska=>detska.Name, new Detska[]
            //{
            //    new Detska()
            //    {
            //        Name = "����",
            //        Color = "����� ������ 16/ ���� 16/ ���� 16",
            //        Description = "�������� - ������� ��������� �����; ������; �������� ������� (������� + ���� � ����); ���� � ���������� ",
            //        Price = 669,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Detski/riki_Lime.jpg"),
            //        Type = "������ �����������"

            //    },

            //    new Detska()
            //    {
            //        Name = "�����",
            //        Color = "������ 18/������� ��� 18/������ 18",
            //        Description = "�������� - ������� ������ � ��������, �����, 2 ���� ����� �� ������ 82/190",
            //        Price = 669,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Detski/Tomas_lila.jpg"),
            //        Type = "������ �����������"

            //    },
            //     new Detska()
            //    {
            //        Name = "�������",
            //        Color = "����� 16/������� ��� 16/�������� 18",
            //        Description = "�������� - ������� ������, ����� ������, ����� �� ������ 120/190",
            //        Price = 669,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Detski/Justin_orange.jpg"),
            //        Type = "������ �����������"

            //    },

            //     new Detska()
            //    {
            //        Name = "����� ����",
            //        Color = "����� 16/���� 16/ ���� 16",
            //        Description = "�������� - ������� ������, ����� ������, ����� �� ������ 120/190",
            //        Price = 669,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Detski/Tomas_lime.jpg"),
            //        Type = "������ �����������"

            //    },

            //});

            //context.Kuhni.AddOrUpdate(kuhnq=>kuhnq.Name, new Kuhnq[]
            //{
            //    new Kuhnq()
            //    {
            //        Name = "������",
            //        Color = " ����� ������: ����� ��� 18��; ����� ����: ����� ���- ����� ��������� ����� 18��;����� ���- ��� ������ ��������� ����� 19��,����� Egger �������� 30��",
            //        Description = "����� - ������������,Quadro ������ � ����� Silent System (������ ���������)",
            //        Price = 999,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Kuhni/Elinor.jpg"),
            //        Type = "����� - ������������",
            //        Razmeri = "2,60 � (18�� ���, 1�� ����)"


            //    },

            //    new Kuhnq()
            //    {
            //        Name = "�������",
            //        Color = "����� ������: ����� ��� 18��;����� ����: ����� ��������� ����� 18��; ��� ������ �����;���: ����� Egger �������� 30��",
            //        Description = "����� - ������������,Quadro ������ � ����� Silent System (������ ���������) ",
            //        Price = 999,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Kuhni/venecia.jpg"),
            //        Type = "����� - ������������",
            //        Razmeri = "2,60 � (18�� ���, 1�� ����)"


            //    },

            //      new Kuhnq()
            //    {
            //        Name = "�����",
            //        Color = "�����: ����� ���/ ��� ������� �����/ ����������� ������ ���: ����� Egger �������� 30��",
            //        Description = "����� - ������������,Quadro ������ � ����� Silent System (������ ���������) ",
            //        Price = 899,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Kuhni/Elada.jpg"),
            //        Type = "����� - ������������",
            //        Razmeri = "2,60 � (18�� ���, 1�� ����)"


            //    },

            //        new Kuhnq()
            //    {
            //        Name = "������",
            //        Color = "�����: ��� �������/ �������/ ����������� ������",
            //        Description = "����� - ������������",
            //        Price = 699,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Kuhni/ELVIRA.jpg"),
            //        Type = "����� - ������������",
            //        Razmeri = "2,60 � "


            //    },

            //        new Kuhnq()
            //    {
            //        Name = "����",
            //        Color = "�����: ����� 16/ ��� ������ 8, ��� ������ �����",
            //        Description = "����� - ������������",
            //        Price = 699,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Kuhni/CITYsonoma.jpg"),
            //        Type = "����� - ������������",
            //        Razmeri = "2,60 � "


            //    },
            //           new Kuhnq()
            //    {
            //        Name = "�������",
            //        Color = "����� ������: ����� ���  16;����� ���� ����� ���: ����� ������ 18��, ���� 1��;����� ���� ����� ���: ������ ������ 18��, ���� 1��;���: ����� Egger �������� 30��",
            //        Description = "����� - ������������,Quadro ������ � ����� Silent System (������ ���������)",
            //        Price = 799,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Kuhni/Toscana.jpg"),
            //        Type = "����� - ������������",
            //        Razmeri = "2,60 � "


            //    },




           // });

            //context.Masi.AddOrUpdate(masa=>masa.Name, new Masa[]
            //{
            //    new Masa()
            //    {
            //        Name = "����� - ������������",
            //        Color = "���� (����) 16/ ����� 16/ ����� ����������� ������; ",
            //        Description = "�������� ����, ������������",
            //        Price = 149,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Masi/EladaR_bialoCherenProfil.jpg"),
            //        Type = "�������� ����"

            //    },
            //    new Masa()
            //    {
            //        Name = "����� - ������������",
            //        Color = "����� (����) 16/ ���� 16/ ���  ����������� ������;  ",
            //        Description = "�������� ����, ������������",
            //        Price = 149,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Masi/EladaR_ChernoBialProfil.jpg"),
            //        Type = "�������� ����"

            //    },
            //    new Masa()
            //    {
            //        Name = "����� - ������������",
            //        Color = "������� (����) 16/ ��� ������� 16/ ����� ����������� ������;",
            //        Description = "�������� ����, ������������",
            //        Price = 149,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Masi/EladaR_pasificCherenProfil.jpg"),
            //        Type = "�������� ����"

            //    },

            //    new Masa()
            //    {
            //        Name = "������ - ������������",
            //        Color = "���������� ����� 16/ ��� ������ ����� � ���������;",
            //        Description = "�������� ����, ������������",
            //        Price = 209,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Masi/masaRavena_krushaR.jpg"),
            //        Type = "�������� ����"

            //    },

            //     new Masa()
            //    {
            //        Name = "����� - ������������",
            //        Color = "��� ������",
            //        Description = "�������� ����, ������������, 120, ���� � ����� 25 ��, ������ 16 ��",
            //        Price = 228,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Masi/DafneP_sonoma.jpg"),
            //        Type = "�������� ����"

            //    },

            //      new Masa()
            //    {
            //        Name = "����� - ������������",
            //        Color = "�����,��� ������",
            //        Description = "�������� ����, ������������, 120, ���� � ����� 25 ��, ������ 16 ��",
            //        Price = 228,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Masi/DafneP_sonomaWenge.jpg"),
            //        Type = "�������� ����"

            //    },

            //       new Masa()
            //    {
            //        Name = "����� - ������������",
            //        Color = "�����,��� ������",
            //        Description = "�������� ����, ������������, 120, ���� � ����� 25 ��, ������ 16 ��",
            //        Price = 228,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Masi/DafneP_sonomaWenge.jpg"),
            //        Type = "�������� ����"

            //    },
            //});

            //context.Portmanta.AddOrUpdate(port=>port.Name, new Portmanto[]
            //{
            //    new Portmanto()
            //    {
            //        Name = "����",
            //        Color = "��� �������/ ��� ������",
            //        Description = "��������� (��� 16 ��)",
            //        Price = 199,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Portmanta/Fini.jpg"),
            //        Type = "���������"
            //    },
            //    new Portmanto()
            //    {
            //        Name = "����",
            //        Color = "�����/������� ���;",
            //        Description = "��������� (��� 16 ��)",
            //        Price = 249,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Portmanta/VIGO_venge.jpg"),
            //        Type = "���������"
            //    },

            //    new Portmanto()
            //    {
            //        Name = "����",
            //        Color = "��� �������/��� ������;",
            //        Description = "��������� (��� 16 ��)",
            //        Price = 199,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Portmanta/Mone_cremona_sonoma_print.jpg"),
            //        Type = "���������"
            //    },

            //     new Portmanto()
            //    {
            //        Name = "������",
            //        Color = "�����/������� ���",
            //        Description = "��������� (��� 16 ��)",
            //        Price = 336,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Portmanta/sahara_venge.jpg"),
            //        Type = "���������"
            //    },

            //      new Portmanto()
            //    {
            //        Name = "����",
            //        Color = "����",
            //        Description = "��������� (��� 16 ��)",
            //        Price = 249,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Portmanta/kali_chery.jpg"),
            //        Type = "���������"
            //    },

            //       new Portmanto()
            //    {
            //        Name = "����",
            //        Color = "��� �������",
            //        Description = "��������� (��� 16 ��)",
            //        Price = 229,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Portmanta/VALIAkremona.jpg"),
            //        Type = "���������"
            //    },

            //});

            //context.Sekcii.AddOrUpdate(sekciq=>sekciq.Name, new Sekciq[]
            //{
            //    new Sekciq()
            //    {
            //        Name = "��� - �������",
            //        Color = "��� ������� 16/��� ������ 16 ",
            //        Description = "����������� �� ������",
            //        Price = 299,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Sekcii/IDA_kremona.jpg"),
            //        Type = "������"
            //    },
            //    new Sekciq()
            //    {
            //        Name = "������",
            //        Color = "����� 16/ ��� ������ 16(� ��� ����������)",
            //        Description = "����������� �� ������",
            //        Price = 349,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Sekcii/NEVADA.jpg"),
            //        Type = "������"
            //    },

            //     new Sekciq()
            //    {
            //        Name = "�������",
            //        Color = "������� ��� 16/ ���� 16;� ��� ����������",
            //        Description = "����������� �� ������",
            //        Price = 399,
            //        Supplier = context.Suppliers.Find(1),
            //        ImagePicture = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory+"Images/Apolo/Sekcii/Arizona_Late.jpg"),
            //        Type = "������"
            //    },
            //});
        }
    }
       
}
