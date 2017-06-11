Imports System.Data.SqlClient
Public Class UCNhanVien

    Private customersBindingSource As New BindingSource()
    Private Sub bntTimKiem_Click(sender As Object, e As EventArgs) Handles bntTimKiem.Click
        If Trim(txtTimKiemNV.Text) = "" Then
            MsgBox(" Nhap thong tin tk vao")
            txtTimKiemNV.Text = ""
        Else : Dim dt As DataTable = Nothing
            dt = TimKiem(Trim(txtTimKiemNV.Text))
            If dt.Rows.Count > 0 Then
                dtgrvUCNhanVien.DataSource = dt
            End If
            txtTimKiemNV.Text = ""
        End If
        customersBindingSource.DataSource = dtgrvUCNhanVien.DataSource
        bnNhanVien.Refresh()
        customersBindingSource.Position = 0
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Loadtbcbb(0)
    End Sub
    Private Sub UCNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "Data Source=(localdb)\projects;Initial Catalog=QuanLyNhanSu;Integrated Security=True"
        Tao_ket_noi(str)
        bnNhanVien.BindingSource = customersBindingSource
        '  Dim dtable As DataTable = LoadDTGRV("Select ROW_NUMBER () over(order by MaNhanVien asc) as STT,* from NhanVien", dtgrvUCNhanVien)
        Dim dtable As DataTable = LoadData("NhanVien")
        dtgrvUCNhanVien.DataSource = dtable
        Dim cmd As New SqlCommand("Select MaChucVu from ChucVu", con)
        Dim rd As SqlDataReader = cmd.ExecuteReader()
        While rd.Read
            cbbmcv.Items.Add(rd.Item("MaChucVu").ToString())
        End While
        rd.Close()
        cmd = New SqlCommand("Select MaPhongBan from PhongBan", con)
        rd = cmd.ExecuteReader()
        While rd.Read
            cbbmpb.Items.Add(rd.Item("MaPhongBan").ToString())
        End While
        rd.Close()
        cmd = New SqlCommand("Select TinhTrangHonNhan from NhanVien", con)
        rd = cmd.ExecuteReader()
        While rd.Read
            cbbtinhtranghonnhan.Items.Add(rd.Item("TinhTrangHonNhan").ToString())
        End While
        rd.Close()
        cmd = New SqlCommand("Select MaChiTietNgoaiNgu from ChiTietNgoaiNgu", con)
        rd = cmd.ExecuteReader()
        While rd.Read
            cbbmangoaingu.Items.Add(rd.Item("MaChiTietNgoaiNgu").ToString())
        End While
        rd.Close()
        cmd = New SqlCommand("Select MaChiTietTrinhDo from ChiTietTrinhDo", con)
        rd = cmd.ExecuteReader()
        While rd.Read
            cbbmatrinhdo.Items.Add(rd.Item("MaChiTietTrinhDo").ToString())
        End While
        rd.Close()
        cmd = New SqlCommand("Select SoHopDong from ChiTietHopDong", con)
        rd = cmd.ExecuteReader()
        While rd.Read
            cbbsohopdong.Items.Add(rd.Item("SoHopDong").ToString())
        End While
        rd.Close()
        cmd = New SqlCommand("Select MaQuaTrinh from QuaTrinhLuong", con)
        rd = cmd.ExecuteReader()
        While rd.Read
            cbbquatrinhluong.Items.Add(rd.Item("MaQuaTrinh").ToString())
        End While
        rd.Close()
        
        If dtgrvUCNhanVien.RowCount > 0 Then
            customersBindingSource.DataSource = dtable
            'Load vao combobox ma chuc vu
            Loadtbcbb(0)
        End If
        cmd = New SqlCommand("SELECT MaThanNhan ,TenThanNhan,QuanHe,GhiChu FROM ThanNhan left join NhanVien on ThanNhan .MaNhanVien =NhanVien .MaNhanVien where Nhanvien .MaNhanVien =@MaNhanVien", con)
        cmd.Parameters.AddWithValue("@MaNhanVien", txtmanv.Text)
        LoadDTGRV(cmd, dtgrvthannhan)
        LoadThanNhan(0)
        dtable = New DataTable
        dtable = LoadData("QuyetDinh")
        dgvquyetdinh.DataSource = dtable
        LoadQuyetDinh(0)
        '  Loadtbcbb(customersBindingSource)
        '  txttongiao.DataBindings.Add(New Binding("Text", customersBindingSource, "MaNhanVien"))
    End Sub
    Private Sub Loadtbcbb(ByVal dong As Object)
        If IsDBNull(Me.dtgrvUCNhanVien.Item(0, dong).Value) Then
            txtmanv.Text = ""
        Else : txtmanv.Text = dtgrvUCNhanVien.Item(0, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(1, dong).Value) Then
            cbbmcv.Text = ""
        Else : cbbmcv.Text = dtgrvUCNhanVien.Item(1, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(2, dong).Value) Then
            txttennv.Text = ""
        Else : txttennv.Text = dtgrvUCNhanVien.Item(2, dong).Value
        End If
        ''''
        If IsDBNull(Me.dtgrvUCNhanVien.Item(3, dong).Value) Then
            rbnu.Checked = True
        Else
            If Me.dtgrvUCNhanVien.Item(3, dong).Value = True Then
                rbnam.Checked = True
            Else
                rbnu.Checked = True
            End If
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(4, dong).Value) Then
            dtpngaysinh.Value = Today
        Else : dtpngaysinh.Value = dtgrvUCNhanVien.Item(4, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(5, dong).Value) Then
            txtnoisinh.Text = ""
        Else : txtnoisinh.Text = dtgrvUCNhanVien.Item(5, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(6, dong).Value) Then
            txtdantoc.Text = ""
        Else : txtdantoc.Text = dtgrvUCNhanVien.Item(6, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(7, dong).Value) Then
            txttongiao.Text = ""
        Else : txttongiao.Text = dtgrvUCNhanVien.Item(7, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(8, dong).Value) Then
            txthokhau.Text = ""
        Else : txthokhau.Text = dtgrvUCNhanVien.Item(8, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(9, dong).Value) Then
            txtnoio.Text = ""
        Else : txtnoio.Text = dtgrvUCNhanVien.Item(9, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(10, dong).Value) Then
            txtchungminh.Text = ""
        Else : txtchungminh.Text = dtgrvUCNhanVien.Item(10, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(11, dong).Value) Then
            dtpngaycap.Value = Today
        Else : dtpngaycap.Value = dtgrvUCNhanVien.Item(11, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(12, dong).Value) Then
            txtnoicap.Text = ""
        Else : txtnoicap.Text = dtgrvUCNhanVien.Item(12, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(13, dtgrvUCNhanVien.CurrentCellAddress.Y).Value) Then
            rbbhxhfalse.Checked = True
        Else
            If Me.dtgrvUCNhanVien.Item(13, dong).Value = True Then
                rbbhxhtrue.Checked = True
            Else
                rbbhxhfalse.Checked = True
            End If
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(14, dtgrvUCNhanVien.CurrentCellAddress.Y).Value) Then
            rbbhytfalse.Checked = True
        Else
            If Me.dtgrvUCNhanVien.Item(14, dong).Value = True Then
                rbbhyttrue.Checked = True
            Else
                rbbhytfalse.Checked = True
            End If
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(15, dong).Value) Then
            cbbmpb.Text = ""
        Else : cbbmpb.Text = dtgrvUCNhanVien.Item(15, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(16, dong).Value) Then
            cbbtinhtranghonnhan.Text = ""
        Else : cbbtinhtranghonnhan.Text = dtgrvUCNhanVien.Item(16, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(17, dong).Value) Then
            txtcannang.Text = ""
        Else : txtcannang.Text = dtgrvUCNhanVien.Item(17, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(18, dong).Value) Then
            txtchieucao.Text = ""
        Else : txtchieucao.Text = dtgrvUCNhanVien.Item(18, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(19, dong).Value) Then
            txttinhtrang.Text = ""
        Else : txttinhtrang.Text = dtgrvUCNhanVien.Item(19, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(20, dong).Value) Then
            txttaikhoan.Text = ""
        Else : txttaikhoan.Text = dtgrvUCNhanVien.Item(20, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(20, dong).Value) Then
            txttaikhoan.Text = ""
        Else : txttaikhoan.Text = dtgrvUCNhanVien.Item(20, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(21, dong).Value) Then
            cbbmangoaingu.Text = ""
        Else : cbbmangoaingu.Text = dtgrvUCNhanVien.Item(21, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(22, dong).Value) Then
            cbbmatrinhdo.Text = ""
        Else : cbbmatrinhdo.Text = dtgrvUCNhanVien.Item(22, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(23, dong).Value) Then
            cbbsohopdong.Text = ""
        Else : cbbsohopdong.Text = dtgrvUCNhanVien.Item(23, dong).Value
        End If
        If IsDBNull(Me.dtgrvUCNhanVien.Item(24, dong).Value) Then
            cbbquatrinhluong.Text = ""
        Else : cbbquatrinhluong.Text = dtgrvUCNhanVien.Item(24, dong).Value
        End If
    End Sub
    Private Sub LoadQuyetDinh(ByVal dong As Object)
        If IsDBNull(Me.dgvquyetdinh.Item("SoQuyetDinh", dong).Value) Then
            txtsqd.Text = ""
        Else : txtsqd.Text = dgvquyetdinh.Item("SoQuyetDinh", dong).Value
        End If
        If IsDBNull(Me.dgvquyetdinh.Item("LoaiQuyetDinh", dong).Value) Then
            txtloaiqd.Text = ""
        Else : txtloaiqd.Text = dgvquyetdinh.Item("LoaiQuyetDinh", dong).Value
        End If
        If IsDBNull(Me.dgvquyetdinh.Item("NgayQuyetDinh", dong).Value) Then
            txtngayquyetdinh.Text = ""
        Else : txtngayquyetdinh.Text = dgvquyetdinh.Item("NgayQuyetDinh", dong).Value
        End If
        If IsDBNull(Me.dgvquyetdinh.Item("NoiDung", dong).Value) Then
            txtnoidungqd.Text = ""
        Else : txtnoidungqd.Text = dgvquyetdinh.Item("NoiDung", dong).Value
        End If
        If IsDBNull(Me.dgvquyetdinh.Item("GhiChu", dong).Value) Then
            txtghichuqd.Text = ""
        Else : txtghichuqd.Text = dgvquyetdinh.Item("GhiChu", dong).Value
        End If
    End Sub
    Private Sub LoadThanNhan(ByVal dong As Object)
        If IsDBNull(Me.dtgrvthannhan.Item("MaThanNhan", dong).Value) Then
            txtmathannhan.Text = ""
        Else : txtmathannhan.Text = dtgrvthannhan.Item("MaThanNhan", dong).Value
        End If
        If IsDBNull(Me.dtgrvthannhan.Item("TenThanNhan", dong).Value) Then
            txttenthannhan.Text = ""
        Else : txttenthannhan.Text = dtgrvthannhan.Item("TenThanNhan", dong).Value
        End If
        If IsDBNull(Me.dtgrvthannhan.Item("QuanHe", dong).Value) Then
            txtquanhetn.Text = ""
        Else : txtquanhetn.Text = dtgrvthannhan.Item("QuanHe", dong).Value
        End If
        If IsDBNull(Me.dtgrvthannhan.Item("GhiChu", dong).Value) Then
            txtghichutn.Text = ""
        Else : txtghichutn.Text = dtgrvthannhan.Item("GhiChu", dong).Value
        End If
    End Sub
    Private Sub dtgrvUCNhanVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgrvUCNhanVien.CellClick
        Dim dong As Object
        dong = dtgrvUCNhanVien.CurrentCellAddress.Y
        customersBindingSource.Position = Int(dong)
        Loadtbcbb(dong)
        'Load ra datagridview than nhan
        Dim cmd As New SqlCommand("SELECT MaThanNhan ,TenThanNhan,QuanHe,GhiChu FROM ThanNhan left join NhanVien on ThanNhan .MaNhanVien =NhanVien .MaNhanVien where Nhanvien .MaNhanVien =@MaNhanVien", con)
        cmd.Parameters.AddWithValue("@MaNhanVien", txtmanv.Text)
        LoadDTGRV(cmd, dtgrvthannhan)
        LoadThanNhan(0)
    End Sub

    Private Sub bntXemLai_Click(sender As Object, e As EventArgs) Handles bntXemLai.Click
        Dim dong As Object
        dong = dtgrvUCNhanVien.CurrentCellAddress.Y
        Loadtbcbb(dong)
    End Sub

    Private Sub bntThem_Click(sender As Object, e As EventArgs) Handles bntThem.Click
        txtmanv.Enabled = True
        txtmanv.Text = ""
        cbbmcv.Text = ""
        txttennv.Text = ""
        rbnam.Checked = True
        ' cbbgt.Text = ""
        dtpngaysinh.Value = Today
        txtnoisinh.Text = ""
        txtdantoc.Text = ""
        txttongiao.Text = ""
        txthokhau.Text = ""
        txtnoio.Text = ""
        txtchungminh.Text = ""
        dtpngaycap.Value = Today
        txtnoicap.Text = ""
        rbbhxhtrue.Checked = True
        rbbhyttrue.Checked = True
        cbbmpb.Text = ""
        cbbtinhtranghonnhan.Text = ""
        txtcannang.Text = ""
        txtchieucao.Text = ""
        txttinhtrang.Text = ""
        cbbmangoaingu.Text = ""
        cbbmatrinhdo.Text = ""
        cbbsohopdong.Text = ""
        cbbquatrinhluong.Text = ""
       
    End Sub

    Private Sub bntLuuNhanVien_Click(sender As Object, e As EventArgs) Handles bntLuuNhanVien.Click

        Try
            Dim dt1 As DataTable = Nothing
            Dim cc, cn As Object
            If txtcannang.Text = "" Then
                cn = DBNull.Value
            Else : cn = Convert.ToInt32(txtcannang.Text)
            End If
            If txtchieucao.Text = "" Then
                cc = DBNull.Value
            Else : cc = Convert.ToInt32(txtchieucao.Text)
            End If
            dt1 = Adddata(txtmanv.Text, cbbmcv.Text, txttennv.Text, rbnam.Checked, dtpngaysinh.Value,
                         txtnoisinh.Text, txtdantoc.Text, txttongiao.Text, txthokhau.Text, txtnoio.Text, txtchungminh.Text, dtpngaycap.Value, txtnoicap.Text,
                         rbbhxhtrue.Checked, rbbhyttrue.Checked, cbbmpb.Text, cbbtinhtranghonnhan.Text,
                        cn, cc, txttinhtrang.Text, cbbmangoaingu.Text,
                         cbbmatrinhdo.Text, cbbsohopdong.Text, cbbquatrinhluong.Text)
            dtgrvUCNhanVien.DataSource = Nothing
            If dt1.Rows.Count > 0 Then
                dtgrvUCNhanVien.DataSource = dt1
            End If
            customersBindingSource.DataSource = dtgrvUCNhanVien.DataSource
            bnNhanVien.Refresh()
            customersBindingSource.Position = 0
            txtmanv.Enabled = False
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Loadtbcbb(0)
            LoadThanNhan(0)
        Catch ex As Exception
            MsgBox("Nhap sai du lieu")
        End Try
      
    End Sub

    Private Sub dtgrvthannhan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgrvthannhan.CellClick
        Dim dong As Object
        dong = dtgrvthannhan.CurrentCellAddress.Y
        LoadThanNhan(dong)
    End Sub

    Private Sub btnupdatethannhan_Click(sender As Object, e As EventArgs) Handles btnupdatethannhan.Click

    End Sub

    Private Sub btnsavetn_Click(sender As Object, e As EventArgs) Handles btnsavetn.Click
        
        'Dim cmd As New SqlCommand(" if exists (select * from ThanNhan left join NhanVien on ThanNhan .MaNhanVien =NhanVien .MaNhanVien where ThanNhan .MaThanNhan =@MaThanNhan)" & _
        '                           "begin update ThanNhan set MaThanNhan=@MaThanNhan,TenThanNhan=@TenThanNhan,MaNhanVien=@MaNhanVien,GhiChu=@GhiChu,QuanHe=@QuanHe end" & _
        '                           " else begin Insert into ThanNhan values (@MaThanNhan,@TenThanNhan,@MaNhanVien,@GhiChu,@QuanHe) end", con)
        'With cmd
        '    .Parameters.AddWithValue("@MaThanNhan", txtmathannhan.Text)
        '    .Parameters.AddWithValue("@TenThanNhan", txttenthannhan.Text)
        '    .Parameters.AddWithValue("@MaNhanVien", txtmanv.Text)
        '    .Parameters.AddWithValue("@QuanHe", txtquanhetn.Text)
        '    .Parameters.AddWithValue("@GhiChu", txtghichutn.Text)
        'End With
        'cmd.ExecuteNonQuery()
        'cmd.Parameters.Clear()
        'LoadDTGRV(cmd, dtgrvthannhan)
        'LoadThanNhan(0)
    End Sub

 
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            Dim dt1 As DataTable = Nothing
            Dim cc, cn As Object
            If txtcannang.Text = "" Then
                cn = DBNull.Value
            Else : cn = Convert.ToInt32(txtcannang.Text)
            End If
            If txtchieucao.Text = "" Then
                cc = DBNull.Value
            Else : cc = Convert.ToInt32(txtchieucao.Text)
            End If

            dt1 = Updatenv(txtmanv.Text, cbbmcv.Text, txttennv.Text, rbnam.Checked, dtpngaysinh.Value,
                    txtnoisinh.Text, txtdantoc.Text, txttongiao.Text, txthokhau.Text, txtnoio.Text, txtchungminh.Text, dtpngaycap.Value, txtnoicap.Text,
                    rbbhxhtrue.Checked, rbbhyttrue.Checked, cbbmpb.Text, cbbtinhtranghonnhan.Text,
                   cn, cc, txttinhtrang.Text, cbbmangoaingu.Text,
                    cbbmatrinhdo.Text, cbbsohopdong.Text, cbbquatrinhluong.Text)

            dtgrvUCNhanVien.DataSource = Nothing
            If dt1.Rows.Count > 0 Then
                dtgrvUCNhanVien.DataSource = dt1
            End If
            customersBindingSource.DataSource = dtgrvUCNhanVien.DataSource
            bnNhanVien.Refresh()
            customersBindingSource.Position = 0
            txtmanv.Enabled = False
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Loadtbcbb(0)
            LoadThanNhan(0)
        Catch ex As Exception
            MsgBox("Nhap sai du lieu")
        End Try
    End Sub
End Class
