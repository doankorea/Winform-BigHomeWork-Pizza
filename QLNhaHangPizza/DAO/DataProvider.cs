using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace QLNhaHangPizza.DAO
{

	internal class DataProvider
    {
        string strConnect = "Data Source=EL\\DOANKOREA;Initial Catalog=QLyNhaHangPizza3;User ID=sa;Password=123";
        //SqlConnection sqlConnect = null;
		
		public DataTable DocBang(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(strConnect))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

		public int CapNhatDuLieu(string query, Hashtable parameters = null)
		{
			int data = 0;

			using (SqlConnection connection = new SqlConnection(strConnect))
			{
				connection.Open();

				SqlCommand command = new SqlCommand(query, connection);

				if (parameters != null)
				{
					foreach (DictionaryEntry parameter in parameters)
					{
						command.Parameters.AddWithValue(parameter.Key.ToString(), parameter.Value);
					}
				}

				data = command.ExecuteNonQuery();

				connection.Close();
			}

			return data;
		}

		public object ExecuteScalar(string query, Hashtable parameters = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(strConnect))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameters != null)
                {
                    foreach (DictionaryEntry parameter in parameters)
                    {
                        string paramName = parameter.Key.ToString();
                        object paramValue = parameter.Value;
                        command.Parameters.AddWithValue(paramName, paramValue);
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }  
        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.ShowInTaskbar = false;
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();
            }
        }
}
}
