(function() {
    "use strict";

    var controller = function ($scope, $http) {
        $scope.answer = '';
        $scope.chord = '';
        $scope.result = '';
        $scope.score = '0 out of 0 (100%)';

        var actualAnswer = '';
        var totalQuestions = 0;
        var totalCorrect = 0;

        $scope.getQuestion = function() {
            $http.get('/api/Question', {}, function (data) {
                $scope.chord = data.Chord;
                actualAnswer = data.Name;
            }, function() {
                $scope.result = 'Error getting next chord';
            });
        };

        $scope.guess = function () {

        };

        $scope.reveal = function () {
            $scope.result = actualAnswer;
        };

        $scope.getQuestion();
    };

    controller.$inject = ['$scope', '$http'];

    angular.module("Theory.Controllers").controller("ChordController", controller);
}());