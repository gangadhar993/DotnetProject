using System;

/// <summary>
/// Summary description for Slot
/// </summary>
public class DegreeCredit
{

    public int DegreeCreditID { get; set; }
    public int DegreeID { get; set; }
    [ForeignKey("DegreeID")]
    public Degree Degree { get; set; }
    public int CreditID { get; set; }
    [ForeignKey("CreditID")]
    public Credit Credit { get; set; }
}