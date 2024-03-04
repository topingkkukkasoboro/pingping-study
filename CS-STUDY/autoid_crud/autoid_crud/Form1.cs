using autoid_crud.DB;
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

namespace autoid_crud
{
    
    public partial class Form1 : Form
    {
        private int autoid = 0;
        public Form1()
        {
            InitializeComponent();
            Select();
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Select(String searchtext = "")
        {
            try
            {
                MessageBox.Show(searchtext);
                CRUD.con.Open();

                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                String sql = "select * from tb_smart_crud where concat(firstname,lastname) like :searchtext order by autoid desc";

                String search = $"%{searchtext}%";

                OracleCommand oracleCommand = new OracleCommand(sql, CRUD.con);
                oracleCommand.Parameters.Add(":searchtext", OracleDbType.Varchar2).Value = search; // 파라미터 추가

                oracleDataAdapter.SelectCommand = oracleCommand;

                DataSet dataset = new DataSet();
                oracleDataAdapter.Fill(dataset);

                dataGridView1.DataSource = dataset.Tables[0];

                if (dataGridView1.Rows.Count > 0)
                {
                    this.autoid = int.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류가 발생했습니다: " + ex.Message);
            }
            finally
            {
                if (CRUD.con.State == ConnectionState.Open)
                    CRUD.con.Close();

                cleancontrol();
            }
        }

        private void cleancontrol()
        {
            FirstnameTextBox.Text = String.Empty;
            LastNameTextBox.Text = String.Empty;
            update.Text = "UPDATE";
            delete.Text = "Delete";
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FirstnameTextBox.Text.Trim()) || String.IsNullOrEmpty(LastNameTextBox.Text.Trim()))
            {
                MessageBox.Show("이름을 입력하세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            String gender = "남자";
            if (comboBox1.SelectedItem != null)
            {
                gender = comboBox1.SelectedItem.ToString();
            }

            String sql = "insert into tb_smart_crud " +
                $"values " +
                $"(tb_smart_seq.nextval," +
                $"'{FirstnameTextBox.Text}'," +
                $"'{LastNameTextBox.Text}'," +
                $"'{gender}')";

            CRUD.con.Open();
            CRUD.cmd = new OracleCommand(sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.ExecuteNonQuery();
            CRUD.con.Close();

            MessageBox.Show("저장완료");
            Select();
        }

        private void select_Click(object sender, EventArgs e)
        {
            if (searchtext.Text.Equals(""))
            {
                Select();
            }
            else
            {
                Select(searchtext.Text);
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("이리온나");

            this.autoid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());


            String firstname =(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            String lastname = (dataGridView1.CurrentRow.Cells[2].Value.ToString());
            String gender = (dataGridView1.CurrentRow.Cells[3].Value.ToString());

            FirstnameTextBox.Text = firstname;
            LastNameTextBox.Text = lastname;
            comboBox1.SelectedItem = gender;
        }
        #region update 버튼 누름
        private void update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FirstnameTextBox.Text.Trim()) || String.IsNullOrEmpty(LastNameTextBox.Text.Trim()))
            {
                MessageBox.Show("이름을 입력하세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            String gender = "남자";
            if (comboBox1.SelectedItem != null)
            {
                gender = comboBox1.SelectedItem.ToString();
            }

            string sql = $"update tb_smart_crud set firstname = :firstName, lastname = :lastName, gender = :gender where autoid = :autoid";

            CRUD.con.Open();
            CRUD.cmd = new OracleCommand(sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.Add(":firstName", FirstnameTextBox.Text);
            CRUD.cmd.Parameters.Add(":lastName",LastNameTextBox.Text);
            CRUD.cmd.Parameters.Add(":gender", gender);
            CRUD.cmd.Parameters.Add(":autoid",this.autoid);

            CRUD.cmd.ExecuteNonQuery();
            CRUD.con.Close();

            MessageBox.Show("저장완료");
            Select();
        }

        #endregion

        #region delete 버튼 누름
        private void delete_Click(object sender, EventArgs e)
        {
            if(autoid == 0)
            {
                MessageBox.Show("삭제하는 행을 선택해주세요");
                return;
            }
            String sql = $"delete tb_smart_crud where autoid = :autoid";

            CRUD.con.Open();
            CRUD.cmd = new OracleCommand(sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.Add(":autoid",this.autoid);
            CRUD.cmd.ExecuteNonQuery();
            CRUD.con.Close();

            MessageBox.Show("삭제되었습니다");
            Select();
        }
        #endregion
    }
}
