import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.scss']
})
export class AboutComponent implements OnInit {
  public workingHours = [
    { day: "Monday", hours: "10AM TO 11PM" },
    { day: "Tuesday", hours: "10AM TO 11PM" },
    { day: "Wednesday", hours: "10AM TO 11PM" },
    { day: "Thursday", hours: "10AM TO 11PM" },
    { day: "Friday", hours: "10AM TO 11PM" },
    { day: "Saturday", hours: "10AM TO 11PM" },
    { day: "Sunday", hours: "10AM TO 11PM" }
  ]
  constructor() { }

  ngOnInit(): void {
  }

}
