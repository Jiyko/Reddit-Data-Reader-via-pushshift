Imports System
Imports System.Net
Imports System.IO
Imports System.Text
Imports StreamJsonRpc

Public Class MainForm

    'Gloabl for the root folder
    Dim rootPath As String
    Dim listOfDates As List(Of KeyValuePair(Of Double, String)) = New List(Of KeyValuePair(Of Double, String))
    Dim duration As Double
    Dim rateLimit = 1000

    Private Sub DoTheThingButton_Click(sender As Object, e As EventArgs) Handles DoTheThingButton.Click

        'Check to see if the text is validated.... poorly

        If DataIsValid() Then

            Dim sURL As String
            Dim FirstRunURL As String
            Dim SecondRunURL As String
            Dim Final As String

            Dim sMonth As String
            Dim sDay As String

            Dim eMonth As String
            Dim eDay As String

            Dim sDate As Date
            Dim eDate As Date

            Dim sampleDay As String
            Dim sampleMonth As String
            Dim sampleDate As Date
            Dim SampleDateFinal As String

            Dim filterWords = New String() {"removed", "https", "remove", "http", "I am a bot"}

            Dim startWindowUTC = (StartDate.Value() - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
            Dim endWindowUTC = (EndDate.Value() - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds

            Dim datesToPullUserInfor As List(Of DateTime) = New List(Of DateTime)


            Dim startSampleWindowUTC = (DateToSampleStart.Value() - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
            Dim endSampleWindowUTC = (DateToSampleEnd.Value() - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds

            Dim numberOfSets = NumberToBeSampled.Value
            Dim dateDif = endSampleWindowUTC - startSampleWindowUTC
            Dim averageDistanceBetweenQueries = dateDif / numberOfSets

            DayToCheckUserBar.Maximum = CInt(numberOfSets)
            DayToCheckUserBar.Value = 0

            For index As Integer = 1 To numberOfSets

                Dim origin = New DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                origin = origin.AddSeconds(startSampleWindowUTC + (averageDistanceBetweenQueries * index))
                datesToPullUserInfor.Add(origin)
            Next

            For Each samplingDate In datesToPullUserInfor




                Dim hashedUserList As New List(Of String)
                Dim nameFile As System.IO.StreamReader

                Try
                    'Trys to open the hashnamedFiles

                    If My.Computer.FileSystem.FileExists(rootPath + "\" + FileNameBox.Text() + "hashedNames.txt") Then
                        'If the file exists, iterate over it and add the content to the hashedUserList 

                        nameFile = My.Computer.FileSystem.OpenTextFileReader(rootPath + "\" + FileNameBox.Text() + "hashedNames.txt")

                        Dim nameTracker As String
                        nameTracker = nameFile.ReadLine

                        Do While Not nameTracker Is Nothing
                            hashedUserList.Add(nameTracker)
                            nameTracker = nameFile.ReadLine
                        Loop

                        nameFile.Close()

                    Else
                        'If the file does not exists, create it 

                        Dim hashedUserListFileCreate As New StreamWriter(rootPath + "\" + FileNameBox.Text() + "hashedNames.txt", True)
                        hashedUserListFileCreate.Close()

                    End If

                Catch exTwo As Exception

                End Try

                Dim tempList As List(Of KeyValuePair(Of Double, String)) = New List(Of KeyValuePair(Of Double, String))

                Dim timeTracker = startWindowUTC

                Dim files() As String = IO.Directory.GetFiles(rootPath + "\")

                Dim bodyTracker As String

                Dim FinalStartDate As String
                Dim FinalEndDate As String
                Dim FinalSize As String
                Dim FinalTags As String

                Dim validLine As Boolean


                Dim FinalBodyTags As String

                Dim ValidLines As Int64
                Dim TotalLines As Int64
                Dim ValidPoster As Int64
                Dim TotalPoster As Int64

                'Declare the IO Stuff
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter(rootPath + "\" + FileNameBox.Text() + ".txt", True)



                If My.Computer.FileSystem.FileExists(rootPath + "\" + FileNameBox.Text() + "Stats.txt") Then
                    'If the stats file exists pull the data

                    'Get the latest stats
                    Dim statsFile As System.IO.StreamReader
                    statsFile = My.Computer.FileSystem.OpenTextFileReader(rootPath + "\" + FileNameBox.Text() + "Stats.txt")
                    ValidLines = Convert.ToInt32(statsFile.ReadLine())
                    TotalLines = Convert.ToInt32(statsFile.ReadLine())
                    ValidPoster = Convert.ToInt32(statsFile.ReadLine())
                    TotalPoster = Convert.ToInt32(statsFile.ReadLine())

                    statsFile.Close()

                End If

                Dim statsFileW As System.IO.StreamWriter
                statsFileW = My.Computer.FileSystem.OpenTextFileWriter(rootPath + "\" + FileNameBox.Text() + "Stats.txt", False)

                sURL = "https://api.pushshift.io/reddit/search/comment/?subreddit="
                sURL = sURL + (SubReddit.Text())


                'Start Date Junk
                sDate = StartDate.Value()
                sMonth = (sDate.Month).ToString
                sDay = (sDate.Day).ToString

                If (sMonth.Length < 2) Then
                    sMonth = "0" + sMonth
                End If

                If (sDay.Length < 2) Then
                    sDay = "0" + sDay
                End If


                FinalStartDate = "&after=" + (sDate.Year).ToString + "-" + sMonth + "-" + sDay


                'Start Date Junk
                eDate = EndDate.Value()
                eMonth = (eDate.Month).ToString
                eDay = (eDate.Day).ToString

                If (eMonth.Length < 2) Then
                    eMonth = "0" + eMonth
                End If

                If (eDay.Length < 2) Then
                    eDay = "0" + eDay
                End If


                FinalEndDate = "&before=" + (eDate.Year).ToString + "-" + eMonth + "-" + eDay

                'Sample Date Junk
                sampleDate = samplingDate
                sampleMonth = (sampleDate.Month).ToString
                sampleDay = (sampleDate.Day).ToString

                If (sampleMonth.Length < 2) Then
                    sampleMonth = "0" + sampleMonth
                End If

                If (sampleDay.Length < 2) Then
                    sampleDay = "0" + sampleDay
                End If

                SampleDateFinal = "&after=" + (sampleDate.Year).ToString + "-" + sampleMonth + "-" + sampleDay

                ProgressBar1.Maximum = CInt(NumberToCheck.Text())
                ProgressBar1.Value = 0


                FinalSize = "&size=" + NumberToCheck.Text()
                FinalTags = "&filter=author,score"

                FinalBodyTags = "&filter=body"

                FirstRunURL = sURL + SampleDateFinal + FinalEndDate + FinalSize + FinalTags
                SecondRunURL = sURL + FinalStartDate + FinalEndDate + FinalSize + "&filter=body,created_utc&&author="

                Dim objReader = OpenStream(FirstRunURL)


                Dim sLine As String = ""
                Dim i As Integer = 0

                Dim sInnerLine As String = ""
                Dim j As Integer = 0
                Dim k As Integer = 0



                Do While Not sLine Is Nothing
                    i += 1
                    sLine = objReader.ReadLine
                    If Not sLine Is Nothing Then

                        If sLine.Contains("author") Then

                            Console.WriteLine("{0}:{1}", i, sLine)

                            sLine = sLine.Remove((sLine.Length) - 2)
                            sLine = sLine.Substring(23)

                            Console.WriteLine(sLine)

                            sLine.GetHashCode()
                            If Not hashedUserList.Contains(sLine.GetHashCode()) Then


                                Final = SecondRunURL + sLine


                                TotalPoster = TotalPoster + 1
                                ProgressBar1.Value = ProgressBar1.Value + 1

                                Dim objInnerReader = OpenStream(Final)

                                sInnerLine = ""
                                j = 0
                                k = 0

                                bodyTracker = ""

                                sInnerLine = objInnerReader.ReadLine

                                Do While Not sInnerLine Is Nothing

                                    If Not sInnerLine.Equals("") Then
                                        j += 1

                                        'check to see if the line contains any words from the filter list
                                        validLine = True

                                        For Each bob In filterWords
                                            If sInnerLine.Contains(bob) Then

                                                validLine = False

                                            End If
                                        Next

                                        'check to see if the line contains any words from the filter list
                                        If validLine Then
                                            If sInnerLine.Contains("body") Then

                                                sInnerLine = sInnerLine.Remove((sInnerLine.Length) - 1)
                                                sInnerLine = sInnerLine.Substring(21)
                                                sInnerLine.Trim()

                                                bodyTracker = bodyTracker + vbCrLf + sInnerLine

                                                TotalLines = TotalLines + 1
                                                k += 1

                                                Dim sInnerLineDate As String = objInnerReader.ReadLine

                                                sInnerLineDate = sInnerLineDate.Substring(27)

                                                Dim dataAsDouble As Double
                                                Double.TryParse(sInnerLineDate, dataAsDouble)

                                                tempList.Add(New KeyValuePair(Of Double, String)(dataAsDouble, sInnerLine))


                                            End If

                                        End If
                                    End If

                                    sInnerLine = objInnerReader.ReadLine

                                Loop

                                hashedUserList.Add(sLine.GetHashCode())

                                'checks the user validity 
                                If k >= Convert.ToInt32(minPostNumber.Text) Then
                                    If bodyTracker.Split(" ").Length + 1 >= Convert.ToInt32(minWordCount.Text) Then

                                        For Each bob In tempList.ToArray

                                            Dim roundedTime As Double
                                            roundedTime = nearestRoundedDouble(bob.Key)

                                            For Each boob In listOfDates.ToArray

                                                If boob.Key = roundedTime Then

                                                    listOfDates.Remove(New KeyValuePair(Of Double, String)(roundedTime, boob.Value))
                                                    listOfDates.Add(New KeyValuePair(Of Double, String)(roundedTime, bob.Value + boob.Value))

                                                    Exit For

                                                End If

                                            Next

                                        Next
                                        ValidPoster = ValidPoster + 1
                                        ValidLines = ValidLines + k
                                    End If
                                End If
                                tempList.Clear()

                            End If
                        End If

                    End If
                Loop

                statsFileW.WriteLine(ValidLines)
                statsFileW.WriteLine(TotalLines)
                statsFileW.WriteLine(ValidPoster)
                statsFileW.WriteLine(TotalPoster)

                file.Close()
                statsFileW.Close()
                ProgressBar1.Value = ProgressBar1.Maximum


                For Each bob In listOfDates.ToArray

                    Dim UTCFilebyDate As New StreamWriter(rootPath + "\" + (bob.Key).ToString + ".txt", True)
                    UTCFilebyDate.Write((bob.Value).Replace(Chr(34), vbCrLf))

                    UTCFilebyDate.Close()
                    listOfDates.Remove(New KeyValuePair(Of Double, String)(bob.Key, bob.Value))

                    listOfDates.Add(New KeyValuePair(Of Double, String)(bob.Key, ""))

                Next


                Dim hashedUserListFile As New StreamWriter(rootPath + "\" + FileNameBox.Text() + "hashedNames.txt", False)
                For Each nameH In hashedUserList
                    hashedUserListFile.Write(nameH + vbCrLf)
                Next
                hashedUserListFile.Close()
                hashedUserList.Clear()



                DayToCheckUserBar.Value = DayToCheckUserBar.Value + 1
            Next

        Else
            MsgBox("Something broke")
        End If


    End Sub

    Function DataIsValid() As Boolean

        Dim DataValid As Boolean
        DataValid = True

        'Check the min post Number 
        Try
            Convert.ToInt32(minPostNumber.Text)
        Catch ex As Exception
            DataValid = False
            Console.WriteLine("Fail")
        End Try

        'Check the min word count 
        Try
            Convert.ToInt32(minWordCount.Text)
        Catch ex As Exception
            DataValid = False
            Console.WriteLine("Fail")
        End Try

        'Check the wordCheck 
        Try
            Convert.ToInt32(NumberToCheck.Text)
        Catch ex As Exception
            DataValid = False
            Console.WriteLine("Fail")
        End Try

        'Check the SubTextLenght 
        If SubReddit.TextLength = 0 Then
            DataValid = False
            Console.WriteLine("Fail")
        End If

        'Check the SubTextLenght 
        If FileNameBox.TextLength = 0 Then
            DataValid = False
            Console.WriteLine("Fail")
        End If

        'Check the minPostNumberLenght 
        If minPostNumber.TextLength = 0 Then
            DataValid = False
            Console.WriteLine("Fail")
        End If

        'Check the minPostNumberLenght 
        If minWordCount.TextLength = 0 Then
            DataValid = False
            Console.WriteLine("Fail")
        End If

        'make sure the root has been selected
        If rootPath Is Nothing Then
            DataValid = False
            Console.WriteLine("Fail")
            MsgBox("Select a folder")
        End If

        DataIsValid = DataValid
    End Function

    Function OpenStream(ByVal wantedURI As String) As StreamReader

        Threading.Thread.Sleep(rateLimit)
        Try
            Convert.ToInt32(minPostNumber.Text)

            MainText.Text = MainText.Text + "Calling - " + wantedURI + vbNewLine

            'Invoke the web request
            Dim wrGETURL As WebRequest
            wrGETURL = WebRequest.Create(wantedURI)

            'Read the Stream
            Dim objStream As Stream
            objStream = wrGETURL.GetResponse.GetResponseStream()

            'Put it in a reader
            Dim objReader As New StreamReader(objStream)
            OpenStream = objReader

        Catch ex As Exception

            MsgBox("Networking Broke")

        End Try

    End Function

    Private Sub SelectFileButton_Click(sender As Object, e As EventArgs) Handles SelectFileButton.Click

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            rootPath = FolderBrowserDialog1.SelectedPath
        End If

        Initialise.Enabled = True

        setupData()

    End Sub

    Private Sub Initialise_Click(sender As Object, e As EventArgs) Handles Initialise.Click

        Dim startWindowUTC = (StartDate.Value() - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        Dim endWindowUTC = (EndDate.Value() - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds

        Dim oneWeekUTC As Double
        oneWeekUTC = 604800

        Dim twoWeekUTC As Double
        twoWeekUTC = 1209600


        Dim usedTimeDifference As Double

        If OneWeekCheck.Checked Then
            usedTimeDifference = oneWeekUTC
        Else
            usedTimeDifference = twoWeekUTC
        End If

        Dim timeTracker = startWindowUTC

        listOfDates.Add(New KeyValuePair(Of Double, String)(timeTracker - usedTimeDifference, ""))

        Do While timeTracker < endWindowUTC

            listOfDates.Add(New KeyValuePair(Of Double, String)(timeTracker, ""))

            timeTracker = timeTracker + usedTimeDifference


        Loop
        listOfDates.Add(New KeyValuePair(Of Double, String)(endWindowUTC, ""))

        Initialise.Enabled = False


        setupData()

    End Sub

    Private Sub MileStoneDate_Click(sender As Object, e As EventArgs) Handles MileStoneDate.Click
        Dim newMileStone = (MilePick.Value() - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        listOfDates.Add(New KeyValuePair(Of Double, String)(newMileStone, ""))

        Dim doubleList As New List(Of Double)

        For Each bob In listOfDates.ToArray
            doubleList.Add(bob.Key)
        Next

        listOfDates.Clear()


        doubleList.Sort()

        For Each waka In doubleList

            listOfDates.Add(New KeyValuePair(Of Double, String)(waka, ""))

        Next

    End Sub


    Function nearestRoundedDouble(tobeDouble As Double) As Double

        Dim doubleList As New List(Of Double)

        Dim doubleTracker As Double
        Dim lastDoubleTracker As Double
        For Each bob In listOfDates.ToArray
            doubleList.Add(bob.Key)
        Next

        doubleList.Sort()
        lastDoubleTracker = doubleList(0)
        For Each waka In doubleList
            If tobeDouble <= waka Then
                doubleTracker = lastDoubleTracker
                Exit For
            End If
            lastDoubleTracker = waka
        Next

        nearestRoundedDouble = doubleTracker
    End Function

    Function setupData()
        InfoSubReddit.Text = "SubReddit: " + SubReddit.Text
        InfoFileName.Text = "FileNane: " + FileNameBox.Text


        InfoStartDate.Text = "StartDate: " + StartDate.Value().ToString

        InfoEndDate.Text = "EndDate: " + EndDate.Value().ToString

        For Each dateToBeSeleted In listOfDates

            Dim origin = New DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)


            origin = origin.AddSeconds(dateToBeSeleted.Key)
            DateListBox.Items.Add(origin.ToLocalTime)


        Next
    End Function

    Private Sub TwoWeekCheck_CheckedChanged(sender As Object, e As EventArgs) Handles TwoWeekCheck.CheckedChanged
        If TwoWeekCheck.Checked Then
            OneWeekCheck.Checked = False
        End If

    End Sub

    Private Sub OneWeekCheck_CheckedChanged(sender As Object, e As EventArgs) Handles OneWeekCheck.CheckedChanged
        If OneWeekCheck.Checked Then
            TwoWeekCheck.Checked = False
        End If
    End Sub

    Private Sub StartDate_ValueChanged(sender As Object, e As EventArgs) Handles StartDate.ValueChanged
        'When the start date of a range is updated change the date that users are sampled to the same 
        DateToSampleStart.Value = StartDate.Value
    End Sub

    Private Sub EndDate_ValueChanged(sender As Object, e As EventArgs) Handles EndDate.ValueChanged
        'When the end date of a range is updated change the date that users are sampled to the same 
        DateToSampleEnd.Value = EndDate.Value
    End Sub

End Class