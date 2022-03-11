function ssgConfigurationController(enterspeedSsgDeploymentResource, notificationsService, $scope, overlayService, $timeout) {
    var vm = this;
    vm.loadingConfiguration = false;
    vm.buttonState = null;
    vm.configuration = {};

    function init() {
        vm.getConfiguration();
    }

    vm.getConfiguration = function () {
        vm.loadingConfiguration = true;
        vm.buttonState = "busy";
        enterspeedSsgDeploymentResource.getConfiguration()
            .then(function (result) {
                if (result.data.isSuccess) {
                    vm.configuration = result.data.data;
                    vm.loadingConfiguration = false;
                    vm.buttonState = null;
                }
            });
    };

    vm.saveConfiguration = function () {
        vm.buttonState = "busy";

        enterspeedSsgDeploymentResource.saveConfiguration(vm.configuration)
            .then(function (result) {
                var status = result.data.statusCode;
                if (status === 204 || status === 200) {
                    notificationsService.success("Configuration saved");
                    vm.setPristine();
                } else {
                    notifyErrors(result.data, "Error saving configuration");
                }
                vm.buttonState = null;
            })
            .catch(function (error) {
                console.error(error);
                notifyErrors(error.data, `Error saving configuration: ${error.data.message}`);
                vm.buttonState = null;
            });
    };

    vm.addService = function() {
        overlayService.open({
            services: vm.configuration.availableServices,
            view: "/App_Plugins/Enterspeed.Deploy.SSG/Dashboard.Sub.Views/Overlays/services.view.html",
            title: "SSG Services",
            hideSubmitButton: true,
            submit: function (model) {
                vm.configuration.configuredServices[model.alias] = model;
                overlayService.close();
            },
            close: function() {
                overlayService.close();
            }
        });
    }

    vm.trash = function(service) {
        delete vm.configuration.configuredServices [service.alias];
    }

    function notifyErrors(data, errorMessage) {
        var status = data.statusCode;

        errorMessage = errorMessage || "Something went wrong";

        if (status === 401) {
            notificationsService.error("Api key is invalid");
        } else if (status === 404) {
            notificationsService.error("Url does not exist");
        } else {
            notificationsService.error(errorMessage);
        }
    }

    vm.setPristine = function () {
        $scope.$$childTail.dashboardForm.$setPristine();
    };

    init();
}

angular.module("umbraco").controller("Enterspeed.Deploy.SSG.Setting.Dashboard", ssgConfigurationController);