namespace act
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = tbFname.Text.ToString();
            StudentInfoClass.MiddleName = tbMname.Text.ToString();
            StudentInfoClass.LastName = tbLname.Text.ToString();
            StudentInfoClass.Address = tbAdd.Text.ToString();
            StudentInfoClass.Program = cbProgram.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt64(tbAge.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(tbConNum.Text);
            StudentInfoClass.StudentNo = Convert.ToInt64(tbStuNum.Text);

            FrmConfirm form2 = new FrmConfirm();
            form2.ShowDialog();
        }
    }

}