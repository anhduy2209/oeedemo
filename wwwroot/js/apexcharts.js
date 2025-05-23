window.renderApexChart = (elementId, options) => {
    var chart = new ApexCharts(document.querySelector(`#${elementId}`), options);
    chart.render();
    return {
        update: (newOptions) => chart.updateOptions(newOptions),
        destroy: () => chart.destroy()
    };
};
