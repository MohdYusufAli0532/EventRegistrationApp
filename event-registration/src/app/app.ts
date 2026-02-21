import { Component, signal } from '@angular/core';
import { EventService } from './services/event';
import { EventListComponent } from './components/event-list/event-list';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  imports: [
    EventListComponent,
    FormsModule,
  ],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected readonly title = signal('event-registration');
}
