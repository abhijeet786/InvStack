app.service('CrudService', function ($http) {
    this.post = function (apiRoute, Model) {
        var Request = $http({
            method: 'Post',
            url: apiRoute,
            data: Model
        });
        return Request;
    }
    this.get = function(apiRoute)
    {
        var Request = $http({
            method: 'get',
            url: apiRoute
        });
        return Request;
    }
    
});