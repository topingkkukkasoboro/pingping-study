using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class AA
    {
        public String NAME  { get; set; }
        public double CNT { get; set; }
    }
    public partial class Form1 : Form
    {
        List<AA>AAList = new List<AA>();

        string connectionString =
            "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=HR;Password=1234;";
        public Form1()
        {
            InitializeComponent();
            select();
            MakeLabels();

        }
        public void MakeLabels()
        {
            int y = 10;
            foreach (AA aa in AAList)
            {
                Label label1 = new Label();
                label1.AutoSize = true;
                label1.Location = new Point(10, y);
                label1.TabIndex = 0;
                label1.Text = aa.NAME;
                label1.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point, 129);
                this.Controls.Add(label1);


                Label label2 = new Label();
                label2.AutoSize = true;
                label2.Location = new Point(150, y);
                label2.TabIndex = 0;
                label2.Text = aa.CNT + "";
                label2.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point, 129);
                this.Controls.Add(label2);
                y += 40;

            }
        }
        public void select()
        {
            AAList.Clear();
            OracleConnection con = new OracleConnection(connectionString);
            con.Open();

            String sql = "select * from AA";
            OracleCommand cmd = new OracleCommand(sql, con);
            OracleDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                AAList.Add(new AA() { NAME = rdr.GetString(0), CNT = rdr.GetDouble(1) });
            }
            rdr.Close();
            con.Close();
        }
    }
}
