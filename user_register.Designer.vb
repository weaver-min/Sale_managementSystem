<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class user_register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnCompanyInfo = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtBankNo = New System.Windows.Forms.TextBox()
        Me.lblBankNo = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.lblBankName = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtPhNo = New System.Windows.Forms.TextBox()
        Me.lblPhNo = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.pnUserInfo = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnCompanyInfo.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnUserInfo.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1346, 89)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(762, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "システム設定"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnCompanyInfo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnUserInfo, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(-2, -10)
        Me.TableLayoutPanel1.MaximumSize = New System.Drawing.Size(1440, 1024)
        Me.TableLayoutPanel1.MinimumSize = New System.Drawing.Size(850, 650)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.47369!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1352, 906)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'pnCompanyInfo
        '
        Me.pnCompanyInfo.AutoSize = True
        Me.pnCompanyInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnCompanyInfo.Controls.Add(Me.Panel8)
        Me.pnCompanyInfo.Controls.Add(Me.Panel7)
        Me.pnCompanyInfo.Controls.Add(Me.Panel6)
        Me.pnCompanyInfo.Controls.Add(Me.Panel5)
        Me.pnCompanyInfo.Controls.Add(Me.Panel4)
        Me.pnCompanyInfo.Controls.Add(Me.lblCompany)
        Me.pnCompanyInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnCompanyInfo.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.pnCompanyInfo.Location = New System.Drawing.Point(3, 98)
        Me.pnCompanyInfo.Name = "pnCompanyInfo"
        Me.pnCompanyInfo.Size = New System.Drawing.Size(670, 805)
        Me.pnCompanyInfo.TabIndex = 3
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel8.Controls.Add(Me.txtBankNo)
        Me.Panel8.Controls.Add(Me.lblBankNo)
        Me.Panel8.Location = New System.Drawing.Point(124, 668)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(536, 92)
        Me.Panel8.TabIndex = 17
        '
        'txtBankNo
        '
        Me.txtBankNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBankNo.BackColor = System.Drawing.Color.White
        Me.txtBankNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBankNo.Font = New System.Drawing.Font("MS UI Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtBankNo.Location = New System.Drawing.Point(133, 31)
        Me.txtBankNo.Name = "txtBankNo"
        Me.txtBankNo.Size = New System.Drawing.Size(376, 23)
        Me.txtBankNo.TabIndex = 1
        '
        'lblBankNo
        '
        Me.lblBankNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBankNo.AutoSize = True
        Me.lblBankNo.Location = New System.Drawing.Point(8, 33)
        Me.lblBankNo.Name = "lblBankNo"
        Me.lblBankNo.Size = New System.Drawing.Size(99, 20)
        Me.lblBankNo.TabIndex = 11
        Me.lblBankNo.Text = "口座情報："
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel7.Controls.Add(Me.txtBankName)
        Me.Panel7.Controls.Add(Me.lblBankName)
        Me.Panel7.Location = New System.Drawing.Point(124, 539)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(536, 92)
        Me.Panel7.TabIndex = 17
        '
        'txtBankName
        '
        Me.txtBankName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBankName.BackColor = System.Drawing.Color.White
        Me.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBankName.Font = New System.Drawing.Font("MS UI Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtBankName.Location = New System.Drawing.Point(133, 31)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(376, 23)
        Me.txtBankName.TabIndex = 1
        '
        'lblBankName
        '
        Me.lblBankName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBankName.AutoSize = True
        Me.lblBankName.Location = New System.Drawing.Point(3, 33)
        Me.lblBankName.Name = "lblBankName"
        Me.lblBankName.Size = New System.Drawing.Size(99, 20)
        Me.lblBankName.TabIndex = 10
        Me.lblBankName.Text = "取引銀行："
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel6.Controls.Add(Me.txtPhNo)
        Me.Panel6.Controls.Add(Me.lblPhNo)
        Me.Panel6.Location = New System.Drawing.Point(124, 400)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(536, 92)
        Me.Panel6.TabIndex = 18
        '
        'txtPhNo
        '
        Me.txtPhNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhNo.BackColor = System.Drawing.Color.White
        Me.txtPhNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPhNo.Font = New System.Drawing.Font("MS UI Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPhNo.Location = New System.Drawing.Point(133, 31)
        Me.txtPhNo.Name = "txtPhNo"
        Me.txtPhNo.Size = New System.Drawing.Size(376, 23)
        Me.txtPhNo.TabIndex = 1
        '
        'lblPhNo
        '
        Me.lblPhNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPhNo.AutoSize = True
        Me.lblPhNo.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPhNo.Location = New System.Drawing.Point(16, 33)
        Me.lblPhNo.Name = "lblPhNo"
        Me.lblPhNo.Size = New System.Drawing.Size(99, 20)
        Me.lblPhNo.TabIndex = 9
        Me.lblPhNo.Text = "電話番号："
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel5.Controls.Add(Me.txtAddress)
        Me.Panel5.Controls.Add(Me.lblAddress)
        Me.Panel5.Location = New System.Drawing.Point(124, 257)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(536, 92)
        Me.Panel5.TabIndex = 17
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Font = New System.Drawing.Font("MS UI Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(133, 19)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(376, 49)
        Me.txtAddress.TabIndex = 1
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(26, 38)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(59, 20)
        Me.lblAddress.TabIndex = 8
        Me.lblAddress.Text = "住所："
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel4.Controls.Add(Me.lblCompanyName)
        Me.Panel4.Controls.Add(Me.txtCompanyName)
        Me.Panel4.Location = New System.Drawing.Point(124, 117)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(536, 92)
        Me.Panel4.TabIndex = 16
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblCompanyName.Location = New System.Drawing.Point(2, 34)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(79, 20)
        Me.lblCompanyName.TabIndex = 7
        Me.lblCompanyName.Text = "会社名："
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCompanyName.BackColor = System.Drawing.Color.White
        Me.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCompanyName.Font = New System.Drawing.Font("MS UI Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtCompanyName.Location = New System.Drawing.Point(133, 34)
        Me.txtCompanyName.MaxLength = 255
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(376, 23)
        Me.txtCompanyName.TabIndex = 1
        '
        'lblCompany
        '
        Me.lblCompany.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("MS UI Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblCompany.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblCompany.Location = New System.Drawing.Point(41, 68)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(130, 24)
        Me.lblCompany.TabIndex = 0
        Me.lblCompany.Text = "〇自社情報"
        '
        'pnUserInfo
        '
        Me.pnUserInfo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnUserInfo.Controls.Add(Me.Panel11)
        Me.pnUserInfo.Controls.Add(Me.Panel10)
        Me.pnUserInfo.Controls.Add(Me.Panel9)
        Me.pnUserInfo.Controls.Add(Me.btnClose)
        Me.pnUserInfo.Controls.Add(Me.btnEdit)
        Me.pnUserInfo.Controls.Add(Me.Label11)
        Me.pnUserInfo.Controls.Add(Me.Label10)
        Me.pnUserInfo.Controls.Add(Me.Label7)
        Me.pnUserInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnUserInfo.Location = New System.Drawing.Point(679, 98)
        Me.pnUserInfo.Name = "pnUserInfo"
        Me.pnUserInfo.Size = New System.Drawing.Size(670, 805)
        Me.pnUserInfo.TabIndex = 4
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel11.Controls.Add(Me.txtTax)
        Me.Panel11.Location = New System.Drawing.Point(127, 550)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(194, 64)
        Me.Panel11.TabIndex = 25
        '
        'txtTax
        '
        Me.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTax.Font = New System.Drawing.Font("MS UI Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtTax.Location = New System.Drawing.Point(41, 20)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(129, 23)
        Me.txtTax.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel10.Controls.Add(Me.txtPassword)
        Me.Panel10.Controls.Add(Me.lblPassword)
        Me.Panel10.Location = New System.Drawing.Point(99, 257)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(536, 92)
        Me.Panel10.TabIndex = 18
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("MS UI Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(132, 35)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(374, 23)
        Me.txtPassword.TabIndex = 1
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(13, 33)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(99, 20)
        Me.lblPassword.TabIndex = 19
        Me.lblPassword.Text = "Password："
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel9.Controls.Add(Me.txtUserId)
        Me.Panel9.Controls.Add(Me.lblUserId)
        Me.Panel9.Location = New System.Drawing.Point(99, 117)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(536, 92)
        Me.Panel9.TabIndex = 24
        '
        'txtUserId
        '
        Me.txtUserId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserId.BackColor = System.Drawing.Color.White
        Me.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserId.Font = New System.Drawing.Font("MS UI Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtUserId.Location = New System.Drawing.Point(132, 35)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(360, 23)
        Me.txtUserId.TabIndex = 1
        '
        'lblUserId
        '
        Me.lblUserId.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserId.AutoSize = True
        Me.lblUserId.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblUserId.Location = New System.Drawing.Point(41, 33)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(43, 20)
        Me.lblUserId.TabIndex = 17
        Me.lblUserId.Text = "ID ："
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Silver
        Me.btnClose.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnClose.Location = New System.Drawing.Point(297, 686)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(147, 74)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.YellowGreen
        Me.btnEdit.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(477, 686)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(147, 74)
        Me.btnEdit.TabIndex = 22
        Me.btnEdit.Text = "編集"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(336, 567)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 30)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "%"
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label10.Location = New System.Drawing.Point(50, 468)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 24)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "〇消費税"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label7.Location = New System.Drawing.Point(32, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 24)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "〇ユーザー情報"
        '
        'user_register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1351, 891)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1440, 1024)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(870, 710)
        Me.Name = "user_register"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.pnCompanyInfo.ResumeLayout(False)
        Me.pnCompanyInfo.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnUserInfo.ResumeLayout(False)
        Me.pnUserInfo.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnCompanyInfo As Panel
    Friend WithEvents lblBankNo As Label
    Friend WithEvents lblBankName As Label
    Friend WithEvents lblPhNo As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents pnUserInfo As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUserId As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtBankName As TextBox
    Friend WithEvents txtPhNo As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtBankNo As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtUserId As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txtTax As TextBox
End Class


