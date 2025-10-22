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
    public partial class POS_Admin : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        private string picpath;
        private Image pic;
        public POS_Admin()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
        {
            try
            {
                pic = Image.FromFile("C:\\Users\\karlr\\Source\\Repos\\Data_Structure\\Lesson1\\pictures\\no_image.jpg");

                picpathTxtbox1.Clear(); picpathTxtbox2.Clear(); picpathTxtbox3.Clear();
                picpathTxtbox4.Clear(); picpathTxtbox5.Clear(); picpathTxtbox6.Clear();
                picpathTxtbox7.Clear(); picpathTxtbox8.Clear(); picpathTxtbox9.Clear();
                picpathTxtbox10.Clear(); picpathTxtbox11.Clear(); picpathTxtbox12.Clear();
                picpathTxtbox13.Clear(); picpathTxtbox14.Clear(); picpathTxtbox15.Clear();
                picpathTxtbox16.Clear(); picpathTxtbox17.Clear(); picpathTxtbox18.Clear();
                picpathTxtbox19.Clear(); picpathTxtbox20.Clear();

                pictureBox1.Image = pic; pictureBox6.Image = pic; pictureBox11.Image = pic;
                pictureBox16.Image = pic; pictureBox2.Image = pic; pictureBox3.Image = pic;
                pictureBox4.Image = pic; pictureBox5.Image = pic; pictureBox7.Image = pic;
                pictureBox12.Image = pic; pictureBox17.Image = pic; pictureBox8.Image = pic;
                pictureBox13.Image = pic; pictureBox18.Image = pic; pictureBox9.Image = pic;
                pictureBox14.Image = pic; pictureBox19.Image = pic; pictureBox10.Image = pic;
                pictureBox15.Image = pic; pictureBox20.Image = pic;

                priceTxtbox1.Clear(); priceTxtbox2.Clear(); priceTxtbox3.Clear();
                priceTxtbox4.Clear(); priceTxtbox5.Clear(); priceTxtbox6.Clear();
                priceTxtbox7.Clear(); priceTxtbox8.Clear(); priceTxtbox9.Clear();
                priceTxtbox10.Clear(); priceTxtbox11.Clear(); priceTxtbox12.Clear();
                priceTxtbox13.Clear(); priceTxtbox14.Clear(); priceTxtbox15.Clear();
                priceTxtbox16.Clear(); priceTxtbox17.Clear(); priceTxtbox18.Clear();
                priceTxtbox19.Clear(); priceTxtbox20.Clear();

                nameTxtbox1.Clear(); nameTxtbox2.Clear(); nameTxtbox3.Clear();
                nameTxtbox4.Clear(); nameTxtbox5.Clear(); nameTxtbox6.Clear();
                nameTxtbox7.Clear(); nameTxtbox8.Clear(); nameTxtbox9.Clear();
                nameTxtbox10.Clear(); nameTxtbox11.Clear(); nameTxtbox12.Clear();
                nameTxtbox13.Clear(); nameTxtbox14.Clear(); nameTxtbox15.Clear();
                nameTxtbox16.Clear(); nameTxtbox17.Clear(); nameTxtbox18.Clear();
                nameTxtbox19.Clear(); nameTxtbox20.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void open_file_image()
        {
            // Codes for inserting picture from the local file to the PictureBox
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";
            // Filtering of image display using specific file extensions
            openFileDialog1.ShowDialog(); // Displaying the file dialog where the possible image is located
        }

        // Helper method to safely load pictures
        private void LoadPictureBox(PictureBox pictureBox, TextBox pathTextBox, string imagePath)
        {
            try
            {
                pathTextBox.Text = imagePath;

                // Check if path is valid and not empty
                if (!string.IsNullOrWhiteSpace(imagePath) && System.IO.File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Load default "no image" picture
                    string defaultPath = "C:\\Users\\karlr\\Source\\Repos\\Data_Structure\\Lesson1\\pictures\\no_image.jpg";
                    if (System.IO.File.Exists(defaultPath))
                    {
                        pictureBox.Image = Image.FromFile(defaultPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {imagePath}\nError: {ex.Message}");
                // Load default image on error
                try
                {
                    string defaultPath = "C:\\Users\\karlr\\Source\\Repos\\Data_Structure\\Lesson1\\pictures\\no_image.jpg";
                    if (System.IO.File.Exists(defaultPath))
                    {
                        pictureBox.Image = Image.FromFile(defaultPath);
                    }
                }
                catch { }
            }
        }

        private void POS_Admin_Load(object sender, EventArgs e)
        {
            try
            {
                picpathTxtbox1.Hide(); picpathTxtbox2.Hide(); picpathTxtbox3.Hide(); picpathTxtbox4.Hide();
                picpathTxtbox5.Hide(); picpathTxtbox6.Hide(); picpathTxtbox7.Hide(); picpathTxtbox8.Hide();
                picpathTxtbox9.Hide(); picpathTxtbox10.Hide(); picpathTxtbox11.Hide(); picpathTxtbox12.Hide();
                picpathTxtbox13.Hide(); picpathTxtbox14.Hide(); picpathTxtbox15.Hide(); picpathTxtbox16.Hide();
                picpathTxtbox17.Hide(); picpathTxtbox18.Hide(); picpathTxtbox19.Hide(); picpathTxtbox20.Hide();

                // Accessing the pos_dbconnection.cs class to connect the form to the database
                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                dataGridDisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "INSERT INTO pos_nameTbl (pos_id, name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, " +
                                        "name11, name12, name13, name14, name15, name16, name17, name18, name19, name20) VALUES ('" +
                                        pos_id_comboBox.Text + "', '" + nameTxtbox1.Text + "', '" + nameTxtbox2.Text + "', '" + nameTxtbox3.Text + "', '" +
                                        nameTxtbox4.Text + "', '" + nameTxtbox5.Text + "', '" + nameTxtbox6.Text + "', '" + nameTxtbox7.Text + "', '" +
                                        nameTxtbox8.Text + "', '" + nameTxtbox9.Text + "', '" + nameTxtbox10.Text + "', '" + nameTxtbox11.Text + "', '" +
                                        nameTxtbox12.Text + "', '" + nameTxtbox13.Text + "', '" + nameTxtbox14.Text + "', '" + nameTxtbox15.Text + "', '" +
                                        nameTxtbox16.Text + "', '" + nameTxtbox17.Text + "', '" + nameTxtbox18.Text + "', '" + nameTxtbox19.Text + "', '" +
                                        nameTxtbox20.Text + "')";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_sql = "INSERT INTO pos_priceTbl (price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, " +
                                        "price11, price12, price13, price14, price15, price16, price17, price18, price19, price20, pos_id) VALUES ('" +
                                        priceTxtbox1.Text + "', '" + priceTxtbox2.Text + "', '" + priceTxtbox3.Text + "', '" + priceTxtbox4.Text + "', '" +
                                        priceTxtbox5.Text + "', '" + priceTxtbox6.Text + "', '" + priceTxtbox7.Text + "', '" + priceTxtbox8.Text + "', '" +
                                        priceTxtbox9.Text + "', '" + priceTxtbox10.Text + "', '" + priceTxtbox11.Text + "', '" + priceTxtbox12.Text + "', '" +
                                        priceTxtbox13.Text + "', '" + priceTxtbox14.Text + "', '" + priceTxtbox15.Text + "', '" + priceTxtbox16.Text + "', '" +
                                        priceTxtbox17.Text + "', '" + priceTxtbox18.Text + "', '" + priceTxtbox19.Text + "', '" + priceTxtbox20.Text + "', '" +
                                        pos_id_comboBox.Text + "')";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_sql = "INSERT INTO pos_picTbl (pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, " + "pic14, " +
                    "pic15, pic16, pic17, pic18, pic19, pic20, pos_id) VALUES ('" + picpathTxtbox1.Text + "', '" + picpathTxtbox2.Text + "', '" + picpathTxtbox3.Text 
                    + "', '" + picpathTxtbox4.Text + "', '" + picpathTxtbox5.Text + "', '" + picpathTxtbox6.Text + "', '" + picpathTxtbox7.Text + "', '" 
                    + picpathTxtbox8.Text + "', '" + picpathTxtbox9.Text + "', '" + picpathTxtbox10.Text + "', '" + picpathTxtbox11.Text + "', '" + picpathTxtbox12.Text 
                    + "', '" + picpathTxtbox13.Text + "', '" + picpathTxtbox14.Text + "', '" + picpathTxtbox15.Text + "', '" + picpathTxtbox16.Text + "', '" 
                    + picpathTxtbox17.Text + "', '" + picpathTxtbox18.Text + "', '" + picpathTxtbox19.Text + "', '" + picpathTxtbox20.Text + "', '" 
                    + pos_id_comboBox.Text + "')";


                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                // Refresh dataset and clear form
                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                dataGridDisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void search_button_Click(object sender, EventArgs e)
        {
            cleartextboxes();
            try
            {
                posdb_connect.pos_sql = "SELECT * FROM pos_nameTbl " +
                    "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                    "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id " +
                    "WHERE pos_nameTbl.pos_id = '" + pos_id_comboBox.Text + "'";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                dataGridDisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];

                if (posdb_connect.pos_sql_dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No records found for the selected POS ID.");
                    return;
                }

                DataRow row = posdb_connect.pos_sql_dataset.Tables[0].Rows[0];

                // Load names using column names instead of indices
                nameTxtbox1.Text = row["name1"].ToString();
                nameTxtbox2.Text = row["name2"].ToString();
                nameTxtbox3.Text = row["name3"].ToString();
                nameTxtbox4.Text = row["name4"].ToString();
                nameTxtbox5.Text = row["name5"].ToString();
                nameTxtbox6.Text = row["name6"].ToString();
                nameTxtbox7.Text = row["name7"].ToString();
                nameTxtbox8.Text = row["name8"].ToString();
                nameTxtbox9.Text = row["name9"].ToString();
                nameTxtbox10.Text = row["name10"].ToString();
                nameTxtbox11.Text = row["name11"].ToString();
                nameTxtbox12.Text = row["name12"].ToString();
                nameTxtbox13.Text = row["name13"].ToString();
                nameTxtbox14.Text = row["name14"].ToString();
                nameTxtbox15.Text = row["name15"].ToString();
                nameTxtbox16.Text = row["name16"].ToString();
                nameTxtbox17.Text = row["name17"].ToString();
                nameTxtbox18.Text = row["name18"].ToString();
                nameTxtbox19.Text = row["name19"].ToString();
                nameTxtbox20.Text = row["name20"].ToString();

                // Load pictures with validation
                LoadPictureBox(pictureBox1, picpathTxtbox1, row["pic1"].ToString());
                LoadPictureBox(pictureBox2, picpathTxtbox2, row["pic2"].ToString());
                LoadPictureBox(pictureBox3, picpathTxtbox3, row["pic3"].ToString());
                LoadPictureBox(pictureBox4, picpathTxtbox4, row["pic4"].ToString());
                LoadPictureBox(pictureBox5, picpathTxtbox5, row["pic5"].ToString());
                LoadPictureBox(pictureBox6, picpathTxtbox6, row["pic6"].ToString());
                LoadPictureBox(pictureBox7, picpathTxtbox7, row["pic7"].ToString());
                LoadPictureBox(pictureBox8, picpathTxtbox8, row["pic8"].ToString());
                LoadPictureBox(pictureBox9, picpathTxtbox9, row["pic9"].ToString());
                LoadPictureBox(pictureBox10, picpathTxtbox10, row["pic10"].ToString());
                LoadPictureBox(pictureBox11, picpathTxtbox11, row["pic11"].ToString());
                LoadPictureBox(pictureBox12, picpathTxtbox12, row["pic12"].ToString());
                LoadPictureBox(pictureBox13, picpathTxtbox13, row["pic13"].ToString());
                LoadPictureBox(pictureBox14, picpathTxtbox14, row["pic14"].ToString());
                LoadPictureBox(pictureBox15, picpathTxtbox15, row["pic15"].ToString());
                LoadPictureBox(pictureBox16, picpathTxtbox16, row["pic16"].ToString());
                LoadPictureBox(pictureBox17, picpathTxtbox17, row["pic17"].ToString());
                LoadPictureBox(pictureBox18, picpathTxtbox18, row["pic18"].ToString());
                LoadPictureBox(pictureBox19, picpathTxtbox19, row["pic19"].ToString());
                LoadPictureBox(pictureBox20, picpathTxtbox20, row["pic20"].ToString());

                // Load prices using column names
                priceTxtbox1.Text = row["price1"].ToString();
                priceTxtbox2.Text = row["price2"].ToString();
                priceTxtbox3.Text = row["price3"].ToString();
                priceTxtbox4.Text = row["price4"].ToString();
                priceTxtbox5.Text = row["price5"].ToString();
                priceTxtbox6.Text = row["price6"].ToString();
                priceTxtbox7.Text = row["price7"].ToString();
                priceTxtbox8.Text = row["price8"].ToString();
                priceTxtbox9.Text = row["price9"].ToString();
                priceTxtbox10.Text = row["price10"].ToString();
                priceTxtbox11.Text = row["price11"].ToString();
                priceTxtbox12.Text = row["price12"].ToString();
                priceTxtbox13.Text = row["price13"].ToString();
                priceTxtbox14.Text = row["price14"].ToString();
                priceTxtbox15.Text = row["price15"].ToString();
                priceTxtbox16.Text = row["price16"].ToString();
                priceTxtbox17.Text = row["price17"].ToString();
                priceTxtbox18.Text = row["price18"].ToString();
                priceTxtbox19.Text = row["price19"].ToString();
                priceTxtbox20.Text = row["price20"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace);
            }
        }
        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql =
                    "UPDATE pos_nameTbl SET name1='" + nameTxtbox1.Text +
                    "', name2='" + nameTxtbox2.Text +
                    "', name3='" + nameTxtbox3.Text +
                    "', name4='" + nameTxtbox4.Text +
                    "', name5='" + nameTxtbox5.Text +
                    "', name6='" + nameTxtbox6.Text +
                    "', name7='" + nameTxtbox7.Text +
                    "', name8='" + nameTxtbox8.Text +
                    "', name9='" + nameTxtbox9.Text +
                    "', name10='" + nameTxtbox10.Text +
                    "', name11='" + nameTxtbox11.Text +
                    "', name12='" + nameTxtbox12.Text +
                    "', name13='" + nameTxtbox13.Text +
                    "', name14='" + nameTxtbox14.Text +
                    "', name15='" + nameTxtbox15.Text +
                    "', name16='" + nameTxtbox16.Text +
                    "', name17='" + nameTxtbox17.Text +
                    "', name18='" + nameTxtbox18.Text +
                    "', name19='" + nameTxtbox19.Text +
                    "', name20='" + nameTxtbox20.Text +
                    "' WHERE pos_id='" + pos_id_comboBox.Text + "'";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqldataadapterUpdate();

                posdb_connect.pos_sql = "UPDATE pos_picTbl SET pic1='" + 
                    picpathTxtbox1.Text + "', pic2='" + 
                    picpathTxtbox2.Text + "', pic3='" + 
                    picpathTxtbox3.Text + "', pic4='" + 
                    picpathTxtbox4.Text + "', pic5='" + 
                    picpathTxtbox5.Text + "', pic6='" + 
                    picpathTxtbox6.Text + "', pic7='" + 
                    picpathTxtbox7.Text + "', pic8='" + 
                    picpathTxtbox8.Text + "', pic9='" + 
                    picpathTxtbox9.Text + "', pic10='" + 
                    picpathTxtbox10.Text + "', pic11='" + 
                    picpathTxtbox11.Text + "', pic12='" + 
                    picpathTxtbox12.Text + "', pic13='" + 
                    picpathTxtbox13.Text + "', pic14='" + 
                    picpathTxtbox14.Text + "', pic15='" + 
                    picpathTxtbox15.Text + "', pic16='" + 
                    picpathTxtbox16.Text + "', pic17='" + 
                    picpathTxtbox17.Text + "', pic18='" + 
                    picpathTxtbox18.Text + "', pic19='" + 
                    picpathTxtbox19.Text + "', pic20='" + 
                    picpathTxtbox20.Text + "' WHERE pos_id='" + pos_id_comboBox.Text + "'";


                posdb_connect.pos_cmd();
                posdb_connect.pos_sqldataadapterUpdate();

                posdb_connect.pos_sql =
                    "UPDATE pos_priceTbl SET price1='" + priceTxtbox1.Text +
                    "', price2='" + priceTxtbox2.Text +
                    "', price3='" + priceTxtbox3.Text +
                    "', price4='" + priceTxtbox4.Text +
                    "', price5='" + priceTxtbox5.Text +
                    "', price6='" + priceTxtbox6.Text +
                    "', price7='" + priceTxtbox7.Text +
                    "', price8='" + priceTxtbox8.Text +
                    "', price9='" + priceTxtbox9.Text +
                    "', price10='" + priceTxtbox10.Text +
                    "', price11='" + priceTxtbox11.Text +
                    "', price12='" + priceTxtbox12.Text +
                    "', price13='" + priceTxtbox13.Text +
                    "', price14='" + priceTxtbox14.Text +
                    "', price15='" + priceTxtbox15.Text +
                    "', price16='" + priceTxtbox16.Text +
                    "', price17='" + priceTxtbox17.Text +
                    "', price18='" + priceTxtbox18.Text +
                    "', price19='" + priceTxtbox19.Text +
                    "', price20='" + priceTxtbox20.Text +
                    "' WHERE pos_id='" + pos_id_comboBox.Text + "'";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqldataadapterUpdate();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                dataGridDisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();
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
                posdb_connect.pos_sql = "DELETE FROM pos_priceTbl WHERE pos_priceTbl.pos_id='" + pos_id_comboBox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqldataadapterDelete();

                posdb_connect.pos_sql = "DELETE FROM pos_picTbl WHERE pos_picTbl.pos_id='" + pos_id_comboBox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqldataadapterDelete();

                posdb_connect.pos_sql = "DELETE FROM pos_nameTbl WHERE pos_nameTbl.pos_id='" + pos_id_comboBox.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqldataadapterDelete();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                dataGridDisplay.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void new_cancel_button_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);//inserting of selected image to the picturebox shown in the GUI interface
                picpath = openFileDialog1.FileName;//storing the file location of the selected image inserted in picturebox to a variable
                picpathTxtbox1.Text = picpath;//displaying the file location of the image stored in a variable to the textbox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox2.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox3.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox3.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox4.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox4.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox5.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox5.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox6.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox6.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox7.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox7.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox8.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox8.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox9.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox9.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox10.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox10.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox11.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox11.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox12.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox12.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox13.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox13.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox14.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox14.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox15.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox15.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox16.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox16.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox17.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox17.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox18.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox18.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox19.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox19.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox20.Image = Image.FromFile(openFileDialog1.FileName);
                picpath = openFileDialog1.FileName;
                picpathTxtbox20.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No image selected!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
