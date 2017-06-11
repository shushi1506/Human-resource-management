<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCphongban
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.btnxoa = New DevComponents.DotNetBar.ButtonX()
        Me.btnupdate = New DevComponents.DotNetBar.ButtonX()
        Me.btnsave = New DevComponents.DotNetBar.ButtonX()
        Me.btnadd = New DevComponents.DotNetBar.ButtonX()
        Me.dgvpb = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.txttenphongban = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.txtmaphongban = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ReflectionLabel4 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TabControl2 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.dgvcv = New System.Windows.Forms.DataGridView()
        Me.txtluongcoban = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ReflectionLabel5 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.txttenchucvu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ReflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.txtmachucvu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ReflectionLabel3 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.dgvpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.dgvcv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(869, 321)
        Me.TabControl1.TabIndex = 9
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.btnxoa)
        Me.TabControlPanel1.Controls.Add(Me.btnupdate)
        Me.TabControlPanel1.Controls.Add(Me.btnsave)
        Me.TabControlPanel1.Controls.Add(Me.btnadd)
        Me.TabControlPanel1.Controls.Add(Me.dgvpb)
        Me.TabControlPanel1.Controls.Add(Me.txttenphongban)
        Me.TabControlPanel1.Controls.Add(Me.ReflectionLabel1)
        Me.TabControlPanel1.Controls.Add(Me.txtmaphongban)
        Me.TabControlPanel1.Controls.Add(Me.ReflectionLabel4)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(869, 295)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'btnxoa
        '
        Me.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnxoa.Location = New System.Drawing.Point(163, 203)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnxoa.TabIndex = 36
        Me.btnxoa.Text = "Xóa"
        '
        'btnupdate
        '
        Me.btnupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnupdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnupdate.Location = New System.Drawing.Point(30, 203)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnupdate.TabIndex = 35
        Me.btnupdate.Text = "Sửa"
        '
        'btnsave
        '
        Me.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnsave.Location = New System.Drawing.Point(163, 140)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnsave.TabIndex = 34
        Me.btnsave.Text = "Lưu"
        '
        'btnadd
        '
        Me.btnadd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnadd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnadd.Location = New System.Drawing.Point(30, 141)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnadd.TabIndex = 33
        Me.btnadd.Text = "Thêm"
        '
        'dgvpb
        '
        Me.dgvpb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvpb.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvpb.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvpb.Location = New System.Drawing.Point(282, 21)
        Me.dgvpb.Name = "dgvpb"
        Me.dgvpb.Size = New System.Drawing.Size(395, 224)
        Me.dgvpb.TabIndex = 32
        '
        'txttenphongban
        '
        '
        '
        '
        Me.txttenphongban.Border.Class = "TextBoxBorder"
        Me.txttenphongban.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txttenphongban.Location = New System.Drawing.Point(148, 76)
        Me.txttenphongban.Name = "txttenphongban"
        Me.txttenphongban.Size = New System.Drawing.Size(100, 20)
        Me.txttenphongban.TabIndex = 31
        '
        'ReflectionLabel1
        '
        Me.ReflectionLabel1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel1.Location = New System.Drawing.Point(30, 72)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(106, 31)
        Me.ReflectionLabel1.TabIndex = 30
        Me.ReflectionLabel1.Text = "<b><font size=""+6""><font color=""#B02B2C"">Tên Phòng Ban</font></font></b>"
        '
        'txtmaphongban
        '
        '
        '
        '
        Me.txtmaphongban.Border.Class = "TextBoxBorder"
        Me.txtmaphongban.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmaphongban.Location = New System.Drawing.Point(148, 21)
        Me.txtmaphongban.Name = "txtmaphongban"
        Me.txtmaphongban.Size = New System.Drawing.Size(100, 20)
        Me.txtmaphongban.TabIndex = 29
        '
        'ReflectionLabel4
        '
        Me.ReflectionLabel4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel4.Location = New System.Drawing.Point(30, 21)
        Me.ReflectionLabel4.Name = "ReflectionLabel4"
        Me.ReflectionLabel4.Size = New System.Drawing.Size(106, 31)
        Me.ReflectionLabel4.TabIndex = 28
        Me.ReflectionLabel4.Text = "<b><font size=""+6""><font color=""#B02B2C"">Mã Phòng Ban</font></font></b>"
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Phòng Ban"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TabControl2)
        Me.GroupPanel1.Location = New System.Drawing.Point(3, 337)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(869, 321)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 10
        '
        'TabControl2
        '
        Me.TabControl2.BackColor = System.Drawing.Color.Transparent
        Me.TabControl2.CanReorderTabs = True
        Me.TabControl2.Controls.Add(Me.TabControlPanel2)
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl2.SelectedTabIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(860, 277)
        Me.TabControl2.TabIndex = 0
        Me.TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl2.Tabs.Add(Me.TabItem2)
        Me.TabControl2.Text = "TabControl2"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.ButtonX1)
        Me.TabControlPanel2.Controls.Add(Me.ButtonX2)
        Me.TabControlPanel2.Controls.Add(Me.ButtonX3)
        Me.TabControlPanel2.Controls.Add(Me.ButtonX4)
        Me.TabControlPanel2.Controls.Add(Me.dgvcv)
        Me.TabControlPanel2.Controls.Add(Me.txtluongcoban)
        Me.TabControlPanel2.Controls.Add(Me.ReflectionLabel5)
        Me.TabControlPanel2.Controls.Add(Me.txttenchucvu)
        Me.TabControlPanel2.Controls.Add(Me.ReflectionLabel2)
        Me.TabControlPanel2.Controls.Add(Me.txtmachucvu)
        Me.TabControlPanel2.Controls.Add(Me.ReflectionLabel3)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(860, 251)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 1
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(596, 208)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 42
        Me.ButtonX1.Text = "Xóa"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(390, 208)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 41
        Me.ButtonX2.Text = "Sửa"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(494, 208)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 40
        Me.ButtonX3.Text = "Lưu"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Location = New System.Drawing.Point(276, 208)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.TabIndex = 39
        Me.ButtonX4.Text = "Thêm"
        '
        'dgvcv
        '
        Me.dgvcv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcv.Location = New System.Drawing.Point(276, 25)
        Me.dgvcv.Name = "dgvcv"
        Me.dgvcv.Size = New System.Drawing.Size(395, 177)
        Me.dgvcv.TabIndex = 38
        '
        'txtluongcoban
        '
        '
        '
        '
        Me.txtluongcoban.Border.Class = "TextBoxBorder"
        Me.txtluongcoban.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtluongcoban.Location = New System.Drawing.Point(142, 167)
        Me.txtluongcoban.Name = "txtluongcoban"
        Me.txtluongcoban.Size = New System.Drawing.Size(100, 20)
        Me.txtluongcoban.TabIndex = 37
        '
        'ReflectionLabel5
        '
        Me.ReflectionLabel5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel5.Location = New System.Drawing.Point(24, 156)
        Me.ReflectionLabel5.Name = "ReflectionLabel5"
        Me.ReflectionLabel5.Size = New System.Drawing.Size(106, 31)
        Me.ReflectionLabel5.TabIndex = 36
        Me.ReflectionLabel5.Text = "<b><font size=""+6""><font color=""#B02B2C"">Lương Cơ Bản</font></font></b>"
        '
        'txttenchucvu
        '
        '
        '
        '
        Me.txttenchucvu.Border.Class = "TextBoxBorder"
        Me.txttenchucvu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txttenchucvu.Location = New System.Drawing.Point(142, 106)
        Me.txttenchucvu.Name = "txttenchucvu"
        Me.txttenchucvu.Size = New System.Drawing.Size(100, 20)
        Me.txttenchucvu.TabIndex = 35
        '
        'ReflectionLabel2
        '
        Me.ReflectionLabel2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel2.Location = New System.Drawing.Point(24, 102)
        Me.ReflectionLabel2.Name = "ReflectionLabel2"
        Me.ReflectionLabel2.Size = New System.Drawing.Size(106, 31)
        Me.ReflectionLabel2.TabIndex = 34
        Me.ReflectionLabel2.Text = "<b><font size=""+6""><font color=""#B02B2C"">Tên Chức Vụ</font></font></b>"
        '
        'txtmachucvu
        '
        '
        '
        '
        Me.txtmachucvu.Border.Class = "TextBoxBorder"
        Me.txtmachucvu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmachucvu.Location = New System.Drawing.Point(142, 51)
        Me.txtmachucvu.Name = "txtmachucvu"
        Me.txtmachucvu.Size = New System.Drawing.Size(100, 20)
        Me.txtmachucvu.TabIndex = 33
        '
        'ReflectionLabel3
        '
        Me.ReflectionLabel3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ReflectionLabel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReflectionLabel3.Location = New System.Drawing.Point(24, 51)
        Me.ReflectionLabel3.Name = "ReflectionLabel3"
        Me.ReflectionLabel3.Size = New System.Drawing.Size(106, 31)
        Me.ReflectionLabel3.TabIndex = 32
        Me.ReflectionLabel3.Text = "<b><font size=""+6""><font color=""#B02B2C"">Mã Chức Vụ</font></font></b>"
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Chức Vụ"
        '
        'UCphongban
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "UCphongban"
        Me.Size = New System.Drawing.Size(869, 620)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        CType(Me.dgvpb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.dgvcv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents txttenphongban As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents txtmaphongban As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ReflectionLabel4 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents dgvpb As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TabControl2 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents dgvcv As System.Windows.Forms.DataGridView
    Friend WithEvents txtluongcoban As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ReflectionLabel5 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents txttenchucvu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ReflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents txtmachucvu As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ReflectionLabel3 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents btnxoa As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnupdate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnsave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnadd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX

End Class
