import { Component, OnInit } from '@angular/core';
import { EventService } from '../../services/event';
import { CommonModule, DatePipe } from '@angular/common';
import { Register } from '../register/register';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-event-list',
  templateUrl: './event-list.html',
  imports: [CommonModule, DatePipe, Register],
  styleUrls: ['./event-list.css'],
})
export class EventListComponent implements OnInit {
  events$!: Observable<any>;

  constructor(private eventService: EventService) {}

  ngOnInit(): void {
    this.events$ = this.eventService.getEvents();
  }
}
