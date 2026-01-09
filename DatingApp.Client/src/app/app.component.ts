import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { UserDTO } from './core/models/userDTO';
import { AccountService } from './core/services/account.service';

@Component({
  selector: 'app-root',
  imports: [],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit{
  title = 'Dating App';
  users:UserDTO[] = [];
  accountService = inject(AccountService);

  ngOnInit(): void {
    this.getUsers();
  }

  getUsers(){
    this.accountService.getMembers().subscribe({
      next: res => this.users = res,
      error: err => console.log(err)
    });
  }
}
