using System;
using System.Collections;

namespace Module2
{
    class HrPerson
    {
        private ArrayList employees;

        public HrPerson() {
            employees = new ArrayList();
        }

        public void hireEmployee(String firstName, String lastName, String ssn) {
            Employee e = new Employee(firstName, lastName, ssn);
            employees.Add(e);
            orientEmployee(e);
        }

        // HRManager delegates work to employee
        private void orientEmployee(Employee emp) {
            emp.doFirstTimeOrientation("B101");
        }

        public void outputReport(String ssn) {
        // find employee in list
            foreach (Employee emp in employees) {
                if (emp.getSsn() == ssn) {
                    // if found run report
                    if (emp.hasMetWithHr() && emp.hasMetDeptStaff()
                    && emp.hasReviewedDeptPolicies() && emp.hasMovedIn()) 
                    {
                        emp.printReport();
                    }
                    break;
                }
            }
        }
    }
}
