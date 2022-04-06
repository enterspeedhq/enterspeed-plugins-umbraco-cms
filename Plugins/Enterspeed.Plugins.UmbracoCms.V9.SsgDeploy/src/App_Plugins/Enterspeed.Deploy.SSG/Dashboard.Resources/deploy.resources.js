angular.module('umbraco.resources')
    .factory('enterspeedSsgDeploymentResource',
        function ($http) {
            return {
                getConfiguration() {
                    return $http.get("/umbraco/backoffice/api/Deployment/GetConfiguration");
                },
                saveConfiguration: function (configuration) {
                    return $http.post("/umbraco/backoffice/api/Deployment/SaveConfiguration", configuration);
                }
            };
        });