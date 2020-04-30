// adds the resource to umbraco.resources module:
angular.module('umbraco.resources').factory('activitydashboardresource',
    function ($q, $http, umbRequestHelper) {
        // the factory object returned
        return {
            // this calls the ApiController we setup earlier
            getDocumentLogs: function () {
                return umbRequestHelper.resourcePromise(
                    $http.get("backoffice/OurUmbracoActivityDashboard/ContentActivityApi/GetDocumentLogs"),
                    "Failed to retrieve content activity data");
            },

            getMediaLogs: function () {
                return umbRequestHelper.resourcePromise(
                    $http.get("backoffice/OurUmbracoActivityDashboard/ContentActivityApi/GetMediaLogs"),
                    "Failed to retrieve media activity data");
            },

            getSettingsLogs: function () {
                return umbRequestHelper.resourcePromise(
                    $http.get("backoffice/OurUmbracoActivityDashboard/ContentActivityApi/GetSettingsLogs"),
                    "Failed to retrieve settings activity data");
            },
            getMemberLogs: function () {
                return umbRequestHelper.resourcePromise(
                    $http.get("backoffice/OurUmbracoActivityDashboard/ContentActivityApi/GetMemberLogs"),
                    "Failed to retrieve member activity data");
            }
        };
    }
);