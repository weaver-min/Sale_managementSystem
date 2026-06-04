Imports System.Data.SqlClient

Public Class C_details
    Public CustomerID As String
    Dim conn As SqlConnection = Database.GetConnection()

    Private Sub C_details_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        CustomerMain.Show()
    End Sub

    Private Sub C_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCustomerDetails.EnableHeadersVisualStyles = False
        dgvCustomerDetails.Font = New Font("Yu Gothic UI", 10)
        dgvCustomerDetails.ColumnHeadersDefaultCellStyle.Font =
    New Font("Yu Gothic UI", 10, FontStyle.Bold)
        dgvCustomerDetails.ColumnHeadersHeight = 35

        Dim sql As String =
            "SELECT customer_id,
                customer_name,
                customer_furigana,
                customer_address
         FROM customer_information
         WHERE customer_id = @id"

        Dim da As New SqlDataAdapter(sql, conn)

        da.SelectCommand.Parameters.AddWithValue(
            "@id", CustomerID)

        Dim dt As New DataTable

        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            txtCustomerId.Text =
                dt.Rows(0)("customer_id").ToString()

            txtCustomerName.Text =
                dt.Rows(0)("customer_name").ToString()

            txtFurigana.Text =
                dt.Rows(0)("customer_furigana").ToString()

            txtAddress.Text =
                dt.Rows(0)("customer_address").ToString()

        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim sql As String =
            "UPDATE customer_information
            SET customer_name = @name,
                customer__furigana = @furigana,
                customer_address = @address
               WHERE customer_information"

        Using cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@name", txtCustomerName.Text)
            cmd.Parameters.AddWithValue("@furigana", txtFurigana.Text)
            cmd.Parameters.AddWithValue("@address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@id", txtCustomerId.Text)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

        End Using

        MessageBox.Show("更新しました。")
    End Sub
End Class