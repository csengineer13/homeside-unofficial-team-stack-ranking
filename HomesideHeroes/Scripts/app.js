﻿// Global
window.app = {};

$(function() {

    // Expose
    app.refreshChart = function () {
        $.ajax({
            method: "GET",
            url: "/api/pluralsight",
            //data: {},
            dataType: "json" // result format
        })
        .done(function(result) {
            app.buildChart(result);

        })
        .fail(function(result) {

        })
        .always(function(result) {
            console.log(result);
        });
    };

    app.buildChart = function(data) 
    {
        var ctx = document.getElementById("myChart");
        var myChart = new Chart(ctx, {
            type: 'line',
            data: data

            //,
            //options: {
            //    scales: {
            //        yAxes: [{
            //            ticks: {
            //                beginAtZero: true
            //            }
            //        }]
            //    }
            //}
        });
    };

});