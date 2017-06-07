using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPTests
{
    public static class Pages
    {
        //method
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static LoginPage Login
        {
            get
            {
                return GetPage<LoginPage>();
            }
        }

        public static LoginPage Loginpage
        { 
            get
            {
                return GetPage<LoginPage>();
            }
        }

        public static MapDashboardPage MapDashboard
        {
            get
            {
                return GetPage<MapDashboardPage>();
            }
        } 
        // Add user management
        public static UserManagementPage UserManagement
        {
            get
            {
                return GetPage<UserManagementPage>();
            }
        }

        public static AddNewUserPage AddNewUser
        {
            get
            {
                return GetPage<AddNewUserPage>();
            }
        }
        //Add User group
        public static UserGroupPage UserGroup
        {
            get
            {
                return GetPage<UserGroupPage>();
            }
        }

        public static AddUserGroupPage AddUserGroup
        {
            get
            {
                return GetPage<AddUserGroupPage>();
            }
        }

        public static EditUserPage EditUser
        {
            get
            {
                return GetPage<EditUserPage>();
            }
        }


    }
}
