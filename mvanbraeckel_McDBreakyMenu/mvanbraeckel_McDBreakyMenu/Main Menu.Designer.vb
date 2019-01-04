<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        Me.btnEnterMenu = New System.Windows.Forms.Button()
        Me.lblBevs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnterMenu
        '
        Me.btnEnterMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnEnterMenu.BackgroundImage = CType(resources.GetObject("btnEnterMenu.BackgroundImage"), System.Drawing.Image)
        Me.btnEnterMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEnterMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 57.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterMenu.ForeColor = System.Drawing.Color.Black
        Me.btnEnterMenu.Location = New System.Drawing.Point(421, 144)
        Me.btnEnterMenu.Name = "btnEnterMenu"
        Me.btnEnterMenu.Size = New System.Drawing.Size(451, 431)
        Me.btnEnterMenu.TabIndex = 0
        Me.btnEnterMenu.Text = " GO TO MENU"
        Me.btnEnterMenu.UseVisualStyleBackColor = False
        '
        'lblBevs
        '
        Me.lblBevs.BackColor = System.Drawing.Color.Transparent
        Me.lblBevs.Font = New System.Drawing.Font("Vineta BT", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBevs.ForeColor = System.Drawing.Color.Gold
        Me.lblBevs.Location = New System.Drawing.Point(67, 597)
        Me.lblBevs.Name = "lblBevs"
        Me.lblBevs.Size = New System.Drawing.Size(1153, 186)
        Me.lblBevs.TabIndex = 111
        Me.lblBevs.Text = "Dollar Drink Days are Here!"
        Me.lblBevs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1294, 1000)
        Me.Controls.Add(Me.lblBevs)
        Me.Controls.Add(Me.btnEnterMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1310, 1038)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1310, 858)
        Me.Name = "Main_Menu"
        Me.Text = "Welcome to McDonald's Breakfast All-the-Time"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnterMenu As System.Windows.Forms.Button
    Friend WithEvents lblBevs As System.Windows.Forms.Label
End Class
