/// <reference path="F:\MyProject\Github\ShopKhanMat\ShopKhanMat.Web\Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('shopKhanMat',
        [
            'shopKhanMat.products',
            'shopKhanMat.product_categories',
            'shopKhanMat.common'
        ]).config(config);

    config.$inject = ['$stateProvider','$urlRouterProvider']

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            Controller:"homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();