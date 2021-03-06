﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added.";
        public static string ProductNameInvalid = "Product name invalid.";
        public static string MaintenanceTime = "System is busy right now.";
        public static string ProductsListed = "Products listed.";
        public static string UnitPriceInvalid = "Unit price must be more the zero";
        public static string ProductCountOfCategoryError = "In this category you can add max 10 product";
        public static string ProductNameAlreadyExists = "Product name already exists";
        public static string ReachedMaxCategoryLimit = "You can add max 15 different categories";
        public static string AuthorizationDenied = "Authorization denied";
        public static string UserRegistered = "User registered";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password error";
        public static string SuccessfulLogin = "Successful login";
        public static string UserAlreadyExists = "User already exists";
        public static string AccessTokenCreated = "Access token created";
    }
}
