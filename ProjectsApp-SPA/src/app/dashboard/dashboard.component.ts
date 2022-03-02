import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ChartOptions, ChartType, ChartDataSets } from 'chart.js';
import {  Label  } from 'ng2-charts';
import { AlertifyService } from '../_services/alertify.service';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  public barChartOptions: ChartOptions = {
    responsive: true,
    scales: {
      yAxes: [{
        display: false,
      }],
      xAxes: [{
        display: false,
      }]
    }
  };
  public barChartLabels: Label[] = ['%'];
  public barChartType: ChartType = 'bar';
  public barChartLegend = false;
  public barChartPlugins = [];

  public barChartData: ChartDataSets[] = [
    { data: [29], backgroundColor: "#8B0000"},
    { data: [100], backgroundColor: "#0000FF"},
  ];

  public hBarChartType: ChartType = 'horizontalBar';
  public hBarChartLabels: Label[] = ['SAR'];
  public hBarChartData: ChartDataSets[] = [
    { data: [4000000], backgroundColor: "#8B0000", label: "Project Amount"},
    { data: [3248843], backgroundColor: "#0000FF", label: "Remaining"},
  ];


  constructor(public authService: AuthService, private alertify: AlertifyService,
    private router: Router) { }

  ngOnInit() {
  }

  logout() {
    localStorage.removeItem('token');
    localStorage.removeItem('user');
    this.authService.currentUser = null;
    this.authService.decodedToken = null;
    this.router.navigate(['/login']);
  }

}
