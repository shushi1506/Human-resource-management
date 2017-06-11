Imports System.Data.SqlClient
Module Connect
    Public con As SqlConnection
    Public Sub Tao_ket_noi(ByVal a As String)
        Dim ketnoistring As String
        ketnoistring = a
        con = New SqlConnection(ketnoistring)
    End Sub
    Function TimKiem(ByVal dk As String) As DataTable
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        dk = "%" + dk + "%"
        Dim cmd As New SqlCommand("SearchProc", con)
        With cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@DieuKien", dk)
        End With
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dt
    End Function
    Function Adddata(ByVal MaNhanVien As String,
           ByVal MaChucVu As String,
           ByVal HoTen As String,
           ByVal GioiTinh As Boolean,
           ByVal NgaySinh As Date,
           ByVal NoiSinh As String,
           ByVal DanToc As String,
           ByVal TonGiao As String,
           ByVal HoKhauThuongTru As String,
           ByVal NoiOHienNay As String,
           ByVal ChungMinhThu As String,
           ByVal NgayCapCMT As Date,
           ByVal NoiCapCMT As String,
           ByVal DongBHXH As Boolean,
           ByVal DongBHYT As Boolean,
           ByVal MaPhongBan As String,
           ByVal TinhTrangHonNhan As String,
           ByVal CanNang As Object,
           ByVal Cao As Object,
           ByVal TinhTrangSucKhoe As String,
           ByVal MaChiTietNgoaiNgu As String,
           ByVal MaChiTietTrinhDo As String,
           ByVal SoHopDong As String,
           ByVal MaQuaTrinh As String) As DataTable
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("if not exists (select * from QuaTrinhCongTac where MaNhanVien=@MaNhanVien) begin Insert into QuaTrinhCongTac(MaNhanVien) values (@MaNhanVien) end", con)
        cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cmd = New SqlCommand("Adddata", con)
        With cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@MaNhanVien", MaNhanVien)
            .Parameters.AddWithValue("@MaChucVu", MaChucVu)
            .Parameters.AddWithValue("@HoTen", HoTen)

            .Parameters.AddWithValue("@GioiTinh", GioiTinh)

            .Parameters.AddWithValue("@NgaySinh", NgaySinh)

            .Parameters.AddWithValue("@NoiSinh", NoiSinh)

            .Parameters.AddWithValue("@DanToc", DanToc)

            .Parameters.AddWithValue("@TonGiao", TonGiao)

            .Parameters.AddWithValue("@HoKhauThuongTru", HoKhauThuongTru)

            .Parameters.AddWithValue("@NoiOHienNay", NoiOHienNay)

            .Parameters.AddWithValue("@ChungMinhThu", ChungMinhThu)

            .Parameters.AddWithValue("@NgayCapCMT", NgayCapCMT)

            .Parameters.AddWithValue("@NoiCapCMT ", NoiCapCMT)

            .Parameters.AddWithValue("@DongBHXH", DongBHXH)

            .Parameters.AddWithValue("@DongBHYT", DongBHYT)

            .Parameters.AddWithValue("@MaPhongBan", MaPhongBan)

            .Parameters.AddWithValue("@TinhTrangHonNhan", TinhTrangHonNhan)

            .Parameters.AddWithValue("@CanNang", CanNang)

            .Parameters.AddWithValue("@Cao", Cao)

            .Parameters.AddWithValue("@TinhTrangSucKhoe", TinhTrangSucKhoe)

            .Parameters.AddWithValue("@MaChiTietNgoaiNgu", MaChiTietNgoaiNgu)

            .Parameters.AddWithValue("@MaChiTietTrinhDo", MaChiTietTrinhDo)

            .Parameters.AddWithValue("@SoHopDong", SoHopDong)

            .Parameters.AddWithValue("@MaQuaTrinh", MaQuaTrinh)
        End With
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cmd = New SqlCommand("Select * from NhanVien", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dt
    End Function
    Function Updatenv(ByVal MaNhanVien As String,
          ByVal MaChucVu As String,
          ByVal HoTen As String,
          ByVal GioiTinh As Boolean,
          ByVal NgaySinh As Date,
          ByVal NoiSinh As String,
          ByVal DanToc As String,
          ByVal TonGiao As String,
          ByVal HoKhauThuongTru As String,
          ByVal NoiOHienNay As String,
          ByVal ChungMinhThu As String,
          ByVal NgayCapCMT As Date,
          ByVal NoiCapCMT As String,
          ByVal DongBHXH As Boolean,
          ByVal DongBHYT As Boolean,
          ByVal MaPhongBan As String,
          ByVal TinhTrangHonNhan As String,
          ByVal CanNang As Object,
          ByVal Cao As Object,
          ByVal TinhTrangSucKhoe As String,
          ByVal MaChiTietNgoaiNgu As String,
          ByVal MaChiTietTrinhDo As String,
          ByVal SoHopDong As String,
          ByVal MaQuaTrinh As String) As DataTable
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Dim cmd As New SqlCommand("Updatenv", con)
        With cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@MaNhanVien", MaNhanVien)
            .Parameters.AddWithValue("@MaChucVu", MaChucVu)
            .Parameters.AddWithValue("@HoTen", HoTen)

            .Parameters.AddWithValue("@GioiTinh", GioiTinh)

            .Parameters.AddWithValue("@NgaySinh", NgaySinh)

            .Parameters.AddWithValue("@NoiSinh", NoiSinh)

            .Parameters.AddWithValue("@DanToc", DanToc)

            .Parameters.AddWithValue("@TonGiao", TonGiao)

            .Parameters.AddWithValue("@HoKhauThuongTru", HoKhauThuongTru)

            .Parameters.AddWithValue("@NoiOHienNay", NoiOHienNay)

            .Parameters.AddWithValue("@ChungMinhThu", ChungMinhThu)

            .Parameters.AddWithValue("@NgayCapCMT", NgayCapCMT)

            .Parameters.AddWithValue("@NoiCapCMT ", NoiCapCMT)

            .Parameters.AddWithValue("@DongBHXH", DongBHXH)

            .Parameters.AddWithValue("@DongBHYT", DongBHYT)

            .Parameters.AddWithValue("@MaPhongBan", MaPhongBan)

            .Parameters.AddWithValue("@TinhTrangHonNhan", TinhTrangHonNhan)

            .Parameters.AddWithValue("@CanNang", CanNang)

            .Parameters.AddWithValue("@Cao", Cao)

            .Parameters.AddWithValue("@TinhTrangSucKhoe", TinhTrangSucKhoe)

            .Parameters.AddWithValue("@MaChiTietNgoaiNgu", MaChiTietNgoaiNgu)

            .Parameters.AddWithValue("@MaChiTietTrinhDo", MaChiTietTrinhDo)

            .Parameters.AddWithValue("@SoHopDong", SoHopDong)

            .Parameters.AddWithValue("@MaQuaTrinh", MaQuaTrinh)
        End With
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        cmd = New SqlCommand("Select * from NhanVien", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return dt
    End Function

    Function LoadDTGRV(ByVal caulenh As String, ByVal DTGRV As DataGridView) As DataTable
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("" & caulenh & " ", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DTGRV.DataSource = dt
        '  con.Close()
        Return dt
    End Function
    Function LoadData(ByVal tablename As String) As DataTable
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("Select * from " & tablename & " ", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        ' con.Close()
        Return dt

    End Function
    Public Sub LoadDTGRV(ByVal cmd As SqlCommand, ByVal grv As DataGridView)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        grv.DataSource = dt
        '  con.Close()
    End Sub
End Module
