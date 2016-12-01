using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{

    public enum DOCUMENT_TYPE
    {
        [Description("Договор")]
        Contract = 1,

        [Description("Счёт фактура")]
        Invoice = 2,

        [Description("Оферта")]
        Offer = 3,

        [Description("Отчёт по транзакциям")]
        TransactionReport = 4,

        [Description("Акт - Счёт фактура")]
        ActInvoice = 5
    }

    public enum DOCUMENT_STATUS
    {
        Added = 1,
        Approved = 2,
        Sent = 3,
        Rejected = 4,
        ApprovedByContractor = 5,
        SentByContractor = 6,
        Published = 7,
        SignSent = 8,
        Deleted = 9,

        AgreementInProgress = 10,
        AgreementApproved = 11,
        AgreementRejected = 12,

        SigningInProgerss = 13,
        SigningApproved = 14,
        SigningRejected = 15
    }
}
