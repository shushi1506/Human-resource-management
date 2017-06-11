Public Class frmMain
  
    Public Sub AddUC(ByVal uccontrol As Object)
        Me.TabControlPanel1.Controls.Add(uccontrol)
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TabControlPanel1.Controls.Clear()
        Me.TabItem1.Text = "Nhân Viên"
        Dim UcNhanVien1 As New Quan_Ly_Nhan_Su.UCNhanVien
        AddUC(UcNhanVien1)
    End Sub
    
    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        frmLogin.Show()
    End Sub

    Private Sub btnttpb_Click(sender As Object, e As EventArgs) Handles btnttpb.Click
        Me.TabControlPanel1.Controls.Clear()
        Me.TabItem1.Text = "Phòng Ban"
        Dim UcPhongBan1 As New Quan_Ly_Nhan_Su.UCphongban
        AddUC(UcPhongBan1)
    End Sub

    Private Sub btnttnv_Click(sender As Object, e As EventArgs) Handles btnttnv.Click
        Me.TabControlPanel1.Controls.Clear()
        Me.TabItem1.Text = "Nhân Viên"
        Dim Uc As New Quan_Ly_Nhan_Su.UCNhanVien
        AddUC(Uc)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.TabControlPanel1.Controls.Clear()
        Me.TabItem1.Text = "Nhân Viên"
        Dim Uc As New Quan_Ly_Nhan_Su.UCNhanVien
        AddUC(Uc)

    End Sub
End Class