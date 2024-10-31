app.controller('navController', function ($scope,$rootScope, AuthService) {                  
    $scope.logout = function () {
        console.log("logout");
        AuthService.logout();
        $rootScope.user=null;
    };
});