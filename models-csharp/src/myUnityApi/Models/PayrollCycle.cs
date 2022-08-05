namespace Models {

  public class PayrollCycle {
    public string Id;
    public string Description;
    public Organization Organization;
    public DateTime StartDate;
    public DateTime? EndDate;
  }
}