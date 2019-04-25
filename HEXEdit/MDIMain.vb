Public Class MDIMain

    Private m_ChildFormNumber As Integer

    Public Sub New()
        ' 此為設計工具所需的呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。
        If My.Settings.StartupPath = "" Then
            My.Settings.StartupPath = Application.StartupPath
            'My.Settings.Save()
        End If

    End Sub


    Private Sub ToolStripMenuItemFileOpen_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItemFileOpen.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Settings.StartupPath   'My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            My.Settings.StartupPath = FileIO.FileSystem.GetFileInfo(FileName).DirectoryName
            'My.Settings.Save()
            ' TODO: 在此加入開啟檔案的程式碼。




            ' 建立子表單的新執行個體。
            Dim ChildForm As New frmMain 'System.Windows.Forms.Form
            ' 將它變成這個 MDI 表單的子表單，然後才顯示。
            ChildForm.MdiParent = Me

            m_ChildFormNumber += 1
            ChildForm.Text = "視窗 " & m_ChildFormNumber
            ChildForm.Filename = FileName
            ChildForm.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItemFileSave_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItemFileSave.Click
        Dim ChildForm As frmMain = ActiveMdiChild
        ChildForm.SaveAs("")
    End Sub

    Private Sub ToolStripMenuItemFileSaveAs_Click(sender As Object, e As System.EventArgs) Handles ToolStripMenuItemFileSaveAs.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: 在此加入程式碼，將表單目前的內容儲存成檔案。
            Dim ChildForm As frmMain = ActiveMdiChild
            ChildForm.SaveAs(FileName)
        End If
    End Sub

    Private Sub ToolStripMenuItemToolHEX2DEC_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItemToolHEX2DEC.Click
        Dim ChildForm As frmHEX2DEC
        ChildForm = frmHEX2DEC
        ChildForm.Show()
    End Sub

    Private Sub MDIMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
    End Sub

    Private Sub MDIMain_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        Dim nWidth As Int32 = Me.Width - 32
        ToolStripStatusLabel4.Width = nWidth / 2
        ToolStripProgressBar1.Width = nWidth / 8
        ToolStripStatusLabel1.Width = nWidth / 8
        ToolStripStatusLabel2.Width = nWidth / 8
        ToolStripStatusLabel3.Width = nWidth / 8
    End Sub

    Private Sub ToolStripMenuItemGameSWD2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItemGameSWD2.Click
        Dim lFind As Boolean = False
        Dim ChildForm As Form
        For Each ChildForm In Me.MdiChildren
            If ChildForm.Name = "SWD2" Then
                lFind = True
            End If
        Next ChildForm
        If lFind Then
            ChildForm.show()
        Else
            ChildForm = New frmSWD2(frmSWD2.nmGameType.SWD2)
            ChildForm.MdiParent = Me
            m_ChildFormNumber += 1
            ChildForm.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItemGameSWDA_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItemGameSWDA.Click
        Dim lFind As Boolean = False
        Dim ChildForm As Form
        For Each ChildForm In Me.MdiChildren
            If ChildForm.Name = "SWDA" Then
                lFind = True
            End If
        Next ChildForm
        If lFind Then
            ChildForm.Show()
        Else
            ChildForm = New frmSWD2(frmSWD2.nmGameType.SWDA)
            ChildForm.MdiParent = Me
            m_ChildFormNumber += 1
            ChildForm.Show()
        End If
    End Sub
End Class