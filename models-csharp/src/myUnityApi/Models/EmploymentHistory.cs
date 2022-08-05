namespace Models {

  public class EmploymentHistory {
    public string Id;
    public DateTime StartDate;
    public DateTime EndDate;
    public bool KeepBaseCalendarActiveOnEnd;
    public ReferenceCode PersonnelType;
    public bool IsExempt;
    public PayrollCycle PayrollCycle;
    public Organization HomeOrganization;
  }
}