using System.ComponentModel;

namespace SampleAvoidIfs.DocumentType
{
    public enum DocumentsType
    {
        [Description("Nenhum")]
        None,
        [Description("Parceiro de Negócio")]
        BusinessPartner,
        [Description("Pedido")]
        Order,
        [Description("Contas a Receber")]
        IncomingPayment,
        [Description("Nota Fiscal")]
        Invoice,
        [Description("Picking")]
        Picking,
        [Description("Adiantamento")]
        DownPayment,
        [Description("XML")]
        XML,
        [Description("NFe Saída de Transferência")]
        InvoiceTransfer,
        [Description("Recebimento de Mercadoria Transferência")]
        PurchaseDeliveryNotesTransfer,
        [Description("NFe Entrada de Transferência")]
        PurchaseInvoiceTransfer,
        [Description("Transferência de Estoque")]
        StockTransfer,
        [Description("Fulfillment - Dev. NFe Saída")]
        CreditNotes,
        [Description("Contas a Pagar")]
        VendorPayment
    }
}
