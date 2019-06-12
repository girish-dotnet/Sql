import { Component, OnInit } from '@angular/core';
import { RouterModule, Router } from '@angular/router';

@Component({
  selector: 'app-first',
  templateUrl: './first.component.html',
  styleUrls: ['./first.component.css']
})
export class FirstComponent implements OnInit {

  constructor(private _router : Router) { }

  ngOnInit() {
  }

  ShowThird() {
    this._router.navigate(["/Third"]);
  }
}
