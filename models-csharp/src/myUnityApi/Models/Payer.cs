namespace Models {

  public class Payer {
    public string Id;
    public string Sequence;
    public string DisplayName;
    public List<Email> EmailAddresses;
    public List<Address> Addresses;
    public List<Phone> Phones;
    public List<Organization> Organizations;
  }
}