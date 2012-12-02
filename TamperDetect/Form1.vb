Public Class frmMain

    Dim curCapsLckState As Boolean
    Dim curScrLckState As Boolean
    Dim curNumLckState As Boolean
    Dim curTick As Integer
    Dim curToggleCount
    Dim countDuration As Integer = 100
    Dim toggleThreshold As Integer = 5
    Dim toggleCount As Integer
    Dim maxTPS As Integer

    Private Sub tmrCheck_Tick(sender As System.Object, e As System.EventArgs) Handles tmrCheck.Tick
        If curTick >= countDuration Then
            curTick = 0
            toggleCount = 0
        End If

        If IsKeyLocked(Keys.CapsLock) <> curCapsLckState Then toggleCount = toggleCount + 1
        If IsKeyLocked(Keys.Scroll) <> curScrLckState Then toggleCount = toggleCount + 1
        If IsKeyLocked(Keys.NumLock) <> curNumLckState Then toggleCount = toggleCount + 1

        curCapsLckState = IsKeyLocked(Keys.CapsLock)
        curScrLckState = IsKeyLocked(Keys.Scroll)
        curNumLckState = IsKeyLocked(Keys.NumLock)

        If toggleCount >= toggleThreshold Then
            lblAlert.BackColor = Color.Red
            lblTPS.BackColor = Color.Red
            lblTPS.ForeColor = Color.White
            lblState.Text = "BAD"
        End If

        If toggleCount > maxTPS Then
            maxTPS = toggleCount
            lblTPS.Text = maxTPS.ToString & "/s"
        End If

        curTick = curTick + 1
    End Sub

End Class
