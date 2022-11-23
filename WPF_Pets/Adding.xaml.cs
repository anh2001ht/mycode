using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Pets
{
    /// <summary>
    /// Interaction logic for Adding.xaml
    /// </summary>
    public partial class Adding : Window
    {
        public Adding()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string typeSelected = ((ComboBoxItem)typeCbx.SelectedItem).Content.ToString();

            SqlConnection conn;

            string sqlStringConnection =
                 "Data Source = localhost,1433; Database=PetWpf; UID=sa; PWD=01012001";
            conn = new SqlConnection(sqlStringConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "Insert into Table1 (Id,Type,Height,Weight,Color) values(@Id,@Type,@Height,@Weight,@Color)";
            cmd.Parameters.AddWithValue("@Id", TextBoxId.Text);
            cmd.Parameters.AddWithValue("@Type", typeSelected);
            cmd.Parameters.AddWithValue("@Height", TextBoxHeight.Text);
            cmd.Parameters.AddWithValue("@Weight", TextBoxWeight.Text);
            cmd.Parameters.AddWithValue("@Color", TextBoxColor.Text);
            cmd.Connection = conn;
            int temp = cmd.ExecuteNonQuery();
            if (temp==1)
            {
                MessageBox.Show("Add successfully");
            }
            
            conn.Close();
        }
    }
}
