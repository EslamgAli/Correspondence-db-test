using Domain.Base;

namespace Domain.Models;

public class User : EntityBase
{
    public string UserName { get; set; } = null!;
    public string FirstNameAr { get; set; } = null!;
    public string FirstNameEn { get; set; } = null!;
    public string LastNameAr { get; set; } = null!;
    public string LastNameEn { get; set; } = null!;
    public string NicknameAr { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Fax { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string JobTitleAr { get; set; } = null!;
    public string JobTitleEn { get; set; } = null!;
    public string EmployeeNumber { get; set; } = null!;
    public string? SignatureUrl { get; set; }
    public int SecurityGroupId { get; set; }
    public bool IsActiveDirectoryUser { get; set; }
    public bool IsActive { get; set; }
    public string? Password { get; set; }

    public string? Salt { get; set; }

    public virtual SecurityGroup SecurityGroup { get; set; } = null!;
    public virtual ICollection<UserOrgUnit> UserOrgUnits { get; set; } = new List<UserOrgUnit>();
}
