Public Class frmSWD2

    Enum nmGameType
        SWD2
        SWDA
    End Enum

    Private Structure GameValue
        Dim Type As nmGameType
        Dim Table As String
        Dim Filter As String
        Dim Displacement As Integer
        Dim MedicineDisplacement As Integer
    End Structure


    Dim myData As Byte()
    Dim ItemList As DataTable
    Dim mGameValue As GameValue

    Public Property Name As String
        Set(value As String)
            mGameValue.Table = value
        End Set
        Get
            Return mGameValue.Table
        End Get
    End Property

    Public Sub New(GameType As nmGameType)
        ' 此為設計工具所需的呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。

        mGameValue.Type = GameType
        Select Case mGameValue.Type
            Case nmGameType.SWD2
                mGameValue.Table = "SWD2"
                mGameValue.Filter = "SAVE.DA*|SAVE.DA*"
                mGameValue.Displacement = 0
                mGameValue.MedicineDisplacement = 0
                Me.Text = "軒轅劍2"
            Case nmGameType.SWDA
                mGameValue.Table = "SWDA"
                mGameValue.Filter = "SAVE.ZA*|SAVE.ZA*"
                mGameValue.Displacement = 23
                mGameValue.MedicineDisplacement = 263
                Me.Text = "軒轅劍外傳楓之舞"
            Case Else
                mGameValue.Table = "SWD2"
                mGameValue.Filter = "SAVE.DA*|SAVE.DA*"
                mGameValue.Displacement = 0
                mGameValue.MedicineDisplacement = 0
                Me.Text = "軒轅劍2"
        End Select

        DataGridView1.Rows.Add(8)
        DataGridView1.Rows(0).HeaderCell.Value = "經驗"
        DataGridView1.Rows(1).HeaderCell.Value = "力量"
        DataGridView1.Rows(2).HeaderCell.Value = "智慧"
        DataGridView1.Rows(3).HeaderCell.Value = "敏捷"
        DataGridView1.Rows(4).HeaderCell.Value = "運氣"
        DataGridView1.Rows(5).HeaderCell.Value = "反應力"
        DataGridView1.Rows(6).HeaderCell.Value = "閃避率"
        DataGridView1.Rows(7).HeaderCell.Value = "等級"
        DataGridView1.Rows(7).ReadOnly = True

        Select Case mGameValue.Type
            Case nmGameType.SWD2
                DataGridView1.Columns(0).HeaderText = "何然"
                DataGridView1.Columns(1).HeaderText = "江如紅"
                DataGridView1.Columns(2).HeaderText = "楊坤碩"
                DataGridView1.Columns(3).HeaderText = "古月聖"

                DataGridView3.Visible = False
            Case nmGameType.SWDA
                DataGridView1.Columns(0).HeaderText = "輔子徹"
                DataGridView1.Columns(1).HeaderText = "機關人"
                DataGridView1.Columns(2).HeaderText = "桑紋錦"
                DataGridView1.Columns(3).HeaderText = "鑄石子"

                DataGridView1.Rows.Add(5)
                DataGridView1.Rows(8).HeaderCell.Value = "抗力-物(0~4)"
                DataGridView1.Rows(9).HeaderCell.Value = "抗力-熱(0~4)"
                DataGridView1.Rows(10).HeaderCell.Value = "抗力-冷(0~4)"
                DataGridView1.Rows(11).HeaderCell.Value = "抗力-毒(0~4)"
                DataGridView1.Rows(12).HeaderCell.Value = "抗力-魔(0~4)"
                DataGridView1.RowHeadersWidth = TextWidth("抗力-魔(0~4)", DataGridView1.Font) + 35


                DataGridView3.Rows.Add(24)
                DataGridView3.Rows(0).HeaderCell.Value = "血芝麻(綠)" : DataGridView3.Rows(0).Cells(1).Value = 40
                DataGridView3.Rows(1).HeaderCell.Value = "血芝麻(白)" : DataGridView3.Rows(1).Cells(1).Value = 110
                DataGridView3.Rows(2).HeaderCell.Value = "血芝麻(紫)" : DataGridView3.Rows(2).Cells(1).Value = 40
                DataGridView3.Rows(3).HeaderCell.Value = "青魚牙(綠)" : DataGridView3.Rows(3).Cells(1).Value = 40
                DataGridView3.Rows(4).HeaderCell.Value = "青魚牙(紫)" : DataGridView3.Rows(4).Cells(1).Value = 40
                DataGridView3.Rows(5).HeaderCell.Value = "青魚牙(白)" : DataGridView3.Rows(5).Cells(1).Value = 40
                DataGridView3.Rows(6).HeaderCell.Value = "金蠶(綠)" : DataGridView3.Rows(6).Cells(1).Value = 1000
                DataGridView3.Rows(7).HeaderCell.Value = "金蠶(無)" : DataGridView3.Rows(7).Cells(1).Value = 1000
                DataGridView3.Rows(8).HeaderCell.Value = "金蠶(紅)" : DataGridView3.Rows(8).Cells(1).Value = 1000
                DataGridView3.Rows(9).HeaderCell.Value = "遊雲(紫)" : DataGridView3.Rows(9).Cells(1).Value = 20
                DataGridView3.Rows(10).HeaderCell.Value = "遊雲(黃)" : DataGridView3.Rows(10).Cells(1).Value = 30
                DataGridView3.Rows(11).HeaderCell.Value = "遊雲(青)" : DataGridView3.Rows(11).Cells(1).Value = 40
                DataGridView3.Rows(12).HeaderCell.Value = "岩蟻(紫)" : DataGridView3.Rows(12).Cells(1).Value = 3000
                DataGridView3.Rows(13).HeaderCell.Value = "岩蟻(棕)" : DataGridView3.Rows(13).Cells(1).Value = 3000
                DataGridView3.Rows(14).HeaderCell.Value = "岩蟻(黃)" : DataGridView3.Rows(14).Cells(1).Value = 3000
                DataGridView3.Rows(15).HeaderCell.Value = "龍麟(黃)" : DataGridView3.Rows(15).Cells(1).Value = 2000
                DataGridView3.Rows(16).HeaderCell.Value = "龍麟(綠)" : DataGridView3.Rows(16).Cells(1).Value = 3000
                DataGridView3.Rows(17).HeaderCell.Value = "龍鱗(藍)" : DataGridView3.Rows(17).Cells(1).Value = 4000
                DataGridView3.Rows(18).HeaderCell.Value = "幻蟲(灰)" : DataGridView3.Rows(18).Cells(1).Value = 8000
                DataGridView3.Rows(19).HeaderCell.Value = "吐牛" : DataGridView3.Rows(19).Cells(1).Value = 8000
                DataGridView3.Rows(20).HeaderCell.Value = "冰針(黃)" : DataGridView3.Rows(20).Cells(1).Value = 2100
                DataGridView3.Rows(21).HeaderCell.Value = "冰針(綠)" : DataGridView3.Rows(21).Cells(1).Value = 3000
                DataGridView3.Rows(22).HeaderCell.Value = "冰針(青)" : DataGridView3.Rows(22).Cells(1).Value = 4000
                DataGridView3.Rows(23).HeaderCell.Value = "幻蟲(紫)" : DataGridView3.Rows(23).Cells(1).Value = 8000
            Case Else
                DataGridView1.Columns(0).HeaderText = "何然"
                DataGridView1.Columns(1).HeaderText = "江如紅"
                DataGridView1.Columns(2).HeaderText = "楊坤碩"
                DataGridView1.Columns(3).HeaderText = "古月聖"

                DataGridView3.Visible = False
        End Select

        Using dt As DataTable = LoadItemList(mGameValue.Table & "LIST", "DISTINCT TYPE")
            ComboBox1.Items.Add("<全選>")
            For Each r As DataRow In dt.Rows
                ComboBox1.Items.Add(r.Item(0))
            Next r
        End Using

        ItemList = LoadItemList(mGameValue.Table & "LIST")
        ItemList.PrimaryKey = {ItemList.Columns("HEX")}
        DataGridView2.DataSource = ItemList
        DataGridView2.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridView2.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView2.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView2.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView2.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        ComboBox1.SelectedIndex = 0

        Using dt As DataTable = LoadStrategy(mGameValue.Table)
            If dt.Rows.Count > 0 Then
                txtMemo.Text = dt.Rows(0).Item("MEMO")
                TextBox6.Text = dt.Rows(1).Item("MEMO")
            End If
        End Using
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Settings.StartupPath   'My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = mGameValue.Filter
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            My.Settings.StartupPath = FileIO.FileSystem.GetFileInfo(FileName).DirectoryName
            'My.Settings.Save()
            txtSaveFilename.Text = FileName
            myData = OpenFile(FileName)
            LoadData()
        End If
    End Sub

    Private Sub LoadData()
        Dim i As Integer, cTmp As String

        '人物
        For i = 0 To 3
            With DataGridView1
                .Item(i, 0).Value = myData(320 + 159 * i + mGameValue.Displacement) * 256 + myData(319 + 159 * i + mGameValue.Displacement) '經驗
                .Item(i, 1).Value = myData(324 + 159 * i + mGameValue.Displacement) * 256 + myData(323 + 159 * i + mGameValue.Displacement) '力量
                .Item(i, 2).Value = myData(332 + 159 * i + mGameValue.Displacement) * 256 + myData(331 + 159 * i + mGameValue.Displacement) '智慧
                .Item(i, 3).Value = myData(340 + 159 * i + mGameValue.Displacement) * 256 + myData(339 + 159 * i + mGameValue.Displacement) '敏捷
                .Item(i, 4).Value = myData(314 + 159 * i + mGameValue.Displacement) * 256 + myData(313 + 159 * i + mGameValue.Displacement) '運氣
                .Item(i, 5).Value = myData(356 + 159 * i + mGameValue.Displacement) * 256 + myData(355 + 159 * i + mGameValue.Displacement) '反應力
                .Item(i, 6).Value = myData(364 + 159 * i + mGameValue.Displacement) * 256 + myData(363 + 159 * i + mGameValue.Displacement) '閃避率
                .Item(i, 7).Value = myData(312 + 159 * i + mGameValue.Displacement) * 256 + myData(311 + 159 * i + mGameValue.Displacement) '等級
            End With
        Next i
        'SWDA的抗力
        If mGameValue.Type = nmGameType.SWDA Then
            For i = 0 To 3
                With DataGridView1
                    .Item(i, 8).Value = myData(323 + 159 * i)
                    .Item(i, 9).Value = myData(324 + 159 * i)
                    .Item(i, 10).Value = myData(325 + 159 * i)
                    .Item(i, 11).Value = myData(326 + 159 * i)
                    .Item(i, 12).Value = myData(327 + 159 * i)
                End With
            Next i
        End If


        '物品
        ListBox1.Items.Clear()
        Label5.Enabled = False : TextBox1.Enabled = False : Label10.Enabled = False
        Label6.Enabled = False : TextBox2.Enabled = False : Label11.Enabled = False
        Label7.Enabled = False : TextBox3.Enabled = False : Label12.Enabled = False
        Label8.Enabled = False : TextBox4.Enabled = False : Label13.Enabled = False
        Label9.Enabled = False : TextBox5.Enabled = False : Label14.Enabled = False
        For i = 898 To 997 Step 2
            cTmp = Hex(myData(i + mGameValue.Displacement)).PadLeft(2, "0") & " " & Hex(myData(i + 1 + mGameValue.Displacement)).PadLeft(2, "0")
            If cTmp <> "00 00" Then
                Dim dr As DataRow = ItemList.Rows.Find(cTmp)
                If dr IsNot Nothing Then
                    Dim item As New myListItem(dr.Item("NAME"), dr.Item("HEX"))
                    ListBox1.Items.Add(item)
                    Select Case cTmp
                        Case "44 00"
                            Label5.Enabled = True : TextBox1.Enabled = True : Label10.Enabled = True : TextBox1.Text = myData(999 + mGameValue.MedicineDisplacement) * 256 + myData(998 + mGameValue.MedicineDisplacement)
                        Case "45 00"
                            Label6.Enabled = True : TextBox2.Enabled = True : Label11.Enabled = True : TextBox2.Text = myData(1001 + mGameValue.MedicineDisplacement) * 256 + myData(1000 + mGameValue.MedicineDisplacement)
                        Case "46 00"
                            Label7.Enabled = True : TextBox3.Enabled = True : Label12.Enabled = True : TextBox3.Text = myData(1003 + mGameValue.MedicineDisplacement) * 256 + myData(1002 + mGameValue.MedicineDisplacement)
                        Case "47 00"
                            Label8.Enabled = True : TextBox4.Enabled = True : Label13.Enabled = True : TextBox4.Text = myData(1005 + mGameValue.MedicineDisplacement) * 256 + myData(1004 + mGameValue.MedicineDisplacement)
                        Case "48 00"
                            Label9.Enabled = True : TextBox5.Enabled = True : Label14.Enabled = True : TextBox5.Text = myData(1007 + mGameValue.MedicineDisplacement) * 256 + myData(1006 + mGameValue.MedicineDisplacement)
                        Case Else
                    End Select
                Else
                    Dim item As New myListItem(cTmp, cTmp)
                    ListBox1.Items.Add(item)
                End If
            End If
        Next i

        '其他
        '金錢
        txtMoney.Text = myData(261 + mGameValue.Displacement) * 256 + myData(260 + mGameValue.Displacement)
        'SWD2的法寶
        If mGameValue.Type = nmGameType.SWDA Then
            DataGridView3.Rows(0).Cells(0).Value = myData(1606) * 256 + myData(1605)
            DataGridView3.Rows(1).Cells(0).Value = myData(1608) * 256 + myData(1607)
            DataGridView3.Rows(2).Cells(0).Value = myData(1610) * 256 + myData(1609)
            DataGridView3.Rows(3).Cells(0).Value = myData(1612) * 256 + myData(1611)
            DataGridView3.Rows(4).Cells(0).Value = myData(1614) * 256 + myData(1613)
            DataGridView3.Rows(5).Cells(0).Value = myData(1616) * 256 + myData(1615)
            DataGridView3.Rows(6).Cells(0).Value = myData(1618) * 256 + myData(1617)
            DataGridView3.Rows(7).Cells(0).Value = myData(1620) * 256 + myData(1619)
            DataGridView3.Rows(8).Cells(0).Value = myData(1622) * 256 + myData(1621)
            DataGridView3.Rows(9).Cells(0).Value = myData(1624) * 256 + myData(1623)
            DataGridView3.Rows(10).Cells(0).Value = myData(1626) * 256 + myData(1625)
            DataGridView3.Rows(11).Cells(0).Value = myData(1628) * 256 + myData(1627)
            DataGridView3.Rows(12).Cells(0).Value = myData(1630) * 256 + myData(1629)
            DataGridView3.Rows(13).Cells(0).Value = myData(1632) * 256 + myData(1631)
            DataGridView3.Rows(14).Cells(0).Value = myData(1634) * 256 + myData(1633)
            DataGridView3.Rows(15).Cells(0).Value = myData(1636) * 256 + myData(1635)
            DataGridView3.Rows(16).Cells(0).Value = myData(1638) * 256 + myData(1637)
            DataGridView3.Rows(17).Cells(0).Value = myData(1640) * 256 + myData(1639)
            DataGridView3.Rows(18).Cells(0).Value = myData(1642) * 256 + myData(1641)
            DataGridView3.Rows(19).Cells(0).Value = myData(1644) * 256 + myData(1643)
            DataGridView3.Rows(20).Cells(0).Value = myData(1646) * 256 + myData(1645)
            DataGridView3.Rows(21).Cells(0).Value = myData(1648) * 256 + myData(1647)
            DataGridView3.Rows(22).Cells(0).Value = myData(1650) * 256 + myData(1649)
            DataGridView3.Rows(23).Cells(0).Value = myData(1652) * 256 + myData(1651)
        End If

        Label4.Text = ListBox1.Items.Count & " / 50"
    End Sub

    Private Sub SaveData()
        Dim i, j As Integer, cTmp As String, nTmp As UInt32

        '人物
        For i = 0 To 3
            With DataGridView1
                '經驗
                nTmp = System.Convert.ToUInt32(.Item(i, 0).Value)
                myData(320 + 159 * i + mGameValue.Displacement) = nTmp \ 256
                myData(319 + 159 * i + mGameValue.Displacement) = nTmp Mod 256
                '力量
                nTmp = System.Convert.ToUInt32(.Item(i, 1).Value)
                myData(324 + 159 * i + mGameValue.Displacement) = nTmp \ 256
                myData(323 + 159 * i + mGameValue.Displacement) = nTmp Mod 256
                '智慧
                nTmp = System.Convert.ToUInt32(.Item(i, 2).Value)
                myData(332 + 159 * i + mGameValue.Displacement) = nTmp \ 256
                myData(331 + 159 * i + mGameValue.Displacement) = nTmp Mod 256
                myData(334 + 159 * i + mGameValue.Displacement) = myData(332 + 159 * i)
                myData(333 + 159 * i + mGameValue.Displacement) = myData(331 + 159 * i)
                '敏捷
                nTmp = System.Convert.ToUInt32(.Item(i, 3).Value)
                myData(340 + 159 * i + mGameValue.Displacement) = nTmp \ 256
                myData(339 + 159 * i + mGameValue.Displacement) = nTmp Mod 256
                '運氣
                nTmp = System.Convert.ToUInt32(.Item(i, 4).Value)
                myData(314 + 159 * i + mGameValue.Displacement) = nTmp \ 256
                myData(313 + 159 * i + mGameValue.Displacement) = nTmp Mod 256
                '反應力
                nTmp = System.Convert.ToUInt32(.Item(i, 5).Value)
                myData(356 + 159 * i + mGameValue.Displacement) = nTmp \ 256
                myData(355 + 159 * i + mGameValue.Displacement) = nTmp Mod 256
                '閃避率
                nTmp = System.Convert.ToUInt32(.Item(i, 6).Value)
                myData(364 + 159 * i + mGameValue.Displacement) = nTmp \ 256
                myData(363 + 159 * i + mGameValue.Displacement) = nTmp Mod 256
                myData(366 + 159 * i + mGameValue.Displacement) = myData(364 + 159 * i)
                myData(365 + 159 * i + mGameValue.Displacement) = myData(363 + 159 * i)
            End With
        Next i
        'SWDA的抗力
        If mGameValue.Type = nmGameType.SWDA Then
            For i = 0 To 3
                With DataGridView1
                    nTmp = System.Convert.ToUInt32(.Item(i, 8).Value)
                    myData(323 + 159 * i) = nTmp
                    nTmp = System.Convert.ToUInt32(.Item(i, 9).Value)
                    myData(324 + 159 * i) = nTmp
                    nTmp = System.Convert.ToUInt32(.Item(i, 10).Value)
                    myData(325 + 159 * i) = nTmp
                    nTmp = System.Convert.ToUInt32(.Item(i, 11).Value)
                    myData(326 + 159 * i) = nTmp
                    nTmp = System.Convert.ToUInt32(.Item(i, 12).Value)
                    myData(327 + 159 * i) = nTmp
                End With
            Next i
        End If

        '物品
        j = 0
        For i = 898 To 997 Step 2
            If ListBox1.Items.Count - 1 >= j Then
                cTmp = ListBox1.Items(j).value
                myData(i + mGameValue.Displacement) = HEX2DEC(cTmp.Split(" ")(0))
                myData(i + 1 + mGameValue.Displacement) = HEX2DEC(cTmp.Split(" ")(1))
                j += 1
            Else
                myData(i + mGameValue.Displacement) = 0
                myData(i + 1 + mGameValue.Displacement) = 0
            End If
        Next i

        '其他
        '金錢
        nTmp = System.Convert.ToUInt32(txtMoney.Text)
        myData(261 + mGameValue.Displacement) = nTmp \ 256
        myData(260 + mGameValue.Displacement) = nTmp Mod 256
        '藥材數量
        If TextBox1.Enabled Then
            nTmp = System.Convert.ToUInt32(TextBox1.Text)
            myData(999 + mGameValue.MedicineDisplacement) = nTmp \ 256
            myData(998 + mGameValue.MedicineDisplacement) = nTmp Mod 256
        End If
        If TextBox2.Enabled Then
            nTmp = System.Convert.ToUInt32(TextBox2.Text)
            myData(1001 + mGameValue.MedicineDisplacement) = nTmp \ 256
            myData(1000 + mGameValue.MedicineDisplacement) = nTmp Mod 256
        End If
        If TextBox3.Enabled Then
            nTmp = System.Convert.ToUInt32(TextBox3.Text)
            myData(1003 + mGameValue.MedicineDisplacement) = nTmp \ 256
            myData(1002 + mGameValue.MedicineDisplacement) = nTmp Mod 256
        End If
        If TextBox4.Enabled Then
            nTmp = System.Convert.ToUInt32(TextBox4.Text)
            myData(1005 + mGameValue.MedicineDisplacement) = nTmp \ 256
            myData(1004 + mGameValue.MedicineDisplacement) = nTmp Mod 256
        End If
        If TextBox5.Enabled Then
            nTmp = System.Convert.ToUInt32(TextBox5.Text)
            myData(1007 + mGameValue.MedicineDisplacement) = nTmp \ 256
            myData(1006 + mGameValue.MedicineDisplacement) = nTmp Mod 256
        End If

        'SWD2的法寶
        If mGameValue.Type = nmGameType.SWDA Then
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(0).Cells(0).Value)
            myData(1606) = nTmp \ 256
            myData(1605) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(1).Cells(0).Value)
            myData(1608) = nTmp \ 256
            myData(1607) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(2).Cells(0).Value)
            myData(1610) = nTmp \ 256
            myData(1609) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(3).Cells(0).Value)
            myData(1612) = nTmp \ 256
            myData(1611) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(4).Cells(0).Value)
            myData(1614) = nTmp \ 256
            myData(1613) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(5).Cells(0).Value)
            myData(1616) = nTmp \ 256
            myData(1615) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(6).Cells(0).Value)
            myData(1618) = nTmp \ 256
            myData(1617) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(7).Cells(0).Value)
            myData(1620) = nTmp \ 256
            myData(1619) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(8).Cells(0).Value)
            myData(1622) = nTmp \ 256
            myData(1621) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(9).Cells(0).Value)
            myData(1624) = nTmp \ 256
            myData(1623) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(10).Cells(0).Value)
            myData(1626) = nTmp \ 256
            myData(1625) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(11).Cells(0).Value)
            myData(1628) = nTmp \ 256
            myData(1627) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(12).Cells(0).Value)
            myData(1630) = nTmp \ 256
            myData(1629) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(13).Cells(0).Value)
            myData(1632) = nTmp \ 256
            myData(1631) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(14).Cells(0).Value)
            myData(1634) = nTmp \ 256
            myData(1633) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(15).Cells(0).Value)
            myData(1636) = nTmp \ 256
            myData(1635) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(16).Cells(0).Value)
            myData(1638) = nTmp \ 256
            myData(1637) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(17).Cells(0).Value)
            myData(1640) = nTmp \ 256
            myData(1639) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(18).Cells(0).Value)
            myData(1642) = nTmp \ 256
            myData(1641) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(19).Cells(0).Value)
            myData(1644) = nTmp \ 256
            myData(1643) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(20).Cells(0).Value)
            myData(1646) = nTmp \ 256
            myData(1645) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(21).Cells(0).Value)
            myData(1648) = nTmp \ 256
            myData(1647) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(22).Cells(0).Value)
            myData(1650) = nTmp \ 256
            myData(1649) = nTmp Mod 256
            nTmp = System.Convert.ToUInt32(DataGridView3.Rows(23).Cells(0).Value)
            myData(1652) = nTmp \ 256
            myData(1651) = nTmp Mod 256
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        For i As Integer = ListBox1.SelectedItems.Count - 1 To 0 Step -1
            ListBox1.Items.Remove(ListBox1.SelectedItems(i))
        Next i
        Label4.Text = ListBox1.Items.Count & " / 50"
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        For Each dr As DataGridViewRow In DataGridView2.SelectedRows
            Dim item As New myListItem(dr.Cells("NAME").Value, dr.Cells("HEX").Value)
            ListBox1.Items.Add(item)
            If ListBox1.Items.Count >= 50 Then
                MsgBox("物品欄已滿！")
                Exit For
            End If
        Next dr
        DataGridView2.ClearSelection()
        Label4.Text = ListBox1.Items.Count & " / 50"
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If txtSaveFilename.Text <> "" Then
            SaveData()
            SaveFile(myData, txtSaveFilename.Text)
            MsgBox("儲存成功")
        End If
    End Sub

    Private Sub DataGridView1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        DataGridView_KeyDown(CType(sender, DataGridView), e)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            ItemList.DefaultView.RowFilter = ""
        Else
            ItemList.DefaultView.RowFilter = "TYPE = '" & ComboBox1.Text & "'"
        End If
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        If ListBox1.Items.Count + 1 > 50 Then
            MsgBox("物品欄已滿！")
        Else
            Using dr As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
                Dim item As myListItem = New myListItem(dr.Cells("NAME").Value, dr.Cells("HEX").Value)
                ListBox1.Items.Add(item)
            End Using
            Label4.Text = ListBox1.Items.Count & " / 50"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        TextBox7.Enabled = CheckBox1.Checked
        Button5.Enabled = CheckBox1.Checked
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        ItemList.DefaultView.RowFilter = "NAME LIKE '%" & TextBox7.Text & "%'"
    End Sub
End Class