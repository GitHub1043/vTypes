<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.btnChar = New System.Windows.Forms.Button()
        Me.btnSingle = New System.Windows.Forms.Button()
        Me.btnInteger = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(30, 268)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(41, 13)
        Me.lblDisplay.TabIndex = 14
        Me.lblDisplay.Text = "Display"
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(12, 204)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(75, 23)
        Me.btnAverage.TabIndex = 13
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'btnChar
        '
        Me.btnChar.Location = New System.Drawing.Point(12, 140)
        Me.btnChar.Name = "btnChar"
        Me.btnChar.Size = New System.Drawing.Size(75, 23)
        Me.btnChar.TabIndex = 12
        Me.btnChar.Text = "Char"
        Me.btnChar.UseVisualStyleBackColor = True
        '
        'btnSingle
        '
        Me.btnSingle.Location = New System.Drawing.Point(12, 76)
        Me.btnSingle.Name = "btnSingle"
        Me.btnSingle.Size = New System.Drawing.Size(75, 23)
        Me.btnSingle.TabIndex = 11
        Me.btnSingle.Text = "Single"
        Me.btnSingle.UseVisualStyleBackColor = True
        '
        'btnInteger
        '
        Me.btnInteger.Location = New System.Drawing.Point(12, 12)
        Me.btnInteger.Name = "btnInteger"
        Me.btnInteger.Size = New System.Drawing.Size(75, 23)
        Me.btnInteger.TabIndex = 10
        Me.btnInteger.Text = "Integer"
        Me.btnInteger.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 449)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.btnChar)
        Me.Controls.Add(Me.btnSingle)
        Me.Controls.Add(Me.btnInteger)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnAverage As System.Windows.Forms.Button
    Friend WithEvents btnChar As System.Windows.Forms.Button
    Friend WithEvents btnSingle As System.Windows.Forms.Button
    Friend WithEvents btnInteger As System.Windows.Forms.Button

End Class
