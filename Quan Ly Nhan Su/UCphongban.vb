Public Class UCphongban

    Private Sub UCphongban_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "Data Source=(localdb)\projects;Initial Catalog=QuanLyNhanSu;Integrated Security=True"
        Tao_ket_noi(str)

        '  Dim dtable As DataTable = LoadDTGRV("Select ROW_NUMBER () over(order by MaNhanVien asc) as STT,* from NhanVien", dtgrvUCNhanVien)
        Dim dtable As DataTable = LoadData("PhongBan")
        dgvpb.DataSource = dtable
        dtable = New DataTable
        dtable = LoadData("ChucVu")
        dgvcv.DataSource = dtable
        Loadcv(0)
        Loadpb(0)
    End Sub
    Private Sub Loadpb(ByVal dong As Object)
        If IsDBNull(Me.dgvpb.Item(0, dong).Value) Then
            txtmaphongban.Text = ""
        Else : txtmaphongban.Text = dgvpb.Item(0, dong).Value
        End If
        If IsDBNull(Me.dgvpb.Item(1, dong).Value) Then
            txttenphongban.Text = ""
        Else : txttenphongban.Text = dgvpb.Item(1, dong).Value
        End If
    End Sub
    Private Sub Loadcv(ByVal dong As Object)
        If IsDBNull(Me.dgvcv.Item(0, dong).Value) Then
            txtmachucvu.Text = ""
        Else : txtmachucvu.Text = dgvcv.Item(0, dong).Value
        End If
        If IsDBNull(Me.dgvcv.Item(1, dong).Value) Then
            txttenchucvu.Text = ""
        Else : txttenchucvu.Text = dgvcv.Item(1, dong).Value
        End If
        If IsDBNull(Me.dgvcv.Item(2, dong).Value) Then
            txtluongcoban.Text = ""
        Else : txtluongcoban.Text = dgvcv.Item(2, dong).Value
        End If

    End Sub
End Class
