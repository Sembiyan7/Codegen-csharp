namespace Models {

  public class License {
    public string Sequence;
    public bool IsDeleted;
    public ReferenceCode LicenseType;
    public ReferenceCode Licensor;
    public string LicenseNumber;
    public DateTime StartDate;
    public DateTime? EndDate;
  }
}