<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Thx
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Thx))
        Me.lblThx = New System.Windows.Forms.Label()
        Me.lblPCA = New System.Windows.Forms.Label()
        Me.btnEXIT = New System.Windows.Forms.Button()
        Me.pbSmile = New System.Windows.Forms.PictureBox()
        CType(Me.pbSmile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblThx
        '
        Me.lblThx.BackColor = System.Drawing.Color.Black
        Me.lblThx.Font = New System.Drawing.Font("Lucida Calligraphy", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThx.ForeColor = System.Drawing.Color.Gold
        Me.lblThx.Location = New System.Drawing.Point(268, 156)
        Me.lblThx.Name = "lblThx"
        Me.lblThx.Size = New System.Drawing.Size(791, 281)
        Me.lblThx.TabIndex = 0
        Me.lblThx.Text = "Thank You!"
        Me.lblThx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPCA
        '
        Me.lblPCA.BackColor = System.Drawing.Color.Black
        Me.lblPCA.Font = New System.Drawing.Font("Lucida Calligraphy", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPCA.ForeColor = System.Drawing.Color.Gold
        Me.lblPCA.Location = New System.Drawing.Point(268, 343)
        Me.lblPCA.Name = "lblPCA"
        Me.lblPCA.Size = New System.Drawing.Size(791, 281)
        Me.lblPCA.TabIndex = 1
        Me.lblPCA.Text = "Please Come Again!"
        Me.lblPCA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEXIT
        '
        Me.btnEXIT.BackColor = System.Drawing.Color.Black
        Me.btnEXIT.Font = New System.Drawing.Font("Copperplate Gothic Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEXIT.ForeColor = System.Drawing.Color.White
        Me.btnEXIT.Location = New System.Drawing.Point(884, 553)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(175, 71)
        Me.btnEXIT.TabIndex = 2
        Me.btnEXIT.Text = "EXIT"
        Me.btnEXIT.UseVisualStyleBackColor = False
        '
        'pbSmile
        '
        Me.pbSmile.BackColor = System.Drawing.Color.Transparent
        Me.pbSmile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbSmile.Image = CType(resources.GetObject("pbSmile.Image"), System.Drawing.Image)
        Me.pbSmile.Location = New System.Drawing.Point(462, 627)
        Me.pbSmile.Name = "pbSmile"
        Me.pbSmile.Size = New System.Drawing.Size(416, 309)
        Me.pbSmile.TabIndex = 3
        Me.pbSmile.TabStop = False
        '
        'Thx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1294, 1000)
        Me.Controls.Add(Me.pbSmile)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.lblPCA)
        Me.Controls.Add(Me.lblThx)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1310, 1038)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1310, 1038)
        Me.Name = "Thx"
        Me.Text = "Bye-Bye!"
        CType(Me.pbSmile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblThx As System.Windows.Forms.Label
    Friend WithEvents lblPCA As System.Windows.Forms.Label
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents pbSmile As System.Windows.Forms.PictureBox
End Class
