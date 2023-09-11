using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act
{
    public partial class FrmConfirm : Form
    {
        public FrmConfirm()
        {
            InitializeComponent();
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

        }

        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelContactNo, DelStudNo;

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblFname.Text = DelFirstName(StudentInfoClass.FirstName);
            lblMname.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblLname.Text = DelLastName(StudentInfoClass.LastName);
            lblAddress.Text = DelAddress(StudentInfoClass.Address);
            lblAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblProgram.Text = DelProgram(StudentInfoClass.Program);
            lblStuNum.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            lblConNum.Text = DelContactNo(StudentInfoClass.ContactNo).ToString();

        }
    }
}
