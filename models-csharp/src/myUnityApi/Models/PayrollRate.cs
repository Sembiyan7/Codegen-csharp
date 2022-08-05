namespace Models {

  public class PayrollRate {
    public string Id;
    public string Rate;
    public int RateType;
    public int RateUnitOfMeasure;
    public Organization Organization;
    public DateTime StartDate;
    public DateTime? EndDate;
  }
}