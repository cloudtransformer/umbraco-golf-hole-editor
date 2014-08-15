angular.module("umbraco").controller("AgeBase.GolfHoleEditor", function ($scope) {

    $scope.holes = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18];
    $scope.pars = [3, 4, 5];
    $scope.tees = ["Black", "Blue", "White", "Yellow", "Red", "Green"];

    $scope.init = function() {
        var retval = [];
        for (var i = 0; i < $scope.tees.length; i++) {
            retval.push({
                name: $scope.tees[i],
                par: null,
                strokeIndex: null,
                distance: null
            });
        }
        return retval;
    }

    $scope.model.value = $scope.model.value || $scope.init();

    if (!($scope.model.value instanceof Array))
        $scope.model.value = $scope.init();

    $scope.selected = $scope.model.value[0].name;

    $scope.showTee = function (name) {
        $scope.selected = name;
    };

    $scope.isTeeActive = function (name) {
        return $scope.selected === name;
    };

});