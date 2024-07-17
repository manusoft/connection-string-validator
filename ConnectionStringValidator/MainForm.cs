using System.Data.SqlClient;

namespace ConnectionStringValidator;

// Certificate password : @lconsoft
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void buttonCheck_Click(object sender, EventArgs e)
    {
        string connStr = textBox.Text.Trim();

        if (string.IsNullOrEmpty(connStr))
        {
            MessageBox.Show("Please enter a connection string to continue!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
