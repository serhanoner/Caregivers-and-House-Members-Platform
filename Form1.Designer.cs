
namespace EvdekiBakicim
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_showUsers = new System.Windows.Forms.Button();
            this.btn_showCaregivers = new System.Windows.Forms.Button();
            this.btn_showMembers = new System.Windows.Forms.Button();
            this.btn_showAddresses = new System.Windows.Forms.Button();
            this.btn_showJobs = new System.Windows.Forms.Button();
            this.btn_showJobApplications = new System.Windows.Forms.Button();
            this.btn_showAppointments = new System.Windows.Forms.Button();
            this.btn_updatePhoneOfPinarYilmaz = new System.Windows.Forms.Button();
            this.btn_addCommissions = new System.Windows.Forms.Button();
            this.btn_deleteMembersKadirgalarStreet = new System.Windows.Forms.Button();
            this.btn_deleteJobsPostedByPinarYilmaz = new System.Windows.Forms.Button();
            this.btn_showCaregiversAndMembersWithAcceptedAppointments = new System.Windows.Forms.Button();
            this.btn_gentleCaregivers = new System.Windows.Forms.Button();
            this.lbl_deleteJobsByName = new System.Windows.Forms.Label();
            this.lbl_surnameForDeletion = new System.Windows.Forms.Label();
            this.txt_firstNameForDeletion = new System.Windows.Forms.TextBox();
            this.txt_surnameForDeletion = new System.Windows.Forms.TextBox();
            this.lbl_streetDeletion = new System.Windows.Forms.Label();
            this.txt_nameOfTheStreetToDelete = new System.Windows.Forms.TextBox();
            this.lbl_simpleQueriesBelow = new System.Windows.Forms.Label();
            this.btn_workHoursOfBabySitters = new System.Windows.Forms.Button();
            this.btn_membersLookingForElderlyCareWithoutPets = new System.Windows.Forms.Button();
            this.lbl_complexQueries = new System.Windows.Forms.Label();
            this.btn_numberOfApplicants = new System.Windows.Forms.Button();
            this.btn_totalHoursSpent = new System.Windows.Forms.Button();
            this.btn_averagePayOfCaregivers = new System.Windows.Forms.Button();
            this.btn_caregiversEarningAboveAverage = new System.Windows.Forms.Button();
            this.lbl_otherQueries = new System.Windows.Forms.Label();
            this.btn_totalPaymentsOfCaregivers = new System.Windows.Forms.Button();
            this.btn_searchJobsPostedByAKeyword = new System.Windows.Forms.Button();
            this.txt_keywordForJobSearch = new System.Windows.Forms.TextBox();
            this.btn_viewFor9thExample = new System.Windows.Forms.Button();
            this.btn_errorHandlingExample = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(923, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_showUsers
            // 
            this.btn_showUsers.Location = new System.Drawing.Point(61, 12);
            this.btn_showUsers.Name = "btn_showUsers";
            this.btn_showUsers.Size = new System.Drawing.Size(86, 29);
            this.btn_showUsers.TabIndex = 1;
            this.btn_showUsers.Text = "Show Users";
            this.btn_showUsers.UseVisualStyleBackColor = true;
            this.btn_showUsers.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_showCaregivers
            // 
            this.btn_showCaregivers.Location = new System.Drawing.Point(165, 12);
            this.btn_showCaregivers.Name = "btn_showCaregivers";
            this.btn_showCaregivers.Size = new System.Drawing.Size(85, 29);
            this.btn_showCaregivers.TabIndex = 2;
            this.btn_showCaregivers.Text = "Show Cgivers";
            this.btn_showCaregivers.UseVisualStyleBackColor = true;
            this.btn_showCaregivers.Click += new System.EventHandler(this.btn_showCaregivers_Click);
            // 
            // btn_showMembers
            // 
            this.btn_showMembers.Location = new System.Drawing.Point(273, 12);
            this.btn_showMembers.Name = "btn_showMembers";
            this.btn_showMembers.Size = new System.Drawing.Size(93, 29);
            this.btn_showMembers.TabIndex = 3;
            this.btn_showMembers.Text = "Show Members";
            this.btn_showMembers.UseVisualStyleBackColor = true;
            this.btn_showMembers.Click += new System.EventHandler(this.btn_showMembers_Click);
            // 
            // btn_showAddresses
            // 
            this.btn_showAddresses.Location = new System.Drawing.Point(386, 12);
            this.btn_showAddresses.Name = "btn_showAddresses";
            this.btn_showAddresses.Size = new System.Drawing.Size(94, 29);
            this.btn_showAddresses.TabIndex = 4;
            this.btn_showAddresses.Text = "Show Addresses";
            this.btn_showAddresses.UseVisualStyleBackColor = true;
            this.btn_showAddresses.Click += new System.EventHandler(this.btn_showAddresses_Click);
            // 
            // btn_showJobs
            // 
            this.btn_showJobs.Location = new System.Drawing.Point(507, 12);
            this.btn_showJobs.Name = "btn_showJobs";
            this.btn_showJobs.Size = new System.Drawing.Size(75, 29);
            this.btn_showJobs.TabIndex = 5;
            this.btn_showJobs.Text = "Show Jobs";
            this.btn_showJobs.UseVisualStyleBackColor = true;
            this.btn_showJobs.Click += new System.EventHandler(this.btn_showJobs_Click);
            // 
            // btn_showJobApplications
            // 
            this.btn_showJobApplications.Location = new System.Drawing.Point(610, 12);
            this.btn_showJobApplications.Name = "btn_showJobApplications";
            this.btn_showJobApplications.Size = new System.Drawing.Size(122, 29);
            this.btn_showJobApplications.TabIndex = 6;
            this.btn_showJobApplications.Text = "Show Job Applications";
            this.btn_showJobApplications.UseVisualStyleBackColor = true;
            this.btn_showJobApplications.Click += new System.EventHandler(this.btn_showJobApplications_Click);
            // 
            // btn_showAppointments
            // 
            this.btn_showAppointments.Location = new System.Drawing.Point(760, 12);
            this.btn_showAppointments.Name = "btn_showAppointments";
            this.btn_showAppointments.Size = new System.Drawing.Size(115, 29);
            this.btn_showAppointments.TabIndex = 7;
            this.btn_showAppointments.Text = "Show Appointments";
            this.btn_showAppointments.UseVisualStyleBackColor = true;
            this.btn_showAppointments.Click += new System.EventHandler(this.btn_showAppointments_Click);
            // 
            // btn_updatePhoneOfPinarYilmaz
            // 
            this.btn_updatePhoneOfPinarYilmaz.Location = new System.Drawing.Point(25, 60);
            this.btn_updatePhoneOfPinarYilmaz.Name = "btn_updatePhoneOfPinarYilmaz";
            this.btn_updatePhoneOfPinarYilmaz.Size = new System.Drawing.Size(95, 40);
            this.btn_updatePhoneOfPinarYilmaz.TabIndex = 8;
            this.btn_updatePhoneOfPinarYilmaz.Text = "Update Phone of Pinar Yilmaz";
            this.btn_updatePhoneOfPinarYilmaz.UseVisualStyleBackColor = true;
            this.btn_updatePhoneOfPinarYilmaz.Click += new System.EventHandler(this.btn_updatePhoneOfPinarYilmaz_Click);
            // 
            // btn_addCommissions
            // 
            this.btn_addCommissions.Location = new System.Drawing.Point(148, 60);
            this.btn_addCommissions.Name = "btn_addCommissions";
            this.btn_addCommissions.Size = new System.Drawing.Size(104, 40);
            this.btn_addCommissions.TabIndex = 9;
            this.btn_addCommissions.Text = "Add Commissions";
            this.btn_addCommissions.UseVisualStyleBackColor = true;
            this.btn_addCommissions.Click += new System.EventHandler(this.btn_addCommissions_Click);
            // 
            // btn_deleteMembersKadirgalarStreet
            // 
            this.btn_deleteMembersKadirgalarStreet.Location = new System.Drawing.Point(676, 60);
            this.btn_deleteMembersKadirgalarStreet.Name = "btn_deleteMembersKadirgalarStreet";
            this.btn_deleteMembersKadirgalarStreet.Size = new System.Drawing.Size(130, 40);
            this.btn_deleteMembersKadirgalarStreet.TabIndex = 11;
            this.btn_deleteMembersKadirgalarStreet.Text = "Delete Members Who Live In a Specific Street";
            this.btn_deleteMembersKadirgalarStreet.UseVisualStyleBackColor = true;
            this.btn_deleteMembersKadirgalarStreet.Click += new System.EventHandler(this.btn_deleteMembersKadirgalarStreet_Click);
            // 
            // btn_deleteJobsPostedByPinarYilmaz
            // 
            this.btn_deleteJobsPostedByPinarYilmaz.Location = new System.Drawing.Point(299, 60);
            this.btn_deleteJobsPostedByPinarYilmaz.Name = "btn_deleteJobsPostedByPinarYilmaz";
            this.btn_deleteJobsPostedByPinarYilmaz.Size = new System.Drawing.Size(113, 40);
            this.btn_deleteJobsPostedByPinarYilmaz.TabIndex = 10;
            this.btn_deleteJobsPostedByPinarYilmaz.Text = "Delete Jobs Posted By Pinar Yilmaz";
            this.btn_deleteJobsPostedByPinarYilmaz.UseVisualStyleBackColor = true;
            this.btn_deleteJobsPostedByPinarYilmaz.Click += new System.EventHandler(this.btn_deleteJobsPostedByPinarYilmaz_Click);
            // 
            // btn_showCaregiversAndMembersWithAcceptedAppointments
            // 
            this.btn_showCaregiversAndMembersWithAcceptedAppointments.Location = new System.Drawing.Point(12, 159);
            this.btn_showCaregiversAndMembersWithAcceptedAppointments.Name = "btn_showCaregiversAndMembersWithAcceptedAppointments";
            this.btn_showCaregiversAndMembersWithAcceptedAppointments.Size = new System.Drawing.Size(164, 40);
            this.btn_showCaregiversAndMembersWithAcceptedAppointments.TabIndex = 13;
            this.btn_showCaregiversAndMembersWithAcceptedAppointments.Text = "Show Caregivers and Members with Accepted Appointments";
            this.btn_showCaregiversAndMembersWithAcceptedAppointments.UseVisualStyleBackColor = true;
            this.btn_showCaregiversAndMembersWithAcceptedAppointments.Click += new System.EventHandler(this.btn_showCaregiversAndMembersWithAcceptedAppointments_Click);
            // 
            // btn_gentleCaregivers
            // 
            this.btn_gentleCaregivers.Location = new System.Drawing.Point(214, 165);
            this.btn_gentleCaregivers.Name = "btn_gentleCaregivers";
            this.btn_gentleCaregivers.Size = new System.Drawing.Size(113, 28);
            this.btn_gentleCaregivers.TabIndex = 12;
            this.btn_gentleCaregivers.Text = "Gentle Caregivers";
            this.btn_gentleCaregivers.UseVisualStyleBackColor = true;
            this.btn_gentleCaregivers.Click += new System.EventHandler(this.btn_gentleCaregivers_Click);
            // 
            // lbl_deleteJobsByName
            // 
            this.lbl_deleteJobsByName.AutoSize = true;
            this.lbl_deleteJobsByName.Location = new System.Drawing.Point(431, 63);
            this.lbl_deleteJobsByName.Name = "lbl_deleteJobsByName";
            this.lbl_deleteJobsByName.Size = new System.Drawing.Size(98, 13);
            this.lbl_deleteJobsByName.TabIndex = 14;
            this.lbl_deleteJobsByName.Text = "Name for Deletion :";
            // 
            // lbl_surnameForDeletion
            // 
            this.lbl_surnameForDeletion.AutoSize = true;
            this.lbl_surnameForDeletion.Location = new System.Drawing.Point(424, 89);
            this.lbl_surnameForDeletion.Name = "lbl_surnameForDeletion";
            this.lbl_surnameForDeletion.Size = new System.Drawing.Size(112, 13);
            this.lbl_surnameForDeletion.TabIndex = 15;
            this.lbl_surnameForDeletion.Text = "Surname for Deletion :";
            // 
            // txt_firstNameForDeletion
            // 
            this.txt_firstNameForDeletion.Location = new System.Drawing.Point(542, 60);
            this.txt_firstNameForDeletion.Name = "txt_firstNameForDeletion";
            this.txt_firstNameForDeletion.Size = new System.Drawing.Size(100, 20);
            this.txt_firstNameForDeletion.TabIndex = 16;
            // 
            // txt_surnameForDeletion
            // 
            this.txt_surnameForDeletion.Location = new System.Drawing.Point(542, 86);
            this.txt_surnameForDeletion.Name = "txt_surnameForDeletion";
            this.txt_surnameForDeletion.Size = new System.Drawing.Size(100, 20);
            this.txt_surnameForDeletion.TabIndex = 17;
            // 
            // lbl_streetDeletion
            // 
            this.lbl_streetDeletion.AutoSize = true;
            this.lbl_streetDeletion.Location = new System.Drawing.Point(821, 63);
            this.lbl_streetDeletion.Name = "lbl_streetDeletion";
            this.lbl_streetDeletion.Size = new System.Drawing.Size(91, 13);
            this.lbl_streetDeletion.TabIndex = 18;
            this.lbl_streetDeletion.Text = "Street To Delete :";
            // 
            // txt_nameOfTheStreetToDelete
            // 
            this.txt_nameOfTheStreetToDelete.Location = new System.Drawing.Point(824, 86);
            this.txt_nameOfTheStreetToDelete.Name = "txt_nameOfTheStreetToDelete";
            this.txt_nameOfTheStreetToDelete.Size = new System.Drawing.Size(100, 20);
            this.txt_nameOfTheStreetToDelete.TabIndex = 19;
            // 
            // lbl_simpleQueriesBelow
            // 
            this.lbl_simpleQueriesBelow.AutoSize = true;
            this.lbl_simpleQueriesBelow.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_simpleQueriesBelow.Location = new System.Drawing.Point(145, 127);
            this.lbl_simpleQueriesBelow.Name = "lbl_simpleQueriesBelow";
            this.lbl_simpleQueriesBelow.Size = new System.Drawing.Size(80, 13);
            this.lbl_simpleQueriesBelow.TabIndex = 20;
            this.lbl_simpleQueriesBelow.Text = "Simple Queries;";
            // 
            // btn_workHoursOfBabySitters
            // 
            this.btn_workHoursOfBabySitters.Location = new System.Drawing.Point(41, 220);
            this.btn_workHoursOfBabySitters.Name = "btn_workHoursOfBabySitters";
            this.btn_workHoursOfBabySitters.Size = new System.Drawing.Size(107, 34);
            this.btn_workHoursOfBabySitters.TabIndex = 21;
            this.btn_workHoursOfBabySitters.Text = "Work Hours Of Baby Sitters";
            this.btn_workHoursOfBabySitters.UseVisualStyleBackColor = true;
            this.btn_workHoursOfBabySitters.Click += new System.EventHandler(this.btn_workHoursOfBabySitters_Click);
            // 
            // btn_membersLookingForElderlyCareWithoutPets
            // 
            this.btn_membersLookingForElderlyCareWithoutPets.Location = new System.Drawing.Point(201, 220);
            this.btn_membersLookingForElderlyCareWithoutPets.Name = "btn_membersLookingForElderlyCareWithoutPets";
            this.btn_membersLookingForElderlyCareWithoutPets.Size = new System.Drawing.Size(135, 34);
            this.btn_membersLookingForElderlyCareWithoutPets.TabIndex = 22;
            this.btn_membersLookingForElderlyCareWithoutPets.Text = "Members Looking For Elderly Care with No Pets";
            this.btn_membersLookingForElderlyCareWithoutPets.UseVisualStyleBackColor = true;
            this.btn_membersLookingForElderlyCareWithoutPets.Click += new System.EventHandler(this.btn_membersLookingForElderlyCareWithoutPets_Click);
            // 
            // lbl_complexQueries
            // 
            this.lbl_complexQueries.AutoSize = true;
            this.lbl_complexQueries.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_complexQueries.Location = new System.Drawing.Point(464, 127);
            this.lbl_complexQueries.Name = "lbl_complexQueries";
            this.lbl_complexQueries.Size = new System.Drawing.Size(89, 13);
            this.lbl_complexQueries.TabIndex = 23;
            this.lbl_complexQueries.Text = "Complex Queries;";
            // 
            // btn_numberOfApplicants
            // 
            this.btn_numberOfApplicants.Location = new System.Drawing.Point(389, 165);
            this.btn_numberOfApplicants.Name = "btn_numberOfApplicants";
            this.btn_numberOfApplicants.Size = new System.Drawing.Size(123, 26);
            this.btn_numberOfApplicants.TabIndex = 24;
            this.btn_numberOfApplicants.Text = "Number Of Applicants";
            this.btn_numberOfApplicants.UseVisualStyleBackColor = true;
            this.btn_numberOfApplicants.Click += new System.EventHandler(this.btn_numberOfApplicants_Click);
            // 
            // btn_totalHoursSpent
            // 
            this.btn_totalHoursSpent.Location = new System.Drawing.Point(543, 165);
            this.btn_totalHoursSpent.Name = "btn_totalHoursSpent";
            this.btn_totalHoursSpent.Size = new System.Drawing.Size(102, 26);
            this.btn_totalHoursSpent.TabIndex = 26;
            this.btn_totalHoursSpent.Text = "Total Hours Spent";
            this.btn_totalHoursSpent.UseVisualStyleBackColor = true;
            this.btn_totalHoursSpent.Click += new System.EventHandler(this.btn_totalHoursSpent_Click);
            // 
            // btn_averagePayOfCaregivers
            // 
            this.btn_averagePayOfCaregivers.Location = new System.Drawing.Point(389, 220);
            this.btn_averagePayOfCaregivers.Name = "btn_averagePayOfCaregivers";
            this.btn_averagePayOfCaregivers.Size = new System.Drawing.Size(114, 34);
            this.btn_averagePayOfCaregivers.TabIndex = 27;
            this.btn_averagePayOfCaregivers.Text = "Average Pay Of Caregivers";
            this.btn_averagePayOfCaregivers.UseVisualStyleBackColor = true;
            this.btn_averagePayOfCaregivers.Click += new System.EventHandler(this.btn_averagePayOfCaregivers_Click);
            // 
            // btn_caregiversEarningAboveAverage
            // 
            this.btn_caregiversEarningAboveAverage.Location = new System.Drawing.Point(535, 220);
            this.btn_caregiversEarningAboveAverage.Name = "btn_caregiversEarningAboveAverage";
            this.btn_caregiversEarningAboveAverage.Size = new System.Drawing.Size(118, 34);
            this.btn_caregiversEarningAboveAverage.TabIndex = 28;
            this.btn_caregiversEarningAboveAverage.Text = "Caregivers Who Earn Above Average";
            this.btn_caregiversEarningAboveAverage.UseVisualStyleBackColor = true;
            this.btn_caregiversEarningAboveAverage.Click += new System.EventHandler(this.btn_caregiversEarningAboveAverage_Click);
            // 
            // lbl_otherQueries
            // 
            this.lbl_otherQueries.AutoSize = true;
            this.lbl_otherQueries.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_otherQueries.Location = new System.Drawing.Point(781, 127);
            this.lbl_otherQueries.Name = "lbl_otherQueries";
            this.lbl_otherQueries.Size = new System.Drawing.Size(75, 13);
            this.lbl_otherQueries.TabIndex = 29;
            this.lbl_otherQueries.Text = "Other Queries;";
            // 
            // btn_totalPaymentsOfCaregivers
            // 
            this.btn_totalPaymentsOfCaregivers.Location = new System.Drawing.Point(696, 161);
            this.btn_totalPaymentsOfCaregivers.Name = "btn_totalPaymentsOfCaregivers";
            this.btn_totalPaymentsOfCaregivers.Size = new System.Drawing.Size(96, 34);
            this.btn_totalPaymentsOfCaregivers.TabIndex = 30;
            this.btn_totalPaymentsOfCaregivers.Text = "Total Cost Of Caregivers";
            this.btn_totalPaymentsOfCaregivers.UseVisualStyleBackColor = true;
            this.btn_totalPaymentsOfCaregivers.Click += new System.EventHandler(this.btn_totalPaymentsOfCaregivers_Click);
            // 
            // btn_searchJobsPostedByAKeyword
            // 
            this.btn_searchJobsPostedByAKeyword.Location = new System.Drawing.Point(812, 161);
            this.btn_searchJobsPostedByAKeyword.Name = "btn_searchJobsPostedByAKeyword";
            this.btn_searchJobsPostedByAKeyword.Size = new System.Drawing.Size(123, 34);
            this.btn_searchJobsPostedByAKeyword.TabIndex = 31;
            this.btn_searchJobsPostedByAKeyword.Text = "Search Jobs Posted By A Keyword";
            this.btn_searchJobsPostedByAKeyword.UseVisualStyleBackColor = true;
            this.btn_searchJobsPostedByAKeyword.Click += new System.EventHandler(this.btn_searchJobsPostedByAKeyword_Click);
            // 
            // txt_keywordForJobSearch
            // 
            this.txt_keywordForJobSearch.Location = new System.Drawing.Point(812, 201);
            this.txt_keywordForJobSearch.Name = "txt_keywordForJobSearch";
            this.txt_keywordForJobSearch.Size = new System.Drawing.Size(123, 20);
            this.txt_keywordForJobSearch.TabIndex = 32;
            // 
            // btn_viewFor9thExample
            // 
            this.btn_viewFor9thExample.Location = new System.Drawing.Point(696, 245);
            this.btn_viewFor9thExample.Name = "btn_viewFor9thExample";
            this.btn_viewFor9thExample.Size = new System.Drawing.Size(96, 34);
            this.btn_viewFor9thExample.TabIndex = 33;
            this.btn_viewFor9thExample.Text = "View For Job and Applicants";
            this.btn_viewFor9thExample.UseVisualStyleBackColor = true;
            this.btn_viewFor9thExample.Click += new System.EventHandler(this.btn_viewFor9thExample_Click);
            // 
            // btn_errorHandlingExample
            // 
            this.btn_errorHandlingExample.Location = new System.Drawing.Point(824, 245);
            this.btn_errorHandlingExample.Name = "btn_errorHandlingExample";
            this.btn_errorHandlingExample.Size = new System.Drawing.Size(88, 34);
            this.btn_errorHandlingExample.TabIndex = 34;
            this.btn_errorHandlingExample.Text = "Error Handling Example";
            this.btn_errorHandlingExample.UseVisualStyleBackColor = true;
            this.btn_errorHandlingExample.Click += new System.EventHandler(this.btn_errorHandlingExample_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 697);
            this.Controls.Add(this.btn_errorHandlingExample);
            this.Controls.Add(this.btn_viewFor9thExample);
            this.Controls.Add(this.txt_keywordForJobSearch);
            this.Controls.Add(this.btn_searchJobsPostedByAKeyword);
            this.Controls.Add(this.btn_totalPaymentsOfCaregivers);
            this.Controls.Add(this.lbl_otherQueries);
            this.Controls.Add(this.btn_caregiversEarningAboveAverage);
            this.Controls.Add(this.btn_averagePayOfCaregivers);
            this.Controls.Add(this.btn_totalHoursSpent);
            this.Controls.Add(this.btn_numberOfApplicants);
            this.Controls.Add(this.lbl_complexQueries);
            this.Controls.Add(this.btn_membersLookingForElderlyCareWithoutPets);
            this.Controls.Add(this.btn_workHoursOfBabySitters);
            this.Controls.Add(this.lbl_simpleQueriesBelow);
            this.Controls.Add(this.txt_nameOfTheStreetToDelete);
            this.Controls.Add(this.lbl_streetDeletion);
            this.Controls.Add(this.txt_surnameForDeletion);
            this.Controls.Add(this.txt_firstNameForDeletion);
            this.Controls.Add(this.lbl_surnameForDeletion);
            this.Controls.Add(this.lbl_deleteJobsByName);
            this.Controls.Add(this.btn_showCaregiversAndMembersWithAcceptedAppointments);
            this.Controls.Add(this.btn_gentleCaregivers);
            this.Controls.Add(this.btn_deleteMembersKadirgalarStreet);
            this.Controls.Add(this.btn_deleteJobsPostedByPinarYilmaz);
            this.Controls.Add(this.btn_addCommissions);
            this.Controls.Add(this.btn_updatePhoneOfPinarYilmaz);
            this.Controls.Add(this.btn_showAppointments);
            this.Controls.Add(this.btn_showJobApplications);
            this.Controls.Add(this.btn_showJobs);
            this.Controls.Add(this.btn_showAddresses);
            this.Controls.Add(this.btn_showMembers);
            this.Controls.Add(this.btn_showCaregivers);
            this.Controls.Add(this.btn_showUsers);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_showUsers;
        private System.Windows.Forms.Button btn_showCaregivers;
        private System.Windows.Forms.Button btn_showMembers;
        private System.Windows.Forms.Button btn_showAddresses;
        private System.Windows.Forms.Button btn_showJobs;
        private System.Windows.Forms.Button btn_showJobApplications;
        private System.Windows.Forms.Button btn_showAppointments;
        private System.Windows.Forms.Button btn_updatePhoneOfPinarYilmaz;
        private System.Windows.Forms.Button btn_addCommissions;
        private System.Windows.Forms.Button btn_deleteMembersKadirgalarStreet;
        private System.Windows.Forms.Button btn_deleteJobsPostedByPinarYilmaz;
        private System.Windows.Forms.Button btn_showCaregiversAndMembersWithAcceptedAppointments;
        private System.Windows.Forms.Button btn_gentleCaregivers;
        private System.Windows.Forms.Label lbl_deleteJobsByName;
        private System.Windows.Forms.Label lbl_surnameForDeletion;
        private System.Windows.Forms.TextBox txt_firstNameForDeletion;
        private System.Windows.Forms.TextBox txt_surnameForDeletion;
        private System.Windows.Forms.Label lbl_streetDeletion;
        private System.Windows.Forms.TextBox txt_nameOfTheStreetToDelete;
        private System.Windows.Forms.Label lbl_simpleQueriesBelow;
        private System.Windows.Forms.Button btn_workHoursOfBabySitters;
        private System.Windows.Forms.Button btn_membersLookingForElderlyCareWithoutPets;
        private System.Windows.Forms.Label lbl_complexQueries;
        private System.Windows.Forms.Button btn_numberOfApplicants;
        private System.Windows.Forms.Button btn_totalHoursSpent;
        private System.Windows.Forms.Button btn_averagePayOfCaregivers;
        private System.Windows.Forms.Button btn_caregiversEarningAboveAverage;
        private System.Windows.Forms.Label lbl_otherQueries;
        private System.Windows.Forms.Button btn_totalPaymentsOfCaregivers;
        private System.Windows.Forms.Button btn_searchJobsPostedByAKeyword;
        private System.Windows.Forms.TextBox txt_keywordForJobSearch;
        private System.Windows.Forms.Button btn_viewFor9thExample;
        private System.Windows.Forms.Button btn_errorHandlingExample;
    }
}

