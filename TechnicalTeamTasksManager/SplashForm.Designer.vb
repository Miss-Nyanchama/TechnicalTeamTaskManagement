<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        splashTimer = New Timer(components)
        lblLoading = New Label()
        lblTitle = New Label()
        ProgressBar1 = New ProgressBar()
        lblConnectionsStatus = New Label()
        SuspendLayout()
        ' 
        ' splashTimer
        ' 
        splashTimer.Interval = 500
        ' 
        ' lblLoading
        ' 
        lblLoading.AutoSize = True
        lblLoading.Location = New Point(291, 132)
        lblLoading.Name = "lblLoading"
        lblLoading.Size = New Size(142, 15)
        lblLoading.TabIndex = 0
        lblLoading.Text = "Connecting to database..."
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(182, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(413, 32)
        lblTitle.TabIndex = 1
        lblTitle.Text = "TECHNICAL TEAM TASK MANAGER"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(291, 182)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(100, 23)
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.TabIndex = 2
        ' 
        ' lblConnectionsStatus
        ' 
        lblConnectionsStatus.AutoSize = True
        lblConnectionsStatus.Location = New Point(291, 237)
        lblConnectionsStatus.Name = "lblConnectionsStatus"
        lblConnectionsStatus.Size = New Size(179, 15)
        lblConnectionsStatus.TabIndex = 3
        lblConnectionsStatus.Text = "Checking database connection..."
        ' 
        ' SplashForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(834, 461)
        Controls.Add(lblConnectionsStatus)
        Controls.Add(ProgressBar1)
        Controls.Add(lblTitle)
        Controls.Add(lblLoading)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MinimizeBox = False
        Name = "SplashForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Technical Team Task Manager"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents splashTimer As Timer
    Friend WithEvents lblLoading As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblConnectionsStatus As Label

End Class
