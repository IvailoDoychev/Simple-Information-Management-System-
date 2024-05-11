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
using System.Configuration;
using System.IO;
using CinemaTicketSystem;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly int yourReserveButtonColumnIndex = 5;  

        private void LoadScreenings(string genre = null, DateTime? time = null, string hall = null)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cinema"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                StringBuilder query = new StringBuilder("SELECT ScreeningID, FilmTitle, Genre, ScreeningTime, CinemaHall, AvailableSeats FROM Screenings WHERE 1=1");

                // Add conditions based on the filters
                if (!string.IsNullOrEmpty(genre))
                {
                    query.Append(" AND Genre = @Genre");
                    cmd.Parameters.AddWithValue("@Genre", genre);
                }
                if (time != null)
                {
                    query.Append(" AND CONVERT(DATE, ScreeningTime) = @ScreeningTime");
                    cmd.Parameters.AddWithValue("@ScreeningTime", time.Value.Date);
                }
                if (!string.IsNullOrEmpty(hall))
                {
                    query.Append(" AND CinemaHall = @CinemaHall");
                    cmd.Parameters.AddWithValue("@CinemaHall", hall);
                }

                cmd.CommandText = query.ToString();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgScreenings.DataSource = table;
            }
        }

        private void LoadGenres()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Cinema"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT Genre FROM Screenings ORDER BY Genre", con);
                SqlDataReader reader = cmd.ExecuteReader();
                cmbGenre.Items.Clear();  // Clear existing items to avoid duplication
                while (reader.Read())
                {
                    cmbGenre.Items.Add(reader["Genre"].ToString());
                }
                reader.Close();
            }
        }


        private void LoadCinemaHalls()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Cinema"].ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT DISTINCT CinemaHall FROM Screenings ORDER BY CinemaHall", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbCinemaHall.Items.Add(reader["CinemaHall"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading cinema halls: " + ex.Message);
                }
            }
        }
        private void InitializeDateTimePicker()
        {
            dtpScreeningTime.Format = DateTimePickerFormat.Custom;
            dtpScreeningTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpScreeningTime.Value = DateTime.Now; 
        }
        
        private void dgScreenings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == yourReserveButtonColumnIndex && e.RowIndex >= 0) // Ensure the click is not on the header row
            {
                var row = dgScreenings.Rows[e.RowIndex];
                string filmTitle = Convert.ToString(row.Cells["FilmTitle"].Value);
                DateTime screeningTime = Convert.ToDateTime(row.Cells["ScreeningTime"].Value);
                int availableSeats = Convert.ToInt32(row.Cells["AvailableSeats"].Value);
                int screeningID = Convert.ToInt32(row.Cells["ScreeningID"].Value);

                ReservationForm reservationForm = new ReservationForm(filmTitle, screeningTime, availableSeats, screeningID);
                reservationForm.ShowDialog(); 
            }
        }



        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedGenre = cmbGenre.SelectedItem?.ToString();
            DateTime? selectedTime = (dtpScreeningTime.Value.Date != DateTime.Now.Date) ? dtpScreeningTime.Value.Date : (DateTime?)null;
            string selectedHall = cmbCinemaHall.SelectedItem?.ToString();

            LoadScreenings(selectedGenre, selectedTime, selectedHall);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadScreenings();
            LoadGenres();
            LoadCinemaHalls();
        }


        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}