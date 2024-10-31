app.controller('HomeController', function ($scope,$rootScope, AuthService, $location) {
    $rootScope.user = AuthService.getUser();
               
    // $rootScope.logout = function () {
    //     console.log("logout");
    //     AuthService.logout();
    //     $rootScope.user=null;
    // };
});

app.controller('navController', function ($scope, AuthService, $location) {
                  
    $scope.logout = function () {
        console.log("logout");
        AuthService.logout();
        $rootScope.user=null;
    };
});