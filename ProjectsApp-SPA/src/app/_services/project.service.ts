import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Project } from '../_models/project';

@Injectable({
  providedIn: 'root'
})
export class ProjectService {
baseUrl = environment.apiUrl + 'project/';

constructor(private http: HttpClient) { }

  addProject(prj: Project) {
    return this.http.post(this.baseUrl + 'addproject', prj);
  }

}
