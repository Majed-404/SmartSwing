import { Component, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { AppSettings, Settings } from 'src/app/app.settings';

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
  public settings: Settings;
  constructor(public translateService: TranslateService,public appSettings: AppSettings) { 
    this.settings = this.appSettings.settings;
  }

  ngOnInit() { } 

  public changeLang(lang:string){ 
    debugger
    if(lang=="ar")
    this.settings.rtl=true;
    else
    this.settings.rtl=false;
    this.translateService.use(lang);   
  } 

}
