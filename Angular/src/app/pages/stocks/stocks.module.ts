import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StocksComponent } from './stocks.component';
import { RouterModule } from '@angular/router';
import { SharedModule } from 'src/app/shared/shared.module';
import { Chart1Component } from './chart1/chart1.component';
import { NgxChartsModule } from '@swimlane/ngx-charts';
import { NgApexchartsModule } from 'ng-apexcharts';


export const routes = [
  {path: '' , component: StocksComponent , pathMatch: 'full'}
]

@NgModule({
  declarations: [StocksComponent, Chart1Component],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    SharedModule,
    NgxChartsModule,
    NgApexchartsModule
  ],
  exports:[Chart1Component]
})
export class StocksModule { }
