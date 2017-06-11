Imports Quan_Ly_Nhan_Su.Connect
Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If OK.Text = "&OK" Then
            Dim str As String
            Dim kt As Integer
            str = "Data Source=(localdb)\Projects;Initial Catalog=Nhanvien;Integrated Security=True"
            Tao_ket_noi(str)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim check As New SqlClient.SqlCommand("Select count(*) from usernv where username=@user and pass=@pass", con)
            check.Parameters.AddWithValue("@user", UsernameTextBox.Text)
            check.Parameters.AddWithValue("@pass", PasswordTextBox.Text)
            kt = check.ExecuteScalar()
            If kt = 1 Then
                MsgBox(" success")
                Dim f As New frmMain
                f.Show()
                Me.Hide()
            Else : MsgBox("Fail")
                UsernameTextBox.Focus()
            End If
        Else : Dim mail As New MailMessage()
            mail.From = New MailAddress("nhomavidai1@gmail.com")
            mail.To.Add(PasswordTextBox.Text)
            mail.Subject = "test mail"
            mail.Body = "Hello!"
            'Dim mail As New MailMessage("nhomavidai@gmail.com.vn", "nhomavidai1@gmail.com.vn", "test mail", "Day la email tao test")
            'Dim mailfile As New Attachment("E:\truyen\photo.jpg")
            '  mail.Attachments.Add(mailfile)
            Dim smtp As New SmtpClient
            smtp.Host = "smtp.gmail.com"
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New Net.NetworkCredential("nhomavidai1@gmail.com", "anhtruog")
            Try
                smtp.Send(mail)
                MsgBox("thanh cong")
            Catch ex As Exception
                MsgBox("fail")
            End Try
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else : PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        PasswordLabel.Text = "Email:"
        OK.Text = "Send"
        CheckBox1.Enabled = False
        Label1.Enabled = False
        PasswordTextBox.UseSystemPasswordChar = False
    End Sub

  

    Private Sub Label1_Move(sender As Object, e As EventArgs) Handles Label1.Move

    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove

        Label1.ForeColor = Color.Red
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
