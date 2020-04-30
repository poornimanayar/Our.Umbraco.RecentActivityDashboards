angular.module("umbraco").controller("ContentActivityDashboardController", function (activitydashboardresource) {
    var vm = this;
    vm.documentLogs = [];
   
    activitydashboardresource.getDocumentLogs().then(function (response) {
        vm.documentLogs = response;
    });

    vm.goToNode = function(url) {
        window.location.replace(url);
    }


});