using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stand_code
{
    static class Program
    {
        public static string log_id = "";
        public static string UserID = "p7g9";
        public static string Password = "Vermelho1423!";
        public static string DataSource = "tcp:mednat.ieeta.pt\\SQLSERVER,8101";
        public static string InitialCatalog = "p7g9";
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
