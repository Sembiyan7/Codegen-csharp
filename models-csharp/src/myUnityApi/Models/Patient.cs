namespace Models {

  public class Patient {
    public Guid Id;
    public string EnterpriseID;
    public string MedicalRecordNumber;
    public string FirstName;
    public string LastName;
    public string MiddleName;
    public string PreferredName;
    public string MaidenName;
    public string Salutation;
    public string Title;
    public string Ssn;
    public DateTime DateOfBirth;
    public Gender Gender;
    public SexualOrientation SexualOrientation;
    public PrimaryLanguage PrimaryLanguage;
    public List<PatientRacesInner> Races;
    public Ethnicity Ethnicity;
    public string MaritalStatus;
    public PatientReligion Religion;
    public CareSetting CareSetting;
    public string CurrentLevelOfCare;
    public string PatientCaseManager;
    public string PrimaryCareTeam;
    public string OrgIDPathForAdmission;
    public DateTime ReferralDate;
    public string ReferralType;
    public string ReferredByBusinessID;
    public string ReferredByPersonnelID;
    public string AdmittedFromType;
    public string AdmittedFromBusinessID;
    public DateTime VerbalSOCDate;
    public string IsDNR;
    public string EvacuationType;
    public string DischargeReason;
    public DateTime DeathDateTime;
    public List<Address> Addresses;
    public List<Phone> Phones;
    public List<Email> EmailAddresses;
    public List<Organization> Organizations;
    public List<PatientChart> Admissions;
    public string MilitaryService;
    public List<LocationOfCare> LocationsOfService;
  }
}