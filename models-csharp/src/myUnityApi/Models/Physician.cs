namespace Models {

  public class Physician {
    public string Id;
    public string Sequence;
    public PersonName Name;
    public string Title;
    public string Salutation;
    public List<Email> EmailAddresses;
    public List<Address> Addresses;
    public List<Phone> Phones;
    public List<Organization> Organizations;
    public List<PhysicianLicense> Licenses;
    public List<PhysicianSpecialtiesInner> Specialties;
  }
}