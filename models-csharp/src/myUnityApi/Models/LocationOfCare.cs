namespace Models {

  public class LocationOfCare {
    public ReferenceCode LocationType;
    public DateTime BeginDate;
    public DateTime? EndDate;
    public string NPI;
    public List<Address> Addresses;
  }
}