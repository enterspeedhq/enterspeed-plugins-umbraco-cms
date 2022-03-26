function dashboardDeployController(enterspeedSsgDeploymentResource, notificationsService) {
    var vm = this;
    vm.loading = false;
    vm.configuration = {};
    vm.tabs = [];

    function init() {
        vm.getConfiguration();
    }

    vm.getConfiguration = function () {
        vm.loading = true;
        enterspeedSsgDeploymentResource.getConfiguration()
            .then(function (result) {
                if (result.data.isSuccess) {
                    vm.configuration = result.data.data;
                    var values = Object.values(vm.configuration.configuredServices);
                    for (var i = 0; i < values.length; i++) {
                        var service = values[i];
                        vm.tabs.push({
                            alias: service.alias,
                            label: service.name,
                            active: i === 0,
                            view: service.contentView,
                            service: service
                        });
                    }
                    vm.loading = false;
                }
            });
    };

    init();
}

angular.module("umbraco").controller("Enterspeed.Deploy.SSG.Content", dashboardDeployController);