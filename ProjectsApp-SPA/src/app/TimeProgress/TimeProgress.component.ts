import { Component, OnInit } from '@angular/core';
import { ChartOptions, ChartType, ChartDataSets } from 'chart.js';
import {  Label  } from 'ng2-charts';

@Component({
  selector: 'app-TimeProgress',
  templateUrl: './TimeProgress.component.html',
  styleUrls: ['./TimeProgress.component.css']
})
export class TimeProgressComponent implements OnInit {
  public barChartOptions: ChartOptions = {
    responsive: true,
    scales: {
        yAxes: [{
            display: true,
            ticks: {
                suggestedMin: 0
            }
        }]
    },
  };
  public barChartLabels: Label[] = ['SAR'];
  public barChartType: ChartType = 'bar';
  public barChartLegend = false;
  public barChartPlugins = [];

  public barChartData: ChartDataSets[] = [
    { data: [65]},
    { data: [28]},

  ];

  constructor() { }

  ngOnInit() {
  }

}
