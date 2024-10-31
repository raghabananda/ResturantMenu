var app = angular.module('myApp', ['ngRoute']);

app.config(['$routeProvider', function ($routeProvider, $location) {
    const authCheck=function (AuthService) {
                    return AuthService.isAuthenticated();
                };
     const skipIfLoggedIn= function (AuthService) {
                    if (AuthService.getUser()) {
                        AuthService.IamLoggedin()                                             
                }
            } ;      
    $routeProvider
        .when('/home', {
            templateUrl: 'Views/Menu.html',
            controller: 'HomeController',
            resolve: {
                auth: authCheck
            }
        })
        .when('/london', {
            templateUrl: 'Views/london.html',
            controller: 'HomeController'
        })
        .when('/login', {
            templateUrl: 'Views/login.html',
            controller: 'LoginController',
            resolve: {
                skipIfLoggedIn:skipIfLoggedIn
            }
        })
        .otherwise({
            redirectTo: '/login'
        });
}]);

app.run(function($rootScope) {    
   $rootScope.logout=function(AuthService){
      AuthService.logout();
   }
});


