import { Component, OnInit } from '@angular/core';

import TrainingProgram from './EmployeeTraining/TrainingProgram';
import ApiService from './EmployeeTraining/api.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'training-program';
  trainingPrograms: Array<TrainingProgram>;

  constructor(private apiService: ApiService) {
  }

  ngOnInit() {
    this.apiService.getAll().
    subscribe(data => {
      this.trainingPrograms = data;
    });
  }
}
