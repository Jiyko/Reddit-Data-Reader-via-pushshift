Imports System
Imports System.Net
Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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

        Dim bodyTracker As String

        Dim FinalStartDate As String
        Dim FinalEndDate As String
        Dim FinalSize As String
        Dim FinalTags As String

        Dim FinalBodyTags As String

        Dim ValidLines As Int64
        Dim TotalLines As Int64
        Dim ValidPoster As Int64
        Dim TotalPoster As Int64

        'Declare the IO Stuff
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("D:\RedditRips\Test\" + FileNameBox.Text() + ".txt", True)


        'Get the latest stats
        Dim statsFile As System.IO.StreamReader
        statsFile = My.Computer.FileSystem.OpenTextFileReader("D:\RedditRips\Test\" + FileNameBox.Text() + "Stats.txt")
        ValidLines = Convert.ToInt32(statsFile.ReadLine())
        TotalLines = Convert.ToInt32(statsFile.ReadLine())
        ValidPoster = Convert.ToInt32(statsFile.ReadLine())
        TotalPoster = Convert.ToInt32(statsFile.ReadLine())

        statsFile.Close()

        Dim statsFileW As System.IO.StreamWriter
        statsFileW = My.Computer.FileSystem.OpenTextFileWriter("D:\RedditRips\Test\" + FileNameBox.Text() + "Stats.txt", False)

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
        SecondRunURL = sURL + FinalStartDate + FinalEndDate + FinalSize + "&filter=body&&author="

        MainText.Text = MainText.Text + FirstRunURL

        Dim wrGETURL As WebRequest
        wrGETURL = WebRequest.Create(FirstRunURL)

        Dim objStream As Stream
        objStream = wrGETURL.GetResponse.GetResponseStream()

        Dim objReader As New StreamReader(objStream)

        Dim sLine As String = ""
        Dim i As Integer = 0



        Dim wrGEInnerURL As WebRequest

        Dim objInnerStream As Stream

        Dim sInnerLine As String = ""
        Dim j As Integer = 0
        Dim k As Integer = 0


        Do While Not sLine Is Nothing
            i += 1
            sLine = objReader.ReadLine
            If Not sLine Is Nothing Then

                If sLine.Contains("author") Then
                    TotalPoster = TotalPoster + 1
                    ProgressBar1.Value = ProgressBar1.Value + 1

                    Console.WriteLine("{0}:{1}", i, sLine)

                    sLine = sLine.Remove((sLine.Length) - 2)
                    sLine = sLine.Substring(23)

                    Console.WriteLine(sLine)

                    Final = SecondRunURL + sLine
                    wrGEInnerURL = WebRequest.Create(Final)
                    objInnerStream = wrGEInnerURL.GetResponse.GetResponseStream()

                    Dim objInnerReader As New StreamReader(objInnerStream)

                    sInnerLine = ""
                    j = 0
                    k = 0

                    bodyTracker = ""

                    Do While Not sInnerLine Is Nothing
                        j += 1

                        For Each bob In filterWords
                            If sInnerLine.Contains(bob) Then

                            End If
                        Next

                        If sInnerLine.Contains("body") Then

                            If Not sInnerLine.Contains("https") Then

                                If Not sInnerLine.Contains("removed") Then

                                    If Not sInnerLine.Contains("I am a bot") Then

                                        If Not sInnerLine.Contains("remove") Then
                                            sInnerLine = sInnerLine.Remove((sInnerLine.Length) - 1)
                                            sInnerLine = sInnerLine.Substring(21)
                                            sInnerLine.Trim()

                                            Console.WriteLine(sInnerLine)
                                            bodyTracker = bodyTracker + vbCrLf + sInnerLine

                                            TotalLines = TotalLines + 1
                                            k += 1
                                        End If
                                    End If
                                End If
                            End If
                        End If


                        sInnerLine = objInnerReader.ReadLine

                    Loop
                    If k >= 3 Then
                        If bodyTracker.Length >= 750 Then
                            file.WriteLine(bodyTracker)
                            ValidPoster = ValidPoster + 1
                            ValidLines = ValidLines + k
                        End If
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

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class