using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using System.Data.SqlClient;

namespace Creator_Fabricator {
    public partial class Form1 : MaterialForm {
        public Form1() {
            InitializeComponent();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e) {

            string connectionString = textBoxDBConString.Text;
            var query = "CREATE DATABASE " + textBoxDBName.Text;
            var conn = new SqlConnection(connectionString);
            var command = new SqlCommand(query, conn);

            try {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Database is created successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            } finally {
                if ((conn.State == ConnectionState.Open)) {
                    conn.Close();
                }
            }

            connectionString = textBoxDBConString.Text;
            connectionString = connectionString.Replace("master", textBoxDBName.Text);

            query = textBoxDBCreation.Text;
            conn = new SqlConnection(connectionString);
            command = new SqlCommand(query, conn);

            try {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Tables created successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            } finally {
                if ((conn.State == ConnectionState.Open)) {
                    conn.Close();
                }
            }

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e) {
            string connectionString = textBoxDBFabConString.Text; ;
            var query = textBoxDBFabrication.Text;
            var conn = new SqlConnection(connectionString);
            var command = new SqlCommand(query, conn);

            try {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Database is fabricated successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            } finally {
                if ((conn.State == ConnectionState.Open)) {
                    conn.Close();
                }
            }
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e) {
            string connectionString = textBoxDWConString.Text; ;
            var query = "CREATE DATABASE " + textBoxDWName.Text;
            var conn = new SqlConnection(connectionString);
            var command = new SqlCommand(query, conn);

            try {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Database is created successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            } finally {
                if ((conn.State == ConnectionState.Open)) {
                    conn.Close();
                }
            }


            connectionString = textBoxDWConString.Text;
            connectionString = connectionString.Replace("master", textBoxDWName.Text);

            query = textBoxDWCreation.Text;
            conn = new SqlConnection(connectionString);
            command = new SqlCommand(query, conn);

            try {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Tables created successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            } finally {
                if ((conn.State == ConnectionState.Open)) {
                    conn.Close();
                }
            }



        }

        private void materialRaisedButton1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void DROPDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void DROPITToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            string connectionString = textBoxDBConString.Text;
            var query = "DROP DATABASE " + toolStripTextBoxDBName.Text;
            var conn = new SqlConnection(connectionString);
            var command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Database dropped successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if ((conn.State == ConnectionState.Open))
                {
                    conn.Close();
                }
            }

        }

        private void ToolStripMenuItemDWDropBtn_Click(object sender, EventArgs e)
        {

            string connectionString = textBoxDWConString.Text;
            var query = "DROP DATABASE " + toolStripTextBoxDWName.Text;
            var conn = new SqlConnection(connectionString);
            var command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Datawarehouse dropped successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if ((conn.State == ConnectionState.Open))
                {
                    conn.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBoxDBCreation.AcceptsReturn = true;
            textBoxDBCreation.MaxLength = 100000000;

            textBoxDWCreation.AcceptsReturn = true;
            textBoxDWCreation.MaxLength = 100000000;

            textBoxDBFabrication.AcceptsReturn = true;
            textBoxDBFabrication.MaxLength = 100000000;

        }
    }
}
