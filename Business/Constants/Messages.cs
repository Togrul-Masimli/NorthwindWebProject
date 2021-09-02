using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Product Name Is Invalid";
        public static string MaintenanceTime = "Maintenance Time";
        public static string ProductsListed = "Products Listed";
        public static string ProductCountOfCategoryError = "Can Be Maximum 10 Products In All Categories";
        public static string ProductNameAlreadyExists = "There Is Already a Product With This Name";
        public static string CategoryLimitExceded = "Cannot Add Product Because Category Limit Exceded";
        public static string AuthorizationDenied = "Denied";
        public static string UserRegistered = "User Registered Successfully";
        public static string UserNotFound = "User Not Found";
        public static string PasswordError = "Password Is Incorrect";
        public static string SuccessfulLogin = "Login Is Successfull";
        public static string UserAlreadyExists = "User already Exists";
        public static string AccessTokenCreated = "Acces Token Created";
    }
}
