using OutOfOffice.DAL.Entity.Selections;

namespace OutOfOffice.DAL.Entity.Employees;

public class GeneralEmployee : BaseEmployeeEntity
{
    public int? SubdivisionId { get; set; }
    public Subdivision Subdivision { get; set; }= null!;
    
    public int? PositionId { get; set; }
    public Position Position { get; set; }= null!;
    
    public bool Status { get; set; }
    public decimal OutOfOfficeBalance { get; set; }

    public int? HrMangerId { get; set; }
    public HrManager HrManager { get; set; } = null!;
    
    public ICollection<LeaveRequest> LeaveRequests { get; set; } = null!;
    public ICollection<Project> Projects { get; set; } = null!;
    
}
