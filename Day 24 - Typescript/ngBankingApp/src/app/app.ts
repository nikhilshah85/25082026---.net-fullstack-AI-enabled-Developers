import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('ngBankingApp');

  firstName: string = 'John';
  lastName: string = 'Doe';

  greetUser():  string {
    return `Hello, ${this.firstName} ${this.lastName}!`;
  }
}