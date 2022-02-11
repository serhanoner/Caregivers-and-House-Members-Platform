using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EvdekiBakicim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EvdekiBakicim;Integrated Security=True");

     //   SqlConnection con;
       // SqlDataAdapter da;
        // SqlCommand cmd;
       // DataSet ds;


        void returnUserList()
        {
           //SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EvdekiBakicim;Integrated Security=True");
           //con.Open();
           //
           //da = new SqlDataAdapter("SELECT * From User", con);
           //
           //DataTable table = new DataTable();
           //da.Fill(table);
           //dataGridView1.DataSource = table;
           //con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //   returnUserList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From [User]";
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;

        }

        private void btn_showCaregivers_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From [Caregiver]";
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;
        }

        private void btn_showMembers_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From [Member]";
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;

        }

        private void btn_showAddresses_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From [Address]";
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;
        }

        private void btn_showJobs_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From [Job]";
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;
        }

        private void btn_showJobApplications_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From [Job_Application]";
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;
        }

        private void btn_showAppointments_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From [Appointment]";
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;
        }

        private void btn_updatePhoneOfPinarYilmaz_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Update [User] Set phone_number = '535-553-4199'  Where (given_name = 'Pinar' and surname = 'Yilmaz')";
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;
        }

        private void btn_addCommissions_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Update [Caregiver] SET hourly_rate = hourly_rate * 1.1 WHERE hourly_rate >= 9";
            cmd.CommandText = "SET SQL_SAFE_UPDATES = 0";
            cmd.CommandText = "Update [Caregiver] SET hourly_rate = hourly_rate + 0.5 WHERE hourly_rate< 9" ;
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;
        }

        private void btn_deleteJobsPostedByPinarYilmaz_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE t1 " +
                "FROM [Job] t1 " +
                "INNER JOIN [Member] t2 ON t1.member_user_id = t2.member_user_id " +
                "INNER JOIN [User] t3 ON t2.member_user_id = t3.user_id " +
                "WHERE t3.given_name = @given_name and t3.surname = @surname ";


            cmd.Parameters.Add(new SqlParameter("@given_name", txt_firstNameForDeletion.Text));
            cmd.Parameters.Add(new SqlParameter("@surname", txt_surnameForDeletion.Text));

            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;
        }

        private void btn_deleteMembersKadirgalarStreet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE t1 " +
                "FROM [User] t1 " +
                "INNER JOIN [Member] t2 ON t1.user_id = t2.member_user_id " +
                "INNER JOIN [Address] t3 ON t2.member_user_id = t3.member_user_id " +
                "WHERE t3.street = @street ";
            cmd.Parameters.Add(new SqlParameter("@street", txt_nameOfTheStreetToDelete.Text));

            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;
        }

        private void btn_showCaregiversAndMembersWithAcceptedAppointments_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT given_name, surname FROM [User] t1 " +
                "FULL OUTER JOIN [Appointment] t2 ON t1.user_id = t2.member_user_id OR t1.user_id = t2.caregiver_user_id "
                + "WHERE t2.status = 'ACCEPTED' ";
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;

        }

        private void btn_gentleCaregivers_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT caregiver_user_id, t3.given_name, t3.surname" +
                " FROM [Job_Application] t1 " +
                "INNER JOIN [User] t3 ON t1.caregiver_user_id = t3.user_id " +
                "FULL OUTER JOIN [Job] t2 ON t1.job_id = t2.job_id "
                + " WHERE t2.other_requirements LIKE '%Gentle%' ";
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;

        }

        private void btn_workHoursOfBabySitters_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT DISTINCT t1.caregiver_user_id, t2.given_name, t2.surname, " +
                " t1.work_hours as TotalWorkHours "
                + " FROM[Appointment] t1, [User] t2, [Caregiver] t3 "
                + " WHERE t1.caregiver_user_id = t2.user_id AND t1.status = 'ACCEPTED' AND t3.caregiving_type = 'Baby Sitter' "
                + " GROUP BY t1.caregiver_user_id, t2.given_name, t2.surname, t1.work_hours "
                + " order by t1.caregiver_user_id ASC ";
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;


        }

        private void btn_membersLookingForElderlyCareWithoutPets_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT given_name, surname FROM [User] t1 " +
                "FULL OUTER JOIN [Job] t2 ON t1.user_id = t2.member_user_id " +
                "FULL OUTER JOIN [Member] t3 ON t1.user_id = t3.member_user_id " +
                "WHERE t2.required_caregiving_type = 'Elderly Care' AND t3.house_rules = 'No pets.' ";
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;

        }

        private void btn_numberOfApplicants_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT DISTINCT t1.job_id, t2.given_name, t2.surname, t1.required_caregiving_type, COUNT(t3.caregiver_user_id) as NumberOfApplicants "
                + "FROM[Job] t1, [User] t2, [Job_Application] t3 "
                + "WHERE t2.user_id = t1.member_user_id and t1.job_id = t3.job_id "
                + "GROUP BY t1.job_id, t3.job_id, t2.given_name, t2.surname, t1.required_caregiving_type "
                + "order by t1.job_id ASC ";
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;
        }

        private void btn_totalHoursSpent_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT DISTINCT t1.caregiver_user_id, t2.given_name, t2.surname, SUM(t1.work_hours) as TotalWorkHours "
                + "FROM[Appointment] t1, [User] t2 "
                + "WHERE t1.caregiver_user_id = t2.user_id AND t1.status = 'ACCEPTED' "
                + "GROUP BY t1.caregiver_user_id, t2.given_name, t2.surname "
                + "order by t1.caregiver_user_id ASC ";
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;
        }

        private void btn_averagePayOfCaregivers_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT AVG(t1.hourly_rate) as HourlyRate, t2.work_hours as WorkHours, AVG((t1.hourly_rate) * t2.work_hours) as AverageOfEarnings "
                + " FROM[Caregiver] t1 "
                + " INNER JOIN[Appointment] t2 ON t1.caregiver_user_id = t2.caregiver_user_id "
                + " WHERE t2.status = 'ACCEPTED' "
                + " GROUP BY t2.work_hours " ;

            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;
        }

        private void btn_caregiversEarningAboveAverage_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "WITH totalSalary(caregiver_user_id, firstname, surname, total) as "
                + "(SELECT DISTINCT t1.caregiver_user_id, t2.given_name, t2.surname, sum(t1.hourly_rate) "
                + "FROM[Caregiver] t1, [User] t2 "
                + "GROUP BY t1.caregiver_user_id, t2.given_name, t2.surname), "
                
                + "\n"

                + "caregiverAverage(caregiver_user_id, firstname, surname, total_work_hours, avgSalary) as "
                + "(SELECT DISTINCT t1.caregiver_user_id, t2.given_name, t2.surname, "
                + "t1.work_hours, avg(t3.hourly_rate) "
                + "FROM[Appointment] t1, [User] t2, [Caregiver] t3 "
                + "WHERE t1.caregiver_user_id = t2.user_id AND t1.status = 'ACCEPTED' "
                + "GROUP BY t1.caregiver_user_id, t2.given_name, t2.surname, t1.work_hours) "

                + "\n"

                + "SELECT t5.caregiver_user_id, t5.firstname, t5.surname, t5.total* t6.total_work_hours as TotalEarnings "
                + "FROM totalSalary t5 "

                + "INNER JOIN caregiverAverage t6 on t5.caregiver_user_id = t6.caregiver_user_id "
                + "WHERE t5.total > t6.avgSalary AND t5.firstname = t6.firstname "    ;

            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;

        }

        private void btn_searchJobsPostedByAKeyword_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT J.job_id, J.required_caregiving_type,  " +
                " CAST(J.other_requirements AS NVARCHAR(200)) OtherRequirements, J.date_posted,  " +
                " Ja.date_applied as DateApplied, " +

                " U.given_name as AppliedBy, U.surname AppliedSurname, " +
                " C.hourly_rate as CaregiverHourlyRate, C.caregiving_type as CaregiverType " +

                " FROM [Job] J " +

                " INNER JOIN [Member] M ON M.member_user_id = J.member_user_id " +
                " INNER JOIN [Caregiver] C ON C.caregiving_type = J.required_caregiving_type " +
                " INNER JOIN [User] U ON C.caregiver_user_id = U.user_id " +
                " INNER JOIN [Job_Application] Ja ON Ja.caregiver_user_id = C.caregiver_user_id " +

                " WHERE J.required_caregiving_type LIKE '%" + "@param1" + "%'" +
                " OR J.other_requirements LIKE '%" + "@param2" + "%'" +
                " AND Ja.caregiver_user_id = C.caregiver_user_id " +

                " GROUP BY J.job_id, J.required_caregiving_type, CAST(J.other_requirements AS NVARCHAR(200)), " +
                " J.date_posted, U.given_name, U.surname, C.hourly_rate, C.caregiving_type, Ja.date_applied " +

                " ORDER BY J.job_id "


                ;

            cmd.Parameters.Add(new SqlParameter("@param1", txt_keywordForJobSearch.Text));
            cmd.Parameters.Add(new SqlParameter("@param2", txt_keywordForJobSearch.Text));

            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;

        }

        private void btn_totalPaymentsOfCaregivers_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT t2.given_name as CaregiverName, t2.surname, " +
                "t3.hourly_rate as HourlyRate, " +
                " t1.appointment_id,  t1.appointment_date_time, t1.status, " +
                " t1.work_hours as WorkHours, " +
                " t1.work_hours* t3.hourly_rate as TotalEarnings " +
                " FROM[Appointment] t1, [User] t2, [Caregiver] t3, [Job_Application] t4 " +
                " WHERE t1.caregiver_user_id = t2.user_id AND t1.status = 'ACCEPTED' AND t1.caregiver_user_id = t3.caregiver_user_id " +
                " GROUP BY t1.caregiver_user_id, t2.given_name, t2.surname, t3.hourly_rate, t1.appointment_id, t1.appointment_date_time, t1.work_hours, t1.status " +
                " ORDER BY t1.appointment_id ASC ";

            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;

        }

        private void btn_viewFor9thExample_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM[JobsAndJobApplications]";
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;
        }

        private void btn_errorHandlingExample_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BEGIN TRY  " +
                " SELECT 1 / 0; " +
                " END TRY " +
                " BEGIN CATCH " +
                " EXECUTE usp_GetErrorInfo; " +
                " END CATCH "
                ;
            cmd.Connection = con;

            SqlDataAdapter adptr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();

            adptr.Fill(tbl);

            dataGridView1.DataSource = tbl;

        }
    }
}
