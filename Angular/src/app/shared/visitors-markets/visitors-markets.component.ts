import { Component, Input, OnInit } from '@angular/core';
import { SwiperConfigInterface } from 'ngx-swiper-wrapper';

@Component({
  selector: 'app-visitors-markets',
  templateUrl: './visitors-markets.component.html',
  styleUrls: ['./visitors-markets.component.scss']
})
export class VisitorsMarketsComponent implements OnInit {
  @Input('menuItems') menuItems: Array<any> = [];
  public config: SwiperConfigInterface = {}; 

  constructor() { }

  ngOnInit() {
  }

  ngAfterViewInit(){
    this.config = {
      observer: true,
      slidesPerView: 1,
      spaceBetween: 16,       
      keyboard: true,
      navigation: { nextEl: '.prop-next', prevEl: '.prop-prev'},
      pagination: true,
      grabCursor: true,        
      loop: false,
      preloadImages: false,
      lazy: true,   
      breakpoints: {
        320: {
          slidesPerView: 1
        },
        600: {
          slidesPerView: 1
        },
        960: {
          slidesPerView: 1
        },
        1280: {
          slidesPerView: 1
        }
      }
    }
  }

}
