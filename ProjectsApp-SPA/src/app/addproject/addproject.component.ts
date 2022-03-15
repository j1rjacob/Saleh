import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { BsDatepickerConfig } from 'ngx-bootstrap/datepicker';
import { TabsetComponent } from 'ngx-bootstrap/tabs';

import { Project } from '../_models/project';
import { AlertifyService } from '../_services/alertify.service';
import { AuthService } from '../_services/auth.service';
import { ProjectService } from '../_services/project.service';

@Component({
  selector: 'app-addproject',
  templateUrl: './addproject.component.html',
  styleUrls: ['./addproject.component.css']
})

export class AddprojectComponent implements OnInit {
  @ViewChild('projectTabs', { static: false }) projectTabs?: TabsetComponent;
  project: Project;
  addProjectForm: FormGroup;
  addRiskForm: FormGroup;
  bsConfig: Partial<BsDatepickerConfig>;

  constructor(public authService: AuthService,
              public projectService: ProjectService,
              private alertify: AlertifyService,
              private router: Router,
              private fb: FormBuilder) { }

  ngOnInit() {
    this.createProjectForm();
    this.createRiskForm();
    this.bsConfig = {
      containerClass: 'theme-blue',
      isAnimated: true,
      dateInputFormat: 'YYYY-MM-DD'
    };
  }

  createProjectForm() {
    this.addProjectForm = this.fb.group({
     projectname: ['', Validators.required],
     projectmanager: ['', Validators.required],
     mobile: ['', Validators.required],
     email: ['', Validators.required],
     projectowner: ['', Validators.required],
     department: ['', Validators.required],
     projectarea: ['', Validators.required],
     podate: [null, Validators.required],
     pono: ['', Validators.required],
     projectamount: ['', Validators.required],
     projectstartdate: [null, Validators.required],
     projectenddate: [null, Validators.required],
     projectperiod: ['', Validators.required],
     remainingperiod: [1, Validators.required],
     userid: [1, Validators.required],
    });
  }

  createRiskForm() {
    this.addRiskForm = this.fb.group({
     issue: ['', Validators.required],
     riskdate: [null, Validators.required],
     impact: ['', Validators.required],
     email: ['', Validators.required],
     correctiveaction: ['', Validators.required],
     owner: ['', Validators.required],
     status: ['', Validators.required]
    });
  }

  updateMyDate(newDate) {
    console.log(newDate);
  }

  saveproject() {
    this.project = Object.assign({}, this.addProjectForm.value);
    this.projectService.addProject(this.project).subscribe(next => {
      this.alertify.success('Login Successfully');
    }, error => {
      this.alertify.error(error);
    }, () => {
      console.log(this.addProjectForm.value);
    });
    console.log(this.addProjectForm.value);
  }

  saverisk() {
    this.project = Object.assign({}, this.addProjectForm.value);
    this.projectService.addProject(this.project).subscribe(next => {

      this.alertify.success('Login Successfully');
    }, error => {
      this.alertify.error(error);
    }, () => {
      console.log(this.addProjectForm.value);
    });
    console.log(this.addProjectForm.value);
  }

  selectTab(tabId: number) {
    if (this.projectTabs?.tabs[tabId]) {
      this.projectTabs.tabs[tabId].active = true;
    }
  }

  logout() {
    localStorage.removeItem('token');
    localStorage.removeItem('user');
    this.authService.currentUser = null;
    this.authService.decodedToken = null;
    this.router.navigate(['/login']);
  }

}
