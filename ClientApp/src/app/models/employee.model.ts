import { Role } from "./role.model";

export interface Employee {
  id: number;
  name: string;
  contractTypeName: string;
  annualSalary: number;
  hourlySalary: number;
  monthlySalary: number;
  role: Role;
}
