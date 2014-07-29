(function() {
    "use strict";

    var controller = function ($scope, $http, $timeout) {
        $scope.answer = '';
        $scope.chord = '';
        $scope.result = '';
        $scope.hidden = true;
        $scope.difficulties = [
            { name: 'C Major', value: 1 },
            { name: 'G Major', value: 2 },
            { name: 'D Major', value: 3 },
            { name: 'A Major', value: 4 },
            { name: 'E Major', value: 5 },
            { name: 'B Major', value: 6 },
            { name: 'F# Major', value: 7 }
        ];

        $scope.difficulty = $scope.difficulties[0];

        var actualAnswer = '';
        var totalQuestions = 0;
        var totalCorrect = 0;
        var revealed = false;
        var id = '';

        $scope.getQuestion = function() {
            $http.get('/api/Question?difficulty=' + $scope.difficulty.value).success(function(data) {
                $scope.chord = data.Chord;
                actualAnswer = data.Name;
                id = data.Id;
            }).error(function() {
                $scope.result = 'Error getting next chord';
            });
        };

        var timeout = null;
        $scope.guess = function () {
            $scope.hidden = false;
            if ($scope.answer.replace(' ', '').toLocaleLowerCase() === actualAnswer.replace(' ', '').toLocaleLowerCase()) {
                if (!revealed) {
                    $scope.result = "Correct!";
                    totalCorrect++;
                    totalQuestions++;
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
            if (isNaN(percent)) {
                percent = 0;
            }

            return totalCorrect + " out of " + totalQuestions + " (" + percent.toFixed(2) + "%)";
        }

        $scope.reset = function() {
            totalQuestions = 0;
            totalCorrect = 0;
        }

        $scope.getQuestion();
    };

    controller.$inject = ['$scope', '$http', '$timeout'];

    angular.module("Theory.Controllers").controller("ChordController", controller);
}());