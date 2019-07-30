﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vermaat.Crm.Specflow
{
    public static class Constants
    {
        public static class SpecFlow
        {
            public const string TABLE_KEY = "Property";
            public const string TABLE_VALUE = "Value";
            public const string TABLE_FORMSTATE = "State";
            public const string TABLE_FORMNOTIFICATION_MESSAGE = "Message";
            public const string TABLE_FORMNOTIFICATION_LEVEL = "Level";

            public const string TARGET_API = "API";
            public const string TARGET_Chrome = "Chrome";
            public const string TARGET_Firefox = "Firefox";
            public const string TARGET_InternetExplorer = "IE";
            public const string TARGET_Edge = "Edge";
        }

        public class CRM
        {
            public const string STATUSCODE = "statuscode";
        }

        public class ErrorCodes
        {
            public const int ERRORMESSAGE_NOT_FOUND = 1;
            public const int FORMLOAD_SCRIPT_ERROR_ON_FORM = 2;
            public const int BROWSER_OT_SUPPORTED_FOR_API_TEST = 3;
            public const int N_N_RELATIONSHIP_NOT_FOUND = 4;
            public const int RECORD_NOT_FOUND = 5;
            public const int UNKNOWN_TAG = 6;
            public const int API_NOT_SUPPORTED_FOR_BROWSER_ONLY_COMMANDS = 7;
            public const int CURRENT_BUSINESS_PROCESS_STAGE_NOT_FOUND = 8;
            public const int BUSINESS_PROCESS_STAGE_NOT_IN_ACTIVE_PATH = 9;
            public const int BUSINESS_PROCESS_STAGE_CANNOT_BE_LAST = 10;
            public const int LANGUAGECODE_MUST_BE_INTEGER = 11;
            public const int FORM_SAVE_FAILED = 12;
            public const int FORM_SAVE_TIMEOUT = 13;
            public const int DUPLICATE_RECORD_DETECTED = 14;
            public const int FIELD_NOT_ON_FORM = 15;
            public const int TWO_OPTION_FIELDS_CANT_BE_CLEARED = 16;
            public const int MORE_COMMANDS_NOT_FOUND = 17;
            public const int UNKNOWN_FORM_NOTIFICATION_TYPE = 18;
            public const int INVALID_FORM_STATE = 19;
            public const int APP_SETTINGS_REQUIRED = 20;
            public const int LABEL_NOT_TRANSLATED = 21;
            public const int ATTRIBUTE_DOESNT_EXIST = 22;
            public const int LOOKUP_NOT_FOUND = 23;
            public const int OPTION_NOT_FOUND = 24;
            public const int CANT_START_BROWSER_FOR_API_TESTS = 25;
            public const int FORM_LOAD_TIMEOUT = 26;
            public const int UNABLE_TO_LOGIN = 27;
            public const int FORM_NOT_FOUND = 28;
        }

        public class XPath
        {
            public const string FIELD_ISLOCKED = "//label[contains(@id, '[NAME]-locked-icon')]";
            public const string FIELD_ISREQUIREDORRECOMMEND = "//div[contains(@id, '[NAME]-required-icon')]";
            public const string DIALOG_CONTAINER = "id(\"dialogContentContainer_1\")";
            public const string DIALOG_OK = "//button[@data-id='ok_id']";
        }
    }
}
