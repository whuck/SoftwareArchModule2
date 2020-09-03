using System;

namespace Module2
{
    class EmployeeReportService
    {
        private String report = "";

        public void addData(String data) {
            report += data;
        }

        public void outputReport() {
            //JOptionPane.showMessageDialog(null, report);
            Console.WriteLine(report);
        }

        public void clearReport() {
            report = "";
        }
    }
}
