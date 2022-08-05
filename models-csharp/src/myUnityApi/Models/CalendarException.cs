namespace Models {

  public class CalendarException {
    public string Sequence;
    public bool RemoveResourceFromRequest;
    public ReferenceCode ExceptionCode;
    public ReferenceCode Reason;
    public string StatusCode;
    public DateTime StartDate;
    public DateTime EndDate;
  }
}