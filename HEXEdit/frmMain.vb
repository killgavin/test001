
Public Class frmMain

    Private mcFilename As String

    Private myData As Byte()

    Private WithEvents TextEdit As DataGridViewTextBoxEditingControl


    Public Property Filename As String
        Get
            Return mcFilename
        End Get
        Set(value As String)
            mcFilename = value
        End Set
    End Property



    Public Sub SaveAs(Optional ByVal NewFilename As String = "")
        If NewFilename = "" Then NewFilename = mcFilename
        SaveFile(myData, NewFilename)
    End Sub



    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        On Error GoTo ErrHandle
        If mcFilename.Length = 0 Then
        Else
            Me.Text = mcFilename
            myData = OpenFile(mcFilename)
            '丟到Grid上
            Dim a(15), b(15), c(7) As String, i, n, r As UInt32
            For i = 0 To myData.GetUpperBound(0)
                n = i Mod 16
                a(n) = Hex(myData(i)).PadLeft(2, "0")
                b(n) = Chr(myData(i))
                If (n + 1) Mod 2 = 0 Then
                    c(n \ 2) = ChrW(myData(i) * 256 + myData(i - 1))
                End If
                If (i + 1) Mod 16 = 0 Then
                    r = DataGridView1.Rows.Add(a)
                    DataGridView1.Rows(r).HeaderCell.Value = Hex(r * 16).PadLeft(4, "0")
                    DataGridView2.Rows.Add(b)
                    DataGridView3.Rows.Add(c)
                    ReDim a(15), b(15), c(7)
                End If
            Next i
            If (i) Mod 16 <> 0 Then
                r = DataGridView1.Rows.Add(a)
                DataGridView1.Rows(r).HeaderCell.Value = Hex(r * 16).PadLeft(4, "0")
                DataGridView2.Rows.Add(b)
                DataGridView3.Rows.Add(c)
            End If
        End If
        Exit Sub
ErrHandle:
        MsgBox(Err.Number & Err.Description)
        Resume
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        DataGridView_KeyDown(CType(sender, DataGridView), e)
    End Sub

    Private Sub DataGridView_Scroll(sender As Object, e As System.Windows.Forms.ScrollEventArgs) Handles DataGridView1.Scroll, DataGridView2.Scroll, DataGridView3.Scroll
        If sender.name <> DataGridView1.Name Then DataGridView1.FirstDisplayedScrollingRowIndex = e.NewValue
        If sender.name <> DataGridView2.Name Then DataGridView2.FirstDisplayedScrollingRowIndex = e.NewValue
        If sender.name <> DataGridView3.Name Then DataGridView3.FirstDisplayedScrollingRowIndex = e.NewValue
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.ToUpper

        Dim i As Integer = e.RowIndex * 16 + e.ColumnIndex
        If i > myData.GetUpperBound(0) Then
            If i Mod 2 = 1 Then
                ReDim Preserve myData(i)
            Else
                ReDim Preserve myData(i + 1)
            End If
        End If
        myData(i) = HEX2DEC(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

        DataGridView2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Chr(myData(i))
        If e.ColumnIndex Mod 2 = 1 Then
            DataGridView3.Rows(e.RowIndex).Cells(e.ColumnIndex \ 2).Value = ChrW(myData(i) * 256 + myData(i - 1))
        Else
            DataGridView3.Rows(e.RowIndex).Cells(e.ColumnIndex \ 2).Value = ChrW(myData(i + 1) * 256 + myData(i))
        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        TextEdit = DataGridView1.EditingControl
        TextEdit.MaxLength = 2
    End Sub

    Private Sub DataGridViewTextBoxEditingControl_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextEdit.KeyPress
        Dim r As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("^[0-9a-fA-F]")
        If r.IsMatch(e.KeyChar.ToString) Then
            e.KeyChar = UCase(e.KeyChar)
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
