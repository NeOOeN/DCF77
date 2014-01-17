Public Class Form1
    Dim compteur As Integer = 0
    Dim compteurBis As Integer = 0
    Dim i As Integer = 0
    Public m As Integer = 0
    Public HeureBit(59) As Integer
    Dim tac As Double = 0
    Dim idnum, demo, channel, state, overVoltage, test, valUn, valDeux, valTrois As Integer
    Dim voltage As Single
    Dim random As New Random()
    Dim hexColor As String



    Function BitToTemps(ByVal bitDepart As Integer, ByVal bitArrivee As Integer, ByVal HeureBit() As Integer)
        Dim j, Valeur3, poids(7) As Integer
        j = 0
        Valeur3 = 0
        poids = {1, 2, 4, 8, 10, 20, 40, 80}
        For i = bitDepart To bitArrivee
            If HeureBit(i) = 1 Then
                Valeur3 += poids(j)
            End If
            j += 1
        Next

        Return Valeur3

    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        valUn = random.Next(0, 99)
        valDeux = random.Next(0, 99)
        valTrois = random.Next(0, 99)
        hexColor = "#" & valUn & valDeux & valTrois
        Form2.Visible = False
        tac = 0
        idnum = -1
        demo = 1
        channel = 0
        state = 0
        PB_Calcul.ForeColor = ColorTranslator.FromHtml(hexColor)
    End Sub

    Private Sub BU_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BU_Start.Click

        test = LJ.EDigitalInX(idnum, demo, channel, 0, state)
        Select Case test
            Case 0
                Cursor = Cursors.AppStarting
                LA_Test.Text = "Pas d'erreur"
                LA_Signal.Visible = True
                BU_Start.Enabled = False
                PB_Calcul.Visible = True
                Tim_Tim.Enabled = True
                PB_Calcul.Style = ProgressBarStyle.Marquee
                Tim_Tim.Start()

            Case 2
                LA_Test.Text = "Erreur - Labjack non trouvé"
            Case Else
                LA_Test.Text = "Erreur n°" & CStr(test) & " " & LJ.GetErrorStringX(test)
        End Select
    End Sub

    Private Sub Tim_Tim_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tim_Tim.Tick


        LJ.EDigitalInX(idnum, demo, channel, 0, state)
        If state = 1 Then
            tac = tac + 1
        Else
            tac = 0
        End If
        If tac = 50 Then
            compteurBis = 0
            PB_Calcul.Style = ProgressBarStyle.Continuous
            LA_Signal.Text = "Reception du signal en cours ..."
            Tom_Tom.Start()
            Tim_Tim.Stop()


        End If
    End Sub

    Private Sub Tom_Tom_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tom_Tom.Tick

        LJ.EDigitalInX(idnum, demo, channel, 0, state)
        If Tom_Tom.Interval = 150 Then
            Tom_Tom.Interval = 50
        ElseIf Tom_Tom.Interval = 100 Then
            If state = 0 Then
                HeureBit(m) = 1
                m += 1
                PB_Calcul.Increment(1)
                valUn = random.Next(0, 99)
                valDeux = random.Next(0, 99)
                valTrois = random.Next(0, 99)
                hexColor = "#" & valUn & valDeux & valTrois
                PB_Calcul.ForeColor = ColorTranslator.FromHtml(hexColor)
            Else
                HeureBit(m) = 0
                m += 1
                PB_Calcul.Increment(1)
                valUn = random.Next(0, 99)
                valDeux = random.Next(0, 99)
                valTrois = random.Next(0, 99)
                hexColor = "#" & valUn & valDeux & valTrois
                PB_Calcul.ForeColor = ColorTranslator.FromHtml(hexColor)
            End If
            If m = 58 Then
                Form2.Activate()
                Form2.Visible = True
                Me.Visible = False
                Tom_Tom.Stop()
                Cursor = Cursors.Arrow
            Else
                Tom_Tom.Interval = 150
            End If
        ElseIf Tom_Tom.Interval = 50 Then
            If state = 0 Then
                Tom_Tom.Interval = 100
            End If

        End If
    End Sub

    Private Sub LA_Signal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LA_Signal.Click

    End Sub
End Class
