//define a module

var myApp = angular.module('myModule', []);


/*myApp.controller("myController", function($scope) {
    $scope.message = "This is my message from controller";
}); //regist controller into this module.*/

/*myApp.controller("mySchool", function($scope){
    $scope.message = "Annoucement from school"
});*/
myApp.controller("schoolController", schoolController);
myApp.service('ValidatorService', Validator);
myApp.directive("teduShopDirective", teduShopDirective);
schoolController.$inject = ['$scope', 'ValidatorService'];

function schoolController($scope, Validator) {
    $scope.checkNumber = function () {
        $scope.message = Validator.checkNumber(2);
    }
    $scope.num = 1;

    
}

function Validator($window) {
    return {
        checkNumber: checkNumber //ten public : ten noi bo.
    }
    function checkNumber(input)
    {
        if (input % 2 == 0) {
            return 'This is event';
        }
        else
            return 'This is odd';
    }
}

function teduShopDirective() {
    return {
        restrict: "A",
        template: "<h1>This is my first custom directive </h1>"
    }
}