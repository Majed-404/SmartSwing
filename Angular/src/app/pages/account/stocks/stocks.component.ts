import { Component, OnInit } from '@angular/core';
import { InfoCardsComponent } from 'src/app/admin/dashboard/info-cards/info-cards.component';
import { FormControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AccountService } from '../account-service.service';
import { Stocks } from './stockes.model';


@Component({
  selector: 'app-stocks',
  templateUrl: './stocks.component.html',
  styleUrls: ['./stocks.component.scss']
})
export class StocksComponent implements OnInit {

  public infocards : InfoCardsComponent

  
  public toggleSearchBar:boolean = false;
  myControl = new FormControl();
  public id:number;



  constructor(public accountService:AccountService,public router: Router,private route: ActivatedRoute) { }

  ngOnInit(): void {
    debugger
    this.id = this.route.snapshot.params['id'];
    
  }

  
}
