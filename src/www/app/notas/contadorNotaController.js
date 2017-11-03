(function () {
    "use strict";

    function contadorNotaController($http){
        var vm = this;
        vm.valor = 0;
        vm.notas = [];
        vm.contarNotas = ()=> $http.get(`http://localhost:54298/api/ContadorNotas/${parseInt(vm.valor)}`).then((response)=> {
            vm.notas = response.data;
            console.log(vm.notas);
        });
        
    }

    angular.module('contador-nota')
           .controller("contadorNotaController", contadorNotaController);

}());