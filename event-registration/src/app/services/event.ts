import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class EventService {
  private apiUrl = 'http://localhost:5125/api/Events';

  constructor(private http: HttpClient) {}

  // Get events
  getEvents(): Observable<any> {
    return this.http.get(this.apiUrl);
  }

  // Create event
  createEvent(eventData: any): Observable<any> {
    return this.http.post(this.apiUrl, eventData);
  }

  // Register participant
  registerParticipant(eventId: number, participant: any): Observable<any> {
    return this.http.post(`${this.apiUrl}/${eventId}/register`, participant);
  }
}
