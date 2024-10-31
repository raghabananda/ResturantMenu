app.run(function ($rootScope, $location) {
    $rootScope.$on('$routeChangeError', function (event, current, previous, rejection) {
        if (rejection === 'Not Authenticated') {
            $location.path('/login');
        }
        if (rejection === 'Authenticated') {
            $location.path('/home');
        }
    });
    
});