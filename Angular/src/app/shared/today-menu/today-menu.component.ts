import { Component, Input, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { DomSanitizer } from '@angular/platform-browser';
import { MenuItem } from 'src/app/app.models';
import { AppService } from 'src/app/app.service';

@Component({
  selector: 'app-today-menu',
  templateUrl: './today-menu.component.html',
  styleUrls: ['./today-menu.component.scss']
})
export class TodayMenuComponent implements OnInit {
  @Input() menuItem: MenuItem;
  @Input('backgroundImage') backgroundImage:any;
  public bgImage:any;
  public quantityCount:number = 1;

  constructor(public appService:AppService, private sanitizer:DomSanitizer, public snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.bgImage = this.sanitizer.bypassSecurityTrustStyle('url('+this.backgroundImage +')'); 
  }


  public counterChange(count:number){ 
    this.quantityCount = count;   
  } 

  public addToCart(){ 
    this.menuItem.cartCount = this.quantityCount;
    if(this.menuItem.cartCount <= this.menuItem.availibilityCount){
      const index: number = this.appService.Data.cartList.findIndex(item => item.id == this.menuItem.id); 
      (index !== -1) ? this.appService.Data.cartList[index] = this.menuItem : this.appService.addToCart(this.menuItem, null); 
      this.appService.calculateCartTotal();
    }
    else{
      this.menuItem.cartCount = this.menuItem.availibilityCount;
      this.snackBar.open('You can not add more items than available. In stock ' + this.menuItem.availibilityCount + ' items and you already added ' + this.menuItem.cartCount + ' item to your cart', '×', { panelClass: 'error', verticalPosition: 'top', duration: 5000 });
    }
  }


  public addToFavorites(){  
    this.appService.addToFavorites(this.menuItem);
  } 

}
