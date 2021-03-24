import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { SharedModule } from '../../shared/shared.module';
import { AccountComponent } from './account.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ProfileComponent } from './profile/profile.component';
import { PasswordChangeComponent } from './password-change/password-change.component';
import { AddressesComponent } from './addresses/addresses.component';
import { FavoritesComponent } from './favorites/favorites.component';
import { ReservationsComponent } from './reservations/reservations.component';
import { OrdersComponent } from './orders/orders.component';
import { OrderComponent } from './orders/order/order.component';
import { MarketsComponent } from './markets/markets.component';
import { StocksComponent } from './stocks/stocks.component';
import { InfoCardsComponent } from 'src/app/admin/dashboard/info-cards/info-cards.component';
import { NgxChartsModule } from '@swimlane/ngx-charts';
import { DashboardModule } from 'src/app/admin/dashboard/dashboard.module';



export const routes = [
  { 
    path: '', 
    component: AccountComponent, children: [
      { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
      { path: 'dashboard', component: DashboardComponent },
      { path: 'profile', component: ProfileComponent },
      { path: 'password-change', component: PasswordChangeComponent },
      { path: 'addresses', component: AddressesComponent },
      { path: 'favorites', component: FavoritesComponent },
      { path: 'reservations', component: ReservationsComponent },
      { path: 'orders', component: OrdersComponent },
      { path: 'orders/:id', component: OrderComponent }, 
      { path: 'markets', component: MarketsComponent }, 
      { path: 'stocks', component: StocksComponent }, 
    ]
  }
];


@NgModule({
  declarations: [
    AccountComponent,
    DashboardComponent,
    ProfileComponent,
    PasswordChangeComponent,
    AddressesComponent,
    FavoritesComponent,
    ReservationsComponent,
    OrdersComponent,
    OrderComponent,
    MarketsComponent,
    StocksComponent 
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    SharedModule,
    NgxChartsModule,
    DashboardModule

  ]
})
export class AccountModule { }
