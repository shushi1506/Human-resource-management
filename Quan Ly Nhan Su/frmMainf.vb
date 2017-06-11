Imports System.Data.SqlClient
Public Class frmMainf
    Private customersBindingSource1 As New BindingSource()
    Private Sub frmMainf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NhanvienDataSet.usernv' table. You can move, or remove it, as needed.
        Me.UsernvTableAdapter.Fill(Me.NhanvienDataSet.usernv)
        Dim str As String = "Data Source=(localdb)\projects;Initial Catalog=anhiu;Integrated Security=True"
        Tao_ket_noi(str)
    End Sub
    Private Sub btntk_Click(sender As Object, e As EventArgs) Handles btntk.Click
        Me.BindingNavigator1.BindingSource = Me.customersBindingSource1
        If Trim(txttk.Text) = "" Then
            MsgBox(" Nhap thong tin tk vao")
        Else : Dim dk As String = txttk.Text
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
            '  ds.Tables.Add("SinhVien")
            ' da.Fill(ds.Tables("SinhVien"))
            dtgrv.AutoGenerateColumns = False
            da.Fill(dt)
            dtgrv.DataSource = dt

            Me.Column1.DataPropertyName = "msv"
            ' Column2.DataPropertyName = "hoten"
            '   Dim dt As DataTable = Nothing
            ' dt = TimKiem(Trim(txttk.Text))
            'If dt.Rows.Count > 0 Then

            '  
            'End If
            'dtgrv.DataSource = ds.Tables("SinhVien")
            Me.customersBindingSource1.DataSource = dt 'ds.Tables("SinhVien")
            '  Me.customersBindingSource.DataSource = dtgrv.DataSource

            TextBox1.DataBindings.Add(New Binding("Text", customersBindingSource1, "hoten"))
        End If
        'If con.State = ConnectionState.Open Then
        '    con.Close()

        'End If
    End Sub

    Private Sub dtgrv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgrv.CellClick
        Dim dong As Object
        dong = Me.dtgrv.CurrentCellAddress.Y
        customersBindingSource1.Position = Int(dong)
    End Sub

   
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        customersBindingSource1.MoveNext()
        dtgrv.ClearSelection()
        dtgrv.Rows(customersBindingSource1.Position).Selected = True
    End Sub

    Private Sub frmMainf_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        con.Close()
    End Sub
End Class