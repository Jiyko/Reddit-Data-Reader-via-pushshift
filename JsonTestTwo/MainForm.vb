Imports System
Imports System.Net
Imports System.IO
Imports System.Text
Imports StreamJsonRpc

Public Class MainForm

    'Gloabl for the root folder
    Dim rootPath As String
    Dim list As List(Of KeyValuePair(Of Double, String)) = New List(Of KeyValuePair(Of Double, String))

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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

            Dim filterWords = New String() {"removed", "https", "remove", "http", "I am a bot"}

            Dim startWindowUTC = (StartDate.Value() - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
            Dim endWindowUTC = (EndDate.Value() - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds


            Dim hashedUserList As New List(Of String)
            Dim nameFile As System.IO.StreamReader

            Try

                nameFile = My.Computer.FileSystem.OpenTextFileReader(rootPath + "\" + FileNameBox.Text() + "hashedNames.txt")

                Dim nameTracker As String
                nameTracker = nameFile.ReadLine

                Do While Not nameTracker Is Nothing
                    hashedUserList.Add(nameTracker)
                    nameTracker = nameFile.ReadLine
                Loop


            Catch exTwo As Exception

                Dim hashedUserListFileCreate As New StreamWriter(rootPath + "\" + "hashedNames.txt", True)
                hashedUserListFileCreate.Close()

            End Try

            nameFile.Close()



            Dim twoWeekUTC As Double
            twoWeekUTC = 1209600
            Dim oneWeekUTC As Double
            oneWeekUTC = 604800


            Dim tempList As List(Of KeyValuePair(Of Double, String)) = New List(Of KeyValuePair(Of Double, String))

            Dim timeTracker = startWindowUTC

            Dim files() As String = IO.Directory.GetFiles(rootPath + "\")

            Dim bodyTracker As String

            Dim FinalStartDate As String
            Dim PosterStartDate As String
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


            'Get the latest stats
            Dim statsFile As System.IO.StreamReader
            statsFile = My.Computer.FileSystem.OpenTextFileReader(rootPath + "\" + FileNameBox.Text() + "Stats.txt")
            ValidLines = Convert.ToInt32(statsFile.ReadLine())
            TotalLines = Convert.ToInt32(statsFile.ReadLine())
            ValidPoster = Convert.ToInt32(statsFile.ReadLine())
            TotalPoster = Convert.ToInt32(statsFile.ReadLine())

            statsFile.Close()

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

            ProgressBar1.Maximum = CInt(NumberToCheck.Text())

            FinalSize = "&size=" + NumberToCheck.Text()
            FinalTags = "&filter=author,score"

            FinalBodyTags = "&filter=body"

            FirstRunURL = sURL + FinalStartDate + FinalEndDate + FinalSize + FinalTags
            SecondRunURL = sURL + FinalStartDate + FinalEndDate + "&filter=body,created_utc&&author="

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
                                If bodyTracker.Split(" ").Length - 1 >= Convert.ToInt32(minWordCount.Text) Then

                                    For Each bob In tempList.ToArray

                                        For Each boob In list.ToArray

                                            If bob.Key < boob.Key Then

                                                list.Add(New KeyValuePair(Of Double, String)(boob.Key, bob.Value))
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
            ProgressBar1.Value = 0

            For Each bob In list.ToArray

                Dim UTCFilebyDate As New StreamWriter(rootPath + "\" + (bob.Key).ToString + ".txt", True)
                UTCFilebyDate.Write((bob.Value).Replace(Chr(34), vbCrLf))

                UTCFilebyDate.Close()
                list.Remove(New KeyValuePair(Of Double, String)(bob.Key, bob.Value))

                list.Add(New KeyValuePair(Of Double, String)(bob.Key, ""))

            Next

            Dim hashedUserListFile As New StreamWriter(rootPath + "\" + FileNameBox.Text() + "hashedNames.txt", False)
            For Each nameH In hashedUserList
                hashedUserListFile.Write(nameH + vbCrLf)
            Next
            hashedUserListFile.Close()
            hashedUserList.Clear()






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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            rootPath = FolderBrowserDialog1.SelectedPath
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Setup.Click

        Dim startWindowUTC = (StartDate.Value() - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        Dim endWindowUTC = (EndDate.Value() - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds

        Dim twoWeekUTC As Double
        twoWeekUTC = 1209600

        Dim timeTracker = startWindowUTC

        Do While timeTracker < endWindowUTC

            list.Add(New KeyValuePair(Of Double, String)(timeTracker, ""))

            If TwoWeekCheck.Checked Then
                timeTracker = timeTracker + twoWeekUTC
            End If

        Loop

    End Sub

    Private Sub MileStoneDate_Click(sender As Object, e As EventArgs) Handles MileStoneDate.Click
        Dim startWindowUTC = (MilePick.Value() - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        list.Add(New KeyValuePair(Of Double, String)(startWindowUTC, ""))

        Dim doubleList As New List(Of Double)

        For Each bob In list.ToArray
            doubleList.Add(bob.Key)
        Next

        list.Clear()


        doubleList.Sort()

        For Each waka In doubleList

            list.Add(New KeyValuePair(Of Double, String)(waka, ""))


        Next




    End Sub
End Class