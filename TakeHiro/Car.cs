using MySql.Data.MySqlClient;
using System.Data;

public class Car
{
    public int CarID { get; set; }
    public string Model { get; set; } = string.Empty;
    public string PlateNumber { get; set; } = string.Empty;
    public bool Availability { get; set; }

    private string _connectionString;

    public Car(string connectionString)
    {
        _connectionString = connectionString;
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(_connectionString);
    }

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

    public void UpdateCar(int carId, string model, string plateNumber, bool availability)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "UPDATE Car SET Model = @Model, PlateNumber = @PlateNumber, Availability = @Availability WHERE CarID = @CarID";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CarID", carId);
            cmd.Parameters.AddWithValue("@Model", model);
            cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
            cmd.Parameters.AddWithValue("@Availability", availability);
            cmd.ExecuteNonQuery();
        }
    }

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
