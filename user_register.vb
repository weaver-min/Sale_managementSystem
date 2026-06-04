Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class user_register
    Private Sub user_register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCompanyInfo()
        LoadUserInfo()

    End Sub
    Private Sub LoadCompanyInfo()
        Using conn As SqlConnection = Database.GetConnection()
            Dim query As String = " SELECT * FROM company_information"
            Dim cmd As New SqlCommand(query, conn)
            conn.Open()
            Dim dir As SqlDataReader = cmd.ExecuteReader()

            If dir.Read() Then
                txtCompanyName.Text = dir("company_name").ToString()
                txtAddress.Text = dir("company_address").ToString()
                txtPhNo.Text = dir("company_phone").ToString()
                txtBankName.Text = dir("company_bank").ToString()
                txtBankNo.Text = dir("company_AccountData").ToString()
                txtTax.Text = dir("tax").ToString()

            End If
        End Using

    End Sub

    Private Sub LoadUserInfo()

        Dim sql As String = "SELECT * FROM user_information"

        Using conn As SqlConnection = Database.GetConnection()

            Dim cmd As New SqlCommand(sql, conn)

            conn.Open()

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then

                txtUserId.Text = dr("login_id").ToString()

                ' Password hidden
                txtPassword.Text = dr("login_password").ToString()
                txtPassword.UseSystemPasswordChar = True

            End If

        End Using

    End Sub

    Private Sub txtTax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTax.KeyPress

        If Not Char.IsControl(e.KeyChar) And
       Not Char.IsDigit(e.KeyChar) Then
            MessageBox.Show("数値のみ入力可能です。")
            e.Handled = True

        End If

    End Sub

    Private Sub txtUserId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserId.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And
        Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("アルファベットか数字のみ入力可能です。")
            e.Handled = True

        End If
    End Sub
End Class