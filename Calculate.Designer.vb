<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalculate
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
        Me.TxtInput1 = New System.Windows.Forms.TextBox()
        Me.TxtInput2 = New System.Windows.Forms.TextBox()
        Me.LblInput1 = New System.Windows.Forms.Label()
        Me.LblInput2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtInput1
        '
        Me.TxtInput1.Location = New System.Drawing.Point(445, 66)
        Me.TxtInput1.Multiline = True
        Me.TxtInput1.Name = "TxtInput1"
        Me.TxtInput1.Size = New System.Drawing.Size(126, 35)
        Me.TxtInput1.TabIndex = 0
        '
        'TxtInput2
        '
        Me.TxtInput2.Location = New System.Drawing.Point(445, 117)
        Me.TxtInput2.Multiline = True
        Me.TxtInput2.Name = "TxtInput2"
        Me.TxtInput2.Size = New System.Drawing.Size(126, 35)
        Me.TxtInput2.TabIndex = 1
        '
        'LblInput1
        '
        Me.LblInput1.AutoSize = True
        Me.LblInput1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInput1.Location = New System.Drawing.Point(245, 66)
        Me.LblInput1.Name = "LblInput1"
        Me.LblInput1.Size = New System.Drawing.Size(159, 37)
        Me.LblInput1.TabIndex = 2
        Me.LblInput1.Text = "Input one"
        '
        'LblInput2
        '
        Me.LblInput2.AutoSize = True
        Me.LblInput2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LblInput2.Location = New System.Drawing.Point(245, 115)
        Me.LblInput2.Name = "LblInput2"
        Me.LblInput2.Size = New System.Drawing.Size(156, 37)
        Me.LblInput2.TabIndex = 3
        Me.LblInput2.Text = "Input two"
        '
        'FrmCalculate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(676, 450)
        Me.Controls.Add(Me.LblInput2)
        Me.Controls.Add(Me.LblInput1)
        Me.Controls.Add(Me.TxtInput2)
        Me.Controls.Add(Me.TxtInput1)
        Me.Name = "FrmCalculate"
        Me.Text = "Calculate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtInput1 As TextBox
    Friend WithEvents TxtInput2 As TextBox
    Friend WithEvents LblInput1 As Label
    Friend WithEvents LblInput2 As Label
End Class
