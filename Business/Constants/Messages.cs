using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added successfully";
        public static string ProductDeleted = "Product deleted successfully";
        public static string ProductUpdated = "Product updated successfully";

        public static string CategoryAdded = "Category added successfully";
        public static string CategoryDeleted = "Category deleted successfully";
        public static string CategoryUpdated = "Category updated successfully";

        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password Error";
        public static string SuccessfulLogin = "Login Successfully";
        public static string UserAlreadyExists="User already exists";
        public static string UserRegistered="User register successfully";
        public static string AccessTokenCreated="Access token created successfully";
    }
}
