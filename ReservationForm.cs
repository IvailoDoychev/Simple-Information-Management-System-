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

namespace CinemaTicketSystem
{
    public partial class ReservationForm : Form
    {
        private string filmTitle;
        private DateTime screeningTime;
        private int availableSeats;
        private int screeningID;

        public ReservationForm(string filmTitle, DateTime screeningTime, int availableSeats, int screeningID)
        {
            InitializeComponent();
            this.filmTitle = filmTitle;
            this.screeningTime = screeningTime;
            this.availableSeats = availableSeats;
            this.screeningID = screeningID;

            // Display the screening details
            lblFilmTitle.Text = filmTitle;
            lblScreeningTime.Text = screeningTime.ToString("g");  // General date/time pattern
            lblAvailableSeats.Text = availableSeats.ToString();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            int numTickets = (int)numericUpDownTickets.Value;
            if (numTickets > 0 && numTickets <= availableSeats)
            {
                // Database update logic here
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Cinema"].ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Screenings SET AvailableSeats = AvailableSeats - @numTickets WHERE ScreeningID = @ScreeningID AND AvailableSeats >= @numTickets", con);
                    cmd.Parameters.AddWithValue("@numTickets", numTickets);
                    cmd.Parameters.AddWithValue("@ScreeningID", screeningID);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Reservation successful!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to reserve tickets.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid number of tickets selected.");
            }
        }
    }
}
