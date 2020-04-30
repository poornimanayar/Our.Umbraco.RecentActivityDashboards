namespace Our.Umbraco.ContentDashboard.Constants
{
    public static class DashboardConstants
    {
        public static string UmbracoEditUrlPrefix = "/Umbraco/#/";

        public static string[] DocumentLogHeader = { "Save", "Publish", "Unpublish", "Copy", "SendToPublish", "Delete", "Update" };

        public static string[] DocumentEntityType = { "Document" };

        public static string DocumentEditUrlPrefix = "content/content/edit/";

        public static string[] MediaLogHeader = { "Save", "Copy", "Delete", "Update" };

        public static string[] MediaEntityType = { "Media" };

        public static string MediaEditUrlPrefix = "media/media/edit/";

        public static string[] SettingsLogHeader = { "Save", "Delete" };

        public static string[] SettingsEntityType = { "DocumentType", "Template", "MediaType", "MemberType", "DataType", "RelationType" };//, "Macro", "PartialView", "PartialViewMacro", "Stylesheet", "Script"

        public static string DocumentTypeEditUrlPrefix = "settings/documenttypes/edit/";

        public static string TemplateEditUrlPrefix = "settings/templates/edit/";

        public static string MediaTypeEditUrlPrefix = "settings/mediatypes/edit/";

        public static string MemberTypeEditUrlPrefix = "settings/membertypes/edit/";

        public static string DataTypeEditUrlPrefix = "settings/datatypes/edit/";

        public static string MacroEditUrlPrefix = "settings/macros/edit/";

        public static string RelationTypeEditUrlPrefix = "settings/relationtypes/edit/";

        public static string PartialViewEditUrlPrefix = "settings/partialviews/edit/";

        public static string PartialViewMacroEditUrlPrefix = "settings/partialviews/edit/";

        public static string StylesheetEditUrlPrefix = "settings/stylesheets/edit/";

        public static string ScriptEditUrlPrefix = "settings/scripts/edit/";

        public static string DictionaryItemEditUrlPrefix = "translation/dictionary/edit/";

        public static string[] MemberLogHeader = { "Save", "Delete" };

        public static string[] MemberEntityType = { "Member" };

        public static string MemberEditUrlPrefix = "member/member/edit/";
    }
}
