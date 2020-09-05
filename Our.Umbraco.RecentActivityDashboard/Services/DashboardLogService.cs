using System;
using System.Collections.Generic;
using System.Linq;
using Our.Umbraco.RecentActivityDashboard.Helpers;
using Our.Umbraco.RecentActivityDashboard.Models;
using Umbraco.Core.Mapping;
using Umbraco.Core.Models.Entities;
using Umbraco.Core.Scoping;
using Umbraco.Core.Services;
using Umbraco.Web.Models.ContentEditing;

namespace Our.Umbraco.RecentActivityDashboard.Services
{
    public class DashboardLogService : IDashboardLogService
    {
        private readonly IScopeProvider _scopeProvider;

        private readonly IUserService _userService;

        private readonly IEntityService _entityService;

        private readonly IContentService _contentService;

        private readonly IMediaService _mediaService;

        private readonly IMemberService _memberService;

        private readonly UmbracoMapper _mapper;

        private readonly IContentTypeService _contentTypeService;

        private readonly IMediaTypeService _mediaTypeService;

        private readonly IMemberTypeService _memberTypeService;

        private readonly IDataTypeService _dataTypeService;

        private readonly IRelationService _relationService;

        public DashboardLogService(IScopeProvider scopeProvider, IUserService userService, IEntityService entityService, IContentTypeService contentTypeService, UmbracoMapper mapper, IContentService contentService, IMemberService memberService, IMediaTypeService mediaTypeService, IMemberTypeService memberTypeService, IDataTypeService dataTypeService, IRelationService relationService, IMediaService mediaService)
        {
            _scopeProvider = scopeProvider;
            _userService = userService;
            _entityService = entityService;
            _contentTypeService = contentTypeService;
            _mapper = mapper;
            _contentService = contentService;
            _memberService = memberService;
            _mediaTypeService = mediaTypeService;
            _memberTypeService = memberTypeService;
            _dataTypeService = dataTypeService;
            _relationService = relationService;
            _mediaService = mediaService;
        }
        public List<LogItem> GetLogs(string[] logHeader, string[] entityType, DateTime sinceDate)
        {
            using (var scope = _scopeProvider.CreateScope(autoComplete: true))
            {
                var sql = scope.SqlContext.Sql().Select("*").From("umbracoLog")
                            .Where("entityType in (@entityType) and logHeader in (@logHeader) and Datestamp >= @sinceDate",
                    new { sinceDate = sinceDate, logHeader = logHeader, entityType = entityType });

                var logDtos = scope.Database.Fetch<LogDto>(sql);

                var logItemsList = new List<LogItem>();
                foreach (var item in logDtos.Where(i => i.NodeId != -1 && i.NodeId !=-20))
                {
                    var entity = GetEntity(item.NodeId);
                    if (entity != null)
                    {
                        logItemsList.Add(new LogItem()
                        {
                            Action = item.LogHeader,
                            UserId = item.UserId ?? global::Umbraco.Core.Constants.Security.UnknownUserId,
                            NodeId = item.NodeId,
                            DateStamp = item.Datestamp.ToString("MMM dd, yyyy HH:mm"),
                            UserName = item.UserId != null
                                ? _userService.GetUserById(Convert.ToInt32(item.UserId)).Name
                                : global::Umbraco.Core.Constants.Security.UnknownUserName,
                            NodeName = entity.Name,
                            EditUrl = item.GetEditUrl(),
                            EntityType = item.EntityType,
                            Icon = GetIcon(item)
                        });
                    }
                }

                return logItemsList;
            }
        }

        private string GetIcon(LogDto logItem)
        {
            switch (logItem.EntityType.ToLower())
            {
                case "document":
                    return _contentService.GetById(logItem.NodeId).ContentType.Icon;
                case "media":
                    return _mediaService.GetById(logItem.NodeId).ContentType.Icon;
                case "member":
                    return _memberTypeService.Get(_memberService.GetById(logItem.NodeId).ContentTypeAlias).Icon;
                case "documenttype":
                    return _contentTypeService.Get(logItem.NodeId).Icon;
                case "mediatype":
                    return _mediaTypeService.Get(logItem.NodeId).Icon;
                case "membertype":
                    return _memberTypeService.Get(logItem.NodeId).Icon;
                case "datatype":
                    return _dataTypeService.GetAll(new[] { logItem.NodeId }).FirstOrDefault().Editor.Icon;
                case "dictionaryitem":
                    return "icon-book-alt";
                default:
                    return "icon-newspaper";
            }
        }

        private EntityBasic GetEntity(int nodeId)
        {
            var entity = _entityService.Get(nodeId);
            return entity != null ? _mapper.Map<IEntitySlim, EntityBasic>(entity) : null;
        }

    }
}
