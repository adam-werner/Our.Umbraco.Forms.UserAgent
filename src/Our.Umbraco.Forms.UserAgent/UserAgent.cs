using System;
using Umbraco.Forms.Core;
using Umbraco.Forms.Core.Enums;

namespace Our.Umbraco.Forms.UserAgent
{
    public class UserAgent : FieldType
    {
        public UserAgent()
        {
            this.Id = new Guid("5F966913-BF6E-4A2F-9562-9957F7E0EEF6");
            this.Icon = "icon-browser-window";
            this.Name = "User Agent";
            this.Description = "Record the browser's user agent string";

            this.FieldTypeViewName = "FieldType.UserAgent.cshtml";

            this.HideLabel = true;

            this.DataType = FieldDataType.String;
            this.SortOrder = 1000;
        }

        public override bool StoresData
        {
            get { return true; }
        }

        public override bool HideField
        {
            get { return true; }
        }
    }
}
