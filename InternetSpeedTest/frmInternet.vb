' Program Name: Internet Speed Test Survey
' Date: October 20, 2024
' Author: K Bola
' Purpose: This application finds the average speed of home internet connection
Public Class frmInternet
    Private Sub frmInternet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstSpeedTest.Items.Clear()
        lblAverage.Visible = False
    End Sub

    Private Sub btnSpeedTest_Click(sender As Object, e As EventArgs) Handles btnSpeedTest.Click
        Dim strSpeedTest As String
        Dim decSpeedTest As Decimal
        Dim decTotalSpeedTest As Decimal = 0
        Dim decAverageSpeedTest As Decimal
        Dim strInputMessage As String = "Enter the internet speed in Mbps"
        Dim strInputHeading As String = "Internet Speed Entry"
        Dim strNonNumericValue As String = "Error - Enter a vaid value"
        Dim strNegativeValue As String = "Error - Enter a positive value"
        Dim strCancelClicked As String = ""
        Dim intNumberOfEntries As Integer = 1
        Dim intMaxNumberOfEntries As Integer = 10
        strSpeedTest = InputBox("No." & intNumberOfEntries & " " & strInputMessage, strInputHeading, "")
        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strSpeedTest = strCancelClicked
            If IsNumeric(strSpeedTest) Then
                decSpeedTest = Convert.ToDecimal(strSpeedTest)
                If decSpeedTest > 0 Then
                    lstSpeedTest.Items.Add(decSpeedTest)
                    decTotalSpeedTest += decSpeedTest
                    intNumberOfEntries += 1
                Else
                    strInputMessage = strNegativeValue
                End If
                If intNumberOfEntries <= intMaxNumberOfEntries Then
                    strSpeedTest = InputBox("No." & intNumberOfEntries & " " & strInputMessage, strInputHeading, "")
                End If
            Else
                strInputMessage = strNonNumericValue
            End If
        Loop
        If intNumberOfEntries > 1 Then
            decAverageSpeedTest = decTotalSpeedTest / (intNumberOfEntries - 1)
            lblAverage.Visible = True
            lblAverage.Text = "Average Internet Speed: " & decAverageSpeedTest.ToString("N2") & " Mbps"
        Else
            MsgBox("No Value Entered", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Empty")
        End If
        btnSpeedTest.Enabled = False
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        lblAverage.Text = ""
        lstSpeedTest.Items.Clear()
        btnSpeedTest.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
