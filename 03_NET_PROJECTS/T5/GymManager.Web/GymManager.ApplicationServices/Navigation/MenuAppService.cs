using GymManager.Core.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Navigation
{
    public class MenuAppService : IMenuAppService
    {
        public List<UserMenuItem> GetMenu()
        {
            List<UserMenuItem> listMenus = new List<UserMenuItem>();


            listMenus.Add(new UserMenuItem
            {
                Name = "Home",
                DisplayName= "Home",
                Order = 0,
                Url = "/",
            });

            listMenus.Add(new UserMenuItem
            {
                Name = "Administration",
                DisplayName = "Administration",
                Order = 1,
                Url = "#",
                Items = new List<UserMenuItem>
                {
                    new UserMenuItem
                    {
                        Name= "MembershipTypes",
                        DisplayName = "Memberships Types",
                        Order = 0,
                        Url= "/MembershipTypes/",
                    },

                    new UserMenuItem
                    {
                        Name= "InventoryUnits",
                        DisplayName = "Inventory Units",
                        Order = 1,
                        Url= "/InventoryUnits/",
                    },

                 new UserMenuItem
                    {
                        Name= "EquipmentTypes",
                        DisplayName = "Equipment Types",
                        Order = 2,
                        Url= "/EquipmentTypes/",
                    },


                 new UserMenuItem
                    {
                        Name= "EquipmentInventory",
                        DisplayName = "Equipment Inventory",
                        Order = 3,
                        Url= "/EquipmentInventory/",
                    }
                }

            });

            listMenus.Add(new UserMenuItem
            {
                Name = "Store",
                DisplayName= "Store",
                Order = 2,
                Url = "#",
                Items = new List<UserMenuItem> ()
                {

                    new UserMenuItem{
                        Name = "Shopping",
                        DisplayName = "Shopping",
                        Order = 0,
                        Url = "/Shopping/"

                    },

                    new UserMenuItem{
                        Name = "ProductInventory",
                        DisplayName = "Inventory",
                        Order = 1,
                        Url = "/ProductInventory/"

                    },

                    new UserMenuItem{
                        Name = "ProductTypes",
                        DisplayName = "Products",
                        Order = 2,
                        Url = "/Products/"

                    },

                    new UserMenuItem{
                        Name = "ProductCategories",
                        DisplayName = "Product Categories",
                        Order = 3,
                        Url = "/ProductCategories/"

                    },

                }
            });


            listMenus.Add(new UserMenuItem
            {
                Name = "Members",
                DisplayName = "Members",
                Order = 3,
                Url = "#",
                Items = new List<UserMenuItem>()
                {
                    new UserMenuItem
                    {
                        Name = "MembersManagment",
                        DisplayName = "Members Managment",
                        Order = 0,
                        Url = "/Members/"
                    },

                    new UserMenuItem
                    {
                        Name = "MembershipRenewal",
                        DisplayName = "Membership Renewal",
                        Order = 1,
                        Url = "/Members/Renewal"
                    },

                    new UserMenuItem
                    {
                        Name = "ChcekIn",
                        DisplayName = "CheckIn",
                        Order = 2,
                        Url = "/Members/CheckIn"
                    },
                    new UserMenuItem
                    {
                        Name = "ChcekOut",
                        DisplayName = "CheckOut",
                        Order = 3,
                        Url = "/Members/CheckOut"
                    }
                }
            });

            listMenus.Add(new UserMenuItem
            {
                Name = "Invocing",
                DisplayName = "Invocing",
                Order = 4,
                Url = "/Invocing",
            });

            listMenus.Add(new UserMenuItem
            {
                Name = "Reports",
                DisplayName = "Reports",
                Order = 5,
                Url = "#",
                Items = new List<UserMenuItem>()
                {
                    new UserMenuItem
                    {
                        Name = "NewMembersReport",
                        DisplayName = "New Members",
                        Order = 0,
                        Url = "/Reports/NewMembers"
                    },

                    new UserMenuItem
                    {
                        Name = "AttendanceReport",
                        DisplayName = "Attendance",
                        Order = 1,
                        Url = "/Reports/Attendance"
                    },

                    new UserMenuItem
                    {
                        Name = "MembershipRenewalReport",
                        DisplayName = "Membership Renewal",
                        Order = 2,
                        Url = "/Reports/MembershipRenewal"
                    }
                }
            });

            return listMenus;
        }  
    }
}
