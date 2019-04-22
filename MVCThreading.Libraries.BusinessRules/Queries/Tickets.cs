using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCThreading.Libraries.BusinessRules.Queries
{
    public class Tickets
    {
        DataAccessManager.DataModels.BasicModel.PLEToteEntities db = DataAccess.DataModelManager.PleBasicModel;

        public List<string> getAllTickets()
        {
            var result = db.vTickets.Select(t => t.TicketNumber.ToString()).ToList();

            return result;
        }

        public List<string> getAllBettorsbyTickets(List<string> tickets)
        {
            var result = (from b in db.Bettors
                         join bt in db.BettorTickets on b.BettorId equals bt.BettorId
                         //where tickets.Contains(bt.TicketNumber.ToString()) && b.IsForeigner == true
                         select b.BettorName).ToList();

            return result;
        }

        public List<string> getDetails()
        {
            return (from t in db.vReportTickets
                    join w in db.TicketWager on t.TicketNumber equals w.TicketNumber
                    select w.WagerDetail).ToList();
        }
    }
}
