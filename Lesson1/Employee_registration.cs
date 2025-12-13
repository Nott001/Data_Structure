using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class Employee_registration : Form
    {
        string picpath;
        employee_dbconnection emp_db_connect = new employee_dbconnection();

        public Employee_registration()
        {
            emp_db_connect.employee_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
        {
            gender_comboBox.Items.Clear();
            status_comboBox.Items.Clear();
            age_comboBox.Items.Clear();

            college_graduated_date.Value = DateTime.Today;
            elem_graduated_date.Value = DateTime.Today;
            junior_high_graduated_date.Value = DateTime.Today;
            senior_high_graduated_date.Value = DateTime.Today;
            emp_hired_date.Value = DateTime.Today;


            emp_idTxtBox.Clear(); first_name_box.Clear(); middle_name_box.Clear();
            surname_box.Clear(); sss_num_box.Clear(); tin_num_box.Clear();
            philhealth_num_box.Clear(); pagibig_num_box.Clear(); height_box.Clear();
            weight_box.Clear(); years_stay_box.Clear(); house_num_box.Clear();
            subd_name_box.Clear(); phase_num_box.Clear(); street_box.Clear();
            barangay_box.Clear(); municipality_box.Clear(); city_box.Clear();
            province_box.Clear(); country_box.Clear(); zipcode_box.Clear();
            elem_school_box.Clear(); elem_address_box.Clear(); elem_awards_box.Clear();
            junior_high_box.Clear(); junior_high_address_box.Clear(); junior_high_awards_box.Clear();
            senior_high_school.Clear(); senior_high_address.Clear(); senior_high_awards_box.Clear();
            senior_high_track.Clear(); college_school_box.Clear(); college_school_address_box.Clear();
            college_awards_box.Clear(); college_course_box.Clear(); others_box.Clear();
            position_box.Clear(); emp_status_box.Clear(); department_box.Clear();
            num_of_despondents_box.Clear(); pic_path_box.Clear();
            pictureBox1.Image = Image.FromFile("C:\\Users\\karlr\\Source\\Repos\\Data_Structure\\Lesson1\\pictures\\Default_pfp.jpg");
            emp_idTxtBox.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Employee_registration_Load(object sender, EventArgs e)
        {
            for (int age = 18; age <= 60; age++)
            {
                // Convert the integer 'age' to a String and add it to the Items collection
                age_comboBox.Items.Add(age.ToString());
            }

            // Optional: Set a default selection (e.g., the first item, 18)
            if (age_comboBox.Items.Count > 0)
            {
                age_comboBox.SelectedIndex = 0;
            }

            gender_comboBox.Items.Add("Male");
            gender_comboBox.Items.Add("Female");
            status_comboBox.Items.Add("Single");
            status_comboBox.Items.Add("Married");

            try 
            {
                pic_path_box.Hide();
                pictureBox1.Image = Image.FromFile("C:\\Users\\karlr\\Source\\Repos\\Data_Structure\\Lesson1\\pictures\\Default_pfp.jpg");
                emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqldataadapterSelect();
                emp_db_connect.employee_sqldatasetSELECT();
                dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png *.bmp";
                openFileDialog1.ShowDialog();
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                pic_path_box.Text = picpath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                emp_db_connect.employee_sql =
                    "SELECT * FROM pos_empRegTbl WHERE emp_id = '" + emp_idTxtBox.Text + "'";
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqldataadapterSelect();
                emp_db_connect.employee_sqldatasetSELECT();

                dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];

                if (emp_db_connect.employee_sql_dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No record found for this Employee ID.");
                    return;
                }

                DataRow row = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0];

                // BASIC INFORMATION
                first_name_box.Text = row["emp_fname"].ToString();
                middle_name_box.Text = row["emp_mname"].ToString();
                surname_box.Text = row["emp_surname"].ToString();

                // COMBOBOXES
                age_comboBox.Text = row["emp_age"].ToString();
                gender_comboBox.Text = row["emp_gender"].ToString();
                status_comboBox.Text = row["emp_status"].ToString(); // educational?
                emp_status_box.Text = row["emp_work_status"].ToString(); // employee working status

                position_box.Text = row["position"].ToString();
                department_box.Text = row["emp_department"].ToString();

                // IDs
                sss_num_box.Text = row["emp_sss_no"].ToString();
                tin_num_box.Text = row["emp_tin_no"].ToString();
                philhealth_num_box.Text = row["emp_philhealth_no"].ToString();
                pagibig_num_box.Text = row["emp_pagibig_no"].ToString();

                // PHYSICAL
                height_box.Text = row["emp_height"].ToString();
                weight_box.Text = row["emp_weight"].ToString();

                // ADDRESS
                years_stay_box.Text = row["add_years_stay"].ToString();
                house_num_box.Text = row["add_house_no"].ToString();
                subd_name_box.Text = row["add_subdivision_name"].ToString();
                phase_num_box.Text = row["add_phase_number"].ToString();
                street_box.Text = row["add_street"].ToString();
                barangay_box.Text = row["add_barangay"].ToString();
                municipality_box.Text = row["add_municipality"].ToString();
                city_box.Text = row["add_city"].ToString();
                province_box.Text = row["add_province"].ToString();
                country_box.Text = row["add_country"].ToString();
                zipcode_box.Text = row["add_zipcode"].ToString();

                // EDUCATION
                elem_school_box.Text = row["elem_name"].ToString();
                elem_address_box.Text = row["elem_address"].ToString();
                elem_awards_box.Text = row["elem_award"].ToString();
                elem_graduated_date.Value = Convert.ToDateTime(row["elem_grad"]);

                junior_high_box.Text = row["junior_high_name"].ToString();
                junior_high_address_box.Text = row["junior_high_address"].ToString();
                junior_high_awards_box.Text = row["junior_high_award"].ToString();
                junior_high_graduated_date.Value = Convert.ToDateTime(row["junior_high_grad"]);

                senior_high_school.Text = row["senior_high_name"].ToString();
                senior_high_address.Text = row["senior_high_address"].ToString();
                senior_high_awards_box.Text = row["senior_high_award"].ToString();
                senior_high_graduated_date.Value = Convert.ToDateTime(row["senior_high_grad"]);
                senior_high_track.Text = row["track"].ToString();

                college_school_box.Text = row["college_school_name"].ToString();
                college_school_address_box.Text = row["college_address"].ToString();
                college_awards_box.Text = row["college_award"].ToString();
                college_course_box.Text = row["college_course"].ToString();
                college_graduated_date.Value = Convert.ToDateTime(row["college_year_grad"]);

                others_box.Text = row["others"].ToString();

                num_of_despondents_box.Text = row["emp_no_of_dependents"].ToString();

                // DATE HIRED
                emp_hired_date.Value = Convert.ToDateTime(row["emp_date_hired"]);

                // PICTURE
                pic_path_box.Text = row["picpath"].ToString();
                if (System.IO.File.Exists(pic_path_box.Text))
                    pictureBox1.Image = Image.FromFile(pic_path_box.Text);
                else
                    pictureBox1.Image = Image.FromFile("C:\\Users\\karlr\\Source\\Repos\\Data_Structure\\Lesson1\\pictures\\Default_pfp.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                emp_db_connect.employee_sql = "DELETE FROM pos_empRegTbl WHERE emp_id = '" + emp_idTxtBox.Text + "'";
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqldataadapterDelete();
                emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqldataadapterSelect();
                emp_db_connect.employee_sqldatasetSELECT();
                dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                emp_db_connect.employee_sql =
                "INSERT INTO pos_empRegTbl (emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_sss_no, " +
                "emp_tin_no, emp_philhealth_no, emp_pagibig_no, emp_status, emp_height, emp_weight, add_years_stay, " +
                "add_house_no, add_subdivision_name, add_phase_number, add_street, add_barangay, add_municipality, " +
                "add_city, add_province, add_country, add_zipcode, elem_name, elem_address, elem_grad, elem_award, " +
                "junior_high_name, junior_high_address, junior_high_grad, junior_high_award, senior_high_name, " +
                "senior_high_address, senior_high_grad, senior_high_award, track, college_school_name, college_address, " +
                "college_year_grad, college_award, college_course, others, position, emp_work_status, emp_date_hired, " +
                "emp_department, emp_no_of_dependents, picpath) VALUES ('" +

                emp_idTxtBox.Text + "', '" +
                first_name_box.Text + "', '" +
                middle_name_box.Text + "', '" +
                surname_box.Text + "', '" +
                age_comboBox.Text + "', '" +
                gender_comboBox.Text + "', '" +
                sss_num_box.Text + "', '" +
                tin_num_box.Text + "', '" +
                philhealth_num_box.Text + "', '" +
                pagibig_num_box.Text + "', '" +
                status_comboBox.Text + "', '" +
                height_box.Text + "', '" +
                weight_box.Text + "', '" +
                years_stay_box.Text + "', '" +
                house_num_box.Text + "', '" +
                subd_name_box.Text + "', '" +
                phase_num_box.Text + "', '" +
                street_box.Text + "', '" +
                barangay_box.Text + "', '" +
                municipality_box.Text + "', '" +
                city_box.Text + "', '" +
                province_box.Text + "', '" +
                country_box.Text + "', '" +
                zipcode_box.Text + "', '" +
                elem_school_box.Text + "', '" +
                elem_address_box.Text + "', '" +
                elem_graduated_date.Value.ToString("yyyy-MM-dd") + "', '" +
                elem_awards_box.Text + "', '" +
                junior_high_box.Text + "', '" +
                junior_high_address_box.Text + "', '" +
                junior_high_graduated_date.Value.ToString("yyyy-MM-dd") + "', '" +
                junior_high_awards_box.Text + "', '" +
                senior_high_school.Text + "', '" +
                senior_high_address.Text + "', '" +
                senior_high_graduated_date.Value.ToString("yyyy-MM-dd") + "', '" +
                senior_high_awards_box.Text + "', '" +
                senior_high_track.Text + "', '" +
                college_school_box.Text + "', '" +
                college_school_address_box.Text + "', '" +
                college_graduated_date.Value.ToString("yyyy-MM-dd") + "', '" +
                college_awards_box.Text + "', '" +
                college_course_box.Text + "', '" +
                others_box.Text + "', '" +
                position_box.Text + "', '" +
                emp_status_box.Text + "', '" +
                emp_hired_date.Value.ToString("yyyy-MM-dd") + "', '" +
                department_box.Text + "', '" +
                num_of_despondents_box.Text + "', '" +
                pic_path_box.Text + "')";

                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqldataadapterInsert();

                dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];

                MessageBox.Show("Employee Successfully Added!");
                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                emp_db_connect.employee_sql =
                "UPDATE pos_empRegTbl SET " +
                "emp_fname = '" + first_name_box.Text + "', " +
                "emp_mname = '" + middle_name_box.Text + "', " +
                "emp_surname = '" + surname_box.Text + "', " +
                "emp_age = '" + age_comboBox.Text + "', " +
                "emp_gender = '" + gender_comboBox.Text + "', " +
                "emp_status = '" + status_comboBox.Text + "', " +
                "emp_sss_no = '" + sss_num_box.Text + "', " +
                "emp_tin_no = '" + tin_num_box.Text + "', " +
                "emp_philhealth_no = '" + philhealth_num_box.Text + "', " +
                "emp_pagibig_no = '" + pagibig_num_box.Text + "', " +
                "emp_height = '" + height_box.Text + "', " +
                "emp_weight = '" + weight_box.Text + "', " +
                "add_years_stay = '" + years_stay_box.Text + "', " +
                "add_house_no = '" + house_num_box.Text + "', " +
                "add_subdivision_name = '" + subd_name_box.Text + "', " +
                "add_phase_number = '" + phase_num_box.Text + "', " +
                "add_street = '" + street_box.Text + "', " +
                "add_barangay = '" + barangay_box.Text + "', " +
                "add_municipality = '" + municipality_box.Text + "', " +
                "add_city = '" + city_box.Text + "', " +
                "add_province = '" + province_box.Text + "', " +
                "add_country = '" + country_box.Text + "', " +
                "add_zipcode = '" + zipcode_box.Text + "', " +
                "elem_name = '" + elem_school_box.Text + "', " +
                "elem_address = '" + elem_address_box.Text + "', " +
                "elem_grad = '" + elem_graduated_date.Value.ToString("yyyy-MM-dd") + "', " +
                "elem_award = '" + elem_awards_box.Text + "', " +
                "junior_high_name = '" + junior_high_box.Text + "', " +
                "junior_high_address = '" + junior_high_address_box.Text + "', " +
                "junior_high_grad = '" + junior_high_graduated_date.Value.ToString("yyyy-MM-dd") + "', " +
                "junior_high_award = '" + junior_high_awards_box.Text + "', " +
                "senior_high_name = '" + senior_high_school.Text + "', " +
                "senior_high_address = '" + senior_high_address.Text + "', " +
                "senior_high_grad = '" + senior_high_graduated_date.Value.ToString("yyyy-MM-dd") + "', " +
                "senior_high_award = '" + senior_high_awards_box.Text + "', " +
                "track = '" + senior_high_track.Text + "', " +
                "college_school_name = '" + college_school_box.Text + "', " +
                "college_address = '" + college_school_address_box.Text + "', " +
                "college_year_grad = '" + college_graduated_date.Value.ToString("yyyy-MM-dd") + "', " +
                "college_award = '" + college_awards_box.Text + "', " +
                "college_course = '" + college_course_box.Text + "', " +
                "others = '" + others_box.Text + "', " +
                "position = '" + position_box.Text + "', " +
                "emp_work_status = '" + emp_status_box.Text + "', " +
                "emp_department = '" + department_box.Text + "', " +
                "emp_date_hired = '" + emp_hired_date.Value.ToString("yyyy-MM-dd") + "', " +
                "emp_no_of_dependents = '" + num_of_despondents_box.Text + "', " +
                "picpath = '" + pic_path_box.Text + "' " +
                "WHERE emp_id = '" + emp_idTxtBox.Text + "'";

                emp_db_connect.employee_cmd();
                emp_db_connect.employee_sqldataadapterUpdate();

                dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];

                MessageBox.Show("Record updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void age_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
