Imports System.IO
Imports System.IO.FileStream
Imports System.Xml
Imports System.Data.OleDb
Imports System.Drawing

Class myListItem
    Dim mText As String
    Dim mValue As Object

    Public Sub New(NewText As String, NewValue As Object)
        mText = NewText
        mValue = NewValue
    End Sub

    Public Overrides Function ToString() As String
        Return mText
    End Function

    Public ReadOnly Property Value As Object
        Get
            Return mValue
        End Get
    End Property
End Class

Module mdlMain

    'Public StartupPath As String

    Public Function OpenFile(ByVal Filename As String) As Byte()
        '參考資料來源： https://dotblogs.com.tw/yc421206/archive/2009/01/15/6829.aspx
        '引用File類別開啟檔案，引用至FileStream類別
        Dim myFile As FileStream = File.Open(Filename, FileMode.OpenOrCreate, FileAccess.Read)
        '引用BinaryReader類別
        Dim myReader As BinaryReader = New BinaryReader(myFile)
        '利用Length屬取得資料筆數(有多少組位元)
        Dim dl As UInt32 = System.Convert.ToInt32(myFile.Length)
        '將讀取的位元組存放至陣列
        Dim myData As Byte() = myReader.ReadBytes(dl)
        '釋放資源
        myReader.Close()
        myFile.Close()
        Return myData
    End Function

    Public Sub SaveFile(ByVal myData As Byte(), ByVal Filename As String)
        '參考資料來源： https://dotblogs.com.tw/yc421206/archive/2009/01/15/6829.aspx
        '引用File類別開啟檔案，引用至FileStream類別
        Dim myFile As FileStream = File.Open(Filename, FileMode.OpenOrCreate, FileAccess.Write)
        '引用BinaryWriter類別
        Dim myWriter As BinaryWriter = New BinaryWriter(myFile)
        '寫檔
        myWriter.Write(myData)
        '釋放資源
        myWriter.Close()
        myFile.Close()
    End Sub

    Public Function HEX2DEC(hex As String) As Integer
        Dim nDEC As Integer = 0
        If hex Is Nothing Then hex = "00"
        hex = hex.ToUpper
        For i As Integer = hex.Length - 1 To 0 Step -1
            Dim x As String = hex.Substring(i, 1)
            If Not IsNumeric(x) Then
                Select Case x
                    Case "A"
                        x = 10
                    Case "B"
                        x = 11
                    Case "C"
                        x = 12
                    Case "D"
                        x = 13
                    Case "E"
                        x = 14
                    Case "F"
                        x = 15
                End Select
            End If
            nDEC = nDEC + x * 16 ^ (hex.Length - 1 - i)
        Next i
        Return nDEC
    End Function

    Public Function LoadItemList(TABLENAME As String, Optional FIELD As String = "*") As DataTable
        Using cn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\ITEMLLIST.mdb")
            cn.Open()
            Dim cSQL As String = "SELECT " & FIELD & " FROM " & TABLENAME & " ORDER BY TYPE" & IIf(FIELD = "*", ", HEX", "")
            Using cmd As OleDbCommand = New OleDbCommand(cSQL, cn)
                Using da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                    Using ds As New DataSet
                        da.Fill(ds)
                        Return ds.Tables(0)
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function LoadStrategy(Game As String) As DataTable
        Using cn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\ITEMLLIST.mdb")
            cn.Open()
            Dim cSQL As String = "SELECT * FROM STRATEGY WHERE GAME = '" & Game & "' ORDER BY TYPE"
            Using cmd As OleDbCommand = New OleDbCommand(cSQL, cn)
                Using da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                    Using ds As New DataSet
                        da.Fill(ds)
                        Return ds.Tables(0)
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Sub DataGridView_KeyDown(dgv As DataGridView, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            Using sc As DataGridViewCell = dgv.SelectedCells(0)
                If sc.ColumnIndex = dgv.ColumnCount - 1 Then
                    If sc.RowIndex = dgv.RowCount - 1 Then
                        Application.DoEvents()
                    Else
                        My.Computer.Keyboard.SendKeys("{HOME}{DOWN}", True)
                    End If
                Else
                    My.Computer.Keyboard.SendKeys("{RIGHT}", True)
                End If
            End Using
        ElseIf e.KeyCode = Keys.Right Then
            Using sc As DataGridViewCell = dgv.SelectedCells(0)
                If sc.ColumnIndex = dgv.ColumnCount - 1 Then
                    If sc.RowIndex = dgv.RowCount - 1 Then
                        Application.DoEvents()
                    Else
                        e.Handled = True
                        My.Computer.Keyboard.SendKeys("{HOME}{DOWN}", True)
                    End If
                Else
                    Application.DoEvents()
                End If
            End Using
        ElseIf e.KeyCode = Keys.Left Then
            Using sc As DataGridViewCell = dgv.SelectedCells(0)
                If sc.ColumnIndex = 0 Then
                    If sc.RowIndex = 0 Then
                        Application.DoEvents()
                    Else
                        e.Handled = True
                        My.Computer.Keyboard.SendKeys("{END}{UP}", True)
                    End If
                Else
                    Application.DoEvents()
                End If
            End Using
        End If
    End Sub

    Public Function TextWidth(text As String, font As System.Drawing.Font) As Long
        Using p As PictureBox = New PictureBox
            Using g As Graphics = p.CreateGraphics
                Dim f As Drawing.SizeF = g.MeasureString(text, font)
                Return f.Width
            End Using
        End Using
    End Function
End Module
