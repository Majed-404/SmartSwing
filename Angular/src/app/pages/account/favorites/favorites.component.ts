import { Component, OnInit, ViewChild } from '@angular/core';
import { AppService } from 'src/app/app.service';
import { MenuItem } from 'src/app/app.models';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-favorites',
  templateUrl: './favorites.component.html',
  styleUrls: ['./favorites.component.scss']
})
export class FavoritesComponent implements OnInit {
  
  public paymentMethod: FormGroup;
  public months = [];
  public years = [];
  constructor(public appService:AppService, private fb: FormBuilder) { }

  ngOnInit() {
    
    this.months = this.appService.getMonths();
    this.years = this.appService.getYears();

    this.paymentMethod = this.fb.group({
      'cardHolderName': [null, Validators.required],
      'cardNumber': [null, Validators.required],
      'expiredMonth': [null, Validators.required],
      'expiredYear': [null, Validators.required],
      'cvv': [null, Validators.compose([Validators.required, Validators.minLength(3)])]
    });
  }

  onSubmitForm(paymentMethod){
    
  }
  

}
