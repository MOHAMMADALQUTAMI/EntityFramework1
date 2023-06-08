import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: Employee[] = [];
  employees: Employee[] = [];
employee: any;

  constructor( private http: HttpClient, @Inject('BASE_URL')private baseUrl: string) {
    // http.get<WeatherForecast[]>(baseUrl + 'weatherforecast').subscribe(result => {
    //   this.forecasts = result;
    // }, error => console.error(error));
  }
  getEmployee(){
    this.http.get<Employee[]>(this.baseUrl + 'employee/Get').subscribe(result => {
      this.employees = result;
    }, error => console.error(error));
  }
  creatEmployee(){
    const employee = {
      id: 0,
      name: "new Name"
    };
    this.http.post<Employee[]>(this.baseUrl + 'employee/create',employee).subscribe(result => {
      this.employees = result;
      this.getEmployee();

    }, error => console.error(error));
  }
}

// interface WeatherForecast {
//   date: string;
//   temperatureC: number;
//   temperatureF: number;
//   summary: string;
// }
interface Employee {
  id: number;
  name: string;
}
