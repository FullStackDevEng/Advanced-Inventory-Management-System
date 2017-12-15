//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

namespace warehouseWeb
{
    public class Constants
    {
        public const string WEBSITE_BASE_URL = "www.HMAStaff.somee.com";
        //"http://hmastaff.azurewebsites.net";*//* "http://localhost:58436/";*/
        public const string UNKNOWN_ERROR = "Unknown Error, please try again";
        public const string INVALID_CREDENTIALS_MESSAGE = "Invalid Username/Password";
        public const string INCORRECT_INFORMATION_MESSAGE = "Empty/Incorrect field(s) detected.";
        public const string ACCOUNT_SUCCESSFULLY_CREATED = "Account Successfully Created.";
        public const string ACCOUNT_Already_CREATED = "Account already Exists.";
        public const string MISSING_FIELDS_MESSAGE = "Please Fill In all Required Fields.";
        public const int MIN_USER_CREDENTIAL_LENGTH = 6;
        public const string NO = "No";
        public static string REGISTER_ERROR_MESSAGE = "All fields must be longer then or equal to " + MIN_USER_CREDENTIAL_LENGTH.ToString() + " characters";
        public const string COMMA = ",";
        public static string ACCOUNT_TABLE = "Accounts";
        public static string NAME = "Name";
        public static string ACCOUNT_TABLE_LOGGEDIN_FIELD = "LoggedIn =";
        public static string ACCOUNT_TABLE_USERNAME_FIELD = "Username =";
        public static string ACCOUNT_TABLE_PASSWORD_FIELD = "pass =";
        public static string YES_Quoted = "'Yes'";
        public static string AND = " AND ";


        // <customErrors mode="On" defaultRedirect="~/Login/InvalidError" /> add to web config at deployment

    }

}