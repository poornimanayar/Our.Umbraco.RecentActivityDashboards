angular.module("umbraco").controller("MemberActivityDashboardController", function (activitydashboardresource) {
    var vm = this;
    vm.memberLogs = [];

    activitydashboardresource.getMemberLogs().then(function (response) {
        vm.memberLogs = response;
    });

    vm.goToNode = function (url) {
        window.location.replace(url);
    }

});