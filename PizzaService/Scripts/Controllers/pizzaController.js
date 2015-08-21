(function () {
    'use strict';
    
    var restaurantApp = angular.module('restaurantApp');
    
    function callback ($scope, pizzaService, ingredientService, orderService) {
        $scope.pizza = pizzaService.getPizza();
        $scope.getPizzaPriceById = pizzaService.getPizzaPriceById;

        $scope.getIngredientBiId = function(id) {
            var promiseFunction = ingredientService.getIngredientById;
            promiseFunction.then(function(response) {

            });
        }

        $scope.addPizza = pizzaService.addPizza;
        $scope.getPriceById = ingredientService.getPriceById;
        $scope.getNameById = ingredientService.getNameById;
        $scope.getPhotoById = ingredientService.getPhotoById;
        $scope.createCustomOrder = orderService.createCustomOrder;
    
        $scope.showPopup = function () {
            $('.ingredients-popup').bPopup({
                follow: [false, false], 
                position: [500, 100] 
            });
        }
    }
    
    restaurantApp.controller('PizzaController', ['$scope', 'pizzaService', 'ingredientService', 'orderService', callback]);    
})();
