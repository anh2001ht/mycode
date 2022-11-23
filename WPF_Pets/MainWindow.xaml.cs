using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace WPF_Pets
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable table = new DataTable("Table1");
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataSet dataset = new DataSet();
        public MainWindow()
        {
            InitAdapter();
            InitializeComponent();
        }
        void InitAdapter()
        {
            string sqlStringConnection =
                "Data Source = localhost,1433; Database=PetWpf; UID=sa; PWD=01012001";
            conn = new SqlConnection(sqlStringConnection);
            conn.Open();
            adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "Table1");
            //select
            adapter.SelectCommand = new SqlCommand("Select Id,Type,Height,Weight,Color from Table1", conn);
            //insert
            adapter.InsertCommand = new SqlCommand("Insert into Table1 (Id,Type,Height,Weight,Color) values(@Id,@Type,@Height,@Weight,@Color)", conn);
            adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 8, "Id");
            adapter.InsertCommand.Parameters.Add("@Type", SqlDbType.NVarChar, 255, "Type");
            adapter.InsertCommand.Parameters.Add("@Height", SqlDbType.Int, 8, "Height");
            adapter.InsertCommand.Parameters.Add("@Weight", SqlDbType.Int, 8, "Weight");
            adapter.InsertCommand.Parameters.Add("@Color", SqlDbType.NVarChar, 255, "Color");
            //delete
            adapter.DeleteCommand = new SqlCommand("Delete from Table1 where Id= @Id", conn);
            var prdel = adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            prdel.SourceColumn = "Id";


            //update
            adapter.UpdateCommand = new SqlCommand("Update Table1 Set " +
                "Id=@Id, Type=@Type, Height=@Height, Weight=@Weight, Color=@Color where Id= @Id", conn);
            //var prup = adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            //prup.SourceColumn = "Id";
            //prup.SourceVersion = DataRowVersion.Original;
            adapter.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int, 8, "Id");
            adapter.UpdateCommand.Parameters.Add("@Type", SqlDbType.NVarChar, 255, "Type");
            adapter.UpdateCommand.Parameters.Add("@Height", SqlDbType.Int, 8, "Height");
            adapter.UpdateCommand.Parameters.Add("@Weight", SqlDbType.Int, 8, "Weight");
            adapter.UpdateCommand.Parameters.Add("@Color", SqlDbType.NVarChar, 255, "Color");
            dataset.Tables.Add(table);
            conn.Close();
        }
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            LoadDataTable();
            datagrid.DataContext = table.DefaultView;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            adapter.Update(dataset);
            table.Rows.Clear();
            adapter.Fill(dataset);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedItem = (DataRowView)datagrid.SelectedValue;
            if (selectedItem != null)
            {
                selectedItem.Delete();
            }
        }
        void LoadDataTable()
        {
            table.Rows.Clear();
            adapter.Fill(dataset);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataTable();
            datagrid.DataContext = table.DefaultView;
        }
        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Adding addFrm = new Adding();
            addFrm.Show();
        }
    }
}
