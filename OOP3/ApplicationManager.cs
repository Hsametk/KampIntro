using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        //method injection
        public void MakeApplication(ILoanManager loanManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme.
            loanManager.Calculate();
            loggerService.Log();

        }

        public void MakeALoanPreİnformation(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate(); 
            }
        }

    }
}
