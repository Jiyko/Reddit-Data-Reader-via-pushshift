Imports System
Imports System.Net
Imports System.IO

Public Class Form1
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
                        TotalPoster = TotalPoster + 1
                        ProgressBar1.Value = ProgressBar1.Value + 1

                        Console.WriteLine("{0}:{1}", i, sLine)

                        sLine = sLine.Remove((sLine.Length) - 2)
                        sLine = sLine.Substring(23)

                        Console.WriteLine(sLine)

                        Final = SecondRunURL + sLine

                        Dim objInnerReader = OpenStream(Final)

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
                        'checks the user validity 
                        If k >= Convert.ToInt32(minPostNumber.Text) Then
                            If bodyTracker.Split(" ").Length - 1 >= Convert.ToInt32(minWordCount.Text) Then
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

End Class