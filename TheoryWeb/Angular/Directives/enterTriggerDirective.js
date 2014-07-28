(function () {
    "use strict";

    var enterTrigger = function () {
        return function (scope, element, attrs) {
            element.bind("keydown keypress", function (event) {
                if (event.which === 13) {
                    scope.$apply(function () {
                        scope.$eval(attrs.enterTrigger);
                    });

                    event.preventDefault();
                }
            });
        }
    };

    angular.module('Theory.Directives').directive('enterTrigger', enterTrigger);
})();