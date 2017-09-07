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
        var apiRoute = baseUrl + "SaveStudent/";
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

    $scope.getallStudent = function () {
        var apiRoute = baseUrl;
        var Response = CrudService.get(apiRoute);
        Response.then(function (response) {
            if (response.data != null) {
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

        var route = "Login/";
        var Login = CrudService.post(route, $scope.User);
        Login.then(function (response) {
            if (response.data.Username != null) {
                $scope.UserData = response.data;
                $window.location.href = '/Home/';

            } else {
                alert("Invalid Credentials");
            }
        })
    }
})
.controller('Question', function ($scope, CrudService) {
    $scope.Title = "Title";
    $scope.Question = "Description";
    $scope.Languages = [];
    var route = "Lang";
    var lang = CrudService.get(route);
    lang.then(function (response) {
        $scope.Languages = response.data;
    })

    $scope.SubmitQues = function () {
        var Ckeditordata = CKEDITOR.instances['txtQuestion'].getData();
        var data = {
            'Title': $scope.Title,
            'Question': $scope.Question,
            'Question_Description': Ckeditordata,
            'language': $scope.language
        };
        var route = "/Questions/SubmitQues/";
        var Questions = CrudService.post(route, data);
        Questions.then(function (response) {
            if (response.data == "success") {
                $scope.Title = "";
                $scope.Question = "";
                $scope.language = "";
                CKEDITOR.instances['txtQuestion'].data = "";
                alert("data inserted succesfully");
            } else {

            }
        })
    }


})

.controller('Articles', function ($scope, CrudService) {

    $scope.UserDetail = $scope.UserData;

    //var data = {
    //    'Username':$scope.UserDetail.Username,

    //};
    //var route = "Comment/";
    //var Comment = CrudService.post(route,)

})

.controller('DashboardQues', function ($scope, CrudService) {
    $scope.Ques = [];
    var route = "/getQues";
    var topQues = CrudService.get(route);
    topQues.then(function (response) {
        if (response.data != null) {
            $scope.Ques = response.data;
        } else {

        }
    })
    $scope.showQues = function (id, user_id) {
        $scope.ID = id;
        $scope.user_id = user_id;
        var data = {
            'ID': $scope.id,
            'UserID': $scope.user_id
        }
        var route = "/Single";
        var single = CrudService.getQuestion(route,$scope.ID,$scope.user_id );
        single.then(function (response) {
            if (response.data != null)
            {
                $scope.singlePageData = response.data;
                console.log($scope.singlePageData); return;
            }
            
        })
    }

})

