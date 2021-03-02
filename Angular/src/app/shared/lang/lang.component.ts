import { Component, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-lang',
  templateUrl: './lang.component.html',
  styleUrls: ['./lang.component.scss']
})
export class LangComponent implements OnInit {
  // public flags = [
  //   { name:'English', image: 'assets/images/flags/gb.svg' },
  //   { name:'German', image: 'assets/images/flags/de.svg' },
  //   { name:'French', image: 'assets/images/flags/fr.svg' },
  //   { name:'Russian', image: 'assets/images/flags/ru.svg' },
  //   { name:'Turkish', image: 'assets/images/flags/tr.svg' }
  // ] 
  constructor(public translateService: TranslateService) { }

  ngOnInit() { } 

  public changeLang(lang:string){ 
    this.translateService.use(lang);   
  } 

}
