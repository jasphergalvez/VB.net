<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1
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
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIndex = New System.Windows.Forms.TextBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.txtInpDisp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.rdbtnParallel = New System.Windows.Forms.RadioButton()
        Me.rdbtnSeries = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtClip = New System.Windows.Forms.TextBox()
        Me.btnClip = New System.Windows.Forms.Button()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(47, 19)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(160, 20)
        Me.txtValue.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtIndex)
        Me.GroupBox1.Controls.Add(Me.btnChange)
        Me.GroupBox1.Controls.Add(Me.btnInput)
        Me.GroupBox1.Controls.Add(Me.txtInpDisp)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtValue)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 197)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Index:"
        '
        'txtIndex
        '
        Me.txtIndex.Location = New System.Drawing.Point(255, 19)
        Me.txtIndex.Name = "txtIndex"
        Me.txtIndex.ReadOnly = True
        Me.txtIndex.Size = New System.Drawing.Size(35, 20)
        Me.txtIndex.TabIndex = 5
        '
        'btnChange
        '
        Me.btnChange.Enabled = False
        Me.btnChange.Location = New System.Drawing.Point(205, 43)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 5
        Me.btnChange.Text = "&Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(124, 43)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 4
        Me.btnInput.Text = "&Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'txtInpDisp
        '
        Me.txtInpDisp.Location = New System.Drawing.Point(6, 72)
        Me.txtInpDisp.Multiline = True
        Me.txtInpDisp.Name = "txtInpDisp"
        Me.txtInpDisp.ReadOnly = True
        Me.txtInpDisp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInpDisp.Size = New System.Drawing.Size(284, 119)
        Me.txtInpDisp.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Display:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Value:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtOutput)
        Me.GroupBox2.Location = New System.Drawing.Point(314, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 352)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(6, 19)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtOutput.Size = New System.Drawing.Size(311, 327)
        Me.txtOutput.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(647, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnReset)
        Me.GroupBox3.Controls.Add(Me.btnCompute)
        Me.GroupBox3.Controls.Add(Me.rdbtnParallel)
        Me.GroupBox3.Controls.Add(Me.rdbtnSeries)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 230)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(296, 149)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Type of Resistor Simplifcation"
        '
        'btnReset
        '
        Me.btnReset.Enabled = False
        Me.btnReset.Location = New System.Drawing.Point(124, 61)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(166, 22)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Enabled = False
        Me.btnCompute.Location = New System.Drawing.Point(124, 19)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(166, 36)
        Me.btnCompute.TabIndex = 3
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'rdbtnParallel
        '
        Me.rdbtnParallel.AutoSize = True
        Me.rdbtnParallel.Location = New System.Drawing.Point(14, 66)
        Me.rdbtnParallel.Name = "rdbtnParallel"
        Me.rdbtnParallel.Size = New System.Drawing.Size(59, 17)
        Me.rdbtnParallel.TabIndex = 1
        Me.rdbtnParallel.TabStop = True
        Me.rdbtnParallel.Text = "Parallel"
        Me.rdbtnParallel.UseVisualStyleBackColor = True
        '
        'rdbtnSeries
        '
        Me.rdbtnSeries.AutoSize = True
        Me.rdbtnSeries.Location = New System.Drawing.Point(14, 28)
        Me.rdbtnSeries.Name = "rdbtnSeries"
        Me.rdbtnSeries.Size = New System.Drawing.Size(54, 17)
        Me.rdbtnSeries.TabIndex = 0
        Me.rdbtnSeries.TabStop = True
        Me.rdbtnSeries.Text = "Series"
        Me.rdbtnSeries.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtClip)
        Me.GroupBox4.Controls.Add(Me.btnClip)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 89)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(276, 54)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Clipboard"
        '
        'txtClip
        '
        Me.txtClip.Location = New System.Drawing.Point(135, 21)
        Me.txtClip.Name = "txtClip"
        Me.txtClip.Size = New System.Drawing.Size(131, 20)
        Me.txtClip.TabIndex = 1
        '
        'btnClip
        '
        Me.btnClip.Enabled = False
        Me.btnClip.Location = New System.Drawing.Point(6, 19)
        Me.btnClip.Name = "btnClip"
        Me.btnClip.Size = New System.Drawing.Size(122, 23)
        Me.btnClip.TabIndex = 0
        Me.btnClip.Text = "Copy to clipboard"
        Me.btnClip.UseVisualStyleBackColor = True
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 387)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm1"
        Me.Text = "TITLE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtValue As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnChange As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents txtInpDisp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdbtnParallel As RadioButton
    Friend WithEvents rdbtnSeries As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIndex As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtClip As TextBox
    Friend WithEvents btnClip As Button
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
