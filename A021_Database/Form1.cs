using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace A021_Database
{
  public partial class Form1 : Form
  {
    OleDbConnection conn = null;
    OleDbCommand comm = null;
    OleDbDataReader reader = null;

    string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\konyang\Documents\bikang\비주얼\Visual01\A021_Database\Students.accdb;Persist Security Info=True";

    public Form1()
    {
      InitializeComponent();
      DisplayStudents();
    }

    private void DisplayStudents()
    {
      // 연결
      if (conn == null)
      {
        conn = new OleDbConnection(connStr);
        conn.Open();
      }

      // 명령어 만들기
      string sql = "SELECT * FROM StudentTable";
      comm = new OleDbCommand(sql, conn);

      // 명령어 실행
      reader = comm.ExecuteReader();

      while(reader.Read())  // 레코드 단위로 읽는다
      {
        string x = "";
        x += reader["ID"] + "\t";
        x += reader["SId"] + "\t";
        x += reader["SName"] + "\t";
        x += reader["Phone"];

        listBox1.Items.Add(x);
      }

      reader.Close();
      conn.Close();
      conn = null;
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
      if (txtSName.Text == "" || txtPhone.Text == "" || txtSId.Text == "")
        return;

      ConnectionOpen();

      string sql = string.Format("insert into " +
         "StudentTable(SId, SName, Phone) VALUES({0}, '{1}', '{2}')",
         txtSId.Text, txtSName.Text, txtPhone.Text);

      comm = new OleDbCommand(sql, conn);
      if (comm.ExecuteNonQuery() == 1)
        MessageBox.Show("삽입성공!");

      ConnectionClose();
      listBox1.Items.Clear();
      DisplayStudents();
    }

    private void ConnectionOpen()
    {
      if (conn == null)
      {
        conn = new OleDbConnection(connStr);
        conn.Open();
      }
    }

    private void ConnectionClose()
    {
      conn.Close();
      conn = null;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      ConnectionOpen();

      string sql = string.Format("DELETE FROM StudentTable WHERE ID={0}",
          txtID.Text);

      comm = new OleDbCommand(sql, conn);
      if (comm.ExecuteNonQuery() == 1)
        MessageBox.Show("삭제성공!");

      ConnectionClose();
      listBox1.Items.Clear();
      DisplayStudents();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListBox lb = sender as ListBox;

      if (lb.SelectedItem == null)
        return;

      string[] s = lb.SelectedItem.ToString().Split('\t');
      txtID.Text = s[0];
      txtSId.Text = s[1];
      txtSName.Text = s[2];
      txtPhone.Text = s[3];
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      ConnectionOpen();

      string sql = string.Format("UPDATE StudentTable SET SID={0},"+ 
        "SName = '{1}', Phone = '{2}' WHERE ID ={3}",
        txtSId.Text, txtSName.Text, txtPhone.Text, txtID.Text);
      comm = new OleDbCommand(sql, conn);
      if (comm.ExecuteNonQuery() == 1)
        MessageBox.Show("수정 성공!");

      ConnectionClose();
      listBox1.Items.Clear();
      DisplayStudents();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtID.Text = "";
      txtSName.Text = "";
      txtPhone.Text = "";
      txtSId.Text = "";
    }

    private void btnViewAll_Click(object sender, EventArgs e)
    {
      listBox1.Items.Clear();
      DisplayStudents();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      if (txtSName.Text == "" && txtPhone.Text == "" && txtSId.Text == "")
        return;

      ConnectionOpen();

      string sql = "";
      if (txtSId.Text != "")
        sql = string.Format("SELECT * FROM StudentTable WHERE SID={0}",
            txtSId.Text);
      else if (txtSName.Text != "")
        sql = string.Format(
            "SELECT * FROM StudentTable WHERE SName='{0}'", txtSName.Text);
      else if (txtPhone.Text != "")
        sql = string.Format(
            "SELECT * FROM StudentTable WHERE Phone='{0}'", txtPhone.Text);

      listBox1.Items.Clear();
      comm = new OleDbCommand(sql, conn);
      ReadAndAddToListBox();
      ConnectionClose();
    }

    private void ReadAndAddToListBox()
    {
      reader = comm.ExecuteReader();
      while (reader.Read())
      {
        string x = "";
        x += reader["ID"] + "\t";
        x += reader["SID"] + "\t";
        x += reader["SName"] + "\t";
        x += reader["Phone"];
        listBox1.Items.Add(x);
      }
      reader.Close();
    }
  }
}
