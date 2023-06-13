// See https://aka.ms/new-console-template for more information

using OOP3;
using System.Collections.Generic;

RequirmentLoanManager requirmentLoanManager = new RequirmentLoanManager();
VehicleLoanManager vehicleLoanManager = new VehicleLoanManager();
ILoanManager houseLoanManager = new HouseLoanManager();

ApplicationManager applicationManager = new ApplicationManager();
ILoggerService fileLoggerService = new FileLoggerService();
applicationManager.MakeApplication(houseLoanManager,new DatabaseLoggerService());

List<ILoanManager> loans = new List<ILoanManager>() { requirmentLoanManager ,vehicleLoanManager };
//applicationManager.MakeALoanPreİnformation(loans);


