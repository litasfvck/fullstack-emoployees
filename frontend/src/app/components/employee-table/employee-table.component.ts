import { Component, inject, signal } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeService } from '../../services/employee.service';
import { Employee } from '../../models/employee.model';

@Component({
  selector: 'employee-table',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './employee-table.component.html',
  styleUrl: './employee-table.component.scss'
})
export class EmployeeTableComponent {
    private employeeService = inject(EmployeeService);

    employees = signal<Employee[]>([]);
    loading = signal(false);

    constructor() {
        this.loadEmployees();
    }

    loadEmployees() {
        this.loading.set(true);

        this.employeeService.getEmployees().subscribe({
            next: (data) => {
            this.employees.set(data);
            this.loading.set(false);
            },
            error: () => {
            this.loading.set(false);
            }
        });
    }
}
