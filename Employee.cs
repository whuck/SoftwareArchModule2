using System;

namespace Module2
{
    class Employee
    {
    
        // Use constants for numbers or Strings that a repeated
        // (all are called 'magic numbers', which are evil)
        private static String REQUIRED_MSG = " is mandatory ";
        private static String NEWLINE = "\n";

        private String firstName;
        private String lastName;
        private String ssn;
        private Boolean metWithHr;
        private Boolean metDeptStaff;
        private Boolean reviewedDeptPolicies;
        private Boolean movedIn;
        private String cubeId;
        private DateTime orientationDate;
        private EmployeeReportService reportService;

        private HrPerson hr;

        public Employee(String firstName, String lastName, String ssn) 
        {
            setFirstName(firstName);
            setLastName(lastName);
            setSsn(ssn);
            reportService = new EmployeeReportService();
        }
        private String getFormattedDate() 
        {
           //DateTimeFormatter formatter = DateTimeFormatter.ofPattern("M/d/yy");
           return orientationDate.ToString();
            //return formatter.format(orientationDate);
        }   
        public void doFirstTimeOrientation(String cubeId) 
        {
            orientationDate = DateTime.Now;
            meetWithHrForBenefitAndSalaryInfo();
            meetDepartmentStaff();
            reviewDeptPolicies();
            moveIntoCubicle(cubeId);
        }
    private void meetWithHrForBenefitAndSalaryInfo() {
        metWithHr = true;
        reportService.addData(firstName + " " + lastName + " met with HR on "
                + getFormattedDate() + NEWLINE);
    }

    // Assume this must be performed first, and assume that an employee
    // would only do this once, upon being hired. If that were true, this
    // method should not be public. It should only be available to this class
    // and should only be called as part of the larger task of:
    // doFirstTimeOrientation()
    private void meetDepartmentStaff() {
        metDeptStaff = true;
        reportService.addData(firstName + " " + lastName + " met with dept staff on "
                + getFormattedDate() + NEWLINE);
    }

    // Assume this must be performed third. And assume that because department
    // policies may change that this method may need to be called
    // independently from other classes.
    public void reviewDeptPolicies() {
        reviewedDeptPolicies = true;
        reportService.addData(firstName + " " + lastName + " reviewed dept policies on "
                + getFormattedDate() + NEWLINE);
    }

    // Assume this must be performed 4th. And assume that because employees
    // sometimes change office locations that this method may need to be called
    // independently from other classes.
    public void moveIntoCubicle(String cubeId) {
        setCubeId(cubeId);

        this.movedIn = true;
        reportService.addData(firstName + " " + lastName + " moved into cubicle "
                + cubeId + " on " + getFormattedDate() + NEWLINE);
    }

    public String getFirstName() {
        return firstName;
    }

    // setter methods give the developer the power to control what data is
    // allowed through validation. Throwing ane exception is the best
    // practice when validation fails. Don't do a System.out.println()
    // to display an error message -- not the job of this class!
    public void setFirstName(String firstName) {
        /*
        if (firstName == null || firstName.isEmpty()) {
            throw new IllegalArgumentException("first name" + REQUIRED_MSG);
        }
        */
        
        try {
            this.firstName = firstName;
        }
        catch (Exception e ){
            Console.WriteLine(e.ToString());
            Console.WriteLine("first name");
        }        
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        /*
        if (lastName == null || lastName.isEmpty()) {
            throw new IllegalArgumentException("last name" + REQUIRED_MSG);
        }
        */
        try {
            this.lastName = lastName;
        }
        catch (Exception e ){
            Console.WriteLine(e.ToString());
            Console.WriteLine("last name");
        }
    }

    public String getSsn() {
        return ssn;
    }

    public void setSsn(String ssn) {
        /*
        if (ssn == null || ssn.length() < 9 || ssn.length() > 11) {
            throw new IllegalArgumentException("ssn" + REQUIRED_MSG + "and must be between 9 and 11 characters (if hyphens are used)");
        }
        */
        try {
            this.ssn = ssn;
        }
        catch (Exception e) 
        {
            Console.WriteLine(e.ToString());
            Console.WriteLine("ssn and must be between 9 and 11 characters (if hyphens are used)");
        }
    }

    public Boolean hasMetWithHr() {
        return metWithHr;
    }

    // Boolean parameters need no validation
    public void setMetWithHr(Boolean metWithHr) {
        this.metWithHr = metWithHr;
    }

    public Boolean hasMetDeptStaff() {
        return metDeptStaff;
    }

    public void setMetDeptStaff(Boolean metDeptStaff) {
        this.metDeptStaff = metDeptStaff;
    }

    public Boolean hasReviewedDeptPolicies() {
        return reviewedDeptPolicies;
    }

    public void setReviewedDeptPolicies(Boolean reviewedDeptPolicies) {
        this.reviewedDeptPolicies = reviewedDeptPolicies;
    }

    public Boolean hasMovedIn() {
        return movedIn;
    }

    public void setMovedIn(Boolean movedIn) {
        this.movedIn = movedIn;
    }

    public String getCubeId() {
        return cubeId;
    }

    public void setCubeId(String cubeId) {
        /*
        if (cubeId == null || cubeId.isEmpty()) {
            throw new IllegalArgumentException("cube id" + REQUIRED_MSG);
        }
        */
        
        try 
        {
            this.cubeId = cubeId;
        }
        catch ( Exception e)
        {
            Console.WriteLine(e.ToString());
            Console.WriteLine("cube id");
        }
    }

    public DateTime getOrientationDate() {
        return orientationDate;
    }

    public void setOrientationDate(DateTime orientationDate) {
        /*
        if (orientationDate == null) {
            throw new IllegalArgumentException("orientationDate" + REQUIRED_MSG);
        }
        */
        
        try 
        {
            this.orientationDate = orientationDate;
        }
        catch ( Exception e)
        {
            Console.WriteLine(e.ToString());
            Console.WriteLine("orientationDate");
        }
    }

    public void printReport() {
        reportService.outputReport();
    }

    
    public String toString() {
        return "Employee{" + "firstName=" + firstName + ", lastName=" + lastName + ", ssn=" + ssn + '}';
    }
}
}