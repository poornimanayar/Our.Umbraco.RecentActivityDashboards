using Our.Umbraco.ContentDashboard.Constants;
using Our.Umbraco.ContentDashboard.Models;

namespace Our.Umbraco.ContentDashboard.Helpers
{
    public static class DashboardHelpers
    {
        public static string GetEditUrl(this LogDto log)
        {
            var editUrl = DashboardConstants.UmbracoEditUrlPrefix;
            switch (log.EntityType.ToLower())
            {
                case "document":
                    {
                        editUrl = editUrl + DashboardConstants.DocumentEditUrlPrefix + log.NodeId;
                        break;
                    }
                case "media":
                    {
                        editUrl = editUrl + DashboardConstants.MediaEditUrlPrefix + log.NodeId;
                        break;
                    }
                case "documenttype":
                    {
                        editUrl = editUrl + DashboardConstants.DocumentTypeEditUrlPrefix + log.NodeId;
                        break;
                    }
                case "template":
                    {
                        editUrl = editUrl + DashboardConstants.TemplateEditUrlPrefix + log.NodeId;
                        break;
                    }
                case "mediatype":
                    {
                        editUrl = editUrl + DashboardConstants.MediaTypeEditUrlPrefix + log.NodeId;
                        break;
                    }
                case "membertype":
                    {
                        editUrl = editUrl + DashboardConstants.MemberTypeEditUrlPrefix + log.NodeId;
                        break;
                    }
                case "datatype":
                    {
                        editUrl = editUrl + DashboardConstants.DataTypeEditUrlPrefix + log.NodeId;
                        break;
                    }
                case "relationtype":
                    {
                        editUrl = editUrl + DashboardConstants.RelationTypeEditUrlPrefix + log.NodeId;
                        break;
                    }
                case "macro":
                    {
                        editUrl = editUrl + DashboardConstants.MacroEditUrlPrefix + log.NodeId;
                        break;
                    }
                case "partialview":
                    {
                        editUrl = editUrl + DashboardConstants.PartialViewEditUrlPrefix + log.NodeId;
                        break;
                    }
                case "partialviewmacro":
                    {
                        editUrl = editUrl + DashboardConstants.PartialViewMacroEditUrlPrefix + log.NodeId;
                        break;
                    }
                case "stylesheet":
                    {
                        editUrl = editUrl + DashboardConstants.StylesheetEditUrlPrefix + log.NodeId;
                        break;
                    }
                case "script":
                    {
                        editUrl = editUrl + DashboardConstants.ScriptEditUrlPrefix + log.NodeId;
                        break;
                    }
                case "member":
                    {
                        editUrl = editUrl + DashboardConstants.MemberEditUrlPrefix + log.NodeId;
                        break;
                    }
                case "dictionaryitem":
                    {
                        editUrl = editUrl + DashboardConstants.DictionaryItemEditUrlPrefix + log.NodeId;
                        break;
                    }

            }
            return editUrl;
        }
    }
}
