namespace Models {

  public class User {
    public string Id;
    public string UserId;
    public string FirstName;
    public string MiddleName;
    public string LastName;
    public string PinNumber;
    public Address PrimaryAddress;
    public List<Address> Addresses;
    public List<Organization> Organizations;
    public List<CareSetting> CareSettings;
    public List<Email> EmailAddresses;
    public List<Phone> Phones;
    public List<SecurityRole> SecurityRoles;
    public DateTime BeginDate;
    public DateTime EndDate;
    public Personnel Personnel;
    public UserPhysician Physician;
  }
}