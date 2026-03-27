import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { AuthService } from './auth.service';

@Injectable({ providedIn: 'root' })
export class ReservationService {
  private apiUrl = environment.apiUrl;
  constructor(private http: HttpClient, private auth: AuthService) {}

  private authHeaders(): HttpHeaders {
    return new HttpHeaders({ Authorization: `Bearer ${this.auth.getToken()}` });
  }

  createReservation(data: any): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/reservations`, data);
  }

  getReservations(): Observable<any[]> {
    return this.http.get<any[]>(`${this.apiUrl}/reservations`, { headers: this.authHeaders() });
  }

  updateReservationStatus(id: number, status: string): Observable<any> {
    return this.http.put<any>(`${this.apiUrl}/reservations/${id}/status`, { status }, { headers: this.authHeaders() });
  }
}
