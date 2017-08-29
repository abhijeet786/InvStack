app.controller('Studentctrl', function ($scope, CrudService) {

    $scope.Message = 'Hello Angular js';
    var baseUrl = '/api/Student/';
    $scope.btnText = "Save";
    $scope.studentID = 0;
    $scope.SaveUpdate = function () {
        var data = {
            FirstName: $scope.firstName,
            LastName: $scope.lastName,
            Email: $scope.email,
            Address: $scope.address,
            StudentID: $scope.studentID
        };
        var apiRoute = baseUrl+"SaveStudent/";
        var saveStudent = CrudService.post(apiRoute, data);
        saveStudent.then(function (response) {
            
            if (response.data != "") {
                alert(response.data);
                $scope.Clear();

            } else {
                alert("Some error");
            }

        }, function (error) {
            console.log("Error: " + error);
        });
    }

    $scope.getallStudent = function()
    {
        var apiRoute = baseUrl;
        var Response = CrudService.get(apiRoute);
        Response.then(function (response) {
            if(response.data !=null)
            {
                $scope.show = 1;
                $scope.studentdata = response.data;
            }
        });
    }
    $scope.getStudentData = function () {
       
        var apiRoute = "Student";
        var Response = CrudService.get(apiRoute);
        Response.then(function (response) {
          
            if (response.data != null) {
                $scope.show = 1;
                $scope.studentdata = response.data;
            }
        });
    }
})

.controller('Login', function ($scope, $window, CrudService) {
    $scope.Login = function () {
      
        var route = "/Login/LoginUser/";
        var Login = CrudService.post(route, $scope.User);
        Login.then(function (response) {
            if (response.data.Username != null)
            {
                $window.location.href = '/Dashboard/Index/';
            } else {
                alert("Invalid Credentials");
            }
        })
    }
})
.controller('Question', function ($scope, CrudService) {

    $scope.SubmitQues = function()
    {
        var data = CKEDITOR.instances['txtQuestion'].getData();
        $scope.Ques.Question_Description = data;
        var route = "/Questions/SubmitQues/";
        alert("");
        var Questions = CrudService.post(route, $scope.Ques);
        Questions.then(function (response) {
            if(response.data != null)
            {

            }else
            {

            }
        })
    }

})

//.directive('ckEditor', function () {
//    return {
//        require: '?ngModel',
//        link: function (scope, elm, attr, ngModel) {
//            var ck = CKEDITOR.replace(elm[0]);

//            if (!ngModel) return;

//            ck.on('pasteState', function () {
//                scope.$apply(function () {
//                    ngModel.$setViewValue(ck.getData());
//                });
//            });

//            ngModel.$render = function (value) {
//                ck.setData(ngModel.$viewValue);
//            };
//        }
//    };
//});