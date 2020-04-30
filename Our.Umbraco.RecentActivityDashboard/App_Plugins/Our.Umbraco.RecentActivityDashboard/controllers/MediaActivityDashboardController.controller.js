angular.module("umbraco").controller("MediaActivityDashboardController", function (activitydashboardresource) {
    var vm = this;
    vm.mediaLogs = [];

    activitydashboardresource.getMediaLogs().then(function (response) {
        vm.mediaLogs = response;
    });

    vm.goToNode = function (url) {
        window.location.replace(url);
    }

});