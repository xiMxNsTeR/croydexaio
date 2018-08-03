<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.usrBtn = New System.Windows.Forms.Button()
        Me.adminBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 236)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'usrBtn
        '
        Me.usrBtn.Location = New System.Drawing.Point(12, 254)
        Me.usrBtn.Name = "usrBtn"
        Me.usrBtn.Size = New System.Drawing.Size(132, 40)
        Me.usrBtn.TabIndex = 1
        Me.usrBtn.Text = "User"
        Me.usrBtn.UseVisualStyleBackColor = True
        '
        'adminBtn
        '
        Me.adminBtn.Location = New System.Drawing.Point(208, 254)
        Me.adminBtn.Name = "adminBtn"
        Me.adminBtn.Size = New System.Drawing.Size(132, 40)
        Me.adminBtn.TabIndex = 2
        Me.adminBtn.Text = "Admin"
        Me.adminBtn.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(352, 304)
        Me.Controls.Add(Me.adminBtn)
        Me.Controls.Add(Me.usrBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "main"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents usrBtn As Button
    Friend WithEvents adminBtn As Button
End Class
