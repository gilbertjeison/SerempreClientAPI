import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Cities } from './model/cities.model';
import { MatDialog } from '@angular/material/dialog';
import { CreateCityDialogComponent } from './dialog/create-city-dialog/create-city-dialog.component';

@Component({
  selector: 'app-city',
  templateUrl: './city.component.html',
  styleUrls: ['./city.component.css']
})
export class CityComponent implements OnInit {
  public cities: Cities[] = [];
  public newCity: Cities = {id: 0, name: ''};
  displayedColumns: string[] = ['id', 'name'];
  baseUrl :string =  '';

  constructor(private http: HttpClient,
                      @Inject('BASE_URL') baseUrl: string,
                      public dialog: MatDialog){
    this.baseUrl = baseUrl;
  }

  ngOnInit(): void {
    this.http.get<Cities[]>(this.baseUrl + 'city').subscribe(result => {
      this.cities = result;
    }, error => console.error(error));
  }

  openDialog(): void {
    const dialogRef = this.dialog.open(CreateCityDialogComponent, {
      data: this.newCity != null ? this.newCity : {},
    });

    dialogRef.afterClosed().subscribe(result => {
      this.newCity = result;

      if(this.newCity != null){
        this.http.post(this.baseUrl + 'city',{name:this.newCity}).subscribe(result => {
          console.log(result);
        }, error => console.error(error));
      }
    });
  }
}
