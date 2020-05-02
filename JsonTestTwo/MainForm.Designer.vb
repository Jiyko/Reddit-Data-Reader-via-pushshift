<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.DoTheThingButton = New System.Windows.Forms.Button()
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
        Me.SelectFileButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.minWordCount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.minPostNumber = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Initialise = New System.Windows.Forms.Button()
        Me.MilePick = New System.Windows.Forms.DateTimePicker()
        Me.MileStoneDate = New System.Windows.Forms.Button()
        Me.DateToSample = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateListBox = New System.Windows.Forms.ListBox()
        Me.InfoEndDate = New System.Windows.Forms.Label()
        Me.InfoStartDate = New System.Windows.Forms.Label()
        Me.InfoFileName = New System.Windows.Forms.Label()
        Me.InfoSubReddit = New System.Windows.Forms.Label()
        Me.OneWeekCheck = New System.Windows.Forms.CheckBox()
        Me.TwoWeekCheck = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubReddit
        '
        Me.SubReddit.Location = New System.Drawing.Point(16, 64)
        Me.SubReddit.Margin = New System.Windows.Forms.Padding(4)
        Me.SubReddit.Name = "SubReddit"
        Me.SubReddit.Size = New System.Drawing.Size(96, 22)
        Me.SubReddit.TabIndex = 0
        Me.SubReddit.Text = "Ireland"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SubReddit"
        '
        'DoTheThingButton
        '
        Me.DoTheThingButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.DoTheThingButton.Location = New System.Drawing.Point(16, 532)
        Me.DoTheThingButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DoTheThingButton.Name = "DoTheThingButton"
        Me.DoTheThingButton.Size = New System.Drawing.Size(969, 129)
        Me.DoTheThingButton.TabIndex = 2
        Me.DoTheThingButton.Text = "Do The Thing"
        Me.DoTheThingButton.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 448)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(969, 28)
        Me.ProgressBar1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Start Date"
        '
        'MainText
        '
        Me.MainText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainText.Enabled = False
        Me.MainText.Location = New System.Drawing.Point(16, 292)
        Me.MainText.Margin = New System.Windows.Forms.Padding(4)
        Me.MainText.Name = "MainText"
        Me.MainText.ReadOnly = True
        Me.MainText.Size = New System.Drawing.Size(969, 147)
        Me.MainText.TabIndex = 6
        Me.MainText.Text = ""
        '
        'StartDate
        '
        Me.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StartDate.Location = New System.Drawing.Point(16, 162)
        Me.StartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(132, 22)
        Me.StartDate.TabIndex = 7
        Me.StartDate.Value = New Date(2018, 6, 1, 17, 28, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(326, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "End Date"
        '
        'EndDate
        '
        Me.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EndDate.Location = New System.Drawing.Point(265, 162)
        Me.EndDate.Margin = New System.Windows.Forms.Padding(4)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(128, 22)
        Me.EndDate.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 43)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "File Name To Use"
        '
        'FileNameBox
        '
        Me.FileNameBox.Location = New System.Drawing.Point(220, 64)
        Me.FileNameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FileNameBox.Name = "FileNameBox"
        Me.FileNameBox.Size = New System.Drawing.Size(173, 22)
        Me.FileNameBox.TabIndex = 10
        Me.FileNameBox.Text = "RedditDataPull-Ireland"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(117, 43)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Number of Calls"
        '
        'NumberToCheck
        '
        Me.NumberToCheck.Location = New System.Drawing.Point(129, 64)
        Me.NumberToCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.NumberToCheck.Name = "NumberToCheck"
        Me.NumberToCheck.Size = New System.Drawing.Size(77, 22)
        Me.NumberToCheck.TabIndex = 12
        Me.NumberToCheck.Text = "10"
        '
        'SelectFileButton
        '
        Me.SelectFileButton.Location = New System.Drawing.Point(16, 96)
        Me.SelectFileButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectFileButton.Name = "SelectFileButton"
        Me.SelectFileButton.Size = New System.Drawing.Size(377, 45)
        Me.SelectFileButton.TabIndex = 14
        Me.SelectFileButton.Text = "Select File Location"
        Me.SelectFileButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.minWordCount)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.minPostNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(414, 137)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(256, 134)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Privacy Restrictions"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 75)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Minimum Word Count"
        '
        'minWordCount
        '
        Me.minWordCount.Location = New System.Drawing.Point(9, 97)
        Me.minWordCount.Margin = New System.Windows.Forms.Padding(4)
        Me.minWordCount.Name = "minWordCount"
        Me.minWordCount.Size = New System.Drawing.Size(237, 22)
        Me.minWordCount.TabIndex = 17
        Me.minWordCount.Text = "150"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Minimum # of Posts"
        '
        'minPostNumber
        '
        Me.minPostNumber.Location = New System.Drawing.Point(9, 47)
        Me.minPostNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.minPostNumber.Name = "minPostNumber"
        Me.minPostNumber.Size = New System.Drawing.Size(237, 22)
        Me.minPostNumber.TabIndex = 0
        Me.minPostNumber.Text = "3"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.SelectedPath = "D:\RedditRips\Test"
        '
        'Initialise
        '
        Me.Initialise.Enabled = False
        Me.Initialise.Location = New System.Drawing.Point(16, 188)
        Me.Initialise.Margin = New System.Windows.Forms.Padding(4)
        Me.Initialise.Name = "Initialise"
        Me.Initialise.Size = New System.Drawing.Size(377, 42)
        Me.Initialise.TabIndex = 18
        Me.Initialise.Text = "Initialise"
        Me.Initialise.UseVisualStyleBackColor = True
        '
        'MilePick
        '
        Me.MilePick.Location = New System.Drawing.Point(416, 42)
        Me.MilePick.Margin = New System.Windows.Forms.Padding(4)
        Me.MilePick.Name = "MilePick"
        Me.MilePick.Size = New System.Drawing.Size(254, 22)
        Me.MilePick.TabIndex = 19
        '
        'MileStoneDate
        '
        Me.MileStoneDate.Location = New System.Drawing.Point(416, 73)
        Me.MileStoneDate.Margin = New System.Windows.Forms.Padding(4)
        Me.MileStoneDate.Name = "MileStoneDate"
        Me.MileStoneDate.Size = New System.Drawing.Size(254, 47)
        Me.MileStoneDate.TabIndex = 20
        Me.MileStoneDate.Text = "Add Milestone Date"
        Me.MileStoneDate.UseVisualStyleBackColor = True
        '
        'DateToSample
        '
        Me.DateToSample.Location = New System.Drawing.Point(387, 501)
        Me.DateToSample.Margin = New System.Windows.Forms.Padding(4)
        Me.DateToSample.Name = "DateToSample"
        Me.DateToSample.Size = New System.Drawing.Size(265, 22)
        Me.DateToSample.TabIndex = 21
        Me.DateToSample.Value = New Date(2018, 11, 14, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(411, 480)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(207, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Date to collect participants from"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label9.Location = New System.Drawing.Point(15, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(233, 26)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "1st - Setup parameters"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label10.Location = New System.Drawing.Point(411, 9)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(216, 26)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "2nd - Add Milestones"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateListBox)
        Me.GroupBox2.Controls.Add(Me.InfoEndDate)
        Me.GroupBox2.Controls.Add(Me.InfoStartDate)
        Me.GroupBox2.Controls.Add(Me.InfoFileName)
        Me.GroupBox2.Controls.Add(Me.InfoSubReddit)
        Me.GroupBox2.Location = New System.Drawing.Point(677, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 261)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CurrentData"
        '
        'DateListBox
        '
        Me.DateListBox.FormattingEnabled = True
        Me.DateListBox.ItemHeight = 16
        Me.DateListBox.Location = New System.Drawing.Point(10, 160)
        Me.DateListBox.Name = "DateListBox"
        Me.DateListBox.ScrollAlwaysVisible = True
        Me.DateListBox.Size = New System.Drawing.Size(292, 100)
        Me.DateListBox.TabIndex = 6
        '
        'InfoEndDate
        '
        Me.InfoEndDate.AutoSize = True
        Me.InfoEndDate.Location = New System.Drawing.Point(7, 78)
        Me.InfoEndDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InfoEndDate.Name = "InfoEndDate"
        Me.InfoEndDate.Size = New System.Drawing.Size(136, 17)
        Me.InfoEndDate.TabIndex = 5
        Me.InfoEndDate.Text = "<<UNINITIALISED>>"
        '
        'InfoStartDate
        '
        Me.InfoStartDate.AutoSize = True
        Me.InfoStartDate.Location = New System.Drawing.Point(7, 57)
        Me.InfoStartDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InfoStartDate.Name = "InfoStartDate"
        Me.InfoStartDate.Size = New System.Drawing.Size(136, 17)
        Me.InfoStartDate.TabIndex = 4
        Me.InfoStartDate.Text = "<<UNINITIALISED>>"
        '
        'InfoFileName
        '
        Me.InfoFileName.AutoSize = True
        Me.InfoFileName.Location = New System.Drawing.Point(7, 37)
        Me.InfoFileName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InfoFileName.Name = "InfoFileName"
        Me.InfoFileName.Size = New System.Drawing.Size(136, 17)
        Me.InfoFileName.TabIndex = 3
        Me.InfoFileName.Text = "<<UNINITIALISED>>"
        '
        'InfoSubReddit
        '
        Me.InfoSubReddit.AutoSize = True
        Me.InfoSubReddit.Location = New System.Drawing.Point(7, 18)
        Me.InfoSubReddit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InfoSubReddit.Name = "InfoSubReddit"
        Me.InfoSubReddit.Size = New System.Drawing.Size(136, 17)
        Me.InfoSubReddit.TabIndex = 2
        Me.InfoSubReddit.Text = "<<UNINITIALISED>>"
        '
        'OneWeekCheck
        '
        Me.OneWeekCheck.AutoSize = True
        Me.OneWeekCheck.Location = New System.Drawing.Point(16, 263)
        Me.OneWeekCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.OneWeekCheck.Name = "OneWeekCheck"
        Me.OneWeekCheck.Size = New System.Drawing.Size(222, 21)
        Me.OneWeekCheck.TabIndex = 17
        Me.OneWeekCheck.Text = "Create files at 1 week intervals"
        Me.OneWeekCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.OneWeekCheck.UseVisualStyleBackColor = True
        '
        'TwoWeekCheck
        '
        Me.TwoWeekCheck.AutoSize = True
        Me.TwoWeekCheck.Checked = True
        Me.TwoWeekCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TwoWeekCheck.Location = New System.Drawing.Point(16, 234)
        Me.TwoWeekCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.TwoWeekCheck.Name = "TwoWeekCheck"
        Me.TwoWeekCheck.Size = New System.Drawing.Size(222, 21)
        Me.TwoWeekCheck.TabIndex = 27
        Me.TwoWeekCheck.Text = "Create files at 2 week intervals"
        Me.TwoWeekCheck.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 674)
        Me.Controls.Add(Me.TwoWeekCheck)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateToSample)
        Me.Controls.Add(Me.MileStoneDate)
        Me.Controls.Add(Me.MilePick)
        Me.Controls.Add(Me.Initialise)
        Me.Controls.Add(Me.OneWeekCheck)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SelectFileButton)
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
        Me.Controls.Add(Me.DoTheThingButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SubReddit)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Reddit Data Reader"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SubReddit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DoTheThingButton As Button
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
    Friend WithEvents SelectFileButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents minPostNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents minWordCount As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Initialise As Button
    Friend WithEvents MilePick As DateTimePicker
    Friend WithEvents MileStoneDate As Button
    Friend WithEvents DateToSample As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents InfoEndDate As Label
    Friend WithEvents InfoStartDate As Label
    Friend WithEvents InfoFileName As Label
    Friend WithEvents InfoSubReddit As Label
    Friend WithEvents DateListBox As ListBox
    Friend WithEvents OneWeekCheck As CheckBox
    Friend WithEvents TwoWeekCheck As CheckBox
End Class
