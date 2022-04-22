function netlifyContentService($scope, $http) {
    var vm = this;
    vm.loading = false;
    vm.progress = {};
    vm.width = 0;
    vm.statusMessage = "Deploy not initiated";
    vm.finishedDeploy = false;
    vm.finishedDeploymentData = null;

    function init() {
        vm.configuration = $scope.model.service;
        checkStatus();

        setInterval(function() {
                checkStatus(true);
            },
            5000);
    }

    vm.deploy = function () {
        vm.loading = true;

        clear().then(function(res) {
            $http.post(vm.configuration.deploymentUrl).then(function (response) {
                $http.post("/Umbraco/api/Netlify/SetProgress?isSuccess=true",
                    {
                        state: "requested",
                        links: null,
                        name: null,
                        admin_url: null
                    }).then(function(response) {
                        checkStatus();
                    });
            });
        });
    }

    function checkStatus(silent) {
        if (!silent) {
            vm.loading = true;
        }
        $http.get("/Umbraco/api/Netlify/CheckProgress").then(function (response) {
            vm.loading = false;
            vm.progress = response.data;

            var values = Object.keys(vm.progress);
            var succeededSteps = [];

            for (var i = 0; i < values.length; i++) {
                var step = vm.progress[values[i]];
                if (step.hasExecuted && step.succeeded) {
                    succeededSteps.push(step);
                }
            }

            vm.width = succeededSteps.length === 0
                ? 0
                : (succeededSteps.length / values.length) * 100;

            vm.statusMessage = succeededSteps.length === 0
                ? "Deploy not initiated"
                : succeededSteps[succeededSteps.length - 1].name;

            vm.finishedDeploy = vm.width === 100;

            if (vm.finishedDeploy) {
                vm.finishedDeploymentData = succeededSteps[succeededSteps.length - 1];
            }
        });
    }

    function clear() {
        return $http.get("/Umbraco/api/Netlify/Clear");
    }

    init();
}

angular.module("umbraco").controller("Enterspeed.Deploy.SSG.Services.Netlify.Content", netlifyContentService);