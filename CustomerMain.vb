Imports System.Data.SqlClient
Public Class CustomerMain
    Dim conn As SqlConnection = Database.GetConnection()
    Private Sub LoadCustomer()

        Dim sql As String =
        "SELECT customer_id,
                customer_name,
                customer_furigana
         FROM customer_information"

        Dim da As New SqlDataAdapter(sql, conn)

        Dim dt As New DataTable()

        da.Fill(dt)
        dgvCustomer.AutoGenerateColumns = False
        dgvCustomer.DataSource = dt


    End Sub
    Private Sub CustomerMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCustomer.EnableHeadersVisualStyles = False
        dgvCustomer.Font = New Font("Yu Gothic UI", 10)
        dgvCustomer.ColumnHeadersDefaultCellStyle.Font =
    New Font("Yu Gothic UI", 10, FontStyle.Bold)
        dgvCustomer.ColumnHeadersHeight = 35
        LoadCustomer()
    End Sub

    Private Sub btnSearch_Click(
    sender As Object,
    e As EventArgs) Handles btnSearch.Click

        Dim sql As String =
        "SELECT customer_id,
                customer_name,
                customer_furigana
         FROM customer_information
         WHERE customer_name LIKE @name"

        Dim da As New SqlDataAdapter(sql, conn)

        da.SelectCommand.Parameters.AddWithValue(
        "@name",
        "%" & txtSearch.Text.Trim() & "%"
    )

        Dim dt As New DataTable()

        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show(
            "該当する顧客が見つかりません。")
            Return
        End If
        dgvCustomer.DataSource = dt

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim frm As New C_details()
        frm.Show()
        Me.Hide()
    End Sub
    Private Sub OpenCustomerDetail()
        Dim frm As New C_details()

        frm.CustomerID =
        dgvCustomer.CurrentRow.Cells(0).Value.ToString()

        frm.Show()

        Me.Hide()

    End Sub

    Private Sub dgvCustomer_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellDoubleClick
        OpenCustomerDetail()
    End Sub

    Private Sub dgvCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCustomer.KeyDown
        OpenCustomerDetail()
    End Sub
End Class