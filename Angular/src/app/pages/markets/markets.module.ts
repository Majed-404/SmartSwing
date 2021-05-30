import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MarketsComponent } from './markets.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { RouterModule } from '@angular/router';
import { StocksComponent } from './stocks/stocks.component';
import { StocksMarketComponent } from './stocks-market/stocks-market.component';

export const routes = [
  {path: '' , component: MarketsComponent, pathMatch: 'full'},
  {path: 'stocks-market/:id' , component: StocksMarketComponent},
]

@NgModule({
  declarations: [MarketsComponent, StocksComponent, StocksMarketComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    SharedModule
  ]
})
export class MarketsModule { }
