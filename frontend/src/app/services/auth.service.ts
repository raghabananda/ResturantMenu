import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, tap } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({ providedIn: 'root' })
export class AuthService {
  private apiUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  login(username: string, password: string): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/auth/login`, { username, password }).pipe(
      tap(res => {
        localStorage.setItem('taj_auth_token', res.token);
        localStorage.setItem('taj_user', JSON.stringify({ name: res.name, role: res.role }));
      })
    );
  }

  logout(): void {
    localStorage.removeItem('taj_auth_token');
    localStorage.removeItem('taj_user');
  }

  isLoggedIn(): boolean {
    return !!localStorage.getItem('taj_auth_token');
  }

  getToken(): string | null {
    return localStorage.getItem('taj_auth_token');
  }

  getUser(): any {
    const u = localStorage.getItem('taj_user');
    return u ? JSON.parse(u) : null;
  }

  isAdmin(): boolean {
    const user = this.getUser();
    return user && user.role === 'Admin';
  }
}
