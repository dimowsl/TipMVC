using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipMVCConsole.Model;
using TipMVCConsole.View;

namespace TipMVCConsole.Controllers
{
    internal class TipController
    {

        Tip myTip = new Tip();

        Display myDisplay = new Display();

        public TipController()
        {
            myDisplay.Input();
            //prehvurlqm ot display v tip
            myTip.Amount = myDisplay.Amount;

            myTip.Percent = myDisplay.Percent;
            //calculate ----
            myDisplay.Tip = myTip.CalculateTip();

            myDisplay.Total = myTip.CalculateTotal();

            myDisplay.Output();
        }

    }
}
