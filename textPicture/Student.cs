﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace textPicture
{
    internal class Student
    {

        #region CheckValue
        private static bool verif(string iD, string firstName, string lastName, string birthDate, string phone, string address)
        {
            if (iD.Trim() == "" || firstName.Trim() == "" || lastName.Trim() == "" 
                || address.Trim() == "")
            {
                MessageBox.Show("Please enter vaild value");
                return false;
            }
            else
            {
                if (containInt(firstName) || containInt(lastName))
                {
                    MessageBox.Show("Dont enter number in name");
                    return false;
                }
                else if (containChar(phone) == false)
                {
                    MessageBox.Show("Dont enter char in phone number");
                    return false;
                }
            }
            return true;
        }

        private static bool containInt(string name)
        {
            return name.Any(char.IsDigit);
        }

        private static bool containChar(string name)
        {
            return name.All(char.IsDigit);
        }
        #endregion CheckValue
        #region WorkWithData
        public static bool deleteStudent(string id)
        {
            MyDB sqlCon = new MyDB();
            SqlCommand sqlCmd = new SqlCommand("delete from STUDENTDETAIL where StudentID = @id", sqlCon.SqlCon);
            sqlCmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            sqlCon.OpenConnection();
            if (sqlCmd.ExecuteNonQuery() == 1)
            {
                sqlCon.CloseConnection();
                return true;
            }
            else
            {
                sqlCon.CloseConnection();
                return false;
            }
        }

        public static bool updateStudent(string ID, string FirstName, string LastName, string BirthDate, string Gender, string Phone,
            string Address, MemoryStream pic)
        {
            if (!verif(ID, FirstName, LastName, BirthDate, Phone, Address))
            {
                return false;
            }
            else
            {
                MyDB sqlCon = new MyDB();
                string query = "update STUDENTDETAIL set FirstName = @fname, LastName = @lname, BirthDate = @bdate, Sex = @gender," +
                    "Phone = @phone, Address = @ad, Face = @face where StudentID = @id";
                SqlCommand sqlCommand = new SqlCommand(query, sqlCon.SqlCon);

                sqlCommand.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
                sqlCommand.Parameters.Add("@fname", SqlDbType.NVarChar).Value = FirstName;
                sqlCommand.Parameters.Add("@lname", SqlDbType.NVarChar).Value = LastName;
                sqlCommand.Parameters.Add("@bdate", SqlDbType.DateTime).Value = BirthDate;
                sqlCommand.Parameters.Add("@gender", SqlDbType.NVarChar).Value = Gender;
                sqlCommand.Parameters.Add("@phone", SqlDbType.VarChar).Value = Phone;
                sqlCommand.Parameters.Add("@ad", SqlDbType.NVarChar).Value = Address;
                sqlCommand.Parameters.Add("@face", SqlDbType.Image).Value = pic.ToArray();
                sqlCon.OpenConnection();
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    sqlCon.CloseConnection();
                    return true;
                }
                else
                {
                    sqlCon.CloseConnection();
                    MessageBox.Show("Update fail");
                    return false;
                }
            }
        }
        public static void InsertStudent(string ID, string FirstName, string LastName, string BirthDate, string Gender, string Phone,
            string Address, MemoryStream pic)
        {
            if (!verif(ID, FirstName, LastName, BirthDate, Phone, Address))
            {
                return;
            }


            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "insert into StudentDetail values(@ID, @FirstName," +
                "@LastName, @BirthDate, @Gender, @Phone, @Address, @Image)";

            sqlCmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Char)).Value = ID;
            sqlCmd.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.Char)).Value = FirstName;
            sqlCmd.Parameters.Add(new SqlParameter("@LastName", SqlDbType.Char)).Value = LastName;
            sqlCmd.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date)).Value = BirthDate;
            sqlCmd.Parameters.Add(new SqlParameter("@Gender", SqlDbType.Char)).Value = Gender;
            sqlCmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.Char)).Value = Phone;
            sqlCmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar)).Value = Address;
            sqlCmd.Parameters.Add(new SqlParameter("@Image", SqlDbType.Image)).Value = pic.ToArray();

            MyDB sqlCon = new MyDB();
            sqlCon.OpenConnection();
            sqlCmd.Connection = sqlCon.SqlCon;
            int k = sqlCmd.ExecuteNonQuery();
            if (k > 0)
            {
                MessageBox.Show("Successfully Added");
            }
            else
            {
                MessageBox.Show("Fail Added");
            }
            sqlCon.CloseConnection();
        }
        #endregion WorkWithData
    }
}
