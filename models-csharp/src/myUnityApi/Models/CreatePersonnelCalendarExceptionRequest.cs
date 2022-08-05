namespace Models {

  public class CreatePersonnelCalendarExceptionRequest {
    public bool RemoveResourceFromRequest;
    public ReferenceCode ExceptionCode;
    public ReferenceCode Reason;
    public string StatusCode;
    public DateTime StartDate;
    public DateTime EndDate;
  }
}