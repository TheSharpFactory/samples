import * as Chartist from 'chartist';
import { IChartistBase, IChartistData, IChartOptions } from 'chartist';

export default class BlazorChartist {
     static createChart(elem: Element, type: 'Bar' | 'Line') {
          var constructor = Chartist[type];
          const chart: IChartistBase<IChartOptions> = new constructor(elem, { series: [] });
          elem['_chart'] = chart;
     }

     static updateChart(elem: Element, data: IChartistData, options: IChartOptions) {
          elem['_chart'].update(data, options);
     }
}