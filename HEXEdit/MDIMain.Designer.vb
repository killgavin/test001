<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItemFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparatorFile1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItemFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemGameSWD2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemToolHEX2DEC = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripMenuItemGameSWDA = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemFile, Me.ToolStripMenuItemGame, Me.ToolStripMenuItemTool})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1021, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItemFile
        '
        Me.ToolStripMenuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemFileOpen, Me.ToolStripSeparatorFile1, Me.ToolStripMenuItemFileSave, Me.ToolStripMenuItemFileSaveAs})
        Me.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile"
        Me.ToolStripMenuItemFile.Size = New System.Drawing.Size(58, 20)
        Me.ToolStripMenuItemFile.Text = "檔案(&F)"
        '
        'ToolStripMenuItemFileOpen
        '
        Me.ToolStripMenuItemFileOpen.Name = "ToolStripMenuItemFileOpen"
        Me.ToolStripMenuItemFileOpen.Size = New System.Drawing.Size(142, 22)
        Me.ToolStripMenuItemFileOpen.Text = "開啟舊擋(&O)"
        '
        'ToolStripSeparatorFile1
        '
        Me.ToolStripSeparatorFile1.Name = "ToolStripSeparatorFile1"
        Me.ToolStripSeparatorFile1.Size = New System.Drawing.Size(139, 6)
        '
        'ToolStripMenuItemFileSave
        '
        Me.ToolStripMenuItemFileSave.Name = "ToolStripMenuItemFileSave"
        Me.ToolStripMenuItemFileSave.Size = New System.Drawing.Size(142, 22)
        Me.ToolStripMenuItemFileSave.Text = "儲存(&S)"
        '
        'ToolStripMenuItemFileSaveAs
        '
        Me.ToolStripMenuItemFileSaveAs.Name = "ToolStripMenuItemFileSaveAs"
        Me.ToolStripMenuItemFileSaveAs.Size = New System.Drawing.Size(142, 22)
        Me.ToolStripMenuItemFileSaveAs.Text = "另存新檔(&A)"
        '
        'ToolStripMenuItemGame
        '
        Me.ToolStripMenuItemGame.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemGameSWD2, Me.ToolStripMenuItemGameSWDA})
        Me.ToolStripMenuItemGame.Name = "ToolStripMenuItemGame"
        Me.ToolStripMenuItemGame.Size = New System.Drawing.Size(85, 20)
        Me.ToolStripMenuItemGame.Text = "遊戲修改(&G)"
        '
        'ToolStripMenuItemGameSWD2
        '
        Me.ToolStripMenuItemGameSWD2.Name = "ToolStripMenuItemGameSWD2"
        Me.ToolStripMenuItemGameSWD2.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItemGameSWD2.Text = "軒轅劍2"
        '
        'ToolStripMenuItemTool
        '
        Me.ToolStripMenuItemTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemToolHEX2DEC})
        Me.ToolStripMenuItemTool.Name = "ToolStripMenuItemTool"
        Me.ToolStripMenuItemTool.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripMenuItemTool.Text = "工具"
        '
        'ToolStripMenuItemToolHEX2DEC
        '
        Me.ToolStripMenuItemToolHEX2DEC.Name = "ToolStripMenuItemToolHEX2DEC"
        Me.ToolStripMenuItemToolHEX2DEC.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripMenuItemToolHEX2DEC.Text = "HEX2DEC"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 682)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1021, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.AutoSize = False
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(132, 17)
        Me.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.AutoSize = False
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(132, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.AutoSize = False
        Me.ToolStripStatusLabel2.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(132, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.AutoSize = False
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(132, 17)
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItemGameSWDA
        '
        Me.ToolStripMenuItemGameSWDA.Name = "ToolStripMenuItemGameSWDA"
        Me.ToolStripMenuItemGameSWDA.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItemGameSWDA.Text = "軒轅劍外傳楓之舞"
        '
        'MDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 704)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIMain"
        Me.Text = "MDIMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItemFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemGameSWD2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparatorFile1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemFileSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemToolHEX2DEC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItemGameSWDA As System.Windows.Forms.ToolStripMenuItem
End Class
