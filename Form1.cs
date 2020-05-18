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

namespace QuanLyBanHang
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-C00IDIB\SQLEXPRESS;Initial Catalog=QuanLy;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable chatlieu = new DataTable();
        private void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM tblChatLieu";
            adapter.SelectCommand = command;
            chatlieu.Clear();
            adapter.Fill(chatlieu);
            dataGridView1.DataSource = chatlieu;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            tbMaChatLieu.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tbTenChatLieu.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private void bnThem_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO tblChatLieu (MaChatLieu, TenChatLieu) VALUES ('"+tbMaChatLieu.Text+"', '"+tbTenChatLieu.Text+"')";
            command.ExecuteNonQuery();
            loaddata();
            connection.Close();
        }

        private void bnXoa_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM tblChatLieu WHERE MaChatLieu = '" + tbMaChatLieu.Text + "' OR TenChatLieu = '" + tbTenChatLieu.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            connection.Close();
        }

        private void bnSua_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "UPDATE tblChatLieu SET TenChatLieu = '" + tbTenChatLieu.Text + "' WHERE MaChatLieu = '"+tbMaChatLieu.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
            connection.Close();
        }

        private void bnTK_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM tblChatLieu WHERE MaChatLieu = '" + tbMaChatLieu.Text + "' OR TenChatLieu = '" + tbTenChatLieu.Text + "'";
            adapter.SelectCommand = command;
            chatlieu.Clear();
            adapter.Fill(chatlieu);
            dataGridView1.DataSource = chatlieu;
            connection.Close();
        }

        private void bnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
