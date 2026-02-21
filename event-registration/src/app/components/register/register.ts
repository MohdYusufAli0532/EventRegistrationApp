import { Component, Input } from '@angular/core';
import { EventService } from '../../services/event';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-register',
  templateUrl: './register.html',
  styleUrls: ['./register.css'],
  imports: [FormsModule]
})
export class Register {
   @Input() eventId!: number

  name: string = '';
  email: string = '';
  message: string = '';

  constructor(private eventService: EventService) {}

  register() {
    const participant = {
      name: this.name,
      email: this.email,
    };

    this.eventService.registerParticipant(this.eventId, participant).subscribe({
      next: (res) => {
        this.message = 'Registration successful!';
        this.name = '';
        this.email = '';
      },
      error: (err) => {
        this.message = err.error || 'Registration failed';
      },
    });
  }
}
