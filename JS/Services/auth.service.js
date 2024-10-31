
app.factory('AuthService', function($q, $location) {
    var user = null;

    return {
        login: function(username, password) {
            var deferred = $q.defer();
            
            // Simulate authentication (replace with real HTTP request)
            if (username === 'user' && password === 'password') {
                user = { name: username };
                localStorage.setItem('user',JSON.stringify(user));
                deferred.resolve(user);
            } else {
                deferred.reject('Invalid credentials');
            }

            return deferred.promise;
        },
        logout: function() {
            user = null;
            localStorage.clear();
            $location.path('/login');
        },
        isAuthenticated: function() {
            return localStorage.getItem("user") ? true : $q.reject('Not Authenticated');
        },        
        getUser: function() {
            return JSON.parse(localStorage.getItem("user"));
        },
        IamLoggedin:()=>{
           return $q.reject('Authenticated')
        }
    };
});