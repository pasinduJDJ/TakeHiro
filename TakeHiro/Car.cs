using MySql.Data.MySqlClient;
using System.Data;

public class Car
{
    // Properties representing the car's attributes
    public int CarID { get; set; }
    public string Model { get; set; } = string.Empty;
    public string PlateNumber { get; set; } = string.Empty;
    public bool Availability { get; set; }

    // Connection string to connect to the MySQL database
    private string _connectionString;

    // Constructor to initialize the connection string
    public Car(string connectionString)
    {
        _connectionString = connectionString;
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(_connectionString);
    }
    // Method to save a new car to the database
    public void SaveCar()
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "INSERT INTO Car (Model, PlateNumber, Availability) VALUES (@Model, @PlateNumber, @Availability)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Model", Model);
            cmd.Parameters.AddWithValue("@PlateNumber", PlateNumber);
            cmd.Parameters.AddWithValue("@Availability", Availability);
            cmd.ExecuteNonQuery();
        }
    }
    // Method to get all cars from the database
    public DataTable GetAllCars()
    {
        DataTable dt = new DataTable();
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM Car";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            da.Fill(dt);
        }
        return dt;
    }
    // Method to get all available cars from the database
    public DataTable GetAvailableCars()
    {
        DataTable dtC = new DataTable();
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM Car WHERE Availability = 1";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dtC);
        }
        return dtC;
    }
    // Method to get the count of available cars in the database
    public int GetAvailabelCarCount()
    {
        int count = 0;
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM Car WHERE Availability = 1";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            count = Convert.ToInt32(cmd.ExecuteScalar());
        }
        return count;
    }
    // Method to get the total count of cars in the database
    public int GetCountAllCars()
    {
        int count = 0;
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM Car";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            count = Convert.ToInt32(cmd.ExecuteScalar());
        }
        return count;
    }
    // Method to update car details in the database
    public void UpdateCar()
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "UPDATE Car SET Model = @Model, PlateNumber = @PlateNumber, Availability = @Availability WHERE CarID = @CarID";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CarID", CarID);
            cmd.Parameters.AddWithValue("@Model", Model);
            cmd.Parameters.AddWithValue("@PlateNumber", PlateNumber);
            cmd.Parameters.AddWithValue("@Availability", Availability);
            cmd.ExecuteNonQuery();
        }
    }
    // Overloaded method to update car availability in the database
    public void UpdateCar(int carId, bool availability)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "UPDATE Car SET Availability = @Availability WHERE CarID = @CarID";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CarID", carId);
            cmd.Parameters.AddWithValue("@Availability", availability);

            cmd.ExecuteNonQuery();
        }
    }
    // Method to delete a car from the database
    public void DeleteCar(int carId)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "DELETE FROM Car WHERE CarID = @CarID";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CarID", carId);
            cmd.ExecuteNonQuery();
        }
    }
}
