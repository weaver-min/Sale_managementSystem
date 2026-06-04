Public Class frmproduct
    Private Sub frmproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProduct.Columns("colDelete").DefaultCellStyle.BackColor = Color.Red
        dgvProduct.Columns("colDelete").DefaultCellStyle.ForeColor = Color.Black
        dgvProduct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvProduct.EnableHeadersVisualStyles = False
        dgvProduct.Font = New Font("Yu Gothic UI", 10)
        dgvProduct.ColumnHeadersDefaultCellStyle.Font =
        New Font("Yu Gothic UI", 10, FontStyle.Bold)
        dgvProduct.ColumnHeadersHeight = 35
    End Sub
End Class