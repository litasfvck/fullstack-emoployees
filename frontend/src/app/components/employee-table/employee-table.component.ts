import { CurrencyPipe, DatePipe } from "@angular/common";
import { EmployeeService } from "../../services/employee.service";
import { Component, computed, DestroyRef, inject, signal } from "@angular/core";
import { Employee } from "../../models/employee.model";
import { takeUntilDestroyed } from "@angular/core/rxjs-interop";

@Component({
  selector: 'employee-table',
  standalone: true,
  imports: [DatePipe, CurrencyPipe],
  templateUrl: './employee-table.component.html',
  styleUrl: './employee-table.component.scss'
})
export class EmployeeTableComponent {
  private readonly employeeService = inject(EmployeeService);
  private readonly destroyRef = inject(DestroyRef);

  readonly employees = signal<Employee[]>([]);
  readonly loading = signal(false);
  readonly error = signal<string | null>(null);

  readonly hasData = computed(() => this.employees().length > 0);

  constructor() { this.loadEmployees(); }

  loadEmployees() {
    this.loading.set(true);
    this.error.set(null);

    this.employeeService
        .getEmployees()
        .pipe(takeUntilDestroyed(this.destroyRef))
        .subscribe({
            next: (data) => { 
                this.employees.set(data); 
                this.loading.set(false); 
            },
            error: () => { 
                this.error.set('Не удалось загрузить данные'); 
                this.loading.set(false); 
            }
        });
  }

  deptClass(dept: string): string {
    const map: Record<string, string> = {
      IT: 'it',
      Продажи: 'sales',
      Маркетинг: 'mkt',
      Финансы: 'fin',
      Кадры: 'hr',
      Администрация: 'admin',
    };
    return map[dept] ?? '';
  }
}