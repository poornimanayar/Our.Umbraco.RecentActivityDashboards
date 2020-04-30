angular.module("umbraco").controller("SettingsActivityDashboardController", function (activitydashboardresource, entityResource) {
    var vm = this;
    vm.settingsLogs = [];

    activitydashboardresource.getSettingsLogs().then(function (response) {
        vm.settingsLogs = response;
    });

    vm.goToNode = function (url) {
        window.location.replace(url);
    }
});