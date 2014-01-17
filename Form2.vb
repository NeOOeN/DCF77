Option Explicit On
Public Class Form2
    Dim t As Integer
    Dim ri


    Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Me.Left = 10
        Me.Top = 10
        Timer1.Enabled = False
        Timer1.Interval = 1000
        Timer1.Enabled = True
        Try
            TimeOfDay = New Date(Now.Year, Now.Month, Now.Day, Form1.BitToTemps(29, 34, Form1.HeureBit), Form1.BitToTemps(21, 27, Form1.HeureBit), 0)
        Catch ex As Exception
            MsgBox(Err.Number & vbLf & vbLf & Err.Description, vbExclamation)
        End Try
    End Sub


    Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        t = Mid(TimeOfDay, 1, 1)
        Call quelleImage()
        PictureBox1.Image = ri
        t = Mid(TimeOfDay, 2, 1)
        Call quelleImage()
        PictureBox2.Image = ri
        t = Mid(TimeOfDay, 4, 1)
        Call quelleImage()
        PictureBox3.Image = ri
        t = Mid(TimeOfDay, 5, 1)
        Call quelleImage()
        PictureBox4.Image = ri
        t = Mid(TimeOfDay, 7, 1)
        Call quelleImage()
        PictureBox5.Image = ri
        t = Mid(TimeOfDay, 8, 1)
        Call quelleImage()
        PictureBox6.Image = ri
    End Sub


    Sub quelleImage()
        Select Case t
            Case 0 : ri = My.Resources._0
            Case 1 : ri = My.Resources._1
            Case 2 : ri = My.Resources._2
            Case 3 : ri = My.Resources._3
            Case 4 : ri = My.Resources._4
            Case 5 : ri = My.Resources._5
            Case 6 : ri = My.Resources._6
            Case 7 : ri = My.Resources._7
            Case 8 : ri = My.Resources._8
            Case 9 : ri = My.Resources._9
        End Select
    End Sub

End Class
