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
        Me.SubReddit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MainText = New System.Windows.Forms.RichTextBox()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FileNameBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumberToCheck = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.minWordCount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.minPostNumber = New System.Windows.Forms.TextBox()
        Me.Weekly = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubReddit
        '
        Me.SubReddit.Location = New System.Drawing.Point(12, 30)
        Me.SubReddit.Name = "SubReddit"
        Me.SubReddit.Size = New System.Drawing.Size(73, 20)
        Me.SubReddit.TabIndex = 0
        Me.SubReddit.Text = "FortniteBR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SubReddit"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Button1.Location = New System.Drawing.Point(12, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(417, 105)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Do The Thing"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 342)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(417, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Start Date"
        '
        'MainText
        '
        Me.MainText.Location = New System.Drawing.Point(12, 228)
        Me.MainText.Name = "MainText"
        Me.MainText.ReadOnly = True
        Me.MainText.Size = New System.Drawing.Size(417, 108)
        Me.MainText.TabIndex = 6
        Me.MainText.Text = ""
        '
        'StartDate
        '
        Me.StartDate.Location = New System.Drawing.Point(12, 119)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(100, 20)
        Me.StartDate.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(163, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "End Date"
        '
        'EndDate
        '
        Me.EndDate.Location = New System.Drawing.Point(118, 119)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(97, 20)
        Me.EndDate.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "File Name To Use"
        '
        'FileNameBox
        '
        Me.FileNameBox.Location = New System.Drawing.Point(130, 76)
        Me.FileNameBox.Name = "FileNameBox"
        Me.FileNameBox.Size = New System.Drawing.Size(85, 20)
        Me.FileNameBox.TabIndex = 10
        Me.FileNameBox.Text = "Pre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(100, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Number "
        '
        'NumberToCheck
        '
        Me.NumberToCheck.Location = New System.Drawing.Point(99, 30)
        Me.NumberToCheck.Name = "NumberToCheck"
        Me.NumberToCheck.Size = New System.Drawing.Size(116, 20)
        Me.NumberToCheck.TabIndex = 12
        Me.NumberToCheck.Text = "300"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 41)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Select File Location"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.minWordCount)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.minPostNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(237, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 109)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Privacy Restrictions"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Minimum Word Count"
        '
        'minWordCount
        '
        Me.minWordCount.Location = New System.Drawing.Point(7, 79)
        Me.minWordCount.Name = "minWordCount"
        Me.minWordCount.Size = New System.Drawing.Size(179, 20)
        Me.minWordCount.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Minimum # of Posts"
        '
        'minPostNumber
        '
        Me.minPostNumber.Location = New System.Drawing.Point(7, 38)
        Me.minPostNumber.Name = "minPostNumber"
        Me.minPostNumber.Size = New System.Drawing.Size(179, 20)
        Me.minPostNumber.TabIndex = 0
        '
        'Weekly
        '
        Me.Weekly.AutoSize = True
        Me.Weekly.Location = New System.Drawing.Point(246, 123)
        Me.Weekly.Name = "Weekly"
        Me.Weekly.Size = New System.Drawing.Size(158, 17)
        Me.Weekly.TabIndex = 16
        Me.Weekly.Text = "Create seperate weekly files"
        Me.Weekly.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 488)
        Me.Controls.Add(Me.Weekly)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumberToCheck)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FileNameBox)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StartDate)
        Me.Controls.Add(Me.MainText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SubReddit)
        Me.Name = "Form1"
        Me.Text = "MRG"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SubReddit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents MainText As RichTextBox
    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents FileNameBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumberToCheck As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents minPostNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents minWordCount As TextBox
    Friend WithEvents Weekly As CheckBox
End Class
