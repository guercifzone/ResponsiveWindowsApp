//////////////////////////////////////////////
//////////////////////////////////////////////
// Coded by Mehedi Shams Rony ////////////////
///////// October 2016 ///////////////////////
//////////////////////////////////////////////
//////////////////////////////////////////////
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResponsiveWindowsApp.Classes;

namespace ResponsiveWindowsApp
{
    public partial class ResponsiveForm : Form
    {
        Responsive ResponsiveObj;

        public ResponsiveForm()
        {
            InitializeComponent();

            ResponsiveObj = new Responsive(Screen.PrimaryScreen.Bounds);
            ResponsiveObj.SetMultiplicationFactor();

            SetupGrid();
        }

        private void ResponsiveForm_Load(object sender, EventArgs e)
        {
            Width = ResponsiveObj.GetMetrics(Width, "Width");    // Form width and height set up.
            Height = ResponsiveObj.GetMetrics(Height, "Height");
            Left = Screen.GetBounds(this).Width / 2 - Width / 2;  // Form centering.
            Top = Screen.GetBounds(this).Height / 2 - Height / 2 - 30;  // 30 is a calibration factor.

            foreach (Control Ctl in this.Controls)
            {
                Ctl.Font = new Font(FontFamily.GenericSansSerif, ResponsiveObj.GetMetrics((int)Ctl.Font.Size), FontStyle.Regular);
                Ctl.Width = ResponsiveObj.GetMetrics(Ctl.Width, "Width");
                Ctl.Height = ResponsiveObj.GetMetrics(Ctl.Height, "Height");
                Ctl.Top = ResponsiveObj.GetMetrics(Ctl.Top, "Top");
                Ctl.Left = ResponsiveObj.GetMetrics(Ctl.Left, "Left");
            }
        }

        private void SetupGrid()
        {
            try
            {
                // http://stackoverflow.com/questions/64041/winforms-datagridview-font-size
                ResponsiveDataGridView.DefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, ResponsiveObj.GetMetrics(15), FontStyle.Regular);
                ResponsiveDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                ResponsiveDataGridView.RowTemplate.Height = ResponsiveObj.GetMetrics(30);
                ResponsiveDataGridView.Columns.Add("", "Word");
                ResponsiveDataGridView.Columns[0].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, ResponsiveObj.GetMetrics(15), FontStyle.Regular);

                // https://msdn.microsoft.com/en-us/library/system.windows.forms.datagridview.font%28v=vs.110%29.aspx?f=255&MSPPError=-2147217396
                // http://stackoverflow.com/questions/5206203/can-i-set-the-max-number-of-rows-in-unbound-datagridview
                ResponsiveDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
                ResponsiveDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;

                // http://stackoverflow.com/questions/2154154/datagridview-how-to-set-column-width
                ResponsiveDataGridView.Columns[0].FillWeight = ResponsiveObj.GetMetrics(200);
                DataGridViewColumn column = ResponsiveDataGridView.Columns[0];
                column.Width = ResponsiveObj.GetMetrics(200);
                column.MinimumWidth = ResponsiveObj.GetMetrics(200);
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.BackColor = Color.Red;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred in 'SetupGrid' method of 'LoadWords' form. Error msg: " + Ex.Message);
            }
        }
    }
}
