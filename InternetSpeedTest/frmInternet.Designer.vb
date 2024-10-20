<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInternet
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
        lblHaeding = New Label()
        lblAverage = New Label()
        btnSpeedTest = New Button()
        lstSpeedTest = New ListBox()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ClearToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblHaeding
        ' 
        lblHaeding.AutoSize = True
        lblHaeding.BackColor = Color.White
        lblHaeding.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHaeding.Location = New Point(177, 28)
        lblHaeding.Name = "lblHaeding"
        lblHaeding.Size = New Size(387, 33)
        lblHaeding.TabIndex = 0
        lblHaeding.Text = "Internet Speed Test Survey"
        ' 
        ' lblAverage
        ' 
        lblAverage.AutoSize = True
        lblAverage.BackColor = Color.White
        lblAverage.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAverage.Location = New Point(36, 257)
        lblAverage.Name = "lblAverage"
        lblAverage.Size = New Size(92, 29)
        lblAverage.TabIndex = 1
        lblAverage.Text = "Label1"
        ' 
        ' btnSpeedTest
        ' 
        btnSpeedTest.BackColor = Color.White
        btnSpeedTest.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSpeedTest.Location = New Point(255, 115)
        btnSpeedTest.Name = "btnSpeedTest"
        btnSpeedTest.Size = New Size(231, 34)
        btnSpeedTest.TabIndex = 2
        btnSpeedTest.Text = "Enter Internet Speed"
        btnSpeedTest.UseVisualStyleBackColor = False
        ' 
        ' lstSpeedTest
        ' 
        lstSpeedTest.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstSpeedTest.ForeColor = Color.PowderBlue
        lstSpeedTest.FormattingEnabled = True
        lstSpeedTest.ItemHeight = 23
        lstSpeedTest.Location = New Point(597, 101)
        lstSpeedTest.Name = "lstSpeedTest"
        lstSpeedTest.Size = New Size(55, 165)
        lstSpeedTest.TabIndex = 3
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(740, 24)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClearToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' ClearToolStripMenuItem
        ' 
        ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        ClearToolStripMenuItem.Size = New Size(180, 22)
        ClearToolStripMenuItem.Text = "&Clear"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(180, 22)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' frmInternet
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.internet
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(740, 420)
        Controls.Add(lstSpeedTest)
        Controls.Add(btnSpeedTest)
        Controls.Add(lblAverage)
        Controls.Add(lblHaeding)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.LightSkyBlue
        MainMenuStrip = MenuStrip1
        Name = "frmInternet"
        Text = "Internet Speed Test Survey For Home Users"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHaeding As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents btnSpeedTest As Button
    Friend WithEvents lstSpeedTest As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem

End Class
