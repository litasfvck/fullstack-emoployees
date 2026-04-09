import { Component } from '@angular/core';
import { EmployeeTableComponent } from './components/employee-table/employee-table.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [EmployeeTableComponent],
  template: `<employee-table />`
})
export class App {}
