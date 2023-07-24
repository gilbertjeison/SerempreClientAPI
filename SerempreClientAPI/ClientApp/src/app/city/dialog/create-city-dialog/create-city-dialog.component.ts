import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { Cities } from '../../model/cities.model';

@Component({
  selector: 'app-create-city-dialog',
  templateUrl: './create-city-dialog.component.html',
  styleUrls: ['./create-city-dialog.component.css']
})
export class CreateCityDialogComponent {
  constructor(
    public dialogRef: MatDialogRef<CreateCityDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: Cities,
  ) {}

  onNoClick(): void {
    this.dialogRef.close();
  }
}
