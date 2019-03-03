﻿using System;

/// <summary>
/// Summary description for Slot
/// </summary>
public class Slot
{
    public int SlotID { get; set; }
    public int DegreePlanID { get; set; }
    [ForeignKey("DegreePlanID")]
    public DereePlan DegreePlan { get; set; }
    public int Term { get; set; }
    public int CreditID { get; set; }
    [ForeignKey("CreditID")]
    public Credit Credit { get; set; }
    public char Status { get; set; }
}
