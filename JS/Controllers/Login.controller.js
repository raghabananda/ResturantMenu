
app.controller('LoginController', function($scope, $location, AuthService) {   
    $scope.login = function() {
        AuthService.login($scope.username, $scope.password)
            .then(function(user) {
                $location.path('/home');
            })
            .catch(function(error) {
                $scope.error = error;
            });
    };
});