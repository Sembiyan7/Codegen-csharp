namespace Models {

  public class UserPhysician {
    public string Id;
    public string NPI;
    public string EnterpriseID;
    public string FirstName;
    public string MiddleName;
    public string LastName;
    public List<Organization> Organizations;
  }
}