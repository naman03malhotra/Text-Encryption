<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GENERATE
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
        Me.keys = New System.Windows.Forms.Label()
        Me.keyr = New System.Windows.Forms.Label()
        Me.sender = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Web.Management.ReadOnlyTextBox()
        Me.TextBox2 = New System.Web.Management.ReadOnlyTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'keys
        '
        Me.keys.AutoSize = True
        Me.keys.Location = New System.Drawing.Point(58, 162)
        Me.keys.Name = "keys"
        Me.keys.Size = New System.Drawing.Size(77, 13)
        Me.keys.TabIndex = 33
        Me.keys.Text = "PRIVATE KEY"
        '
        'keyr
        '
        Me.keyr.AutoSize = True
        Me.keyr.Location = New System.Drawing.Point(552, 162)
        Me.keyr.Name = "keyr"
        Me.keyr.Size = New System.Drawing.Size(69, 13)
        Me.keyr.TabIndex = 32
        Me.keyr.Text = "PUBLIC KEY"
        '
        'sender
        '
        Me.sender.AutoSize = True
        Me.sender.Location = New System.Drawing.Point(302, 17)
        Me.sender.Name = "sender"
        Me.sender.Size = New System.Drawing.Size(139, 13)
        Me.sender.TabIndex = 31
        Me.sender.Text = "PERSONAL ID (SENDER) :"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(537, 127)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 37
        Me.TextBox3.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(48, 127)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 38
        Me.TextBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 36)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "GENERATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(376, 150)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(104, 36)
        Me.button2.TabIndex = 39
        Me.button2.Text = "CLOSE"
        Me.button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(317, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 40
        '
        'GENERATE
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.button2
        Me.ClientSize = New System.Drawing.Size(701, 234)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.keys)
        Me.Controls.Add(Me.keyr)
        Me.Controls.Add(Me.sender)
        Me.MaximizeBox = False
        Me.Name = "GENERATE"
        Me.Text = "GENERATE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents keys As System.Windows.Forms.Label
    Friend WithEvents keyr As System.Windows.Forms.Label
    Friend WithEvents sender As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Web.Management.ReadOnlyTextBox
    Friend WithEvents TextBox2 As System.Web.Management.ReadOnlyTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
