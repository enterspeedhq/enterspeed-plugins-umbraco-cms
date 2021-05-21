function netlifySettingsService($scope) {
    var vm = this;
    vm.currentDomain = null;

    $scope.deploymentUrlProperty = {
        view: "textbox",
        value: $scope.model.deploymentUrl,
        label: "Deployment URL",
        alias: "deploymentUrlProperty"
    };

    function init() {
        console.log(window.location.origin);
        vm.currentDomain = window.location.origin;
    }

    $scope.$watch("deploymentUrlProperty.value",
        function (newVal, oldVal) {
            $scope.model.deploymentUrl = newVal;
        });
    
    init();
}

angular.module("umbraco").controller("Enterspeed.Deploy.SSG.Services.Netlify.Configuration", netlifySettingsService);