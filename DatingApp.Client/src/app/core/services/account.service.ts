import { inject, Injectable, signal } from '@angular/core';
import { environment } from '../../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable, tap } from 'rxjs';
import { UserDTO } from '../models/userDTO';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl: string = environment.apiUrl;
  users = signal<UserDTO[]>([]);
  private http = inject(HttpClient);

  getMembers():Observable<UserDTO[]>{
    return this.http.get<UserDTO[]>(`${this.baseUrl}/members`).pipe(
      tap(res => this.users.set(res))
    );
  }
}
