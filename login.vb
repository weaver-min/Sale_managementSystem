Imports System.Data.SqlClient
Public Class login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim conn As SqlConnection = Database.GetConnection()

        Try
            conn.Open()

            Dim query As String =
                "SELECT COUNT(*) FROM user_information WHERE　login_id=@userid AND login_password=@password"

            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@userid", txtUserName.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)

            Dim count As Integer = CInt(cmd.ExecuteScalar())

            If count > 0 Then
                Dim frm As New main_menu()
                frm.Show()

                Me.Hide()
            Else
                MessageBox.Show("ユーザーID　と　パスワードが正しくありません。")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Close()
        End Try

    End Sub
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserName.Text = "ユーザーID"
        txtUserName.ForeColor = Color.DarkGray

        txtPassword.Text = "パスワード"
        txtPassword.ForeColor = Color.DarkGray
    End Sub


    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles txtUserName.GotFocus
        If txtUserName.Text = "ユーザーID" Then
            txtUserName.Text = ""
            txtUserName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUserName_LostFocus(sender As Object, e As EventArgs) Handles txtUserName.LostFocus
        If txtUserName.Text = "" Then
            txtUserName.Text = "ユーザーID"
            txtUserName.ForeColor = Color.DarkGray

        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "パスワード" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "*"
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = "パスワード"
            txtPassword.ForeColor = Color.DarkGray
        End If
    End Sub
End Class