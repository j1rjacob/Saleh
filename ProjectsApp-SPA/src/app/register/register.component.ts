import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from '../_models/user';
import { Form, FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { AlertifyService } from '../_services/alertify.service';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  user: User;
  registerForm: FormGroup;

  constructor(public authService: AuthService,
              private alertify: AlertifyService,
              private router: Router,
              private fb: FormBuilder) { }

  ngOnInit() {
    this.createRegisterForm();
  }

  createRegisterForm() {
    this.registerForm = this.fb.group({
     username: ['', Validators.required],
     name: ['', Validators.required],
     position: ['', Validators.required],
     password: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(8)]]
    });
  }

  register() {
    this.user = Object.assign({}, this.registerForm.value);
    this.authService.register(this.user).subscribe(next => {
      //this.alertify.success('Login Successfully');
    }, error => {
      //this.alertify.error(error);
    }, () => {
      this.authService.login(this.user).subscribe(() => {
        this.router.navigate(['/dashboard']);
       });
    });
    console.log(this.registerForm.value);
  }

}
