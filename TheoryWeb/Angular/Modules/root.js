(function () {
    "use strict";

    angular.module("Theory.Controllers", []);
    angular.module("Theory.Directives", []);
    
    angular.module("Root", ['Theory.Controllers', 'Theory.Directives']);
}());