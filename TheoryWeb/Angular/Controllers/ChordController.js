(function() {
    "use strict";

    var controller = function ($scope, $http, $timeout) {
        $scope.answer = '';
        $scope.chord = '';
        $scope.result = '';
        $scope.hidden = true;

        var actualAnswer = '';
        var totalQuestions = 0;
        var totalCorrect = 0;
        var revealed = false;
        var id = '';

        $scope.getQuestion = function() {
            $http.get('/api/Question').success(function(data) {
                $scope.chord = data.Chord;
                actualAnswer = data.Name;
                id = data.Id;
                totalQuestions++;
            }).error(function() {
                $scope.result = 'Error getting next chord';
            });
        };

        var timeout = null;
        $scope.guess = function () {
            $scope.hidden = false;
            if ($scope.answer.replace(' ', '') === actualAnswer.replace(' ','')) {
                if (!revealed) {
                    $scope.result = "Correct!";
                    totalCorrect++;
                }

                $scope.getQuestion();
            } else {
                $scope.result = "Nope!";
                totalQuestions++;
            }

            if (timeout !== null) {
                $timeout.cancel(timeout);
            }

            timeout = $timeout(function() {
                $scope.result = '';
                $scope.hidden = true;
                timeout = null;
            }, 1000);

            $scope.answer = '';

            revealed = false;
        };

        $scope.reveal = function () {
            if (revealed) {
                return;
            }

            $scope.result = actualAnswer;
            $scope.hidden = false;
            revealed = true;
        };

        $scope.getScore = function() {
            var percent = (totalCorrect / totalQuestions) * 100;

            return totalCorrect + " out of " + totalQuestions + " (" + percent.toFixed(2) + "%)";
        }

        $scope.getQuestion();
    };

    controller.$inject = ['$scope', '$http', '$timeout'];

    angular.module("Theory.Controllers").controller("ChordController", controller);
}());