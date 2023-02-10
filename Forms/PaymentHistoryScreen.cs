using Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Excel = Microsoft.Office.Interop.Excel;
using Business.DependencyResolvers.Ninject;

namespace Forms
{
    public partial class PaymentHistoryScreen : DevExpress.XtraEditors.XtraForm
    {
        public PaymentHistoryScreen()
        {
            InitializeComponent();
            _paymentService = InstanceFactory.GetInstance<IPaymentService>();
        }
        IPaymentService _paymentService;
        public int user_id;

        private void LoadPayments()
        {
            dqwPayments.DataSource = _paymentService.GetAll();
        }

        private string GetByPaymentMethod(string method)
        {
            var list = _paymentService.GetByPaymentMethod(method);
            decimal price = 0;
            foreach (var temp in list)
            {
                price += Convert.ToDecimal(temp.Price);
            }

            return price.ToString();
        }

        private string GetSumPrice()
        {
            var list = _paymentService.GetAll();
            decimal price = 0;
            foreach (var temp in list)
            {
                price += Convert.ToDecimal(temp.Price);
            }

            return price.ToString();
        }

        private void PaymentHistoryScreen_Load(object sender, EventArgs e)
        {
            LoadPayments();
            LoadPayments();
            tbxToplam.Text = GetSumPrice();
            tbxKart.Text = GetByPaymentMethod("Kredi Kartı");
            tbxNakit.Text = GetByPaymentMethod("Nakit");
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            LoadPayments();
            LoadPayments();
            tbxToplam.Text = GetSumPrice();
            tbxKart.Text = GetByPaymentMethod("Kredi Kartı");
            tbxNakit.Text = GetByPaymentMethod("Nakit");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            export_dgw_excel_1(dqwPayments);
        }

        bool export_dgw_excel_1(DataGridView dgw)
        {
            bool durum = false;
            try
            {
                dgw.SelectAll();
                DataObject dataObj = dgw.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
                Excel.Application xlexcel;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                durum = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("DataGrid Verileri Aktarılamadı : " + exception.Message);
            }
            return durum;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Ödeme geçmişi silinecek, Emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                var list = _paymentService.GetAll();
                foreach (var temp in list)
                {
                    _paymentService.Delete(temp);
                }
                LoadPayments();
                tbxToplam.Text = GetSumPrice();
                tbxKart.Text = GetByPaymentMethod("Kredi Kartı");
                tbxNakit.Text = GetByPaymentMethod("Nakit");
            }
        }
    }
}
