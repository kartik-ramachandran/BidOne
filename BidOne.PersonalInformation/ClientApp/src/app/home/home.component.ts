import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  private _http: HttpClient;
  private _baseUrl: string;
  FirstName: string = '';
  LastName: string = '';
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._http = http;
    this._baseUrl = baseUrl;
  }
  OnSubmit() {
    this._http.post<any>(this._baseUrl + 'personalinformation', { 'FirstName': this.FirstName, 'LastName': this.LastName }).subscribe(result => {
    }, error => console.error(error));
  }
}
