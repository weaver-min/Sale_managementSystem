<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_menu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSystem = New System.Windows.Forms.Button()
        Me.btnSaleRegist = New System.Windows.Forms.Button()
        Me.btnGoods = New System.Windows.Forms.Button()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.lblmain_menu = New System.Windows.Forms.Label()
        Me.btnCustomerMaster = New System.Windows.Forms.Button()
        Me.btnSalelst = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 377.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSystem, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSaleRegist, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnGoods, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnInvoice, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblmain_menu, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCustomerMaster, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSalelst, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(50, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67606!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.32394!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 355.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 326.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1071, 773)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnSystem
        '
        Me.btnSystem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSystem.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSystem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSystem.Location = New System.Drawing.Point(758, 529)
        Me.btnSystem.Name = "btnSystem"
        Me.btnSystem.Size = New System.Drawing.Size(249, 161)
        Me.btnSystem.TabIndex = 6
        Me.btnSystem.Text = "システム設定"
        Me.btnSystem.UseVisualStyleBackColor = True
        '
        'btnSaleRegist
        '
        Me.btnSaleRegist.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSaleRegist.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSaleRegist.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaleRegist.Location = New System.Drawing.Point(401, 529)
        Me.btnSaleRegist.Name = "btnSaleRegist"
        Me.btnSaleRegist.Size = New System.Drawing.Size(226, 161)
        Me.btnSaleRegist.TabIndex = 5
        Me.btnSaleRegist.Text = "販売登録"
        Me.btnSaleRegist.UseVisualStyleBackColor = True
        '
        'btnGoods
        '
        Me.btnGoods.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGoods.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnGoods.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGoods.Location = New System.Drawing.Point(54, 529)
        Me.btnGoods.Name = "btnGoods"
        Me.btnGoods.Size = New System.Drawing.Size(226, 161)
        Me.btnGoods.TabIndex = 4
        Me.btnGoods.Text = "商品マスタ"
        Me.btnGoods.UseVisualStyleBackColor = True
        '
        'btnInvoice
        '
        Me.btnInvoice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnInvoice.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInvoice.Location = New System.Drawing.Point(753, 188)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Size = New System.Drawing.Size(258, 161)
        Me.btnInvoice.TabIndex = 3
        Me.btnInvoice.Text = "請求書"
        Me.btnInvoice.UseVisualStyleBackColor = True
        '
        'lblmain_menu
        '
        Me.lblmain_menu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmain_menu.AutoSize = True
        Me.lblmain_menu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblmain_menu, 3)
        Me.lblmain_menu.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblmain_menu.Location = New System.Drawing.Point(3, 11)
        Me.lblmain_menu.Name = "lblmain_menu"
        Me.lblmain_menu.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmain_menu.Size = New System.Drawing.Size(1065, 80)
        Me.lblmain_menu.TabIndex = 0
        Me.lblmain_menu.Text = "販売管理システム"
        Me.lblmain_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblmain_menu.UseMnemonic = False
        '
        'btnCustomerMaster
        '
        Me.btnCustomerMaster.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCustomerMaster.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCustomerMaster.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCustomerMaster.Location = New System.Drawing.Point(54, 188)
        Me.btnCustomerMaster.Name = "btnCustomerMaster"
        Me.btnCustomerMaster.Size = New System.Drawing.Size(226, 161)
        Me.btnCustomerMaster.TabIndex = 1
        Me.btnCustomerMaster.Text = "顧客マスタ"
        Me.btnCustomerMaster.UseVisualStyleBackColor = True
        '
        'btnSalelst
        '
        Me.btnSalelst.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSalelst.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSalelst.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalelst.Location = New System.Drawing.Point(401, 188)
        Me.btnSalelst.Name = "btnSalelst"
        Me.btnSalelst.Size = New System.Drawing.Size(226, 161)
        Me.btnSalelst.TabIndex = 2
        Me.btnSalelst.Text = "販売一覧"
        Me.btnSalelst.UseVisualStyleBackColor = True
        '
        'main_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 797)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "main_menu"
        Me.Text = "Main_menu"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblmain_menu As Label
    Friend WithEvents btnCustomerMaster As Button
    Friend WithEvents btnSystem As Button
    Friend WithEvents btnSaleRegist As Button
    Friend WithEvents btnGoods As Button
    Friend WithEvents btnInvoice As Button
    Friend WithEvents btnSalelst As Button
End Class


