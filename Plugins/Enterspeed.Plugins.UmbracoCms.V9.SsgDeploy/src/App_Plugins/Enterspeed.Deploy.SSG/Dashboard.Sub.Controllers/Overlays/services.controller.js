function servicesOverlayController($scope) {
    var vm = this;

    function init() {
    }

    vm.select = function (item) {
        $scope.model.submit(item);
    }
    
    init();
}

angular.module("umbraco").controller("Enterspeed.Deploy.SSG.Overlays.Services", servicesOverlayController);