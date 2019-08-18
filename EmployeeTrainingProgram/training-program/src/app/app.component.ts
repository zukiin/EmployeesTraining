import { Component, OnInit } from '@angular/core';

import TrainingProgram from './EmployeeTraining/TrainingProgram';
import ApiService from './EmployeeTraining/api.service';
import { error } from 'util';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  public title = 'training-program';
  public trainingPrograms: Array<TrainingProgram>;
  public errorMessage: string;


  constructor(private apiService: ApiService) {
  }

  ngOnInit() {
    this.apiService.getAll().
    subscribe(data => {
      this.trainingPrograms = data;
    }, error => {this.errorMessage = "Data didn't load properly" });
  }
}
