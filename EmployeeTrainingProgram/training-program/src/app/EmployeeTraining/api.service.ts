import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import TrainingProgram from './TrainingProgram';

@Injectable()
export default class TrainingService {
  private API = 'https://localhost:44349/';
  private TRAINING_PROGRAM_ENDPOINT = 'https://localhost:44349/api/trainingprogram';

  constructor(private http: HttpClient) { }

  getAll(): Observable<Array<TrainingProgram>> {
    return this.http.get<Array<TrainingProgram>>(this.TRAINING_PROGRAM_ENDPOINT);
  }
}
